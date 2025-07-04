﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using PlanEase.Models;
using PlanEase.LLM.Prompts;
using PlanEase.LLM.Tagging;
using static QRCoder.PayloadGenerator;
using PlanEase.LLM.Memory;
using PlanEase.LLM.Models;




namespace PlanEase.Helpers
{
    public class GptService
    {




        private static readonly string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
        private static readonly string endpoint = "https://api.openai.com/v1/chat/completions";
        


        public static async Task<string> SendChatAsync(string systemPrompt, string userPrompt)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                MessageBox.Show("OpenAI API 키가 환경변수에 설정되어 있지 않습니다.\n환경 변수 'OPENAI_API_KEY'를 설정해주세요.",
                    "API 키 없음", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "[ERROR] API 키 없음";
            }


            using var httpClient = new HttpClient();

            var requestData = new
            {
                model = "gpt-4o",
                messages = new[]
                {
                new { role = "system", content = systemPrompt },
                new { role = "user", content = userPrompt }
            }
            };

            string json = System.Text.Json.JsonSerializer.Serialize(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            var response = await httpClient.PostAsync(endpoint, content);
            string responseJson = await response.Content.ReadAsStringAsync();

            // 예외 응답 처리
            using var doc = JsonDocument.Parse(responseJson);
            if (doc.RootElement.TryGetProperty("error", out var error))
            {
                string errorMsg = error.GetProperty("message").GetString();
                return $"[ERROR] GPT 응답 오류: {errorMsg}";
            }

            string result = doc.RootElement
                .GetProperty("choices")[0]
                .GetProperty("message")
                .GetProperty("content")
                .GetString();

            Console.WriteLine("=== SendChatAsync ===");
            return result;
        }


        public static async Task<ParsedScheduleResult> GenerateScheduleFromText(string userInput)
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            var prompt = new SchedulePrompt();
            string systemPrompt = prompt.Build(today, userInput);


            ParsedScheduleResult result = new ParsedScheduleResult();
            string gptResponse = await SendChatAsync(systemPrompt, userInput);

            try
            {
                using var doc = JsonDocument.Parse(gptResponse);
                var root = doc.RootElement;

                // 필수 필드 검증
                List<string> missingFields = new List<string>();

                // 필수 필드 존재 여부 확인
                bool hasTitle = root.TryGetProperty("title", out var titleProp);
                bool hasStart = root.TryGetProperty("startTime", out var startTimeProp);
                bool hasEnd = root.TryGetProperty("endTime", out var endTimeProp);

                // 존재하지 않거나 "??? 누락됨"일 경우 누락으로 간주
                if (!hasTitle || titleProp.GetString()?.Contains("???") == true)
                    missingFields.Add("제목");

                if (!hasStart || startTimeProp.ToString().Contains("???"))
                    missingFields.Add("시작 시간");

                if (!hasEnd || endTimeProp.ToString().Contains("???"))
                    missingFields.Add("종료 시간");

                // 하나라도 누락되었으면 메시지 작성 후 종료
                if (missingFields.Count > 0)
                {
                    result.FollowUpMessage = $"{string.Join(", ", missingFields)} 정보가 누락되었습니다. 입력해주세요.";
                    return result;
                }
                string title = titleProp.GetString() ?? "";
                string startTimeStr = startTimeProp.ToString();
                string endTimeStr = endTimeProp.ToString();


                Schedule schedule = new Schedule
                {
                    Title = title,
                    StartTime = DateTime.Parse(startTimeStr),
                    EndTime = DateTime.Parse(endTimeStr),
                    Tags = root.TryGetProperty("tags", out var tagsProp)
                    ? tagsProp.EnumerateArray().Select(t => t.GetString()).Where(t => t != null).ToList()!
                : new List<string>(),
                    Description = root.TryGetProperty("description", out var descProp)
                    ? (descProp.GetString()?.Contains("???") == true ? "" : (descProp.GetString() ?? "")) : ""

                };
                result.Schedule = schedule;
                result.IsComplete = true;
                return result;
            }
            catch (Exception ex)
            {
                result.FollowUpMessage = $"GPT 응답을 해석하지 못했습니다. 다시 시도해주세요.\n{ex.Message}";
                return result;
            }
        }

        // TitleTagPrompt용
        public static async Task<List<string>> RequestTitleTagsAsync(string title)
        {
            var prompt = new TitleTagPrompt(title);
            string systemPrompt = prompt.BuildSystemMessage();
            string userPrompt = prompt.BuildUserMessage();
            string response = await SendChatAsync(systemPrompt, userPrompt);

            Console.WriteLine("=== SYSTEM(RequestTitleTagsAsync) ===");
            Console.WriteLine("=== USER(RequestTitleTagsAsync) ===");
            Console.WriteLine("=== RequestTitleTagsAsync response : " + response);

            List<string> tagList = new List<string>();

            try
            {
                // Case 1: 직접 JSON 배열 문자열일 경우 (ex: ["#학업", "#과제", "#공부"])
                if (response.Trim().StartsWith("[") && response.Trim().EndsWith("]"))
                {
                    tagList = JsonSerializer.Deserialize<List<string>>(response);
                    Console.WriteLine("JSON 배열 파싱 성공 (직접 배열)");
                }
                else
                {
                    // Case 2: JSON 객체에 태그 배열이 포함된 경우 (ex: { "태그 추천": [ ... ] })
                    using var doc = JsonDocument.Parse(response);
                    string[] possibleKeys = { "tags", "태그", "태그 추천", "제안하는 태그" };
                    foreach (var key in possibleKeys)
                    {
                        if (doc.RootElement.TryGetProperty(key, out var arrayElem) && arrayElem.ValueKind == JsonValueKind.Array)
                        {
                            tagList = arrayElem.EnumerateArray()
                                .Select(e => e.GetString())
                                .Where(tag => !string.IsNullOrWhiteSpace(tag) && tag.StartsWith("#"))
                                .ToList();
                            Console.WriteLine("JSON 객체 파싱 성공 (키: " + key + ")");
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("JSON 파싱 실패: " + ex.Message);
            }

            // Fallback: 그냥 문자열에서 #태그 추출
            if (tagList == null || tagList.Count == 0)
            {
                tagList = response
                    .Split(new[] { '\n', ',', ' ', '\"', '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(tag => tag.StartsWith("#"))
                    .Distinct()
                    .ToList();
                Console.WriteLine("문자열 기반 파싱 수행");
            }

            Console.WriteLine("Tag list count after Distinct: " + tagList.Count);
            return tagList;
        }



        // TagReplacementPrompt용
        public static async Task<string> RequestTagReplacementAsync(string title, string weakTag, TagMemory memory)
        {
            var prompt = new TagReplacementPrompt(title, weakTag, memory);
            string systemPrompt = prompt.BuildSystemMessage();
            string userPrompt = prompt.BuildUserMessage();
            Console.WriteLine("=== SYSTEM(RequestTagReplacementAsync) ===");
            //Console.WriteLine(systemPrompt);
            Console.WriteLine("=== USER(RRequestTagReplacementAsync) ===");
            //Console.WriteLine(userPrompt);
            string response = await SendChatAsync(systemPrompt, userPrompt);
            Console.WriteLine("===  RequestTagReplacementAsync response : " + response);
            return response.Trim();
        }


        // IsScheduleCommandPrompt용
        public static async Task<bool> IsScheduleCommandAsync(string userInput)
        {
            var prompt = new IsScheduleCommandPrompt(userInput);
            string system = prompt.BuildSystemMessage();
            string user = prompt.BuildUserMessage();

            string response = await SendChatAsync(system, user);
            response = response.Trim().ToLower();

            return response.StartsWith("y");
        }
        // TaskInquiryPrompt용 
        public static async Task<ScheduleCommand?> ExtractScheduleCommandAsync(string userInput)
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            var prompt = new TaskInquiryPrompt(today, userInput);
            string systemMessage = prompt.BuildSystemMessage();
            string userMessage = prompt.BuildUserMessage();

            Console.WriteLine("=== SYSTEM(ExtractScheduleCommandAsync) ===");
            Console.WriteLine(systemMessage);
            Console.WriteLine("=== USER(ExtractScheduleCommandAsync) ===");
            Console.WriteLine(userMessage);

            string gptResponse = await SendChatAsync(systemMessage, userMessage);
            Console.WriteLine("=== GPT RESPONSE ===");
            Console.WriteLine(gptResponse);

            // 파싱 후 반환
            var command = CommandParser.Parse(gptResponse);
            return command;
        }


        public class Monster
        {
            public string Name { get; set; }
            public int Level { get; set; }
            public int MaxHP { get; set; }
            public int CurrentHP { get; set; }
            public int ImageNumber { get; set; } // ImageNumber로 변경
            public string Description { get; set; }
        }

        // 일정 정보로부터 몬스터를 생성하는 메서드
        public static async Task<Monster> GenerateMonsterFromSchedule(Schedule schedule)
        {
            string systemPrompt = @"너는 할 일 기반 RPG 게임의 몬스터 생성 AI야. 
사용자의 할 일 내용을 분석하여 그 특성과 난이도에 맞는 가상의 몬스터를 생성해줘.
할 일의 중요도나 난이도에 따라 몬스터의 레벨(1-10)과 체력(50-500)을 결정해줘.
추가로 몬스터의 외형을 결정하기 위해 1부터 5까지의 이미지 번호를 선택해줘.";

            string userPrompt = $@"다음 할 일을 분석하여 적절한 몬스터를 생성해줘:

제목: {schedule.Title}
우선순위: {schedule.Description}
태그: {(schedule.Tags.Count > 0 ? string.Join(", ", schedule.Tags) : "없음")}

다음 JSON 형식으로 몬스터 정보를 반환해줘:
{{
  ""name"": ""몬스터 이름"",
  ""level"": 1-10 사이의 숫자,
  ""maxHP"": 50-500 사이의 숫자,
  ""imageNumber"": 1부터 5 사이의 정수(몬스터 이미지 번호),
  ""description"": ""몬스터 설명, 이 할 일이 왜 이 난이도인지에 대한 이유""
}}";

            try
            {
                // API 키 직접 설정 (개발/테스트용)
                // apiKey = "sk-your-actual-api-key-here";

                string gptResponse = await SendChatAsync(systemPrompt, userPrompt);
                Console.WriteLine("GPT 응답 받음: " + gptResponse);

                // JSON 응답 파싱
                using var doc = JsonDocument.Parse(gptResponse);
                var root = doc.RootElement;

                Monster monster = new Monster
                {
                    Name = root.GetProperty("name").GetString(),
                    Level = root.GetProperty("level").GetInt32(),
                    MaxHP = root.GetProperty("maxHP").GetInt32(),
                    CurrentHP = root.GetProperty("maxHP").GetInt32(), // 처음에는 최대 체력으로 설정
                    ImageNumber = root.GetProperty("imageNumber").GetInt32(), // 이미지 번호
                    Description = root.GetProperty("description").GetString()
                };

                return monster;
            }
            catch (Exception ex)
            {
                Console.WriteLine("몬스터 생성 오류: " + ex.Message);
                Console.WriteLine("예외 스택 트레이스: " + ex.StackTrace);

                // GPT 응답 해석 실패 시 기본 몬스터 반환
                Random rand = new Random();
                return new Monster
                {
                    Name = $"{schedule.Title}의 수호자",
                    Level = rand.Next(1, 6), // 1~5 사이 랜덤 레벨
                    MaxHP = rand.Next(5, 11) * 20, // 100~200 사이 랜덤 체력
                    CurrentHP = rand.Next(5, 11) * 20, // 처음에는 최대 체력으로 설정
                    ImageNumber = rand.Next(1, 6), // 1~5 사이 랜덤 이미지 번호
                    Description = $"'{schedule.Title}'에서 생성된 기본 몬스터입니다. 이 할 일을 완료하면 처치할 수 있습니다."
                };
            }
        }
    }

        // 몬스터 생성 결과를 담는 클래스 (ParsedScheduleResult와 유사한 구조)
        public class MonsterGenerationResult
    {
        public GptService.Monster Monster { get; set; }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
    }



}




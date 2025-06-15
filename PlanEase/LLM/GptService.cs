using System;
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
                    Console.WriteLine("✅ JSON 배열 파싱 성공 (직접 배열)");
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
                            Console.WriteLine("✅ JSON 객체 파싱 성공 (키: " + key + ")");
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ JSON 파싱 실패: " + ex.Message);
            }

            // Fallback: 그냥 문자열에서 #태그 추출
            if (tagList == null || tagList.Count == 0)
            {
                tagList = response
                    .Split(new[] { '\n', ',', ' ', '\"', '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(tag => tag.StartsWith("#"))
                    .Distinct()
                    .ToList();
                Console.WriteLine("🟡 문자열 기반 파싱 수행");
            }

            Console.WriteLine("🎯 Tag list count after Distinct: " + tagList.Count);
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
    }
    }

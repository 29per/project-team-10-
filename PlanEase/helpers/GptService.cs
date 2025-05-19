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
                model = "gpt-3.5-turbo",
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

            return result;
        }


        public static async Task<ParsedScheduleResult> GenerateScheduleFromText(string userInput)
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string systemPrompt = $"너는 일정관리 도우미야. 오늘은 {today}야.\n" +
            "사용자의 입력을 바탕으로 다음 JSON 형식으로 일정 정보를 만들어줘:\n\n" +
            "{ \"title\": string, \"startTime\": ISO8601 datetime, \"endTime\": ISO8601 datetime, \"tags\": [string], \"description\": string }\n\n" +
            "title, startTime, endTime은 **사용자가 언급하지 않은 정보를 절대로 추측해서 임의로 값을 채우지 말고 없으면 \"??? 누락됨\"이라고 적어.\n" +
            "tags는 사용자가 직접 말하지 않더라도 내용을 기반으로 관련된 해시태그 3개를 추천해줘.\n" +
            "description은 명확하게 언급되지 않았다면 **절대 추측하지 말고 아예 생략해도 돼. '???'로 채우지 마.**\n";


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
                :    new List<string>(),
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
    }
}

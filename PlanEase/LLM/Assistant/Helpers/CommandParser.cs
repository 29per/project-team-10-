using PlanEase.LLM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace PlanEase.Helpers
{
    public static class CommandParser
    {
        public static ScheduleCommand? Parse(string gptResponse)
        {
            try
            {
                // 코드 블록 제거
                if (gptResponse.StartsWith("```"))
                {
                    int start = gptResponse.IndexOf('{');
                    int end = gptResponse.LastIndexOf('}');
                    if (start >= 0 && end > start)
                    {
                        gptResponse = gptResponse.Substring(start, end - start + 1);
                    }
                }
                using var doc = JsonDocument.Parse(gptResponse);
                var root = doc.RootElement;

                // 1. Command Type 파싱
                if (!root.TryGetProperty("type", out var typeProp))
                    return null;

                string? typeStr = typeProp.GetString();
                if (!Enum.TryParse<ScheduleCommandType>(typeStr, true, out var commandType))
                    return null;

                // 2. 필수 및 선택 필드 파싱
                var command = new ScheduleCommand
                {
                    Command = commandType,
                    Title = root.TryGetProperty("title", out var titleProp) ? titleProp.GetString() : null,
                    StartTime = TryParseDateTime(root, "startTime"),
                    EndTime = TryParseDateTime(root, "endTime"),
                    AdditionalFields = new Dictionary<string, string>()
                };

                // 3. 기타 필드 추가
                foreach (var prop in root.EnumerateObject())
                {
                    string name = prop.Name;
                    if (name != "type" && name != "title" && name != "startTime" && name != "endTime")
                    {
                        command.AdditionalFields[name] = prop.Value.ToString();
                    }
                }

                return command;
            }
            catch (Exception ex)
            {
                Console.WriteLine("CommandParser.Parse 실패: " + ex.Message);
                return null;
            }
        }

        private static DateTime? TryParseDateTime(JsonElement root, string propertyName)
        {
            if (root.TryGetProperty(propertyName, out var prop))
            {
                string? value = prop.GetString();
                if (!string.IsNullOrWhiteSpace(value) && DateTime.TryParse(value, out var dt))
                {
                    return dt;
                }
            }
            return null;
        }
    }
}

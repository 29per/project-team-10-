using PlanEase.Models;
using PlanEase.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanEase.LLM.Models;
using PlanEase.LLM.Retrieval;
using PlanEase.LLM.Retrieval;

namespace PlanEase.LLM.Tools
{
    public static class ScheduleCommandTool
    {


        public static async Task<string> ExecuteAsync(ScheduleCommand command,ScheduleManager manager,int userId)
        {
            return command.Command switch
            {
                ScheduleCommandType.Add => await HandleAddAsync(command, manager, userId),
                ScheduleCommandType.Edit => await HandleEditAsync(command, manager, userId),
                ScheduleCommandType.Delete => await HandleDeleteAsync(command, manager,userId),
                ScheduleCommandType.View => await HandleViewAsync(command, manager, userId),
                _ => "알 수 없는 명령입니다."
            };
        }

        private static Task<string> HandleAddAsync(ScheduleCommand command, ScheduleManager manager, int userId)
        {
            if (command.Title == null || command.StartTime == null || command.EndTime == null)
                return Task.FromResult("일정 추가에는 제목, 시작 시간, 종료 시간이 필요합니다.");

            string description = "";
            List<string> tags = new List<string>();

            if (command.AdditionalFields != null)
            {
                if (command.AdditionalFields.TryGetValue("description", out var desc))
                    description = desc;

                if (command.AdditionalFields.TryGetValue("tags", out var tagsStr))
                    tags = tagsStr.Split(',').Select(t => t.Trim()).ToList();
            }

            Schedule schedule = new Schedule
            {
                Title = command.Title,
                StartTime = command.StartTime.Value,
                EndTime = command.EndTime.Value,
                Description = description,
                Tags = tags,
                UserId = userId
            };

            manager.AddSchedule(schedule);
            return Task.FromResult($"일정이 추가되었습니다: {schedule.Title} ({schedule.StartTime:t} ~ {schedule.EndTime:t})");
        }



        private static async Task<string> HandleEditAsync(ScheduleCommand command, ScheduleManager manager, int userId)
        {
            if (string.IsNullOrWhiteSpace(command.Title) || command.StartTime == null)
                return "수정할 일정을 찾기 위해 제목과 시작 시간이 필요합니다.";

            var schedule = await FindBestMatchingSchedule(command, manager);
            if (schedule == null)
                return "해당 조건에 맞는 일정을 찾을 수 없습니다.";

            // 기존 필드 업데이트
            if (command.AdditionalFields != null)
            {
                if (command.AdditionalFields.TryGetValue("description", out var desc))
                    schedule.Description = desc;

                if (command.AdditionalFields.TryGetValue("tags", out var tagsStr))
                    schedule.Tags = tagsStr.Split(',').Select(t => t.Trim()).ToList();

                // 새 시간으로 변경 (newStartTime, newEndTime)
                if (command.AdditionalFields.TryGetValue("newStartTime", out var newStart) &&
                    DateTime.TryParse(newStart, out var parsedNewStart))
                {
                    schedule.StartTime = parsedNewStart;
                }

                if (command.AdditionalFields.TryGetValue("newEndTime", out var newEnd) &&
                    DateTime.TryParse(newEnd, out var parsedNewEnd))
                {
                    schedule.EndTime = parsedNewEnd;
                }
            }

            if (!string.IsNullOrWhiteSpace(command.Title))
                schedule.Title = command.Title;

            if (command.StartTime != null)
                schedule.StartTime = command.StartTime.Value;
            if (command.EndTime != null)
                schedule.EndTime = command.EndTime.Value;

            manager.UpdateSchedule(schedule);
            return $"일정 \"{schedule.Title}\"이 수정되었습니다.";
        }



        private static async Task<string> HandleDeleteAsync(ScheduleCommand command, ScheduleManager manager, int userId)
        {
            if (string.IsNullOrWhiteSpace(command.Title) || command.StartTime == null)
                return "삭제할 일정을 찾기 위해 제목과 시작 시간이 필요합니다.";

            var schedule = await FindBestMatchingSchedule(command, manager);
            if (schedule == null)
                return "해당 조건에 맞는 일정을 찾을 수 없습니다.";


            manager.RemoveSchedule(schedule.Id);
            return $"일정 \"{schedule.Title}\"이 삭제되었습니다.";
        }

        // 날짜 기반 일정 확인
        private static Task<string> HandleViewAsync(ScheduleCommand command, ScheduleManager manager, int userId)
        {
            DateTime date = command.StartTime ?? DateTime.Today;
            var schedules = manager.GetSchedulesForDate(date);

            if (schedules.Count == 0)
                return Task.FromResult($"{date:yyyy-MM-dd}에는 일정이 없습니다.");

            var result = $"{date:yyyy-MM-dd} 일정 목록:\n";
            foreach (var s in schedules)
            {
                result += $"- {s.Title} ({s.StartTime:t} ~ {s.EndTime:t})\n";
            }

            return Task.FromResult(result.Trim());
        }


        private static async Task<Schedule?> FindBestMatchingSchedule(ScheduleCommand command, ScheduleManager manager)
        {
            if (string.IsNullOrWhiteSpace(command.Title) || command.StartTime == null)
                return null;

            var candidates = manager.GetAllSchedules()
                .Where(s => s.StartTime.Date == command.StartTime.Value.Date)
                .ToList();

            foreach (var s in candidates)
            {
                if (string.Equals(s.Title, command.Title, StringComparison.OrdinalIgnoreCase))
                    return s;

                if (s.Title.IndexOf(command.Title, StringComparison.OrdinalIgnoreCase) >= 0)
                    return s;
            }

            // 유사도 기반 fallback
            var inputVec = await EmbeddingHelper.GetEmbeddingAsync(command.Title);
            Schedule? bestMatch = null;
            float bestScore = 0.5f;

            foreach (var s in candidates)
            {
                var titleVec = await EmbeddingHelper.GetEmbeddingAsync(s.Title);
                float score = EmbeddingHelper.ComputeCosineSimilarity(inputVec, titleVec);

                if (score > bestScore)
                {
                    bestScore = score;
                    bestMatch = s;
                }
            }

            return bestMatch;
        }


    }
}


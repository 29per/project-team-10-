using PlanEase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlanEase.Services.ScheduleConflict
{
    
    public class ConflictResolver
    {
        private readonly ScheduleManager _scheduleManager;

        public ConflictResolver(ScheduleManager scheduleManager)
        {
            _scheduleManager = scheduleManager;
        }

        
        /// ChangeTime 전략: 대상 일정의 시작/종료 시간을 새 값으로 수정.
        
        public void ChangeTime(Schedule target, DateTime newStart, DateTime newEnd)
        {
            target.StartTime = newStart;
            target.EndTime = newEnd;
            // DB에 반영하려면 Remove 후 Add 또는 Update 필요
            _scheduleManager.RemoveSchedule(target.Id);
            _scheduleManager.AddSchedule(target);
        }

        
        /// Delete 전략: 대상 일정을 삭제.
        
        public void Delete(Schedule target)
        {
            _scheduleManager.RemoveSchedule(target.Id);
        }

        
        /// Merge 전략: 두 일정 병합 후 기존 일정 삭제, 병합 일정 추가.
       
        public void Merge(Schedule s1, Schedule s2)
        {
            var merged = new Schedule

            {
                UserId = s1.UserId, 

                Title = $"{s1.Title} + {s2.Title}",

                StartTime = s1.StartTime < s2.StartTime ? s1.StartTime : s2.StartTime,
                EndTime = s1.EndTime > s2.EndTime ? s1.EndTime : s2.EndTime,
                Description = $"{s1.Description}\n{s2.Description}",
                Tags = s1.Tags.Union(s2.Tags).ToList(),
                Priority = (PriorityLevel)Math.Round(((int)s1.Priority + (int)s2.Priority) / 2.0),
                IsCompleted = s1.IsCompleted && s2.IsCompleted  // 둘 다 완료일 경우만 완료로 처리
            };


            
            _scheduleManager.RemoveSchedule(s1.Id);   // 기존 일정 삭제
            _scheduleManager.RemoveSchedule(s2.Id);



            
            _scheduleManager.AddSchedule(merged);  // 병합 일정 추가
        }
    }
}
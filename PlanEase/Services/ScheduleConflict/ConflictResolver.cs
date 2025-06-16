using PlanEase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlanEase.Services.ScheduleConflict
{
    // 충돌 해결 전략 열거형
    public enum ResolutionStrategy
    {
        ChangeTime,     // 시간 변경
        Delete,         // 삭제
        Merge           // 병합
    }

    public class ConflictResolver
    {
        private readonly ScheduleManager _scheduleManager;
        private bool _enableAutoResolution = false; // 자동 해결 활성화 여부

        public ConflictResolver(ScheduleManager scheduleManager)
        {
            _scheduleManager = scheduleManager;
        }

        // 자동 해결 활성화/비활성화 설정
        public void SetAutoResolution(bool enabled)
        {
            _enableAutoResolution = enabled;
        }

        // 자동 해결 여부 확인
        public bool IsAutoResolutionEnabled()
        {
            return _enableAutoResolution;
        }

        // ChangeTime 전략: 대상 일정의 시작/종료 시간을 새 값으로 수정
        public void ChangeTime(Schedule target, DateTime newStart, DateTime newEnd)
        {
            target.StartTime = newStart;
            target.EndTime = newEnd;
            // DB에 반영하려면 Remove 후 Add 또는 Update 필요
            _scheduleManager.RemoveSchedule(target.Id);
            _scheduleManager.AddSchedule(target);
        }

        // Delete 전략: 대상 일정을 삭제
        public void Delete(Schedule target)
        {
            _scheduleManager.RemoveSchedule(target.Id);
        }

        // Merge 전략: 두 일정 병합 후 기존 일정 삭제, 병합 일정 추가
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

        // 충돌 유형에 따른 기본 해결 전략 반환
        private ResolutionStrategy GetDefaultStrategyForConflictType(ConflictType conflictType)
        {
            return conflictType switch
            {
                ConflictType.Same => ResolutionStrategy.Merge,
                ConflictType.Contain => ResolutionStrategy.Delete,
                ConflictType.Contain2 => ResolutionStrategy.ChangeTime,
                ConflictType.Overlap => ResolutionStrategy.ChangeTime,
                ConflictType.Overlap2 => ResolutionStrategy.ChangeTime,
                ConflictType.After => ResolutionStrategy.Merge,
                ConflictType.Before => ResolutionStrategy.Merge,
                _ => ResolutionStrategy.ChangeTime
            };
        }

        // 우선순위 기반 해결 전략 결정
        private ResolutionStrategy DetermineStrategyByPriority(Schedule newSchedule, Schedule existingSchedule, ConflictType conflictType)
        {
            // 새 일정이 기존 일정보다 우선순위가 높은 경우
            if ((int)newSchedule.Priority > (int)existingSchedule.Priority)
            {
                return conflictType switch
                {
                    ConflictType.Same => ResolutionStrategy.Delete,         // 기존 일정 삭제
                    ConflictType.Contain => ResolutionStrategy.Delete,     // 기존 일정 삭제
                    ConflictType.Contain2 => ResolutionStrategy.ChangeTime, // 기존 일정 시간 변경
                    ConflictType.Overlap => ResolutionStrategy.ChangeTime, // 기존 일정 시간 변경
                    ConflictType.Overlap2 => ResolutionStrategy.ChangeTime,   // 기존 일정 시간 변경
                    _ => GetDefaultStrategyForConflictType(conflictType)
                };
            }
            // 기존 일정이 더 우선순위가 높은 경우
            else if ((int)newSchedule.Priority < (int)existingSchedule.Priority)
            {
                return conflictType switch
                {
                    ConflictType.Same => ResolutionStrategy.ChangeTime,     // 새 일정 시간 변경
                    ConflictType.Contain => ResolutionStrategy.ChangeTime, // 새 일정 시간 변경
                    ConflictType.Contain2 => ResolutionStrategy.Delete,  // 새 일정 삭제
                    ConflictType.Overlap => ResolutionStrategy.ChangeTime, // 새 일정 시간 변경
                    ConflictType.Overlap2 => ResolutionStrategy.ChangeTime,   // 새 일정 시간 변경
                    _ => GetDefaultStrategyForConflictType(conflictType)
                };
            }

            // 우선순위가 같은 경우 기본 전략 사용
            return GetDefaultStrategyForConflictType(conflictType);
        }

        // 충돌 유형에 따른 시간 조정
        private void AdjustTimeBasedOnConflictType(Schedule newSchedule, Schedule existingSchedule, ConflictType conflictType)
        {
            switch (conflictType)
            {
                case ConflictType.Same:
                    // 시작 시간을 30분 늦추기
                    ChangeTime(newSchedule,
                        newSchedule.StartTime.AddMinutes(30),
                        newSchedule.EndTime.AddMinutes(30));
                    break;

                case ConflictType.Contain:
                case ConflictType.Contain2:
                    // 겹치는 일정 뒤로 배치
                    ChangeTime(newSchedule,
                        existingSchedule.EndTime,
                        existingSchedule.EndTime.Add(newSchedule.EndTime - newSchedule.StartTime));
                    break;

                case ConflictType.Overlap:
                    // 겹치는 부분만큼 시작 시간 조정
                    ChangeTime(newSchedule,
                        existingSchedule.EndTime,
                        newSchedule.EndTime);
                    break;

                case ConflictType.Overlap2:
                    // 겹치는 부분만큼 종료 시간 조정
                    ChangeTime(existingSchedule,
                        existingSchedule.StartTime,
                        newSchedule.StartTime);
                    break;

                case ConflictType.After:
                case ConflictType.Before:
                    // 연속 일정은 그대로 유지 (병합 가능)
                    break;
            }
        }

        // 충돌 자동 해결
        public void ResolveConflict(Schedule newSchedule, Schedule existingSchedule)
        {
            if (!_enableAutoResolution)
                return;

            var conflictType = ConflictChecker.GetConflictType(newSchedule, existingSchedule);

            // 충돌이 없으면 처리하지 않음
            if (conflictType == ConflictType.No)
                return;

            // 우선순위 기반으로 해결 전략 결정
            var strategy = DetermineStrategyByPriority(newSchedule, existingSchedule, conflictType);

            // 전략에 따라 충돌 해결
            switch (strategy)
            {
                case ResolutionStrategy.ChangeTime:
                    // 충돌 유형에 따라 시간 조정
                    AdjustTimeBasedOnConflictType(newSchedule, existingSchedule, conflictType);
                    break;

                case ResolutionStrategy.Delete:
                    // 우선순위에 따라 삭제할 일정 결정
                    if ((int)newSchedule.Priority >= (int)existingSchedule.Priority)
                        Delete(existingSchedule);
                    break;

                case ResolutionStrategy.Merge:
                    // 일정 병합
                    Merge(newSchedule, existingSchedule);
                    break;
            }
        }

        // 전체 일정 목록에서 모든 충돌 자동 해결
        public void ResolveAllConflicts(Schedule newSchedule, List<Schedule> existingSchedules)
        {
            if (!_enableAutoResolution)
                return;

            var conflicts = ConflictChecker.FindConflicts(newSchedule, existingSchedules);

            foreach (var conflict in conflicts)
            {
                ResolveConflict(newSchedule, conflict);
            }
        }
    }
}
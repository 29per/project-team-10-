using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanEase.Models;


namespace PlanEase.Services.ScheduleConflict
{
    
    public enum ConflictType
    {
        No,              // 충돌 없음
        Same,            // 완전 일치
        Contain,         // A가 B를 포함
        Contain2,        // B가 A를 포함
        Overlap,         // A가 먼저 시작, 일부 겹침
        Overlap2,        // B가 먼저 시작, 일부 겹침
        After,           // A 다음에 B
        Before           // B 다음에 A
    }

    internal class ConflictChecker
    {
        
        public static bool IsConflict(Schedule s1, Schedule s2)
        {
            return s1.StartTime < s2.EndTime && s2.StartTime < s1.EndTime;
        }

        
        public static ConflictType GetConflictType(Schedule s1, Schedule s2)
        {
            
            if (s1.EndTime <= s2.StartTime || s2.EndTime <= s1.StartTime)
            {
                
                if (s1.EndTime == s2.StartTime)
                    return ConflictType.After;
                if (s2.EndTime == s1.StartTime)
                    return ConflictType.Before;

                return ConflictType.No;
            }

            
            if (s1.StartTime == s2.StartTime && s1.EndTime == s2.EndTime)
                return ConflictType.Same;

            
            if (s1.StartTime <= s2.StartTime && s1.EndTime >= s2.EndTime)
                return ConflictType.Contain;
            if (s2.StartTime <= s1.StartTime && s2.EndTime >= s1.EndTime)
                return ConflictType.Contain2;

            
            if (s1.StartTime < s2.StartTime && s1.EndTime < s2.EndTime)
                return ConflictType.Overlap;
            else
                return ConflictType.Overlap2;
        }

        
        public static List<Schedule> FindConflicts(Schedule newSchedule, List<Schedule> existingSchedules)
        {
            return existingSchedules.Where(s => IsConflict(newSchedule, s)).ToList();
        }

        
        public static Dictionary<ConflictType, List<Schedule>> FindConflictsByType(
            Schedule newSchedule, List<Schedule> existingSchedules)
        {
            var result = new Dictionary<ConflictType, List<Schedule>>();

            foreach (var conflict in existingSchedules)
            {
                var type = GetConflictType(newSchedule, conflict);
                if (type != ConflictType.No)
                {
                    if (!result.ContainsKey(type))
                        result[type] = new List<Schedule>();

                    result[type].Add(conflict);
                }
            }

            return result;
        }
    }
}

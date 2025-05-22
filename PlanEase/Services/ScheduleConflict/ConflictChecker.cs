using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanEase.Models;

namespace PlanEase.Services.ScheduleConflict
{
    internal class ConflictChecker
    {
        public static bool IsConflict(Schedule s1, Schedule s2)
        {
            
            return s1.StartTime < s2.EndTime && s2.StartTime < s1.EndTime;
        }

        
        public static List<Schedule> FindConflicts(Schedule newSchedule, List<Schedule> existingSchedules)
        {
            return existingSchedules.Where(s => IsConflict(newSchedule, s)).ToList();
        }
    }
}

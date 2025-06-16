using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEase.LLM.Models
{
    public enum ScheduleCommandType { Add, Edit, Delete, View }

    public class ScheduleCommand
    {
        public ScheduleCommandType Command { get; set; }
        public string? Title { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public Dictionary<string, string>? AdditionalFields { get; set; } // optional
    }
}


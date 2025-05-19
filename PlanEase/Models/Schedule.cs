using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEase.Models
{
    public enum PriorityLevel
    {
        VeryLow = 1,
        Low = 2,
        Medium = 3,
        High = 4,
        VeryHigh = 5
    }

    // 일정 항목을 표현하는 클래스
    // 시간, 제목, 태그, 우선순위 등의 정보를 포함

    public class Schedule
    {
        public int Id { get; set; } // 고유 ID
        public int UserId { get; set; } // 사용자 ID
        public string Title { get; set; } // 일정 제목
        public DateTime StartTime { get; set; } // 시작 시간
        public DateTime EndTime { get; set; } // 종료 시간
        public List<string> Tags { get; set; } = new List<string>(); // 태그 목록
        public PriorityLevel Priority { get; set; } = PriorityLevel.Medium; // 우선순위(5단계 Enum)
        public bool IsCompleted { get; set; } = false; // 완료 여부
        public string Description { get; set; } = "";// 일정에 대한 상세 설명

        public Schedule() { }
        public Schedule(int userId, string title, DateTime startTime, DateTime endTime)
        {

            Title = title;
            StartTime = startTime;
            EndTime = endTime;
            UserId = userId;
        }

        // Schedule 객체를 CSV 형식으로 변환
        //    public string ToCsv()
        //    {
        //        string tags = string.Join("|", Tags);
        //        return $"{Id},{Title},{StartTime},{EndTime},{IsCompleted},{Priority},{tags}";
        //    }

        //    // 문자열로부터 Schedule 객체 생성
        //    public static Schedule FromCsv(string line)
        //    {
        //        string[] parts = line.Split(',');

        //        int id = int.Parse(parts[0]);
        //        string title = parts[1];
        //        DateTime start = DateTime.Parse(parts[2]);
        //        DateTime end = DateTime.Parse(parts[3]);
        //        bool isCompleted = bool.Parse(parts[4]);
        //        PriorityLevel priority = (PriorityLevel)Enum.Parse(typeof(PriorityLevel), parts[5]);
        //        List<string> tags = parts.Length > 6 ? parts[6].Split('|').ToList() : new List<string>();

        //        var schedule = new Schedule(id, title, start, end)
        //        {
        //            IsCompleted = isCompleted,
        //            Priority = priority,
        //            Tags = tags
        //        };
        //        return schedule;
        //    }
    }
}

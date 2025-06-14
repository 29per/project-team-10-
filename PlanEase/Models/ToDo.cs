using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEase.Models
{
    // 할 일(Todo) 항목을 표현하는 클래스
    // 내용, 완료 여부, 마감기한 정보를 포함
    public class ToDo
    {
        public int Id { get; set; } // 고유 ID
        public int UserId { get; set; } // 사용자 ID
        public string Content { get; set; } // 할 일 내용
        public bool IsDone { get; set; } // 완료 여부
        public DateTime? StartTime { get; set; }  // 할 일 시작 시간 
        public DateTime? DueDate { get; set; } // 마감일 
        public int Priority { get; set; }  // 1: 높음, 2: 중간, 3: 낮음

        public ToDo(int userId, string content, DateTime? dueDate = null, DateTime? startTime = null)
        {

            UserId = userId;
            Content = content;
            DueDate = dueDate;
            StartTime = startTime;
            IsDone = false;
        }
        public ToDo() { }
        // ToDo 객체를 CSV 형식으로 변환
        //public string ToCsv()
        //{
        //    string due = DueDate.HasValue ? DueDate.Value.ToString("yyyy-MM-dd") : "";
        //    return $"{Id},{Content},{IsDone},{due}";
        //}

        //// 문자열로부터 ToDo 객체 생성
        //public static ToDo FromCsv(string line)
        //{
        //    string[] parts = line.Split(',');

        //    int id = int.Parse(parts[0]);
        //    string content = parts[1];
        //    bool isDone = bool.Parse(parts[2]);

        //    DateTime? dueDate = null;
        //    if (parts.Length > 3 && !string.IsNullOrWhiteSpace(parts[3]))
        //        dueDate = DateTime.Parse(parts[3]);

        //    var todo = new ToDo(id, content, dueDate);
        //    todo.IsDone = isDone;

        //    return todo;
        //}


    }
}

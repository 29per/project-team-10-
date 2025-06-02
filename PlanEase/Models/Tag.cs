using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEase.Models
{
    // 일정에 연결할 수 있는 태그 정보를 표현하는 클래스
    public class Tag
    {
        public int Id { get; set; } // 고유 ID
        public string Name { get; set; } // 태그 이름 
        public int UserId { get; set; }


        public Tag(string name, int userId)
        {
            Name = name;
            UserId = userId;
        }

        public Tag() { }



    }
}

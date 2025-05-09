using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEase.Models
{
    // 일정에 연결할 수 있는 태그 정보를 표현하는 클래스
    internal class Tag
    {
        public string Name { get; set; } // 태그 이름 
        public Color DisplayColor { get; set; } // 태그 텍스트 색상
        public bool IsDefaultTag { get; set; } // 기본 태그 여부  

        public Tag(string name, Color color, bool isDefaultTag = false)
        {
            Name = name;
            DisplayColor = color;
            IsDefaultTag = isDefaultTag;
        }

        // Tag 객체를 CSV 형식으로 변환
        public string ToCsv()
        {
            return $"{Name},{DisplayColor.ToArgb()},{IsDefaultTag}";
        }

        //// 문자열로부터 Tag 객체 생성
        public static Tag FromCsv(string line)
        {
            string[] parts = line.Split(',');

            string name = parts[0];
            Color color = Color.FromArgb(int.Parse(parts[1]));
            bool isDefault = bool.Parse(parts[2]);

            return new Tag(name, color, isDefault);
        }


    }
}

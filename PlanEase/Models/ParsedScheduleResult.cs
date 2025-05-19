using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEase.Models
{
    // GPT 응답 결과를 일정 객체로 파싱한 결과 구조
    // 필수 필드의 유효성 검사 여부와 사용자에게 보일 추가 메시지를 포함
    public class ParsedScheduleResult
    {
        public Schedule? Schedule { get; set; } // 파싱된 일정 객체. 유효하지 않은 경우 null
        public bool IsComplete { get; set; } = false; // 일정이  유효하게 파싱되었는 지 여부
        public string? FollowUpMessage { get; set; } // 필수 정보 누락 시 사용자에게 보여줄 메시지
        public string? RawJson { get; set; } //GPT가 응답한 JSON 문자열
    }
}

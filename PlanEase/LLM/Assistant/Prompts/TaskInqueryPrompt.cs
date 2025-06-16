using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEase.LLM.Prompts
{
    public class TaskInquiryPrompt
    {
        private readonly string _userInput;
        private readonly string _today;

        public TaskInquiryPrompt(string today, string userInput)
        {
            _today = today;
            _userInput = userInput;
        }

        public string BuildSystemMessage() =>
    "너는 사용자 일정 관리 프로그램의 비서야. 사용자의 자연어 요청을 아래 형식의 JSON 명령으로 정확하게 변환해.\n" +
    "- 오늘 날짜는 \"" + _today + "\"야. 이를 기준으로 상대적인 날짜 표현(예: 오늘, 내일, 모레 등)을 해석해.\n" +
    "- 응답은 반드시 JSON 객체 하나여야 하며, 어떤 설명도 포함하지 마.\n" +
    "- 각 명령 유형에 맞는 필수 항목을 포함해야 해.\n" +
    "- 필드명은 camelCase를 사용해(type, title, startTime, endTime, description, tags 등).\n" +
    "- 날짜 및 시간은 yyyy-MM-dd HH:mm 형식으로 출력해.";


        public string BuildUserMessage() =>
     $"사용자 입력: \"{_userInput}\"\n\n" +
     "다음은 명령 형식 예시야. type은 add | edit | delete | view 중 하나야.\n\n" +
     "예시 1: 일정 추가\n" +
     "{\n" +
     "  \"type\": \"add\",\n" +
     "  \"title\": \"팀 회의\",\n" +
     "  \"startTime\": \"2025-06-18 15:00\",\n" +
     "  \"endTime\": \"2025-06-18 16:00\",\n" +
     "  \"tags\": [\"#업무\", \"#중요\"],\n" +
     "  \"description\": \"주간 계획 논의\"\n" +
     "}\n\n" +
     "예시 2-1: 일정 제목 수정\n" +
     "{\n" +
     "  \"type\": \"edit\",\n" +
     "  \"title\": \"운동\",\n" +
     "  \"startTime\": \"2025-06-17 07:00\",\n" +
     "  \"endTime\": \"2025-06-17 08:00\",\n" +
     "  \"description\": \"러닝에서 수영으로 변경\"\n" +
     "}\n\n" +
     "예시 2-2: 일정 시간 변경\n" +
     "{\n" +
     "  \"type\": \"edit\",\n" +
     "  \"title\": \"병원 예약\",\n" +
     "  \"startTime\": \"2025-06-25 10:00\",\n" +
     "  \"endTime\": \"2025-06-25 11:00\",\n" +
    "  \"newStartTime\": \"2025-06-26 14:00\",\n" +
     "  \"newEndTime\": \"2025-06-25 15:00\",\n"+
     "예시 3: 일정 삭제\n" +
     "{\n" +
     "  \"type\": \"delete\",\n" +
     "  \"title\": \"병원 예약\",\n" +
     "  \"startTime\": \"2025-06-17 10:00\"\n" +
     "}\n\n" +
     "예시 4: 일정 조회\n" +
     "{\n" +
     "  \"type\": \"view\",\n" +
     "  \"startTime\": \"2025-06-17\"\n" +
     "}\n\n" +
     "응답은 반드시 JSON 객체 하나여야 하며, 어떤 설명이나 코드 블록(```)도 포함하지 마.";

    }
}


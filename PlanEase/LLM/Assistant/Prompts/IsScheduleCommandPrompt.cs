using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEase.LLM.Prompts
{
    public class IsScheduleCommandPrompt
    {
        private readonly string _userInput;

        public IsScheduleCommandPrompt(string userInput)
        {
            _userInput = userInput;
        }

        public string BuildSystemMessage() =>
             "너는 사용자 입력이 '일정 관련 작업 명령'인지 아니면 '프로그램 설명 질의'인지 구분하는 도우미야.";

        public string BuildUserMessage() =>
            $"다음 사용자 입력이 **일정 추가, 수정, 삭제, 조회 중 하나를 수행하려는 명령**인지 판단해 줘.\n\n" +
            $"예를 들어, 일정 생성/편집/삭제/조회처럼 직접적인 작업을 하려는 요청이면 \"yes\"라고만 답하고, " +
            $"기능 설명, 사용법, 프로그램 구조에 대한 질문이면 \"no\"라고만 답해.\n\n" +
            $"사용자 입력: \"{_userInput}\"";
    }
}

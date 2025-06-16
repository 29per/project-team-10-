using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEase.LLM.Prompts
{
    public class SchedulePrompt
    {
        private readonly PromptTemplate _template;

        public SchedulePrompt()
        {
            _template = new PromptTemplate(
@"너는 일정관리 도우미야. 오늘은 {{today}}야.
사용자의 입력을 바탕으로 다음 JSON 형식으로 일정 정보를 만들어줘:

{
  ""title"": string,
  ""startTime"": ISO8601 datetime,
  ""endTime"": ISO8601 datetime,
  ""tags"": [string],
  ""description"": string
}

반드시 다음 규칙을 지켜:
- title, startTime, endTime은 **사용자가 언급하지 않은 정보는 절대로 추측하지 말고**, ""??? 누락됨""으로 표시해.
- tags는 사용자가 직접 말하지 않더라도 내용을 기반으로 적절한 해시태그 3개를 추천해줘.
- description은 명확히 언급되지 않았다면 **절대 포함하지 마**.
- 다른 설명은 하지 말고 **JSON 객체 하나만 출력해**.

예시:
입력: ""내일 오후 3시에 팀 미팅""
출력:
{
  ""title"": ""팀 미팅"",
  ""startTime"": ""내일 오후 3시 (→ GPT가 ISO 형식으로 변환)"",
  ""endTime"": ""??? 누락됨"",
  ""tags"": [""#업무"", ""#미팅"", ""#오후""],
  ""description"": """"
}

입력: """"2025년 6월 18일 오전 9시부터 11시까지 팀프로젝트 발표가 예정되어 있어. 장소는 새빛관 101호야.""""
출력:
{
  """"title"""": """"팀프로젝트 발표"""",
  """"startTime"""": """"2025-06-18T09:00:00"""",
  """"endTime"""": """"2025-06-18T11:00:00"""",
  """"tags"""": [""""#팀프로젝트"""", """"#발표"""", """"#새빛관""""],
  """"description"""": """"새빛관 101호에서 진행""""
}"

            );
        }


        public string Build(string today, string userInput)
        {
            return _template.Apply(("today", today), ("input", userInput));
        }



    }
}

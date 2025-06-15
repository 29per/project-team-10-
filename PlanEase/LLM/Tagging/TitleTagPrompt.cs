using PlanEase.LLM.Tagging;
using System;

namespace PlanEase.LLM.Prompts
{
    /// <summary>
    /// 일정 제목을 기반으로 공식 태그 목록 중에서 GPT가 적절한 태그 3개를 선택하도록 유도하는 프롬프트 생성 클래스
    /// </summary>
    public class TitleTagPrompt : IPrompt
    {
        private readonly PromptTemplate _systemTemplate;
        private readonly PromptTemplate _userTemplate;

        private readonly string _title;

        public TitleTagPrompt(string title)
        {
            _title = title;

            _systemTemplate = new PromptTemplate(
                "너는 일정 제목을 바탕으로 공식 태그 목록 중 적절한 태그 3개를 추천해주는 GPT 태그 도우미야."
            );

            _userTemplate = new PromptTemplate(
@"일정 제목: ""{{title}}""

태그 선택 규칙:
- 태그는 아래 공식 태그 목록에서만 선택해야 해.
- 총 3개 태그를 출력하되, **1개는 반드시 범주(Categories)에서**, 나머지 2개는 자유롭게 선택해.
- 태그는 반드시 '#'으로 시작하고 공백 없이 작성해야 해.
- 출력 형식은 반드시 JSON 배열로만 하고 설명은 포함하지 마.

[공식 범주 목록]
{{categories}}

[공식 태그 목록]
{{tags}}

예시:

입력: ""치과 예약 잡기""
출력: [""#건강"", ""#검진"", ""#병원""]

입력: ""생일 선물 준비""
출력: [""#일상"", ""#가족"", ""#기념일""]

입력: ""여름 휴가 비행기 예매""
출력: [""#일상"", ""#여행"", ""#약속""]"
            );
        }

        public string BuildSystemMessage() =>
            _systemTemplate.Apply();

        public string BuildUserMessage() =>
            _userTemplate.Apply(
                ("title", _title),
                ("tags", OfficialTagManager.BuildTagListForPrompt()),
                ("categories", OfficialTagManager.BuildCategoryListForPrompt())
            );
    }
}

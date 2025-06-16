using System;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using PlanEase.LLM.Memory;
using PlanEase.LLM.Prompts;
using PlanEase.LLM.Tagging;


namespace PlanEase.LLM.Tagging
{
    public class TagReplacementPrompt : IPrompt
    {
        private readonly PromptTemplate _systemTemplate;
        private readonly PromptTemplate _userTemplate;

        private readonly string _title;
        private readonly string _weakTag;
        private readonly TagMemory _memory;

        public TagReplacementPrompt(string title, string weakTag, TagMemory memory)
        {
            _title = title;
            _weakTag = weakTag;
            _memory = memory;

            _systemTemplate = new PromptTemplate(
                "너는 일정 제목에 더 적합한 태그를 추천해주는 GPT 비서야."
            );

            _userTemplate = new PromptTemplate(
@"현재 태그 ""{{weakTag}}""는 일정 제목 ""{{title}}""과 관련성이 부족해 보여.
이 태그를 대체할 수 있는 더 적절한 태그를 하나 추천해줘.

규칙:
- 태그는 반드시 '#'으로 시작하고 공백 없이 작성할 것
- 태그는 ""{{title}}""에 있는 동일한 단어를 포함하지 말 것
- 설명은 생략하고 태그만 출력할 것
- 적절한 태그가 없다면 빈 문자열을 출력할 것
{{#if excluded}}
- 다음 태그는 추천하지 마: {{excluded}}
{{/if}}"
            );
        }

        public string BuildSystemMessage() =>
            _systemTemplate.Apply();

        public string BuildUserMessage() =>
            _userTemplate.Apply(
                ("title", _title),
                ("weakTag", _weakTag),
                 ("excluded", string.Join(", ", _memory.GetAll()))
            );
    }
}

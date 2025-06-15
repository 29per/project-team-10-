using PlanEase.Helpers;
using PlanEase.LLM.Memory;
using PlanEase.LLM.Tagging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEase.LLM.Chains
{
    public class TagRecommendationPipeline
    {
        private readonly TagMemory _memory = new TagMemory();
        public async Task<List<string>> RecommendTagsAsync(string title)
        {
            // Step 1 : TitleTagPrompt 기반 태그 요청
            List<string> initialTags = await GptService.RequestTitleTagsAsync(title);

            List<string> validatedTags;
            if (TagRecommendationValidator.IsValid(initialTags))
            {
                // 규칙 통과 → Refinement 진행
                Console.WriteLine("초기 태그 유효성 검사 통과, Refinement 진행");
                validatedTags = await TagRefinementChain.RefineAsync(title, initialTags, _memory);
            }
            else
            {
                // 규칙 불통과 → 다시 TitleTagPrompt 기반 요청
                Console.WriteLine("초기 태그 유효성 검사 실패, TitleTagPrompt 재요청");
                var retryTags = await GptService.RequestTitleTagsAsync(title);
                validatedTags = await TagRefinementChain.RefineAsync(title, retryTags, _memory);
            }

            // Step 3: 부족한 태그 보정
            while (validatedTags.Count < 3)
            {
                Console.WriteLine($"유효한 태그 개수: {validatedTags.Count}");
                int needed = 3 - validatedTags.Count;
                var placeholders = new List<string>();
                for (int i = 0; i < needed; i++)
                    placeholders.Add("상관 없음");

                var refined = await TagRefinementChain.RefineWeakTagsOnlyAsync(title, placeholders, _memory);
                validatedTags.AddRange(refined);

                // 혹시라도 중복이 생기면 제거
                validatedTags = validatedTags
                    .Distinct()
                    .Take(3)
                    .ToList();
            }

            return validatedTags;
        }
    }
}

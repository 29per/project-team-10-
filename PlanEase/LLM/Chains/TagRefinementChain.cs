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
    public static class TagRefinementChain
    {
        /// <summary>
        /// 관련도 낮은 태그들을 GPT를 통해 교체하고, 재검증하여 통과한 것만 반환한다.
        /// </summary>
        /// <param name="title">일정 제목</param>
        /// <param name="originalTags">초기 GPT 태그</param>
        /// <returns>교체를 시도하고 재검증을 통과한 태그 목록 (3개 미만 가능)</returns>
        public static async Task<List<string>> RefineAsync(string title, List<string> originalTags, TagMemory memory)
        {
            var refined = new List<string>();

            // 우선 관련도 높은 태그들만 유지
            var weakTags = await TagRecommendationValidator.GetLowRelevanceTagsAsync(title, originalTags);
            var strongTags = originalTags.Except(weakTags).ToList();
            refined.AddRange(strongTags);

            foreach (var weakTag in weakTags)
            {
                string? replacement = await GptService.RequestTagReplacementAsync(title, weakTag, memory);
                if (string.IsNullOrWhiteSpace(replacement)) continue;
                memory.Add(replacement);

                bool ok = await TagRecommendationValidator.IsRelevantAsync(title, replacement); // 재검증
                if (ok)
                    refined.Add(replacement);
            }

            return refined.Distinct().ToList();
        }

        public static async Task<List<string>> RefineWeakTagsOnlyAsync(string title, List<string> weakTags, TagMemory memory)
        {
            var refined = new List<string>();

            foreach (var weak in weakTags)
            {
                var replacement = await GptService.RequestTagReplacementAsync(title, weak, memory);
                memory.Add(replacement);
                if (replacement != null && await TagRecommendationValidator.IsRelevantAsync(title, replacement))
                {
                    refined.Add(replacement);
                   
                }
            }

            return refined;
        }
    }
}

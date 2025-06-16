using PlanEase.LLM.Retrieval;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanEase.LLM.Tagging
{
    public static class TagRecommendationValidator
    {
        private static readonly List<string> AllTags = OfficialTagManager.GetAllTags();
        private static readonly List<string> Categories = OfficialTagManager.GetCategories();


        /// <summary>
        /// GPT가 추천한 태그 리스트의 유효성을 검사한다.
        /// </summary>
        /// <param name="tagList">GPT 응답 결과 (3개의 태그)</param>
        /// <returns>유효한 경우 true, 잘못된 경우 false</returns>
        public static bool IsValid(List<string> tagList)
        {
            if (tagList == null || tagList.Count != 3)
            {
                Console.WriteLine($"❌ tagList null or count ≠ 3. count = {tagList?.Count ?? -1}");
                return false;
            }

            int categoryCount = 0;
            foreach (var rawTag in tagList)
            {
                var tag = rawTag.Trim();

                if (!tag.StartsWith("#"))
                {
                    Console.WriteLine($"❌ Invalid format (missing #): [{tag}]");
                    return false;
                }

                if (!AllTags.Contains(tag))
                {
                    Console.WriteLine($"❌ Tag not found in official tag list: [{tag}]");
                    Console.WriteLine("🔎 예시 AllTags 항목:");
                    foreach (var t in AllTags.Take(10)) Console.WriteLine($" - {t}");
                    return false;
                }

                if (Categories.Contains(tag))
                {
                    categoryCount++;
                }
            }

            if (categoryCount >= 1)
            {
                Console.WriteLine($"✅ Valid tag list with {categoryCount} category tag(s)");
                return true;
            }
            else
            {
                Console.WriteLine($"❌ No category tag found");
                return false;
            }
        }




        /// <summary>
        /// 개별 태그와 제목 간의 연관도를 평가하여 임계값 미달 태그만 추출한다
        /// </summary>
        /// <param name="title">일정 제목</param>
        /// <param name="tags">태그 목록</param>
        /// <returns>연관도 낮은 태그 리스트</returns>
        public static async Task<List<string>> GetLowRelevanceTagsAsync(string title, List<string> tags)
        {
            var weakTags = new List<string>();
            foreach (var tag in tags)
            {
                float score = await EmbeddingHelper.ComputeTitleTagRelevanceAsync(title, tag);
                if (score < 0.2f)
                    Console.WriteLine($"Tag '{tag}' relevance score: {score}");
                weakTags.Add(tag);
            }
            return weakTags;
        }

        public static async Task<bool> IsRelevantAsync(string title, string tag)
        {
            float score = await EmbeddingHelper.ComputeTitleTagRelevanceAsync(title, tag);
            Console.WriteLine($"Tag '{tag}' relevance score: {score}");
            return score >= 0.2f;
        }


    }
}

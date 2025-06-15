using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace PlanEase.LLM.Tagging
{
    public static class OfficialTagManager
    {
        private static readonly string JsonPath = "Resources/official_tags.json";

        // 전체 JSON 파싱
        private static OfficialTagData LoadRaw()
        {
            string json = File.ReadAllText(JsonPath);
            return JsonSerializer.Deserialize<OfficialTagData>(json)!;
        }

        // 전체 태그 목록 (카테고리 + 라벨 전체)
        public static List<string> GetAllTags()
        {
            var data = LoadRaw();
            return data.Categories.Concat(data.Labels.Values.SelectMany(x => x)).Distinct().ToList();
        }

        // 범주(카테고리)만 추출
        public static List<string> GetCategories()
        {
            return LoadRaw().Categories;
        }

        // Prompt용 태그 리스트 문자열 생성
        public static string BuildTagListForPrompt()
        {
            return "[ " + string.Join(", ", GetAllTags()) + " ]";
        }

        // Prompt용 범주 리스트 문자열 생성
        public static string BuildCategoryListForPrompt()
        {
            return "[ " + string.Join(", ", GetCategories()) + " ]";
        }
    }
}

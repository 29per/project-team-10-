using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;

namespace PlanEase.LLM.Retrieval
{
    public static class EmbeddingHelper
    {
        private static readonly string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY"); // OpenAI API 키
        private static readonly string endpoint = "https://api.openai.com/v1/embeddings";
        private static readonly string model = "text-embedding-3-large";

        private static readonly HttpClient httpClient = new HttpClient();

        // 주어진 텍스트를 OpenAI Embedding API로 변환하여 벡터(float 리스트)로 반환
        public static async Task<List<float>> GetEmbeddingAsync(string input)
        {
            var requestData = new
            {
                input = input,
                model = model
            };

            var json = JsonSerializer.Serialize(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

            var response = await httpClient.PostAsync(endpoint, content);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();

            using var document = JsonDocument.Parse(responseString);
            var embeddingJson = document.RootElement.GetProperty("data")[0].GetProperty("embedding");

            return embeddingJson.EnumerateArray().Select(x => x.GetSingle()).ToList();
        }

        // 두 벡터 간의 코사인 유사도 계산(0~1 사이의 값)
        public static float ComputeCosineSimilarity(List<float> vec1, List<float> vec2)
        {
            if (vec1.Count != vec2.Count) throw new ArgumentException("Vector size mismatch");

            float dot = 0f, mag1 = 0f, mag2 = 0f;
            for (int i = 0; i < vec1.Count; i++)
            {
                dot += vec1[i] * vec2[i];
                mag1 += vec1[i] * vec1[i];
                mag2 += vec2[i] * vec2[i];
            }
            return dot / (float)(Math.Sqrt(mag1) * Math.Sqrt(mag2));
        }


        public static async Task<float> ComputeTitleTagRelevanceAsync(string title, string tag)
        {
            var titleVec = await GetEmbeddingAsync(title);
            var tagVec = await GetEmbeddingAsync(tag);
            return ComputeCosineSimilarity(titleVec, tagVec);
        }
    }
}

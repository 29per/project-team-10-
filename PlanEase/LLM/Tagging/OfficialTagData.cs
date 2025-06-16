using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PlanEase.LLM.Tagging
{
    public class OfficialTagData
    {
        [JsonPropertyName("categories")]
        public List<string> Categories { get; set; }

        [JsonPropertyName("labels")]
        public Dictionary<string, List<string>> Labels { get; set; }

        public OfficialTagData()
        {
            Categories = new List<string>();
            Labels = new Dictionary<string, List<string>>();
        }
    }
}

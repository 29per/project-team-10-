using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEase.LLM.Memory
{
    public class TagMemory
    {
        private readonly HashSet<string> _generatedTags = new HashSet<string>();

        public void Add(string tag)
        {
            _generatedTags.Add(tag);
        }

        public List<string> GetAll()
        {
            return _generatedTags.ToList();
        }

        public bool Contains(string tag)
        {
            return _generatedTags.Contains(tag);
        }

        public void Reset()
        {
            _generatedTags.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEase.LLM.Memory
{
    public class ConversationMemory
    {
        private readonly List<string> _userMessages = new List<string>();
        private readonly List<string> _assistantMessages = new List<string>();

        // 최근 메시지를 기록
        public void AddUserMessage(string message)
        {
            _userMessages.Add(message);
        }

        public void AddAssistantMessage(string message)
        {
            _assistantMessages.Add(message);
        }

        // 사용자-Assistant 간 대화 쌍을 기억
        public void Remember(string userMessage, string assistantMessage)
        {
            AddUserMessage(userMessage);
            AddAssistantMessage(assistantMessage);
        }

        // 최근 대화 맥락 반환 (예: LLM에 context로 전달할 경우)
        public string GetRecentContext(int maxCount = 5)
        {
            int count = Math.Min(_userMessages.Count, _assistantMessages.Count);
            int start = Math.Max(0, count - maxCount);

            List<string> recentPairs = new List<string>();

            for (int i = start; i < count; i++)
            {
                string user = _userMessages[i];
                string assistant = _assistantMessages[i];
                recentPairs.Add($"User: {user}\nAssistant: {assistant}");
            }

            return string.Join("\n\n", recentPairs);
        }

        // 가장 마지막 사용자의 발화
        public string? GetLastUserMessage()
        {
            return _userMessages.Count > 0 ? _userMessages[_userMessages.Count - 1] : null;
        }

        // 가장 마지막 GPT 응답
        public string? GetLastAssistantMessage()
        {
            return _assistantMessages.Count > 0 ? _assistantMessages[_assistantMessages.Count - 1] : null;
        }

        // 전체 초기화
        public void Clear()
        {
            _userMessages.Clear();
            _assistantMessages.Clear();
        }
    }
}

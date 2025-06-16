using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanEase.LLM.Memory;
using PlanEase.LLM.Retrieval;
using PlanEase.LLM.Chains;
using PlanEase.Helpers;
using PlanEase.Services;

namespace PlanEase.LLM.Agents
{
    public class PlannerAgent
    {
        private readonly ConversationMemory _memory = new ConversationMemory();
        private readonly DocumentationRetriever _retriever = new DocumentationRetriever();
        private readonly ScheduleManager _scheduleManager;
        private readonly int _userId;

        public PlannerAgent(ScheduleManager scheduleManager, int userId)
        {
            _scheduleManager = scheduleManager;
            _userId = userId;
        }

        public async Task<string> HandleUserInputAsync(string userInput)
        {
            _memory.AddUserMessage(userInput);

            // 1. 자연어 명령 분석 → 일정 명령인지 문서 질의인지 분기
            if (await GptService.IsScheduleCommandAsync(userInput))
            {
                // 일정 추가/수정/조회/삭제 관련 요청
                string result = await TaskInquiryChain.HandleAsync(userInput,_memory, _scheduleManager, _userId);
                _memory.AddAssistantMessage(result);
                return result;
            }
            else
            {
                // 문서 기반 질의응답 흐름
                //string context = await _retriever.RetrieveRelevantContentAsync(userInput);
                // string result = await DocQAChain.HandleAsync(userInput, context);
                //_memory.AddAssistantMessage(result);
                string result = "처리할 수 없는 질문입니다";
                return result;
            }
        }
    }
}

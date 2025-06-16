using PlanEase.Helpers;
using PlanEase.LLM.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanEase.LLM.Prompts;
using PlanEase.LLM.Tools;
using PlanEase.Services;

namespace PlanEase.LLM.Chains
{
    public static class TaskInquiryChain
    {
        public static async Task<string> HandleAsync(string userInput, ConversationMemory memory,
                                                        ScheduleManager scheduleManager, int userId)
        {
            // GPT로부터 일정 명령 추출
            var command = await GptService.ExtractScheduleCommandAsync(userInput);
            if (command == null)
                return "죄송합니다. 명령을 이해하지 못했어요.";

            // 명령 실행
            string result = await ScheduleCommandTool.ExecuteAsync(command, scheduleManager, userId);

            // 기억 저장
            memory.Remember(userInput, command.ToString()); // 또는 gptResponse 보관

            return result;
        }



    }
}

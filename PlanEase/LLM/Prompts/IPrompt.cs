using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEase.LLM.Prompts
{
    /// <summary>
    /// GPT 프롬프트의 기본 인터페이스. 시스템 메시지와 사용자 메시지를 생성합니다.
    /// </summary>
    public interface IPrompt
    {
        string BuildSystemMessage();
        string BuildUserMessage();
    }

    /// <summary>
    /// GPT 응답을 특정 타입으로 파싱할 수 있도록 제네릭 응답 타입을 지원하는 인터페이스입니다.
    /// </summary>
    /// <typeparam name="T">응답을 역직렬화할 타입</typeparam>
    public interface IPrompt<T> : IPrompt
    {
        string BuildSystemMessage();
        string BuildUserMessage();
        T ParseResponse(string raw);
    }
}

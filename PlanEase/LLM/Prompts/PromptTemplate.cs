using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEase.LLM.Prompts
{
    /// <summary>
    /// 프롬프트 문자열 템플릿을 관리하고 치환 기능을 제공하는 클래스.
    /// "{{변수}}" 형태의 플레이스홀더를 실값으로 치환할 수 있음.
    /// </summary>
    public class PromptTemplate
    {
        public string TemplateText { get; private set; }


        /// <summary>
        /// 템플릿 생성자
        /// </summary>
        /// <param name="templateText">치환 가능한 템플릿 문자열</param>
        public PromptTemplate(string templateText)
        {
            TemplateText = templateText ?? throw new ArgumentNullException(nameof(templateText));
        }

        /// <summary>
        /// 템플릿 문자열의 {{키}}를 실제 값으로 치환하여 완성된 프롬프트를 반환함.
        /// </summary>
        /// <param name="variables">치환할 키-값 쌍</param>
        /// <returns>완성된 프롬프트 문자열</returns>
        public string Apply(IDictionary<string, string> variables)
        {
            string result = TemplateText;

            foreach (var pair in variables)
            {
                string placeholder = $"{{{{{pair.Key}}}}}"; // "{{key}}"
                result = result.Replace(placeholder, pair.Value);
            }

            return result;
        }

        // <summary>
        /// 가변인자로 치환할 값을 넣을 수 있는 편의 메서드
        /// </summary>
        public string Apply(params (string key, string value)[] pairs)
        {
            var dict = new Dictionary<string, string>();
            foreach (var (key, value) in pairs)
                dict[key] = value;

            return Apply(dict);
        }


    }
}

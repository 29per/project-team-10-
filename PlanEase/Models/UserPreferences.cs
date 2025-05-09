using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanEase.Models
{
    /// 충돌 해결 전략
    public enum ConflictResolutionStrategy
    {
        AskUser, // 사용자에게 물어보기
        ChangeTime, // 시간 변경
        Merge, // 병합
        Delete // 삭제
    }

    // 사용자 설정을 저장하는 클래스
    // 충돌 해결 전략, 테마, 폰트 설정 등을 포함
    internal class UserPreferences
    {
        public bool UseAutoConflictResolution { get; set; } = false; // 충돌 시 자동으로 처리할지 여부
        public ConflictResolutionStrategy DefaultStrategy { get; set; } = ConflictResolutionStrategy.AskUser; // 기본 전략
        public string Theme { get; set; } = "Light"; //UI 테마
        public string FontName { get; set; } = "Segoe UI"; //UI 폰트

        public UserPreferences() { }

        /// UserPreferences 객체를 CSV 형식으로 변환
        public string ToCsv()
        {
            return $"{UseAutoConflictResolution},{DefaultStrategy},{Theme},{FontName}";
        }

        /// 문자열로부터 UserPreferences 객체 생성
        public static UserPreferences FromCsv(string line)
        {
            string[] parts = line.Split(',');

            return new UserPreferences
            {
                UseAutoConflictResolution = bool.Parse(parts[0]),
                DefaultStrategy = (ConflictResolutionStrategy)Enum.Parse(typeof(ConflictResolutionStrategy), parts[1]),
                Theme = parts[3],
                FontName = parts[4]
            };
        }

    }
}

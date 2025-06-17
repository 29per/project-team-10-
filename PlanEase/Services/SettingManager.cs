using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PlanEase.Models;

namespace PlanEase.Services
{
    public class SettingManager
    {
        private Setting currentSetting;
        private readonly string connStr = "Server=gondola.proxy.rlwy.net;Port=22404;Database=railway;Uid=root;Pwd=vMbiAFpyuiYNKkWXyMCsxdbOFmkqbUHt;SslMode=Required;";

        public void LoadSetting(int userId)
        {
            currentSetting = LoadSettingFromDb(userId) ?? new Setting
            {
                UserId = userId,
                UseAutoConflictResolution = false,
                DefaultStrategy = ConflictResolutionStrategy.AskUser,
                Theme = "Purple"
            };
        }

        public Setting GetSetting()
        {
            return currentSetting;
        }

        public void UpdateTheme(string newTheme)
        {
            currentSetting.Theme = newTheme;
            SaveOrUpdateSetting();
        }

        public void ResetToDefault()
        {
            if (currentSetting == null)
                throw new InvalidOperationException("설정이 로드되지 않았습니다.");

            currentSetting.UseAutoConflictResolution = false;
            currentSetting.DefaultStrategy = ConflictResolutionStrategy.AskUser;
            currentSetting.Theme = "Purple";

            SaveOrUpdateSetting(); // DB에도 반영
        }

        public void SaveOrUpdateSetting()
        {
            // 디버깅 메시지: 저장할 설정 값 표시
            Console.WriteLine($"설정 저장: 자동 충돌 해결={currentSetting.UseAutoConflictResolution}, 기본 전략={currentSetting.DefaultStrategy}");


            if (SettingExists(currentSetting.UserId))
                UpdateSettingInDb(currentSetting);
            else
                InsertSettingToDb(currentSetting);

            var savedSetting = LoadSettingFromDb(currentSetting.UserId);
            if (savedSetting != null)
            {
                Console.WriteLine($"저장 후 로드: 자동 충돌 해결={savedSetting.UseAutoConflictResolution}, 기본 전략={savedSetting.DefaultStrategy}");
            }
            else
            {
                Console.WriteLine("저장 후 설정을 로드할 수 없습니다.");
            }



        }

        private Setting? LoadSettingFromDb(int userId)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Settings WHERE UserId = @UserId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", userId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Setting
                {
                    UserId = userId,
                    UseAutoConflictResolution = reader.GetBoolean("UseAutoConflictResolution"),
                    DefaultStrategy = (ConflictResolutionStrategy)reader.GetInt32("DefaultStrategy"),
                    Theme = reader.GetString("Theme")
                };
            }

            return null;
        }

        private void InsertSettingToDb(Setting setting)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = @"INSERT INTO Settings (UserId, UseAutoConflictResolution, DefaultStrategy, Theme)
                         VALUES (@UserId, @Auto, @Strategy, @Theme)";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", setting.UserId);
            cmd.Parameters.AddWithValue("@Auto", setting.UseAutoConflictResolution);
            cmd.Parameters.AddWithValue("@Strategy", (int)setting.DefaultStrategy);
            cmd.Parameters.AddWithValue("@Theme", setting.Theme);

            cmd.ExecuteNonQuery();
        }

        private void UpdateSettingInDb(Setting setting)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = @"UPDATE Settings 
                         SET UseAutoConflictResolution = @Auto,
                             DefaultStrategy = @Strategy,
                             Theme = @Theme
                         WHERE UserId = @UserId";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", setting.UserId);
            cmd.Parameters.AddWithValue("@Auto", setting.UseAutoConflictResolution);
            cmd.Parameters.AddWithValue("@Strategy", (int)setting.DefaultStrategy);
            cmd.Parameters.AddWithValue("@Theme", setting.Theme);

            cmd.ExecuteNonQuery();
        }

        private bool SettingExists(int userId)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "SELECT COUNT(*) FROM Settings WHERE UserId = @UserId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", userId);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using PlanEase.Models;

namespace PlanEase.Services
{
    public class UserService
    {
        private readonly string connStr = "Server=gondola.proxy.rlwy.net;Port=22404;Database=railway;Uid=root;Pwd=vMbiAFpyuiYNKkWXyMCsxdbOFmkqbUHt;SslMode=Required;";


        public User? LoginUser(string username, string password)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Users WHERE Username = @username";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string storedHash = reader.GetString("PasswordHash");
                string inputHash = HashPassword(password);

                if (storedHash == inputHash)
                {
                    // 로그인 성공 → User 객체 리턴
                    return new User
                    {
                        Id = reader.GetInt32("Id"),
                        Username = reader.GetString("Username"),
                        PasswordHash = storedHash,
                        Level = reader.GetInt32("Level"),
                        XP = reader.GetInt32("XP")
                    };
                }
            }

            return null;  // 로그인 실패
        }

        public bool RegisterUser(User user)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "INSERT INTO Users (Username, PasswordHash, Level, XP) VALUES (@username, @password, @level, @xp)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", user.Username);
            cmd.Parameters.AddWithValue("@password", user.PasswordHash);
            cmd.Parameters.AddWithValue("@level", user.Level);
            cmd.Parameters.AddWithValue("@xp", user.XP);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)  // Duplicate username
                    throw new Exception("이미 존재하는 사용자입니다.");
                else
                    throw;
            }
        }

        public static string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha.ComputeHash(bytes);
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        public bool UpdateUserXpAndLevel(int userId, int xp, int level)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "UPDATE Users SET XP = @xp, Level = @level WHERE Id = @userId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@xp", xp);
            cmd.Parameters.AddWithValue("@level", level);
            cmd.Parameters.AddWithValue("@userId", userId);

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"사용자 경험치/레벨 업데이트 오류: {ex.Message}");
                return false;
            }
        }


    }
}

using PlanEase.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace PlanEase.Services
{
    // 태그 데이터를 관리하는 클래스
    // 중복 없이 태그를 등록하고 색상, 이름 등의 정보를 저장
    public class TagManager
    {
        private List<Tag> tags = new List<Tag>(); // 전체 태그 객체 리스트
        private readonly string connStr = "Server=gondola.proxy.rlwy.net;Port=22404;Database=railway;Uid=root;Pwd=vMbiAFpyuiYNKkWXyMCsxdbOFmkqbUHt;SslMode=Required;";

        // 태그 이름이 리스트에 없을 경우 새 태그로 등록 (자동으로 # 추가)
        public void RegisterIfNew(string name, int userId)
        {
            if (!name.StartsWith("#"))
                name = "#" + name; // 자동 보정

            if (tags.Any(t => t.Name == name))
                return;

            Tag tag = new Tag(name, userId);
            tags.Add(tag);
            InsertTagToDb(tag);
        }

        // 이름으로 태그 객체 조회
        public Tag GetTagByName(string name)
        {
            return tags.FirstOrDefault(t => t.Name == name);
        }

        // 전체 태그 리스트 반환 (복사본)
        public List<Tag> GetAllTags()
        {
            return new List<Tag>(tags); // 외부 변경 방지
        }

        public void LoadTagsFromDb(int userId)
        {
            tags.Clear();

            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Tags WHERE UserId = @UserId ORDER BY Name";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", userId);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var tag = new Tag
                {
                    Id = reader.GetInt32("Id"),
                    Name = reader.GetString("Name"),
                    UserId = reader.GetInt32("UserId")

                };
                tags.Add(tag);
            }
        }

        private void InsertTagToDb(Tag tag)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "INSERT INTO Tags (Name, UserId) VALUES (@Name, @UserId)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", tag.Name);
            cmd.Parameters.AddWithValue("@UserId", tag.UserId);


            cmd.ExecuteNonQuery();
            tag.Id = (int)cmd.LastInsertedId;
        }

    }
}

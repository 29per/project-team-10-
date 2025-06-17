using PlanEase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace PlanEase.Services
{
    // 일정 데이터를 관리하는 클래스
    // CRUD 기능과 파일 저장/불러오기를 담당
    public class ScheduleManager
    {
        private List<Schedule> schedules = new List<Schedule>(); // 전체 일정 데이터를 메모리에서 관리하는 리스트
        private const string FilePath = "schedules.txt"; // 일정 데이터를 저장할 파일 경로
        private readonly string connStr = "Server=gondola.proxy.rlwy.net;Port=22404;Database=railway;Uid=root;Pwd=vMbiAFpyuiYNKkWXyMCsxdbOFmkqbUHt;SslMode=Required;";
        private ConflictResolver _conflictResolver;
        



        public ScheduleManager()
        {
            schedules = new List<Schedule>();
            // 중요: 여기서는 this를 전달하여 자기 자신을 참조
            _conflictResolver = new ConflictResolver(this);
        }



        //자동 해결 설정 활성화여부
        public void SetAutoResolution(bool enabled)
        {
            if (_conflictResolver != null)
            {
                _conflictResolver.SetAutoResolution(enabled);
            }
            else
            {
                Console.WriteLine("ConflictResolver is null");
                // 필요하다면 여기서 초기화
                _conflictResolver = new ConflictResolver(this);
                _conflictResolver.SetAutoResolution(enabled);
            }
        }

        public bool IsAutoResolutionEnabled()
        {
            return _conflictResolver?.IsAutoResolutionEnabled() ?? false;
        }






        // 새로운 일정을 리스트에 추가하고 파일에 저장
        public void AddSchedule(Schedule s)
        {
            schedules.Add(s);
            AddScheduleToDb(s); // DB에 추가
            Console.WriteLine($"[ScheduleManager] DB에 일정 추가됨: {s.Title} ({s.StartTime} ~ {s.EndTime})");
        }

        // ID에 해당하는 일정을 삭제하고 파일에 저장
        public void RemoveSchedule(int id)
        {
            schedules.RemoveAll(s => s.Id == id);
            //SaveSchedules();
            DeleteScheduleFromDb(id); // DB에서 삭제
        }

        // DB에서 일정 로드
        public void LoadSchedules(int userId)
        {
            schedules = LoadSchedulesFromDb(userId);
        }

        // 일정 전체 목록을 외부로 반환
        public List<Schedule> GetAllSchedules()
        {
            return new List<Schedule>(schedules); // 외부 변경 방지
        }

        // 일정 업데이트
        public void UpdateSchedule(Schedule updated)
        {
            var index = schedules.FindIndex(s => s.Id == updated.Id);
            if (index != -1)
            {
                if (_conflictResolver != null && _conflictResolver.IsAutoResolutionEnabled())
                {
                    Console.WriteLine("자동 충돌 해결 실행: 일정 업데이트");
                    // 현재 업데이트 중인 일정을 제외한 다른 일정들과의 충돌만 검사
                    var otherSchedules = schedules.Where(s => s.Id != updated.Id).ToList();
                    _conflictResolver.ResolveAllConflicts(updated, otherSchedules);
                }





                schedules[index] = updated; // 기존 객체를 통째로 교체 (Id/UserId는 동일하게 유지됨)
                UpdateScheduleInDb(updated);
            }
        }

        public void AddScheduleToDb(Schedule schedule)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string tagString = string.Join("|", schedule.Tags);

            string query = @"INSERT INTO Schedules (UserId, Title, StartTime, EndTime, Tags, Priority, IsCompleted, Description)
                     VALUES (@UserId, @Title, @StartTime, @EndTime, @Tags, @Priority, @IsCompleted, @Description)";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", schedule.UserId);
            cmd.Parameters.AddWithValue("@Title", schedule.Title);
            cmd.Parameters.AddWithValue("@StartTime", schedule.StartTime);
            cmd.Parameters.AddWithValue("@EndTime", schedule.EndTime);
            cmd.Parameters.AddWithValue("@Tags", tagString);
            cmd.Parameters.AddWithValue("@Priority", (int)schedule.Priority);
            cmd.Parameters.AddWithValue("@IsCompleted", schedule.IsCompleted);
            cmd.Parameters.AddWithValue("@Description", schedule.Description ?? "");

            cmd.ExecuteNonQuery();
            schedule.Id = (int)cmd.LastInsertedId;
        }

        public void DeleteScheduleFromDb(int id)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "DELETE FROM Schedules WHERE Id = @Id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }

        public List<Schedule> LoadSchedulesFromDb(int userId)
        {
            List<Schedule> result = new List<Schedule>();

            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM Schedules WHERE UserId = @UserId ORDER BY StartTime";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", userId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Schedule schedule = new Schedule
                {
                    Id = reader.GetInt32("Id"),
                    UserId = reader.GetInt32("UserId"),
                    Title = reader.GetString("Title"),
                    StartTime = reader.GetDateTime("StartTime"),
                    EndTime = reader.GetDateTime("EndTime"),
                    Tags = reader.IsDBNull(reader.GetOrdinal("Tags")) ? new List<string>() : reader.GetString("Tags").Split('|').ToList(),
                    Priority = (PriorityLevel)reader.GetInt32("Priority"),
                    IsCompleted = reader.GetBoolean("IsCompleted"),
                    Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? "" : reader.GetString("Description")
                };
                result.Add(schedule);
            }

            return result;
        }

        private void UpdateScheduleInDb(Schedule s)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string tagString = string.Join("|", s.Tags);
            string query = @"UPDATE Schedules SET 
                        Title = @Title, StartTime = @StartTime, EndTime = @EndTime,
                        Tags = @Tags, Priority = @Priority, IsCompleted = @IsCompleted, Description = @Description
                     WHERE Id = @Id";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Title", s.Title);
            cmd.Parameters.AddWithValue("@StartTime", s.StartTime);
            cmd.Parameters.AddWithValue("@EndTime", s.EndTime);
            cmd.Parameters.AddWithValue("@Tags", tagString);
            cmd.Parameters.AddWithValue("@Priority", (int)s.Priority);
            cmd.Parameters.AddWithValue("@IsCompleted", s.IsCompleted);
            cmd.Parameters.AddWithValue("@Description", s.Description ?? "");
            cmd.Parameters.AddWithValue("@Id", s.Id);

            cmd.ExecuteNonQuery();
        }

        // 태그 이름으로 일정 조회
        public List<Schedule> GetSchedulesByTag(string tagName)
        {
            return schedules.Where(s => s.Tags.Contains(tagName)).ToList();
        }

        public List<Schedule> GetSchedulesForDate(DateTime date)
        {
            return schedules.Where(s => s.StartTime.Date == date.Date).ToList();
        }

    }


}

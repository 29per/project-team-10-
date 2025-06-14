using PlanEase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Collections;

namespace PlanEase.Services
{
    // 할 일 데이터를 관리하는 클래스
    // CRUD 기능과 파일 입출력을 처리
    public class ToDoManager
    {
        private List<ToDo> todos = new List<ToDo>(); // 메모리 상에 저장된 전체 할 일 목록
        private const string FilePath = "todos.txt"; // 할 일 데이터를 저장할 파일 경로
        private readonly string connStr = "Server=gondola.proxy.rlwy.net;Port=22404;Database=railway;Uid=root;Pwd=vMbiAFpyuiYNKkWXyMCsxdbOFmkqbUHt;SslMode=Required;";

        // 할 일을 추가하고 DB에 저장
        public void AddToDo(ToDo todo)
        {

            todos.Add(todo);
            //SaveToDos();
            AddToDoToDb(todo);
        }

        // 할일을 삭제 (메모리,DB)
        public void RemoveToDo(int id)
        {
            todos.RemoveAll(t => t.Id == id);
            //SaveToDos();
            RemoveToDoFromDb(id);
        }

        // 완료 여부를 true ↔ false로 전환하고 저장
        public void ToggleDone(int id)
        {
            ToDo todo = todos.FirstOrDefault(t => t.Id == id);
            if (todo != null)
            {
                todo.IsDone = !todo.IsDone;
                UpdateToDoDoneStatusInDb(id, todo.IsDone);
            }
        }

        // 전체 할 일 목록 반환
        public List<ToDo> GetAllToDos()
        {
            return todos.OrderBy(t => t.DueDate == null).ThenBy(t => t.DueDate).ToList();
        }

        private void AddToDoToDb(ToDo todo)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = @"INSERT INTO ToDos (UserId, Content, IsDone, DueDate, StartTime)
                     VALUES (@UserId, @Content, @IsDone, @DueDate, @StartTime)";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", todo.UserId);
            cmd.Parameters.AddWithValue("@Content", todo.Content);
            cmd.Parameters.AddWithValue("@IsDone", todo.IsDone);
            cmd.Parameters.AddWithValue("@DueDate", todo.DueDate);
            cmd.Parameters.AddWithValue("@StartTime", todo.StartTime);

            cmd.ExecuteNonQuery();
            todo.Id = (int)cmd.LastInsertedId;
        }

        private void RemoveToDoFromDb(int id)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "DELETE FROM ToDos WHERE Id = @Id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }

        public void LoadToDosFromDb(int userId)
        {
            todos.Clear();

            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "SELECT * FROM ToDos WHERE UserId = @UserId ORDER BY DueDate";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserId", userId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var todo = new ToDo
                {
                    Id = reader.GetInt32("Id"),
                    UserId = reader.GetInt32("UserId"),
                    Content = reader.GetString("Content"),
                    IsDone = reader.GetBoolean("IsDone"),
                    DueDate = reader.IsDBNull(reader.GetOrdinal("DueDate")) ? (DateTime?)null : reader.GetDateTime("DueDate"),
                    StartTime = reader.IsDBNull(reader.GetOrdinal("StartTime")) ? (DateTime?)null : reader.GetDateTime("StartTime")
                };
                todos.Add(todo);
            }
        }
        private void UpdateToDoDoneStatusInDb(int id, bool isDone)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "UPDATE ToDos SET IsDone = @IsDone WHERE Id = @Id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IsDone", isDone);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }

        // 파일에서 할 일 목록을 불러옴
        //public void LoadToDos()
        //{
        //    List<string> lines = File.Exists(FilePath) ? File.ReadAllLines(FilePath).ToList() : new List<string>();
        //    todos = lines.Select(line => ToDo.FromCsv(line)).ToList();
        //}

        //// 현재 할 일 데이터를 파일에 저장
        //public void SaveToDos()
        //{
        //    List<string> lines = todos.Select(t => t.ToCsv()).ToList();
        //    File.WriteAllLines(FilePath, lines);
        //}

        public List<ToDo> GetToDoList()
        {
            
            // 우선순위(1=높음) → 마감일 빠른 순으로 정렬
            return todos
                .Where(t => !t.IsDone) // 완료 안 된 항목만 리턴
                .OrderBy(t => t.Priority)
                .ThenBy(t => t.DueDate)
                .ToList();
                
                
        }

        public void UpdateToDo(ToDo updatedToDo)
        {
            var existing = todos.FirstOrDefault(t => t.Id == updatedToDo.Id);
            if (existing != null)
            {
                existing.Content = updatedToDo.Content;
                existing.DueDate = updatedToDo.DueDate;
                //existing.IsDone = updatedToDo.IsDone;
                existing.StartTime = updatedToDo.StartTime;
                existing.Priority = updatedToDo.Priority;
                // 필요 시 다른 필드도 복사
            }
        }

        





    }
}

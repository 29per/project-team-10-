using PlanEase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlanEase.Services
{
    // 할 일 데이터를 관리하는 클래스
    // CRUD 기능과 파일 입출력을 처리
    internal class ToDoManager
    {
        private List<ToDo> todos = new List<ToDo>(); // 메모리 상에 저장된 전체 할 일 목록
        private const string FilePath = "todos.txt"; // 할 일 데이터를 저장할 파일 경로

        // 할 일을 추가하고 파일에 저장
        public void AddToDo(ToDo todo)
        {
            todos.Add(todo);
            SaveToDos();
        }

        // 특정 ID의 할 일을 삭제하고 저장
        public void RemoveToDo(int id)
        {
            todos.RemoveAll(t => t.Id == id);
            SaveToDos();
        }

        // 완료 여부를 true ↔ false로 전환하고 저장
        public void ToggleDone(int id)
        {
            foreach (ToDo t in todos)
            {
                if (t.Id == id)
                {
                    t.IsDone = !t.IsDone;
                    break;
                }
            }
            SaveToDos();
        }

        // 전체 할 일 목록 반환
        public List<ToDo> GetAllToDos()
        {
            return new List<ToDo>(todos); // 외부 변경 방지
        }

        // 파일에서 할 일 목록을 불러옴
        public void LoadToDos()
        {
            List<string> lines = File.Exists(FilePath) ? File.ReadAllLines(FilePath).ToList() : new List<string>();
            todos = lines.Select(line => ToDo.FromCsv(line)).ToList();
        }

        // 현재 할 일 데이터를 파일에 저장
        public void SaveToDos()
        {
            List<string> lines = todos.Select(t => t.ToCsv()).ToList();
            File.WriteAllLines(FilePath, lines);
        }
    }
}

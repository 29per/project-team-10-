using PlanEase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlanEase.Services
{
    // 일정 데이터를 관리하는 클래스
    // CRUD 기능과 파일 저장/불러오기를 담당
    internal class ScheduleManager
    {
        private List<Schedule> schedules = new List<Schedule>(); // 전체 일정 데이터를 메모리에서 관리하는 리스트
        private const string FilePath = "schedules.txt"; // 일정 데이터를 저장할 파일 경로

        // 새로운 일정을 리스트에 추가하고 파일에 저장
        public void AddSchedule(Schedule s)
        {
            schedules.Add(s);
            SaveSchedules();
        }

        // ID에 해당하는 일정을 삭제하고 파일에 저장
        public void RemoveSchedule(int id)
        {
            schedules.RemoveAll(s => s.Id == id);
            SaveSchedules();
        }

        // 일정 전체 목록을 외부로 반환
        public List<Schedule> GetAllSchedules()
        {
            return new List<Schedule>(schedules); // 외부 변경 방지
        }

        // 파일에서 일정 데이터를 불러와 리스트에 저장
        public void LoadSchedules()
        {
            List<string> lines = File.Exists(FilePath) ? File.ReadAllLines(FilePath).ToList(): new List<string>();
            schedules = lines.Select(line=>Schedule.FromCsv(line)).ToList();
        }

        // 현재 일정 리스트를 파일로 저장
        public void SaveSchedules()
        {
            List<string> lines = schedules.Select(s => s.ToCsv()).ToList();
            File.WriteAllLines(FilePath, lines);
        }
    }
}

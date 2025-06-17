using PlanEase.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanEase.Views.Controls;

namespace PlanEase.Views.Controls
{
    public partial class CalendarControl : UserControl
    {
        private List<DateCellControl> dateCells = new List<DateCellControl>();
        private DateTime currentMonth; 
        private ScheduleManager scheduleManager; 
        private TagManager tagManager;
        int userId;

        public CalendarControl(ScheduleManager scheduleManager, TagManager tagManager, int userId)
        {
            InitializeComponent();
            this.scheduleManager = scheduleManager;
            this.tagManager = tagManager;
            this.userId = userId;
            InitializeDateCells();
            Console.WriteLine("CalendarControl 생성자 호출됨. UserId: " + userId);
        }

        public void SetScheduleManager(ScheduleManager manager)
        {
            scheduleManager = manager;
        }

        public void ShowMonth(DateTime targetMonth)
        {
            currentMonth = new DateTime(targetMonth.Year, targetMonth.Month, 1);
            RenderCalendar();
        }

        private void InitializeDateCells()
        {
            for (int i = 0; i < 42; i++)
            {

                var cell = new DateCellControl(scheduleManager, tagManager,userId);
                //cell.Size = new Size(110, 110);
                cell.Location = new Point((i % 7) * (cell.Size.Width), (i / 7) * (cell.Size.Height));
                cell.Visible = false;

                cell.ScheduleDropped += HandleScheduleDropped; // 이벤트 연결

                this.Controls.Add(cell);
                dateCells.Add(cell);
            }
        }

        private void RenderCalendar()
        {
            DateTime firstDay = currentMonth;
            int startDayOfWeek = (int)firstDay.DayOfWeek; // 0 = Sunday, 1 = Monday...

            int daysInMonth = DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month);
            int totalSlots = startDayOfWeek + daysInMonth;
            int visibleCellCount = (totalSlots > 35) ? 42 : 35;

            int rowCount = (visibleCellCount + 6) / 7; // 35 → 5줄, 36~42 → 6줄
            int controlHeight = rowCount * 110;

            this.Size = new Size(770, controlHeight); // CalendarControl 크기 동적 변경

            DateTime startDate = firstDay.AddDays(-startDayOfWeek); // 달력 시작 날짜 (빈 칸 포함)

            for (int i = 0; i < 42; i++)
            {
                DateTime cellDate = startDate.AddDays(i);
                var cell = dateCells[i];
                cell.SetDate(cellDate);
                // 일정 초기화
                cell.ClearSchedules();

                // 해당 날짜의 일정 추가
                if (scheduleManager != null)
                {
                    if (i < visibleCellCount && cellDate.Month == currentMonth.Month)
                    {
                        cell.Visible = true;

                        // 일정 추가
                        var schedules = scheduleManager.GetSchedulesForDate(cellDate);
                        foreach (var sched in schedules)
                        {
                            var item = new ScheduleItemControl(sched.Title, sched.Priority,scheduleManager);
                            item.ScheduleId = sched.Id;
                            cell.AddScheduleControl(item);
                        }
                    }
                    else
                    {
                        cell.Visible = false;
                    }
                }
            }
        }

        private void HandleScheduleDropped(int scheduleId, DateTime newDate)
        {
            var schedule = scheduleManager.GetAllSchedules().FirstOrDefault(s => s.Id == scheduleId);
            if (schedule == null) return;

            // 날짜만 수정
            DateTime originalStart = schedule.StartTime;
            DateTime originalEnd = schedule.EndTime;

            TimeSpan duration = originalEnd - originalStart;
            schedule.StartTime = newDate.Date + originalStart.TimeOfDay;
            schedule.EndTime = schedule.StartTime + duration;


            scheduleManager.UpdateSchedule(schedule); // DB 반영
            ShowMonth(currentMonth); // 달력 갱신
            if (SchedulePopUpForm.CurrentInstance != null)
            {
                var date = SchedulePopUpForm.CurrentInstance.Date; // Date 프로퍼티가 있어야 함
                var updatedList = scheduleManager.GetSchedulesForDate(date);
                SchedulePopUpForm.CurrentInstance.RefreshScheduleList(updatedList);
            }

        }


    }
}

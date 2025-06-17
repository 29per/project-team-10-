using PlanEase.Models;
using PlanEase.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanEase.Views.Controls
{
    public partial class DateCellControl : UserControl
    {
        public DateTime Date { get; private set; } // 이 셀의 날짜
        private const int MaxVisibleSchedules = 2;
        public event Action<int, DateTime> ScheduleDropped;
        private ScheduleManager scheduleManager;
        private TagManager tagManager;

        public DateCellControl(ScheduleManager scheduleManager, TagManager tagManager)
        {
            InitializeComponent();
            panelContent.AllowDrop = true;

            // Drag event 연결
            panelContent.DragEnter += PanelContent_DragEnter;
            panelContent.DragDrop += PanelContent_DragDrop;
            this.scheduleManager = scheduleManager;
            this.tagManager = tagManager;
        }


        // 날짜 설정 메서드
        public void SetDate(DateTime date)
        {
            Date = date;
            lblDate.Text = date.Day.ToString();

            // 오늘이면 강조 색
            if (date.Date == DateTime.Today)
                panelContent.BackColor = Color.Plum;
            //else
            //    panelContent.BackColor = Color.White;
        }

        // 일정 추가
        public void AddScheduleControl(ScheduleItemControl scheduleItem)
        {
            scheduleItem.ScheduleEditRequested += OnScheduleEditRequested;

            if (pnlScheduleList.Controls.Count < MaxVisibleSchedules)
            {
                pnlScheduleList.Controls.Add(scheduleItem);
            }
            else
            {
                lblMore.Visible = true;
                lblMore.Text = $"+{pnlScheduleList.Controls.Count - MaxVisibleSchedules + 1}";
            }
        }


        // 일정 드래그 들어올 때
        private void PanelContent_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) // 드롭 가능한지를 검사
                e.Effect = DragDropEffects.Move;
        }

        // 일정 드랍했을 때
        private void PanelContent_DragDrop(object sender, DragEventArgs e)
        {
            //string scheduleId = e.Data.GetData(DataFormats.Text).ToString();
            //// TODO: ID로 Schedule 찾아서 AddScheduleControl() 호출
            //MessageBox.Show($"드롭 성공! 날짜: {Date.ToShortDateString()}, 일정 ID: {scheduleId}");

            string scheduleIdStr = e.Data.GetData(DataFormats.Text).ToString();
            if (int.TryParse(scheduleIdStr, out int scheduleId))
            {
                ScheduleDropped?.Invoke(scheduleId, this.Date); // 이벤트 발생
            }
        }



        // 일정 목록 초기화
        public void ClearSchedules()
        {
            pnlScheduleList.Controls.Clear();
            lblMore.Visible = false;
        }

        private void lblMore_Click(object sender, EventArgs e)
        {
            var schedules = scheduleManager.GetSchedulesForDate(this.Date);
            var form = new SchedulePopUpForm(this.Date,schedules,scheduleManager);

            var screenLocation = this.PointToScreen(Point.Empty);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(screenLocation.X + 110, screenLocation.Y);
            form.Show();
        }

        private void OnScheduleEditRequested(Schedule schedule)
        {
            var form = new AddScheduleForm_new_(
                schedule,
                scheduleManager,
                tagManager,
                () =>
                {
                    var calendar = this.FindForm()
                                       .Controls
                                       .Find("calendar", true)
                                       .FirstOrDefault() as CalendarControl;

                    calendar?.ShowMonth(schedule.StartTime);
                });

            form.ShowDialog();
        }
    }
}

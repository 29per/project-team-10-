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

namespace PlanEase.Views.panelDesktop
{
    public partial class Planner : UserControl
    {
        private DateTime currentMonth;
        private DateTime currentWeekStartDate;
        private Dictionary<DateTime, Panel> datePanels = new Dictionary<DateTime, Panel>();
        private User loggedInUser;
        private ScheduleManager scheduleManager;
        private ToDoManager toDoManager;
        private TagManager tagManager;


        private void GenerateCalendar(DateTime targetMonth)
        {
            calendarTable.Controls.Clear();

            DateTime firstDay = new DateTime(targetMonth.Year, targetMonth.Month, 1);
            int startDay = (int)firstDay.DayOfWeek;
            int daysInMonth = DateTime.DaysInMonth(targetMonth.Year, targetMonth.Month);



            int cellIndex = 0;

            for (int i = 0; i < 42; i++) // 7 x 6 = 42 cells
            {
                Panel cellPanel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(1),
                    BackColor = Color.White,
                    AllowDrop = true
                };

                if (i >= startDay && i < startDay + daysInMonth)
                {
                    int day = i - startDay + 1;

                    Label lblDate = new Label
                    {
                        Text = day.ToString(),
                        Dock = DockStyle.Top,
                        TextAlign = ContentAlignment.TopRight,
                        Padding = new Padding(5),
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        ForeColor = Color.Black
                    };

                    cellPanel.Tag = new DateTime(targetMonth.Year, targetMonth.Month, day);
                    cellPanel.Controls.Add(lblDate);

                    // 이벤트 핸들링 (예시)
                    cellPanel.Click += DateCell_Click;
                    cellPanel.DragEnter += CellPanel_DragEnter;
                    cellPanel.DragDrop += CellPanel_DragDrop;
                    cellPanel.MouseDown += CellPanel_MouseDown;
                }

                calendarTable.Controls.Add(cellPanel);
                cellIndex++;
            }
        }


        public Planner(User user, ScheduleManager manager)
        {
            InitializeComponent();
            SetupCalendarTable();
            this.loggedInUser = user;
            this.scheduleManager = manager;
        }

        private void SetupCalendarTable()
        {
            // calendarTable 스타일 초기화 및 설정 담당 (중복 호출 대비 안전)
            calendarTable.SuspendLayout();

            // Clear 이전 스타일
            calendarTable.ColumnStyles.Clear();
            calendarTable.RowStyles.Clear();

            // 고정 열, 행 설정
            calendarTable.ColumnCount = 7;
            calendarTable.RowCount = 6;

            // Dock 및 Margin 설정도 여기서 통합 관리 (필요 시)
            calendarTable.Dock = DockStyle.Fill;
            calendarTable.Margin = new Padding(0);

            // 열 비율 지정 (7일)
            for (int i = 0; i < 7; i++)
            {
                calendarTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));
            }

            // 행 비율 지정 (6주)
            for (int i = 0; i < 6; i++)
            {
                calendarTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 6));
            }

            calendarTable.ResumeLayout();
        }

        private void btnDayView_Click(object sender, EventArgs e)
        {
            panelDayView.Visible = true;
            panelWeekView.Visible = false;
            panelMonthView.Visible = false;
            InitializeDayView(DateTime.Today);

            // 예시 콘텐츠
            panelDayView.Controls.Clear();
            Label lbl = new Label
            {
                Text = "오늘의 일정 보기",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("맑은 고딕", 20)
            };
            panelDayView.Controls.Add(lbl);
        }

        private void btnWeekView_Click(object sender, EventArgs e)
        {
            panelDayView.Visible = false;
            panelWeekView.Visible = true;
            panelMonthView.Visible = false;
            InitializeWeekCalendar(DateTime.Today);

            // 예시 콘텐츠
            panelWeekView.Controls.Clear();
            Label lbl = new Label
            {
                Text = "이번 주 일정 보기",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("맑은 고딕", 20)
            };
            panelWeekView.Controls.Add(lbl);
        }

        private void btnMonthView_Click(object sender, EventArgs e)
        {
            panelDayView.Visible = false;
            panelWeekView.Visible = false;
            panelMonthView.Visible = true;
            GenerateCalendar(DateTime.Today);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GenerateCalendar(DateTime.Today);

            // 먼저 열과 행 개수 설정
            calendarTableLayoutPanel.ColumnCount = 7;
            calendarTableLayoutPanel.RowCount = 5;

            // 기존 스타일 초기화 (중복 추가 방지)
            calendarTableLayoutPanel.ColumnStyles.Clear();
            calendarTableLayoutPanel.RowStyles.Clear();

            // 열 스타일 설정
            for (int i = 0; i < 7; i++)
            {
                calendarTableLayoutPanel.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 100f / 7f));
            }

            // 행 스타일 설정
            for (int i = 0; i < 6; i++)
            {
                calendarTableLayoutPanel.RowStyles.Add(
                    new RowStyle(SizeType.Percent, 100f / 6f));
            }

            panelDayView.Visible = false;
            panelWeekView.Visible = false;
            panelMonthView.Visible = true;

            GenerateCalendar(DateTime.Today);

            UpdateMonthLabel();
            //RenderCalendar();

        }
        private void InitializeWeekCalendar(DateTime referenceDate)
        {
            panelWeekView.Controls.Clear();

            // referenceDate가 포함된 주의 일요일 구하기
            int diff = (int)referenceDate.DayOfWeek; // 일요일=0
            currentWeekStartDate = referenceDate.AddDays(-diff);

            // 7일(일주일) 표시용 TableLayoutPanel 생성
            TableLayoutPanel weekTable = new TableLayoutPanel();
            weekTable.Dock = DockStyle.Fill;
            weekTable.ColumnCount = 7;
            weekTable.RowCount = 1;

            for (int i = 0; i < 7; i++)
            {
                weekTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));
            }
            weekTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));

            for (int i = 0; i < 7; i++)
            {
                DateTime date = currentWeekStartDate.AddDays(i);

                Panel dayPanel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(1),
                    BackColor = Color.White,
                    Dock = DockStyle.Fill,
                    Tag = date,
                    AllowDrop = true
                };

                // 날짜 라벨
                Label dayLabel = new Label
                {
                    Text = date.ToString("ddd dd"),
                    Dock = DockStyle.Top,
                    Height = 20,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("맑은 고딕", 10, FontStyle.Bold)
                };
                dayPanel.Controls.Add(dayLabel);

                // 할 일 리스트 영역
                FlowLayoutPanel toDoListPanel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    WrapContents = false,
                    FlowDirection = FlowDirection.TopDown,
                    Tag = "ToDoListPanel"
                };
                dayPanel.Controls.Add(toDoListPanel);

                weekTable.Controls.Add(dayPanel, i, 0);
            }

            panelWeekView.Controls.Add(weekTable);

        }

       
        

        private void InitializeDayView(DateTime date)
        {
            panelDayView.Controls.Clear();

            Panel dayPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                AllowDrop = true,
                Tag = date
            };

            Label dayLabel = new Label
            {
                Text = date.ToString("yyyy-MM-dd (dddd)"),
                Dock = DockStyle.Top,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("맑은 고딕", 14, FontStyle.Bold)
            };
            dayPanel.Controls.Add(dayLabel);

            FlowLayoutPanel toDoListPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = false,
                FlowDirection = FlowDirection.TopDown,
                Tag = "ToDoListPanel"
            };
            dayPanel.Controls.Add(toDoListPanel);

           

            panelDayView.Controls.Add(dayPanel);

        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            AddScheduleForm_new_ addScheduleForm = new AddScheduleForm_new_(loggedInUser.Id,scheduleManager);
            addScheduleForm.ShowDialog();
        }



        private DateTime currentDate = DateTime.Today;

        //달력 넘김
        private void UpdateMonthLabel()
        {
            lblCurrentMonth.Text = currentDate.ToString("yyyy년 M월");
        }

        private void btnPrevMonth_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(-1);
            UpdateMonthLabel();
            GenerateCalendar(currentDate);

        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddMonths(1);
            UpdateMonthLabel();
            GenerateCalendar(currentDate);

        }



        private void btnAddTodo_Click(object sender, EventArgs e)
        {
            //List<Tag> availableTags = tagManager.GetAllTags(); // TagManager에서 태그 리스트 가져오기
            AddToDoForm addToDoForm = new AddToDoForm(loggedInUser.Id, toDoManager); //availableTags);
            addToDoForm.ShowDialog();
        }
    }
}


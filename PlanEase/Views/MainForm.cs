using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PlanEase.Models;

namespace PlanEase
{
    public partial class MainForm : Form
    {
        private User loggedInUser;

        public MainForm(User user)
        {
            InitializeComponent();
            SetupCalendarTable();
            loggedInUser = user;
        }

        public MainForm()
        {
            InitializeComponent();
            SetupCalendarTable();
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

        private void TestDbConnection()
        {
            string connStr = "Server=gondola.proxy.rlwy.net;Port=22404;Database=railway;Uid=root;Pwd=vMbiAFpyuiYNKkWXyMCsxdbOFmkqbUHt;SslMode=Required;";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("MySQL 연결 성공!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("연결 실패: " + ex.Message);
                }
            }
        }

        private DateTime currentWeekStartDate;


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 전체 프로그램 종료
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
            InitializeCalendar(DateTime.Today);

        }

        private DateTime currentMonth;
        private Dictionary<DateTime, Panel> datePanels = new Dictionary<DateTime, Panel>();
        private Dictionary<DateTime, List<ToDoItem>> toDoItems = new Dictionary<DateTime, List<ToDoItem>>();

        // ToDoItem 클래스도 추가 필요 (할 일 항목 데이터 클래스)
        public class ToDoItem
        {
            public string Title { get; set; }
            public string Details { get; set; }
            // 기타 필요한 속성들
        }

        private void InitializeCalendar(DateTime targetMonth)
        {
            currentMonth = new DateTime(targetMonth.Year, targetMonth.Month, 1);
            calendarTableLayoutPanel.Controls.Clear();
            datePanels.Clear();

            // 1일의 요일 구하기 (일요일=0 ~ 토요일=6)
            int startDayOfWeek = (int)currentMonth.DayOfWeek;
            int daysInMonth = DateTime.DaysInMonth(currentMonth.Year, currentMonth.Month);

            int totalCells = 42; // 7 * 6 (최대 주 수)
            DateTime cellDate;

            for (int i = 0; i < totalCells; i++)
            {
                Panel dayPanel = new Panel();
                dayPanel.BorderStyle = BorderStyle.FixedSingle;
                dayPanel.Margin = new Padding(1);
                dayPanel.BackColor = Color.White;
                dayPanel.AllowDrop = true;  // 드래그앤드랍 활성화

                // 날짜 텍스트 라벨
                Label dayLabel = new Label();
                dayLabel.AutoSize = false;
                dayLabel.TextAlign = ContentAlignment.TopRight;
                dayLabel.Dock = DockStyle.Top;
                dayLabel.Height = 20;

                if (i >= startDayOfWeek && i < startDayOfWeek + daysInMonth)
                {
                    int dayNumber = i - startDayOfWeek + 1;
                    cellDate = new DateTime(currentMonth.Year, currentMonth.Month, dayNumber);
                    dayLabel.Text = dayNumber.ToString();

                    dayPanel.Tag = cellDate;
                    dayPanel.Controls.Add(dayLabel);

                    // ToDo 목록 보여줄 Panel
                    FlowLayoutPanel toDoListPanel = new FlowLayoutPanel();
                    toDoListPanel.Dock = DockStyle.Fill;
                    toDoListPanel.AutoScroll = true;
                    toDoListPanel.WrapContents = false;
                    toDoListPanel.FlowDirection = FlowDirection.TopDown;
                    toDoListPanel.Tag = "ToDoListPanel";

                    dayPanel.Controls.Add(toDoListPanel);

                    // 이벤트 연결
                    dayPanel.DragEnter += DayPanel_DragEnter;
                    dayPanel.DragDrop += DayPanel_DragDrop;

                    datePanels[cellDate] = dayPanel;
                }
                else
                {
                    dayLabel.Text = "";
                    dayPanel.Controls.Add(dayLabel);
                }

                calendarTableLayoutPanel.Controls.Add(dayPanel);
            }

            RefreshToDoLists();
        }

        private void RefreshToDoLists()
        {
            foreach (var kvp in datePanels)
            {
                DateTime date = kvp.Key;
                Panel dayPanel = kvp.Value;
                FlowLayoutPanel toDoListPanel = null;

                foreach (Control c in dayPanel.Controls)
                {
                    if (c is FlowLayoutPanel && c.Tag?.ToString() == "ToDoListPanel")
                    {
                        toDoListPanel = (FlowLayoutPanel)c;
                        break;
                    }
                }
                if (toDoListPanel == null)
                    continue;

                toDoListPanel.Controls.Clear();

                if (toDoItems.ContainsKey(date))
                {
                    foreach (var todo in toDoItems[date])
                    {
                        Label todoLabel = new Label();
                        todoLabel.Text = todo.Title;
                        todoLabel.AutoSize = false;
                        todoLabel.Width = toDoListPanel.Width - 20;
                        todoLabel.Height = 20;
                        todoLabel.BackColor = Color.LightBlue;
                        todoLabel.Margin = new Padding(2);
                        todoLabel.Cursor = Cursors.Hand;
                        todoLabel.Tag = todo;

                        // 클릭 이벤트 - 세부정보 보기
                        todoLabel.Click += TodoLabel_Click;

                        // 드래그 시작 이벤트
                        todoLabel.MouseDown += TodoLabel_MouseDown;

                        // 우클릭 메뉴 추가
                        todoLabel.ContextMenuStrip = CreateToDoContextMenu(todo, date);

                        toDoListPanel.Controls.Add(todoLabel);
                    }
                }
            }
        }

        private void DayPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ToDoItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void DayPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(ToDoItem))) return;

            Panel targetPanel = sender as Panel;
            if (targetPanel == null) return;

            DateTime targetDate = (DateTime)targetPanel.Tag;
            ToDoItem draggedToDo = (ToDoItem)e.Data.GetData(typeof(ToDoItem));

            // 원래 날짜 찾기
            DateTime originalDate = toDoItems.Keys.FirstOrDefault(date => toDoItems[date].Contains(draggedToDo));

            if (originalDate != default && originalDate != targetDate)
            {
                toDoItems[originalDate].Remove(draggedToDo);

                if (!toDoItems.ContainsKey(targetDate))
                    toDoItems[targetDate] = new List<ToDoItem>();

                toDoItems[targetDate].Add(draggedToDo);

                RefreshToDoLists();
            }
        }

        private void TodoLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label todoLabel = sender as Label;
                if (todoLabel?.Tag is ToDoItem todo)
                {
                    todoLabel.DoDragDrop(todo, DragDropEffects.Move);
                }
            }
        }

        private ContextMenuStrip CreateToDoContextMenu(ToDoItem todo, DateTime date)
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            ToolStripMenuItem editItem = new ToolStripMenuItem("수정");
            editItem.Click += (s, e) => EditToDoItem(todo, date);

            ToolStripMenuItem deleteItem = new ToolStripMenuItem("삭제");
            deleteItem.Click += (s, e) => DeleteToDoItem(todo, date);

            menu.Items.Add(editItem);
            menu.Items.Add(deleteItem);

            return menu;
        }

        private void EditToDoItem(ToDoItem todo, DateTime date)
        {
            // TODO: 세부정보 창 띄우기 (팝업 Form 등)
            MessageBox.Show($"수정할 ToDo: {todo.Title} (날짜: {date.ToShortDateString()})");
        }

        private void DeleteToDoItem(ToDoItem todo, DateTime date)
        {
            if (toDoItems.ContainsKey(date))
            {
                toDoItems[date].Remove(todo);
                RefreshToDoLists();
            }
        }

        private void TodoLabel_Click(object sender, EventArgs e)
        {
            Label todoLabel = sender as Label;
            if (todoLabel?.Tag is ToDoItem todo)
            {
                // TODO: 세부정보 창 띄우기 (팝업 Form 등)
                MessageBox.Show($"ToDo 제목: {todo.Title}\n내용: {todo.Details}");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeCalendar(DateTime.Today);

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

            InitializeCalendar(DateTime.Today);

            GenerateCalendar(DateTime.Today);

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

                // 이벤트 핸들러 연결
                dayPanel.DragEnter += DayPanel_DragEnter;
                dayPanel.DragDrop += DayPanel_DragDrop;

                weekTable.Controls.Add(dayPanel, i, 0);
            }

            panelWeekView.Controls.Add(weekTable);

            RefreshWeekToDoLists();
        }

        private void RefreshWeekToDoLists()
        {
            if (panelWeekView.Controls.Count == 0) return;

            TableLayoutPanel weekTable = panelWeekView.Controls[0] as TableLayoutPanel;
            if (weekTable == null) return;

            for (int i = 0; i < weekTable.ColumnCount; i++)
            {
                Panel dayPanel = weekTable.GetControlFromPosition(i, 0) as Panel;
                if (dayPanel == null) continue;

                FlowLayoutPanel toDoListPanel = null;

                foreach (Control c in dayPanel.Controls)
                {
                    if (c is FlowLayoutPanel && c.Tag?.ToString() == "ToDoListPanel")
                    {
                        toDoListPanel = (FlowLayoutPanel)c;
                        break;
                    }
                }

                if (toDoListPanel == null) continue;

                toDoListPanel.Controls.Clear();

                DateTime date = (DateTime)dayPanel.Tag;
                if (toDoItems.ContainsKey(date))
                {
                    foreach (var todo in toDoItems[date])
                    {
                        Label todoLabel = new Label
                        {
                            Text = todo.Title,
                            AutoSize = false,
                            Width = toDoListPanel.Width - 20,
                            Height = 20,
                            BackColor = Color.LightBlue,
                            Margin = new Padding(2),
                            Cursor = Cursors.Hand,
                            Tag = todo
                        };

                        todoLabel.Click += TodoLabel_Click;
                        todoLabel.MouseDown += TodoLabel_MouseDown;
                        todoLabel.ContextMenuStrip = CreateToDoContextMenu(todo, date);

                        toDoListPanel.Controls.Add(todoLabel);
                    }
                }
            }
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

            dayPanel.DragEnter += DayPanel_DragEnter;
            dayPanel.DragDrop += DayPanel_DragDrop;

            panelDayView.Controls.Add(dayPanel);

            RefreshDayToDoList(date);
        }

        private void RefreshDayToDoList(DateTime date)
        {
            if (panelDayView.Controls.Count == 0) return;

            Panel dayPanel = panelDayView.Controls[0] as Panel;
            if (dayPanel == null) return;

            FlowLayoutPanel toDoListPanel = null;

            foreach (Control c in dayPanel.Controls)
            {
                if (c is FlowLayoutPanel && c.Tag?.ToString() == "ToDoListPanel")
                {
                    toDoListPanel = (FlowLayoutPanel)c;
                    break;
                }
            }

            if (toDoListPanel == null) return;

            toDoListPanel.Controls.Clear();

            if (toDoItems.ContainsKey(date))
            {
                foreach (var todo in toDoItems[date])
                {
                    Label todoLabel = new Label
                    {
                        Text = todo.Title,
                        AutoSize = false,
                        Width = toDoListPanel.Width - 20,
                        Height = 20,
                        BackColor = Color.LightBlue,
                        Margin = new Padding(2),
                        Cursor = Cursors.Hand,
                        Tag = todo
                    };

                    todoLabel.Click += TodoLabel_Click;
                    todoLabel.MouseDown += TodoLabel_MouseDown;
                    todoLabel.ContextMenuStrip = CreateToDoContextMenu(todo, date);

                    toDoListPanel.Controls.Add(todoLabel);
                }
            }
        }


    }
}


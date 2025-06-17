using PlanEase.Models;
using PlanEase.Services;
using PlanEase.Views.Controls;
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

        private DateTime currentMonth =DateTime.Now;
        private DateTime currentWeekStartDate;
        private Dictionary<DateTime, Panel> datePanels = new Dictionary<DateTime, Panel>();
        private User loggedInUser;
        private ScheduleManager scheduleManager;
        private ToDoManager toDoManager;
        private TagManager tagManager;
        private List<ToDo> toDoList = new List<ToDo>();

        public CalendarControl calendar;
        private Panel pnlMonthPicker;
        private ComboBox cbYear;
        private ComboBox cbMonth;

        private void InitializeCalendar()
        {
            calendar = new CalendarControl(scheduleManager,tagManager,loggedInUser.Id);
            //calendar.SetScheduleManager(scheduleManager);
            calendar.Location = new Point(0, 0); // panelRight 내에서 좌측 상단 정렬
            //calendar.Size = new Size(770, 660);
            panelRight.Controls.Add(calendar);

            calendar.ShowMonth(DateTime.Now); // 현재 월 표시
            UpdateCalendar();
        }

        private void InitializeMonthNavigation()
        {

            InitializeMonthPickerPanel();
        }

        private void InitializeMonthPickerPanel()
        {
            pnlMonthPicker = new Panel
            {
                Size = new Size(200, 100),
                Location = new Point(285, 45),
                Visible = false,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            cbYear = new ComboBox { Location = new Point(10, 10), Size = new Size(180, 30) };
            cbMonth = new ComboBox { Location = new Point(10, 50), Size = new Size(180, 30) };

            for (int year = DateTime.Now.Year - 5; year <= DateTime.Now.Year + 5; year++)
                cbYear.Items.Add(year);

            for (int month = 1; month <= 12; month++)
                cbMonth.Items.Add(month);

            cbYear.SelectedIndexChanged += MonthPicker_Changed;
            cbMonth.SelectedIndexChanged += MonthPicker_Changed;

            pnlMonthPicker.Controls.Add(cbYear);
            pnlMonthPicker.Controls.Add(cbMonth);
            this.Controls.Add(pnlMonthPicker);
            pnlMonthPicker.BringToFront();

        }


        private void BtnPrevMonth_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(-1);
            UpdateCalendar();
        }

        private void BtnNextMonth_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(1);
            UpdateCalendar();
        }

        private void LblMonthDisplay_Click(object sender, EventArgs e)
        {
            pnlMonthPicker.Visible = !pnlMonthPicker.Visible;
            cbYear.SelectedItem = currentMonth.Year;
            cbMonth.SelectedItem = currentMonth.Month;
        }

        private void MonthPicker_Changed(object sender, EventArgs e)
        {
            if (cbYear.SelectedItem != null && cbMonth.SelectedItem != null)
            {
                int year = (int)cbYear.SelectedItem;
                int month = (int)cbMonth.SelectedItem;
                currentMonth = new DateTime(year, month, 1);
                pnlMonthPicker.Visible = false;
                UpdateCalendar();
            }
        }

        private void UpdateCalendar()
        {
            lblMonthDisplay.Text = $"{currentMonth.Year}년 {currentMonth.Month}월";
            calendar.ShowMonth(currentMonth);
        }



        //private void GenerateCalendar(DateTime targetMonth)
        //{
        //    calendarTable.Controls.Clear();

        //    DateTime firstDay = new DateTime(targetMonth.Year, targetMonth.Month, 1);
        //    int startDay = (int)firstDay.DayOfWeek;
        //    int daysInMonth = DateTime.DaysInMonth(targetMonth.Year, targetMonth.Month);



        //    int cellIndex = 0;

        //    for (int i = 0; i < 42; i++) // 7 x 6 = 42 cells
        //    {
        //        Panel cellPanel = new Panel
        //        {
        //            BorderStyle = BorderStyle.FixedSingle,
        //            Margin = new Padding(1),
        //            BackColor = Color.White,
        //            AllowDrop = true
        //        };

        //        if (i >= startDay && i < startDay + daysInMonth)
        //        {
        //            int day = i - startDay + 1;

        //            Label lblDate = new Label
        //            {
        //                Text = day.ToString(),
        //                Dock = DockStyle.Top,
        //                TextAlign = ContentAlignment.TopRight,
        //                Padding = new Padding(5),
        //                Font = new Font("Segoe UI", 9, FontStyle.Bold),
        //                ForeColor = Color.Black
        //            };

        //            cellPanel.Tag = new DateTime(targetMonth.Year, targetMonth.Month, day);
        //            cellPanel.Controls.Add(lblDate);

        //            // 이벤트 핸들링 (예시)
        //            cellPanel.Click += DateCell_Click;
        //            cellPanel.DragEnter += CellPanel_DragEnter;
        //            cellPanel.DragDrop += CellPanel_DragDrop;
        //            cellPanel.MouseDown += CellPanel_MouseDown;
        //        }

        //        calendarTable.Controls.Add(cellPanel);
        //        cellIndex++;
        //    }
        //}


        public Planner(User user, ScheduleManager manager,TagManager tagManager, ToDoManager toDoManager)
        {
            InitializeComponent();
            //SetupCalendarTable();
            // 1. 전달받은 객체들을 멤버 변수에 저장
            this.loggedInUser = user;
            this.scheduleManager = manager;
            this.tagManager = tagManager;
            this.toDoManager = toDoManager;
            // 2. 달력 및 네비게이션 초기화
            InitializeCalendar();
            InitializeMonthNavigation();
            //RefreshToDoListView();
            // 3. DB에서 현재 로그인한 사용자의 할 일 목록을 불러옴
            //    currentUserId 대신 loggedInUser.Id를 사용합니다.
            this.toDoManager.LoadToDosFromDb(this.loggedInUser.Id);
            // 4. 불러온 데이터를 화면에 표시
            LoadToDoList();
            Console.WriteLine("Planner 생성자 호출됨. UserId: " + loggedInUser.Id);
        }

        //private void SetupCalendarTable()
        //{
        //    // calendarTable 스타일 초기화 및 설정 담당 (중복 호출 대비 안전)
        //    calendarTable.SuspendLayout();

        //    // Clear 이전 스타일
        //    calendarTable.ColumnStyles.Clear();
        //    calendarTable.RowStyles.Clear();

        //    // 고정 열, 행 설정
        //    calendarTable.ColumnCount = 7;
        //    calendarTable.RowCount = 6;

        //    // Dock 및 Margin 설정도 여기서 통합 관리 (필요 시)
        //    calendarTable.Dock = DockStyle.Fill;
        //    calendarTable.Margin = new Padding(0);

        //    // 열 비율 지정 (7일)
        //    for (int i = 0; i < 7; i++)
        //    {
        //        calendarTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));
        //    }

        //    // 행 비율 지정 (6주)
        //    for (int i = 0; i < 6; i++)
        //    {
        //        calendarTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 6));
        //    }

        //    calendarTable.ResumeLayout();
        //}

        //private void btnDayView_Click(object sender, EventArgs e)
        //{
        //    panelDayView.Visible = true;
        //    panelWeekView.Visible = false;
        //    panelMonthView.Visible = false;
        //    //InitializeDayView(DateTime.Today);

        //    // 예시 콘텐츠
        //    panelDayView.Controls.Clear();
        //    Label lbl = new Label
        //    {
        //        Text = "오늘의 일정 보기",
        //        Dock = DockStyle.Fill,
        //        TextAlign = ContentAlignment.MiddleCenter,
        //        Font = new Font("맑은 고딕", 20)
        //    };
        //    panelDayView.Controls.Add(lbl);
        //}

        //private void btnWeekView_Click(object sender, EventArgs e)
        //{
        //    panelDayView.Visible = false;
        //    panelWeekView.Visible = true;
        //    panelMonthView.Visible = false;
        //    //InitializeWeekCalendar(DateTime.Today);

        //    // 예시 콘텐츠
        //    panelWeekView.Controls.Clear();
        //    Label lbl = new Label
        //    {
        //        Text = "이번 주 일정 보기",
        //        Dock = DockStyle.Fill,
        //        TextAlign = ContentAlignment.MiddleCenter,
        //        Font = new Font("맑은 고딕", 20)
        //    };
        //    panelWeekView.Controls.Add(lbl);
        //}

        //private void btnMonthView_Click(object sender, EventArgs e)
        //{
        //    panelDayView.Visible = false;
        //    panelWeekView.Visible = false;
        //    panelMonthView.Visible = true;
        //    GenerateCalendar(DateTime.Today);

        //}

        //private void MainForm_Load(object sender, EventArgs e)
        //{
            //GenerateCalendar(DateTime.Today);

            //// 먼저 열과 행 개수 설정
            //calendarTableLayoutPanel.ColumnCount = 7;
            //calendarTableLayoutPanel.RowCount = 5;

            //// 기존 스타일 초기화 (중복 추가 방지)
            //calendarTableLayoutPanel.ColumnStyles.Clear();
            //calendarTableLayoutPanel.RowStyles.Clear();

            //// 열 스타일 설정
            //for (int i = 0; i < 7; i++)
            //{
            //    calendarTableLayoutPanel.ColumnStyles.Add(
            //        new ColumnStyle(SizeType.Percent, 100f / 7f));
            //}

            //// 행 스타일 설정
            //for (int i = 0; i < 6; i++)
            //{
            //    calendarTableLayoutPanel.RowStyles.Add(
            //        new RowStyle(SizeType.Percent, 100f / 6f));
            //}

            //panelDayView.Visible = false;
            //panelWeekView.Visible = false;
            //panelMonthView.Visible = true;

            //GenerateCalendar(DateTime.Today);

            //UpdateMonthLabel();
            //RenderCalendar();

        //}
        //private void InitializeWeekCalendar(DateTime referenceDate)
        //{
        //    panelWeekView.Controls.Clear();

        //    // referenceDate가 포함된 주의 일요일 구하기
        //    int diff = (int)referenceDate.DayOfWeek; // 일요일=0
        //    currentWeekStartDate = referenceDate.AddDays(-diff);

        //    // 7일(일주일) 표시용 TableLayoutPanel 생성
        //    TableLayoutPanel weekTable = new TableLayoutPanel();
        //    weekTable.Dock = DockStyle.Fill;
        //    weekTable.ColumnCount = 7;
        //    weekTable.RowCount = 1;

        //    for (int i = 0; i < 7; i++)
        //    {
        //        weekTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));
        //    }
        //    weekTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));

        //    for (int i = 0; i < 7; i++)
        //    {
        //        DateTime date = currentWeekStartDate.AddDays(i);

        //        Panel dayPanel = new Panel
        //        {
        //            BorderStyle = BorderStyle.FixedSingle,
        //            Margin = new Padding(1),
        //            BackColor = Color.White,
        //            Dock = DockStyle.Fill,
        //            Tag = date,
        //            AllowDrop = true
        //        };

        //        // 날짜 라벨
        //        Label dayLabel = new Label
        //        {
        //            Text = date.ToString("ddd dd"),
        //            Dock = DockStyle.Top,
        //            Height = 20,
        //            TextAlign = ContentAlignment.MiddleCenter,
        //            Font = new Font("맑은 고딕", 10, FontStyle.Bold)
        //        };
        //        dayPanel.Controls.Add(dayLabel);

        //        // 할 일 리스트 영역
        //        FlowLayoutPanel toDoListPanel = new FlowLayoutPanel
        //        {
        //            Dock = DockStyle.Fill,
        //            AutoScroll = true,
        //            WrapContents = false,
        //            FlowDirection = FlowDirection.TopDown,
        //            Tag = "ToDoListPanel"
        //        };
        //        dayPanel.Controls.Add(toDoListPanel);

        //        weekTable.Controls.Add(dayPanel, i, 0);
        //    }

        //    panelWeekView.Controls.Add(weekTable);

        //}

       
        

        //private void InitializeDayView(DateTime date)
        //{
        //    panelDayView.Controls.Clear();

        //    Panel dayPanel = new Panel
        //    {
        //        Dock = DockStyle.Fill,
        //        BorderStyle = BorderStyle.FixedSingle,
        //        BackColor = Color.White,
        //        AllowDrop = true,
        //        Tag = date
        //    };

        //    Label dayLabel = new Label
        //    {
        //        Text = date.ToString("yyyy-MM-dd (dddd)"),
        //        Dock = DockStyle.Top,
        //        Height = 30,
        //        TextAlign = ContentAlignment.MiddleCenter,
        //        Font = new Font("맑은 고딕", 14, FontStyle.Bold)
        //    };
        //    dayPanel.Controls.Add(dayLabel);

        //    FlowLayoutPanel toDoListPanel = new FlowLayoutPanel
        //    {
        //        Dock = DockStyle.Fill,
        //        AutoScroll = true,
        //        WrapContents = false,
        //        FlowDirection = FlowDirection.TopDown,
        //        Tag = "ToDoListPanel"
        //    };
        //    dayPanel.Controls.Add(toDoListPanel);

           

        //    panelDayView.Controls.Add(dayPanel);

        //}

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            AddScheduleForm_new_ addScheduleForm = new AddScheduleForm_new_(loggedInUser.Id,scheduleManager,tagManager,this);
            addScheduleForm.ShowDialog();
        }



        private DateTime currentDate = DateTime.Today;

        //달력 넘김
        //private void UpdateMonthLabel()
        //{
        //    lblCurrentMonth.Text = currentDate.ToString("yyyy년 M월");
        //}

        //private void btnPrevMonth_Click(object sender, EventArgs e)
        //{
        //    currentDate = currentDate.AddMonths(-1);
        //    UpdateMonthLabel();
        //    //GenerateCalendar(currentDate);

        //}

        //private void btnNextMonth_Click(object sender, EventArgs e)
        //{
        //    currentDate = currentDate.AddMonths(1);
        //    UpdateMonthLabel();
        //    //GenerateCalendar(currentDate);

        //}



        //private void btnAddTodo_Click(object sender, EventArgs e)
        //{

        //    //List<Tag> availableTags = tagManager.GetAllTags(); // TagManager에서 태그 리스트 가져오기
        //    AddToDoForm addToDoForm = new AddToDoForm(loggedInUser.Id, toDoManager); //availableTags);
        //    addToDoForm.FormClosed += (s, args) => LoadToDoList(); // 폼 닫히면 자동 갱신
        //    addToDoForm.ShowDialog();
        //}



        //private void AddToDoForm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    RefreshToDoListView();
        //}

        //private void RefreshToDoListView()
        //{
        //    var todos = toDoManager.GetAllToDos();

        //    ToDoListView.Items.Clear();
        //    foreach (var todo in todos)
        //    {
        //        var item = new ListViewItem(todo.Content);
        //        item.SubItems.Add(todo.DueDate?.ToString("yyyy-MM-dd HH:mm") ?? "없음");
        //        item.SubItems.Add(todo.Priority.ToString());
        //        item.SubItems.Add(todo.IsDone ? "완료" : "미완료");
        //        item.Tag = todo;
        //        ToDoListView.Items.Add(item);
        //    }
        //}



        //private void LoadToDoList()
        //{


        //    // 정렬된 목록 가져오기
        //    List<ToDo> sortedList = toDoManager.GetToDoList();

        //    // 기존 UI 목록 비우기
        //    ToDoListView.Items.Clear();



        //    // 정렬된 항목 다시 추가
        //    foreach (ToDo todo in sortedList)
        //    {
        //        ListViewItem item = new ListViewItem(todo.Content);
        //        if (todo.DueDate.HasValue)
        //            item.SubItems.Add(todo.DueDate.Value.ToString("yyyy-MM-dd HH:mm"));
        //        else
        //            item.SubItems.Add("미정");
        //        item.SubItems.Add(GetPriorityText(todo.Priority)); // 예: "높음", "중간", "낮음"

        //        item.Tag = todo;
        //        item.Checked = todo.IsDone;  // 이미 완료된 항목은 체크되어있게(필요시)

        //        ToDoListView.Items.Add(item);

        //    }
        //}

        private void LoadToDoList()
        {
            // 1. 기존 UI 목록 비우기 (메모리 누수 방지를 위해 Dispose 호출)
            while (flpTodoList.Controls.Count > 0)
            {
                flpTodoList.Controls[0].Dispose();
            }
            // flpTodoList.Controls.Clear(); // 간단하게 이렇게만 해도 되지만, 위 방식이 더 안전합니다.

            // 2. toDoManager로부터 정렬된 목록 가져오기 (이 부분은 기존과 동일)
            List<ToDo> sortedList = toDoManager.GetToDoList();

            // 3. 목록을 순회하며 TodoItemControl을 생성하고 패널에 추가
            foreach (ToDo todo in sortedList)
            {
                // ToDo 데이터 하나당 TodoItemControl 하나를 생성
                TodoItemControl item = new TodoItemControl();

                // 컨트롤에 데이터 채우기
                item.TodoText = todo.Content; // 할 일 내용 설정
                item.IsCompleted = todo.IsDone; // 완료 여부(체크 상태) 설정
                item.Tag = todo; // ★★★ 컨트롤에 ToDo 객체 전체를 저장 (기존과 동일한 방식)

                // 컨트롤 너비를 패널에 맞춤
                item.Width = flpTodoList.ClientSize.Width - 5; // 여백을 약간 줍니다.

                // 이벤트 핸들러 연결
                //item.CompletionToggled += TodoItem_CompletionToggled; // 체크박스 상태 변경 이벤트 연결
                item.DeleteRequested += TodoItem_DeleteRequested;   // 삭제 버튼 이벤트 연결Add commentMore actions

                // 수정 이벤트 핸들러 연결
                item.EditRequested += (s, e) =>
                {
                    EditToDoForm editForm = new EditToDoForm(todo, toDoManager); // ToDo 객체 전달
                    var result = editForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        // 수정 완료 시 UI 갱신
                        item.TodoText = todo.Content;
                        item.IsCompleted = todo.IsDone;
                    }
                    else if (result == DialogResult.Abort)
                    {
                        // 삭제 완료 시 컨트롤 제거
                        flpTodoList.Controls.Remove(item);
                        item.Dispose();
                    }
                   
                };

                // FlowLayoutPanel에 최종적으로 추가
                flpTodoList.Controls.Add(item);
            }
        }




        // 우선순위 숫자를 텍스트로 변환
        private string GetPriorityText(int priority)
        {
            return priority switch
            {
                1 => "매우 높음",
                2 => "높음",
                3 => "보통",
                4 => "낮음",
                5 => "매우 낮음",
                _ => "알 수 없음"
            };
        }

        //private void ToDoListView_ItemActivate(object sender, EventArgs e)
        //{
        //    if (ToDoListView.SelectedItems.Count > 0)
        //    {
        //        var selectedItem = ToDoListView.SelectedItems[0];
        //        var todo = selectedItem.Tag as ToDo;

        //        if (todo != null)
        //        {
        //            using (var editForm = new EditToDoForm(todo, toDoManager))
        //            {
        //                var result = editForm.ShowDialog();

        //                if (result == DialogResult.OK || result == DialogResult.Abort)
        //                {
        //                    LoadToDoList(); // 목록 새로고침
        //                }
        //            }
        //        }
        //    }
        //}

        //private void btnConfirm_Click(object sender, EventArgs e)
        //{
        //    // 체크된 항목 가져오기
        //    var checkedItems = ToDoListView.CheckedItems;

        //    foreach (ListViewItem item in checkedItems)
        //    {
        //        var todo = item.Tag as ToDo;
        //        if (todo != null && !todo.IsDone)
        //        {
        //            // 완료 처리 (메모리, DB 동기화)
        //            toDoManager.ToggleDone(todo.Id); // IsDone true로 변경 및 DB 업데이트
        //        }
        //    }

        //    // 완료된 항목은 UI에서 제거하기 위해 다시 로드
        //    LoadToDoList();
        //}

        //private void TodoItem_CompletionToggled(object sender, EventArgs e)
        //{
        //    // 이벤트를 발생시킨 컨트롤(TodoItemControl)을 가져옵니다.
        //    var item = sender as TodoItemControl;
        //    if (item == null) return;

        //    // Tag에 저장해둔 ToDo 객체를 가져옵니다.
        //    var todo = item.Tag as ToDo;
        //    if (todo == null) return;

        //    // toDoManager를 통해 데이터의 완료 상태를 업데이트합니다. (기존 로직 재활용)
        //    toDoManager.ToggleDone(todo.Id);

        //    // [선택사항] 
        //    // 만약 완료된 항목을 즉시 목록에서 숨기고 싶다면, 여기서 LoadToDoList()를 다시 호출하세요.
        //    // 예: toDoManager.GetToDoList()가 완료된 항목은 제외하고 반환하는 경우
        //    LoadToDoList(); 

        //    // 만약 그냥 화면에 남겨두고 싶다면, 아무것도 하지 않아도 됩니다.
        //    // TodoItemControl 내부에서 취소선 효과는 이미 처리되었습니다.
        //}

        private void btnAddTodo_Click(object sender, EventArgs e)
        {
            // 입력창이 비어있으면 아무것도 하지 않음
            if (string.IsNullOrWhiteSpace(txtNewTodo.Text))
            {
                MessageBox.Show("할 일을 입력해주세요.");
                return;
            }

            // 1. 새로운 ToDo 객체 생성
            ToDo newTodo = new ToDo
            {
                UserId = this.loggedInUser.Id, // 현재 로그인한 사용자의 ID 사용
                Content = txtNewTodo.Text,
                IsDone = false,
                // 필요하다면 DueDate, Priority 등 다른 속성도 설정
            };

            // 2. ToDoManager를 통해 DB와 메모리에 할 일 추가
            toDoManager.AddToDo(newTodo);

            // 3. 전체 목록을 다시 불러와 UI를 새로고침
            LoadToDoList();

            // 4. 입력창 비우기
            txtNewTodo.Clear();
        }

        // TodoItemControl에서 삭제 요청이 오면 실행될 메서드
        private void TodoItem_DeleteRequested(object sender, EventArgs e)
        {
            // 이벤트를 발생시킨 컨트롤(sender)을 가져옵니다.
            var itemToDelete = sender as TodoItemControl;
            if (itemToDelete == null) return;

            // Tag에 저장된 ToDo 객체를 가져옵니다.
            var todo = itemToDelete.Tag as ToDo;
            if (todo == null) return;

            // 1. ToDoManager를 통해 DB와 메모리에서 데이터 삭제
            toDoManager.RemoveToDo(todo.Id);

            // 2. UI에서도 해당 컨트롤을 제거
            flpTodoList.Controls.Remove(itemToDelete);
            itemToDelete.Dispose();
        }

        private void Planner_Load(object sender, EventArgs e)
        {
            // 1. ToDoManager를 통해 DB에서 현재 사용자의 할 일 목록을 불러옵니다.
            toDoManager.LoadToDosFromDb(loggedInUser.Id);

            // 2. 불러온 데이터를 화면에 표시합니다.
            LoadToDoList();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // flpTodoList에 있는 모든 컨트롤을 순회합니다.
            // .OfType<TodoItemControl>()을 사용하면 TodoItemControl만 골라낼 수 있습니다.
            // .ToList()를 붙이는 이유는 순회 중에 컬렉션이 변경되는 것을 방지하기 위함입니다.
            foreach (var itemControl in flpTodoList.Controls.OfType<TodoItemControl>().ToList())
            {
                // 컨트롤이 체크되어 있는지 확인합니다.
                if (itemControl.IsCompleted)
                {
                    // Tag에 저장된 ToDo 객체를 가져옵니다.
                    var todo = itemControl.Tag as ToDo;
                    if (todo != null && !todo.IsDone) // DB에 이미 완료 처리된 건 아닌지 한번 더 확인
                    {
                        // ToDoManager를 통해 DB와 메모리의 완료 상태를 업데이트합니다.
                        toDoManager.ToggleDone(todo.Id);
                    }
                }
            }

            // 모든 작업이 끝난 후, UI를 새로고침하여 완료된 항목을 숨깁니다.
            // (ToDoManager의 GetToDoList()가 완료된 항목은 제외하고 반환한다고 가정)
            LoadToDoList();

            //MessageBox.Show("선택한 항목들이 완료 처리되었습니다.");
        }

        
    }
}


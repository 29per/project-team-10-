using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlanEase.Views.panelDesktop
{
    partial class Planner
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel calendarTableLayoutPanel;



        private void DateCell_Click(object sender, EventArgs e)
        {
            Panel cell = sender as Panel;
            if (cell?.Tag is DateTime date)
            {
                MessageBox.Show($"[{date:yyyy-MM-dd}] 클릭됨");
            }
        }

        private void CellPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void CellPanel_DragDrop(object sender, DragEventArgs e)
        {
            Panel cell = sender as Panel;
            if (cell?.Tag is DateTime date)
            {
                string todo = e.Data.GetData(typeof(string)) as string;
                MessageBox.Show($"'{todo}' 항목이 {date:yyyy-MM-dd}로 이동됨");
            }
        }

        private void CellPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Panel cell = sender as Panel;
                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("일정 수정", null, (s, args) => MessageBox.Show("수정"));
                menu.Items.Add("일정 삭제", null, (s, args) => MessageBox.Show("삭제"));
                menu.Show(cell, e.Location);
            }
        }

        #region Windows Form 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.ToDoListView = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTodoTitle = new System.Windows.Forms.Label();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.btnSearchTag = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.calendarTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrevMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.lblMonthDisplay = new FontAwesome.Sharp.IconButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.ToDoListView);
            this.panelLeft.Location = new System.Drawing.Point(10, 210);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(507, 972);
            this.panelLeft.TabIndex = 0;
            // 
            // ToDoListView
            // 
            this.ToDoListView.CheckBoxes = true;
            this.ToDoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.DueDate});
            this.ToDoListView.FullRowSelect = true;
            this.ToDoListView.GridLines = true;
            this.ToDoListView.HideSelection = false;
            this.ToDoListView.Location = new System.Drawing.Point(1, -1);
            this.ToDoListView.Margin = new System.Windows.Forms.Padding(4);
            this.ToDoListView.Name = "ToDoListView";
            this.ToDoListView.Size = new System.Drawing.Size(500, 967);
            this.ToDoListView.TabIndex = 0;
            this.ToDoListView.UseCompatibleStateImageBehavior = false;
            this.ToDoListView.View = System.Windows.Forms.View.Details;
            this.ToDoListView.ItemActivate += new System.EventHandler(this.ToDoListView_ItemActivate);
            // 
            // Title
            // 
            this.Title.Text = "할 일";
            this.Title.Width = 250;
            // 
            // DueDate
            // 
            this.DueDate.Text = "마감 기한";
            this.DueDate.Width = 250;
            // 
            // lblTodoTitle
            // 
            this.lblTodoTitle.AutoSize = true;
            this.lblTodoTitle.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.lblTodoTitle.Location = new System.Drawing.Point(26, 112);
            this.lblTodoTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodoTitle.Name = "lblTodoTitle";
            this.lblTodoTitle.Size = new System.Drawing.Size(176, 45);
            this.lblTodoTitle.TabIndex = 0;
            this.lblTodoTitle.Text = "할 일 목록";
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(12, 1190);
            this.btnAddSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(145, 35);
            this.btnAddSchedule.TabIndex = 3;
            this.btnAddSchedule.Text = "일정 추가";
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.Location = new System.Drawing.Point(195, 1190);
            this.btnAddTodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(138, 35);
            this.btnAddTodo.TabIndex = 2;
            this.btnAddTodo.Text = "할 일 추가";
            this.btnAddTodo.Click += new System.EventHandler(this.btnAddTodo_Click);
            // 
            // btnSearchTag
            // 
            this.btnSearchTag.Location = new System.Drawing.Point(373, 1190);
            this.btnSearchTag.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchTag.Name = "btnSearchTag";
            this.btnSearchTag.Size = new System.Drawing.Size(139, 35);
            this.btnSearchTag.TabIndex = 1;
            this.btnSearchTag.Text = "태그 검색";
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.AutoScroll = true;
            this.panelRight.Location = new System.Drawing.Point(525, 210);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1382, 1015);
            this.panelRight.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("굴림", 25F);
            this.lblTitle.Location = new System.Drawing.Point(23, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(323, 59);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "PLANEASE";
            // 
            // calendarTableLayoutPanel
            // 
            this.calendarTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.calendarTableLayoutPanel.ColumnCount = 7;
            this.calendarTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.calendarTableLayoutPanel.Name = "calendarTableLayoutPanel";
            this.calendarTableLayoutPanel.RowCount = 6;
            this.calendarTableLayoutPanel.Size = new System.Drawing.Size(200, 100);
            this.calendarTableLayoutPanel.TabIndex = 0;
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPrevMonth.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPrevMonth.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPrevMonth.Location = new System.Drawing.Point(737, 96);
            this.btnPrevMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Size = new System.Drawing.Size(88, 44);
            this.btnPrevMonth.TabIndex = 0;
            this.btnPrevMonth.Text = "<";
            this.btnPrevMonth.UseVisualStyleBackColor = false;
            this.btnPrevMonth.Click += new System.EventHandler(this.BtnPrevMonth_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNextMonth.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNextMonth.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnNextMonth.Location = new System.Drawing.Point(1582, 96);
            this.btnNextMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(88, 44);
            this.btnNextMonth.TabIndex = 11;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = false;
            this.btnNextMonth.Click += new System.EventHandler(this.BtnNextMonth_Click);
            // 
            // lblMonthDisplay
            // 
            this.lblMonthDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMonthDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthDisplay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lblMonthDisplay.FlatAppearance.BorderSize = 0;
            this.lblMonthDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lblMonthDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lblMonthDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMonthDisplay.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthDisplay.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblMonthDisplay.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.lblMonthDisplay.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.lblMonthDisplay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lblMonthDisplay.IconSize = 40;
            this.lblMonthDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMonthDisplay.Location = new System.Drawing.Point(989, 49);
            this.lblMonthDisplay.Margin = new System.Windows.Forms.Padding(5);
            this.lblMonthDisplay.Name = "lblMonthDisplay";
            this.lblMonthDisplay.Padding = new System.Windows.Forms.Padding(18, 0, 35, 0);
            this.lblMonthDisplay.Size = new System.Drawing.Size(446, 140);
            this.lblMonthDisplay.TabIndex = 26;
            this.lblMonthDisplay.Text = "Calendar";
            this.lblMonthDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMonthDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lblMonthDisplay.UseVisualStyleBackColor = false;
            this.lblMonthDisplay.Click += new System.EventHandler(this.LblMonthDisplay_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 160);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(143, 43);
            this.btnConfirm.TabIndex = 27;
            this.btnConfirm.Text = "할 일 완료";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Planner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblMonthDisplay);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.lblTodoTitle);
            this.Controls.Add(this.btnPrevMonth);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.btnSearchTag);
            this.Controls.Add(this.btnAddTodo);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Planner";
            this.Size = new System.Drawing.Size(1925, 1260);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // 생성자 또는 Load 이벤트에서 호출
        //private void InitializeCalendarTable()
        //{
        //    // 컬럼 세팅
        //    this.calendarTable.ColumnCount = 7;
        //    this.calendarTable.ColumnStyles.Clear();
        //    for (int i = 0; i < 7; i++)
        //    {
        //        this.calendarTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28F));
        //    }

        //    // 행 세팅
        //    this.calendarTable.RowCount = 6;
        //    this.calendarTable.RowStyles.Clear();
        //    for (int i = 0; i < 6; i++)
        //    {
        //        this.calendarTable.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        //    }

        //    this.calendarTable.Dock = DockStyle.Fill;
        //    this.calendarTable.Margin = new Padding(0);
        //}


        #endregion

        // 좌측: 할 일 영역
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblTodoTitle;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Button btnAddTodo;
        private System.Windows.Forms.Button btnSearchTag;

        // 우측: 일정 영역 (3가지 보기)
        private System.Windows.Forms.Panel panelRight;

        // 상단: 제목, 버튼
        private System.Windows.Forms.Label lblTitle;
        private Button btnPrevMonth;
        private ListView ToDoListView;
        private ColumnHeader Title;
        private ColumnHeader DueDate;
        private Button btnNextMonth;
        private FontAwesome.Sharp.IconButton lblMonthDisplay;
        private Button btnConfirm;
    }
}




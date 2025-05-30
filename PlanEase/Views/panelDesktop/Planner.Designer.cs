﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlanEase.Views.panelDesktop
{
    partial class Planner
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel calendarTable;
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
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTodoTitle = new System.Windows.Forms.Label();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.btnSearchTag = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelDayView = new System.Windows.Forms.Panel();
            this.panelWeekView = new System.Windows.Forms.Panel();
            this.panelMonthView = new System.Windows.Forms.Panel();
            this.calendarTable = new System.Windows.Forms.TableLayoutPanel();
            this.calendarMonth = new System.Windows.Forms.MonthCalendar();
            this.btnDayView = new System.Windows.Forms.Button();
            this.btnWeekView = new System.Windows.Forms.Button();
            this.btnMonthView = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.calendarTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrevMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.lblCurrentMonth = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelMonthView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.ToDoListView);
            this.panelLeft.Location = new System.Drawing.Point(7, 100);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(266, 300);
            this.panelLeft.TabIndex = 0;
            // 
            // ToDoListView
            // 
            this.ToDoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.DueDate,
            this.Priority});
            this.ToDoListView.FullRowSelect = true;
            this.ToDoListView.GridLines = true;
            this.ToDoListView.HideSelection = false;
            this.ToDoListView.Location = new System.Drawing.Point(2, 2);
            this.ToDoListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToDoListView.Name = "ToDoListView";
            this.ToDoListView.Size = new System.Drawing.Size(262, 296);
            this.ToDoListView.TabIndex = 0;
            this.ToDoListView.UseCompatibleStateImageBehavior = false;
            this.ToDoListView.View = System.Windows.Forms.View.Details;
            // 
            // Title
            // 
            this.Title.Text = "할 일";
            this.Title.Width = 300;
            // 
            // DueDate
            // 
            this.DueDate.Text = "마감일";
            this.DueDate.Width = 100;
            // 
            // Priority
            // 
            this.Priority.Text = "우선순위";
            this.Priority.Width = 80;
            // 
            // lblTodoTitle
            // 
            this.lblTodoTitle.AutoSize = true;
            this.lblTodoTitle.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.lblTodoTitle.Location = new System.Drawing.Point(15, 64);
            this.lblTodoTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTodoTitle.Name = "lblTodoTitle";
            this.lblTodoTitle.Size = new System.Drawing.Size(102, 25);
            this.lblTodoTitle.TabIndex = 0;
            this.lblTodoTitle.Text = "할 일 목록";
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(6, 426);
            this.btnAddSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(70, 20);
            this.btnAddSchedule.TabIndex = 3;
            this.btnAddSchedule.Text = "일정 추가";
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.Location = new System.Drawing.Point(93, 426);
            this.btnAddTodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(70, 20);
            this.btnAddTodo.TabIndex = 2;
            this.btnAddTodo.Text = "할 일 추가";
            this.btnAddTodo.Click += new System.EventHandler(this.btnAddTodo_Click);
            // 
            // btnSearchTag
            // 
            this.btnSearchTag.Location = new System.Drawing.Point(183, 426);
            this.btnSearchTag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchTag.Name = "btnSearchTag";
            this.btnSearchTag.Size = new System.Drawing.Size(70, 20);
            this.btnSearchTag.TabIndex = 1;
            this.btnSearchTag.Text = "태그 검색";
            // 
            // panelRight
            // 
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.panelDayView);
            this.panelRight.Controls.Add(this.panelWeekView);
            this.panelRight.Controls.Add(this.panelMonthView);
            this.panelRight.Location = new System.Drawing.Point(284, 64);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(553, 393);
            this.panelRight.TabIndex = 1;
            // 
            // panelDayView
            // 
            this.panelDayView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDayView.Location = new System.Drawing.Point(0, 0);
            this.panelDayView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDayView.Name = "panelDayView";
            this.panelDayView.Size = new System.Drawing.Size(551, 391);
            this.panelDayView.TabIndex = 0;
            this.panelDayView.Visible = false;
            // 
            // panelWeekView
            // 
            this.panelWeekView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWeekView.Location = new System.Drawing.Point(0, 0);
            this.panelWeekView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelWeekView.Name = "panelWeekView";
            this.panelWeekView.Size = new System.Drawing.Size(551, 391);
            this.panelWeekView.TabIndex = 1;
            this.panelWeekView.Visible = false;
            // 
            // panelMonthView
            // 
            this.panelMonthView.Controls.Add(this.calendarTable);
            this.panelMonthView.Controls.Add(this.calendarMonth);
            this.panelMonthView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMonthView.Location = new System.Drawing.Point(0, 0);
            this.panelMonthView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMonthView.Name = "panelMonthView";
            this.panelMonthView.Size = new System.Drawing.Size(551, 391);
            this.panelMonthView.TabIndex = 2;
            // 
            // calendarTable
            // 
            this.calendarTable.ColumnCount = 7;
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.calendarTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 486F));
            this.calendarTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarTable.Location = new System.Drawing.Point(0, 0);
            this.calendarTable.Margin = new System.Windows.Forms.Padding(0);
            this.calendarTable.Name = "calendarTable";
            this.calendarTable.RowCount = 6;
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.calendarTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.calendarTable.Size = new System.Drawing.Size(551, 391);
            this.calendarTable.TabIndex = 0;
            // 
            // calendarMonth
            // 
            this.calendarMonth.Location = new System.Drawing.Point(0, 0);
            this.calendarMonth.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.calendarMonth.Name = "calendarMonth";
            this.calendarMonth.TabIndex = 1;
            // 
            // btnDayView
            // 
            this.btnDayView.Location = new System.Drawing.Point(693, 30);
            this.btnDayView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDayView.Name = "btnDayView";
            this.btnDayView.Size = new System.Drawing.Size(32, 20);
            this.btnDayView.TabIndex = 5;
            this.btnDayView.Text = "일";
            this.btnDayView.Click += new System.EventHandler(this.btnDayView_Click);
            // 
            // btnWeekView
            // 
            this.btnWeekView.Location = new System.Drawing.Point(731, 30);
            this.btnWeekView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWeekView.Name = "btnWeekView";
            this.btnWeekView.Size = new System.Drawing.Size(32, 20);
            this.btnWeekView.TabIndex = 6;
            this.btnWeekView.Text = "주";
            this.btnWeekView.Click += new System.EventHandler(this.btnWeekView_Click);
            // 
            // btnMonthView
            // 
            this.btnMonthView.Location = new System.Drawing.Point(768, 30);
            this.btnMonthView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMonthView.Name = "btnMonthView";
            this.btnMonthView.Size = new System.Drawing.Size(32, 20);
            this.btnMonthView.TabIndex = 7;
            this.btnMonthView.Text = "월";
            this.btnMonthView.Click += new System.EventHandler(this.btnMonthView_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(806, 30);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(22, 20);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "⚙";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("굴림", 25F);
            this.lblTitle.Location = new System.Drawing.Point(13, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 34);
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
            this.btnPrevMonth.Location = new System.Drawing.Point(363, 38);
            this.btnPrevMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Size = new System.Drawing.Size(40, 20);
            this.btnPrevMonth.TabIndex = 0;
            this.btnPrevMonth.Text = "<";
            this.btnPrevMonth.UseVisualStyleBackColor = true;
            this.btnPrevMonth.Click += new System.EventHandler(this.btnPrevMonth_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(564, 38);
            this.btnNextMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(40, 20);
            this.btnNextMonth.TabIndex = 9;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // lblCurrentMonth
            // 
            this.lblCurrentMonth.AutoSize = true;
            this.lblCurrentMonth.Location = new System.Drawing.Point(469, 42);
            this.lblCurrentMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentMonth.Name = "lblCurrentMonth";
            this.lblCurrentMonth.Size = new System.Drawing.Size(17, 12);
            this.lblCurrentMonth.TabIndex = 10;
            this.lblCurrentMonth.Text = "월";
            // 
            // Planner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.lblTodoTitle);
            this.Controls.Add(this.lblCurrentMonth);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.btnPrevMonth);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.btnSearchTag);
            this.Controls.Add(this.btnAddTodo);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDayView);
            this.Controls.Add(this.btnWeekView);
            this.Controls.Add(this.btnMonthView);
            this.Controls.Add(this.btnSettings);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Planner";
            this.Size = new System.Drawing.Size(844, 530);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelMonthView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // 생성자 또는 Load 이벤트에서 호출
        private void InitializeCalendarTable()
        {
            // 컬럼 세팅
            this.calendarTable.ColumnCount = 7;
            this.calendarTable.ColumnStyles.Clear();
            for (int i = 0; i < 7; i++)
            {
                this.calendarTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28F));
            }

            // 행 세팅
            this.calendarTable.RowCount = 6;
            this.calendarTable.RowStyles.Clear();
            for (int i = 0; i < 6; i++)
            {
                this.calendarTable.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
            }

            this.calendarTable.Dock = DockStyle.Fill;
            this.calendarTable.Margin = new Padding(0);
        }


        #endregion

        // 좌측: 할 일 영역
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblTodoTitle;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Button btnAddTodo;
        private System.Windows.Forms.Button btnSearchTag;

        // 우측: 일정 영역 (3가지 보기)
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelDayView;
        private System.Windows.Forms.Panel panelWeekView;
        private System.Windows.Forms.Panel panelMonthView;
        private System.Windows.Forms.MonthCalendar calendarMonth;

        // 상단: 제목, 버튼
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDayView;
        private System.Windows.Forms.Button btnWeekView;
        private System.Windows.Forms.Button btnMonthView;
        private System.Windows.Forms.Button btnSettings;
        private Button btnPrevMonth;
        private Button btnNextMonth;
        private Label lblCurrentMonth;
        private ListView ToDoListView;
        private ColumnHeader Title;
        private ColumnHeader DueDate;
        private ColumnHeader Priority;
    }
}




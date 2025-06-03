using System;

namespace PlanEase
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblTodoTitle = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.btnAddTodo = new System.Windows.Forms.Button();
            this.btnSearchTag = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelDayView = new System.Windows.Forms.Panel();
            this.panelWeekView = new System.Windows.Forms.Panel();
            this.panelMonthView = new System.Windows.Forms.Panel();
            this.calendarMonth = new System.Windows.Forms.MonthCalendar();
            this.btnDayView = new System.Windows.Forms.Button();
            this.btnWeekView = new System.Windows.Forms.Button();
            this.btnMonthView = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelMonthView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.lblTodoTitle);
            this.panelLeft.Controls.Add(this.progressBar);
            this.panelLeft.Location = new System.Drawing.Point(7, 64);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(266, 335);
            this.panelLeft.TabIndex = 0;
            // 
            // lblTodoTitle
            // 
            this.lblTodoTitle.AutoSize = true;
            this.lblTodoTitle.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.lblTodoTitle.Location = new System.Drawing.Point(8, 3);
            this.lblTodoTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTodoTitle.Name = "lblTodoTitle";
            this.lblTodoTitle.Size = new System.Drawing.Size(102, 25);
            this.lblTodoTitle.TabIndex = 0;
            this.lblTodoTitle.Text = "할 일 목록";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 30);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(260, 22);
            this.progressBar.TabIndex = 0;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(6, 426);
            this.btnAddSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(70, 20);
            this.btnAddSchedule.TabIndex = 3;
            this.btnAddSchedule.Text = "일정 추가";
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.Location = new System.Drawing.Point(93, 426);
            this.btnAddTodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(70, 20);
            this.btnAddTodo.TabIndex = 2;
            this.btnAddTodo.Text = "할 일 추가";
            // 
            // btnSearchTag
            // 
            this.btnSearchTag.Location = new System.Drawing.Point(183, 426);
            this.btnSearchTag.Margin = new System.Windows.Forms.Padding(2);
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
            this.panelRight.Margin = new System.Windows.Forms.Padding(2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(553, 393);
            this.panelRight.TabIndex = 1;
            // 
            // panelDayView
            // 
            this.panelDayView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDayView.Location = new System.Drawing.Point(0, 0);
            this.panelDayView.Margin = new System.Windows.Forms.Padding(2);
            this.panelDayView.Name = "panelDayView";
            this.panelDayView.Size = new System.Drawing.Size(551, 391);
            this.panelDayView.TabIndex = 0;
            this.panelDayView.Visible = false;
            // 
            // panelWeekView
            // 
            this.panelWeekView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWeekView.Location = new System.Drawing.Point(0, 0);
            this.panelWeekView.Margin = new System.Windows.Forms.Padding(2);
            this.panelWeekView.Name = "panelWeekView";
            this.panelWeekView.Size = new System.Drawing.Size(551, 391);
            this.panelWeekView.TabIndex = 1;
            this.panelWeekView.Visible = false;
            // 
            // panelMonthView
            // 
            this.panelMonthView.Controls.Add(this.calendarMonth);
            this.panelMonthView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMonthView.Location = new System.Drawing.Point(0, 0);
            this.panelMonthView.Margin = new System.Windows.Forms.Padding(2);
            this.panelMonthView.Name = "panelMonthView";
            this.panelMonthView.Size = new System.Drawing.Size(551, 391);
            this.panelMonthView.TabIndex = 2;
            // 
            // calendarMonth
            // 
            this.calendarMonth.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.calendarMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarMonth.Location = new System.Drawing.Point(0, 0);
            this.calendarMonth.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.calendarMonth.Name = "calendarMonth";
            this.calendarMonth.TabIndex = 0;
            // 
            // btnDayView
            // 
            this.btnDayView.Location = new System.Drawing.Point(693, 30);
            this.btnDayView.Margin = new System.Windows.Forms.Padding(2);
            this.btnDayView.Name = "btnDayView";
            this.btnDayView.Size = new System.Drawing.Size(32, 20);
            this.btnDayView.TabIndex = 5;
            this.btnDayView.Text = "일";
            this.btnDayView.Click += new System.EventHandler(this.btnDayView_Click);
            // 
            // btnWeekView
            // 
            this.btnWeekView.Location = new System.Drawing.Point(731, 30);
            this.btnWeekView.Margin = new System.Windows.Forms.Padding(2);
            this.btnWeekView.Name = "btnWeekView";
            this.btnWeekView.Size = new System.Drawing.Size(32, 20);
            this.btnWeekView.TabIndex = 6;
            this.btnWeekView.Text = "주";
            this.btnWeekView.Click += new System.EventHandler(this.btnWeekView_Click);
            // 
            // btnMonthView
            // 
            this.btnMonthView.Location = new System.Drawing.Point(768, 30);
            this.btnMonthView.Margin = new System.Windows.Forms.Padding(2);
            this.btnMonthView.Name = "btnMonthView";
            this.btnMonthView.Size = new System.Drawing.Size(32, 20);
            this.btnMonthView.TabIndex = 7;
            this.btnMonthView.Text = "월";
            this.btnMonthView.Click += new System.EventHandler(this.btnMonthView_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(806, 30);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 466);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "PlanEase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelMonthView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 좌측: 할 일 영역
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblTodoTitle;
        private System.Windows.Forms.ProgressBar progressBar;
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
    }
}




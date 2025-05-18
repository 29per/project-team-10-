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
            this.panelLeft.Location = new System.Drawing.Point(13, 128);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(492, 668);
            this.panelLeft.TabIndex = 0;
            // 
            // lblTodoTitle
            // 
            this.lblTodoTitle.AutoSize = true;
            this.lblTodoTitle.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.lblTodoTitle.Location = new System.Drawing.Point(14, 6);
            this.lblTodoTitle.Name = "lblTodoTitle";
            this.lblTodoTitle.Size = new System.Drawing.Size(200, 51);
            this.lblTodoTitle.TabIndex = 0;
            this.lblTodoTitle.Text = "할 일 목록";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(5, 60);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(482, 44);
            this.progressBar.TabIndex = 0;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.Location = new System.Drawing.Point(12, 853);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(130, 40);
            this.btnAddSchedule.TabIndex = 3;
            this.btnAddSchedule.Text = "일정 추가";
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.Location = new System.Drawing.Point(172, 853);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.Size = new System.Drawing.Size(130, 40);
            this.btnAddTodo.TabIndex = 2;
            this.btnAddTodo.Text = "할 일 추가";
            // 
            // btnSearchTag
            // 
            this.btnSearchTag.Location = new System.Drawing.Point(339, 853);
            this.btnSearchTag.Name = "btnSearchTag";
            this.btnSearchTag.Size = new System.Drawing.Size(130, 40);
            this.btnSearchTag.TabIndex = 1;
            this.btnSearchTag.Text = "태그 검색";
            // 
            // panelRight
            // 
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.panelDayView);
            this.panelRight.Controls.Add(this.panelWeekView);
            this.panelRight.Controls.Add(this.panelMonthView);
            this.panelRight.Location = new System.Drawing.Point(527, 128);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1025, 784);
            this.panelRight.TabIndex = 1;
            // 
            // panelDayView
            // 
            this.panelDayView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDayView.Location = new System.Drawing.Point(0, 0);
            this.panelDayView.Name = "panelDayView";
            this.panelDayView.Size = new System.Drawing.Size(1023, 782);
            this.panelDayView.TabIndex = 0;
            this.panelDayView.Visible = false;
            // 
            // panelWeekView
            // 
            this.panelWeekView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWeekView.Location = new System.Drawing.Point(0, 0);
            this.panelWeekView.Name = "panelWeekView";
            this.panelWeekView.Size = new System.Drawing.Size(1023, 782);
            this.panelWeekView.TabIndex = 1;
            this.panelWeekView.Visible = false;
            // 
            // panelMonthView
            // 
            this.panelMonthView.Controls.Add(this.calendarMonth);
            this.panelMonthView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMonthView.Location = new System.Drawing.Point(0, 0);
            this.panelMonthView.Name = "panelMonthView";
            this.panelMonthView.Size = new System.Drawing.Size(1023, 782);
            this.panelMonthView.TabIndex = 2;
            // 
            // calendarMonth
            // 
            this.calendarMonth.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.calendarMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarMonth.Location = new System.Drawing.Point(0, 0);
            this.calendarMonth.Name = "calendarMonth";
            this.calendarMonth.TabIndex = 0;
            // 
            // btnDayView
            // 
            this.btnDayView.Location = new System.Drawing.Point(1287, 59);
            this.btnDayView.Name = "btnDayView";
            this.btnDayView.Size = new System.Drawing.Size(60, 40);
            this.btnDayView.TabIndex = 5;
            this.btnDayView.Text = "일";
            this.btnDayView.Click += new System.EventHandler(this.btnDayView_Click);
            // 
            // btnWeekView
            // 
            this.btnWeekView.Location = new System.Drawing.Point(1357, 59);
            this.btnWeekView.Name = "btnWeekView";
            this.btnWeekView.Size = new System.Drawing.Size(60, 40);
            this.btnWeekView.TabIndex = 6;
            this.btnWeekView.Text = "주";
            this.btnWeekView.Click += new System.EventHandler(this.btnWeekView_Click);
            // 
            // btnMonthView
            // 
            this.btnMonthView.Location = new System.Drawing.Point(1427, 59);
            this.btnMonthView.Name = "btnMonthView";
            this.btnMonthView.Size = new System.Drawing.Size(60, 40);
            this.btnMonthView.TabIndex = 7;
            this.btnMonthView.Text = "월";
            this.btnMonthView.Click += new System.EventHandler(this.btnMonthView_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(1497, 59);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(40, 40);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "⚙";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("굴림", 25F);
            this.lblTitle.Location = new System.Drawing.Point(25, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(367, 67);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "PLANEASE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 932);
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




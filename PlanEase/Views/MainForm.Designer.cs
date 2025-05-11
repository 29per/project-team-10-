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
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.monthCalendarCurrent = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarNext = new System.Windows.Forms.MonthCalendar();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblTasks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAddTask = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.btnChangePriority = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.monthCalendarCurrent);
            this.pnlLeft.Controls.Add(this.monthCalendarNext);
            this.pnlLeft.Controls.Add(this.lblTodayDate);
            this.pnlLeft.Location = new System.Drawing.Point(12, 12);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(493, 669);
            this.pnlLeft.TabIndex = 0;
            // 
            // monthCalendarCurrent
            // 
            this.monthCalendarCurrent.Location = new System.Drawing.Point(10, 10);
            this.monthCalendarCurrent.Name = "monthCalendarCurrent";
            this.monthCalendarCurrent.ShowToday = false;
            this.monthCalendarCurrent.TabIndex = 0;
            // 
            // monthCalendarNext
            // 
            this.monthCalendarNext.Location = new System.Drawing.Point(10, 325);
            this.monthCalendarNext.Name = "monthCalendarNext";
            this.monthCalendarNext.TabIndex = 1;
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.Location = new System.Drawing.Point(10, 350);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(280, 23);
            this.lblTodayDate.TabIndex = 2;
            this.lblTodayDate.Text = "오늘 날짜: 2025-05-11";
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.label3);
            this.pnlRight.Controls.Add(this.label2);
            this.pnlRight.Controls.Add(this.label1);
            this.pnlRight.Controls.Add(this.tblTasks);
            this.pnlRight.Controls.Add(this.txtAddTask);
            this.pnlRight.Controls.Add(this.btnAddTask);
            this.pnlRight.Controls.Add(this.cboPriority);
            this.pnlRight.Controls.Add(this.btnChangePriority);
            this.pnlRight.Controls.Add(this.btnComplete);
            this.pnlRight.Controls.Add(this.btnDelete);
            this.pnlRight.Controls.Add(this.btnSave);
            this.pnlRight.Controls.Add(this.btnLoad);
            this.pnlRight.Location = new System.Drawing.Point(540, 12);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1025, 785);
            this.pnlRight.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "우선순위：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "할　일：";
            // 
            // tblTasks
            // 
            this.tblTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tblTasks.Location = new System.Drawing.Point(51, 72);
            this.tblTasks.Name = "tblTasks";
            this.tblTasks.RowHeadersWidth = 82;
            this.tblTasks.Size = new System.Drawing.Size(879, 402);
            this.tblTasks.TabIndex = 0;
            this.tblTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblTasks_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "할 일";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "우선순위";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "상태";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "시간";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // txtAddTask
            // 
            this.txtAddTask.Location = new System.Drawing.Point(183, 506);
            this.txtAddTask.Name = "txtAddTask";
            this.txtAddTask.Size = new System.Drawing.Size(400, 35);
            this.txtAddTask.TabIndex = 1;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(613, 511);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(100, 30);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "추가";
            // 
            // cboPriority
            // 
            this.cboPriority.Items.AddRange(new object[] {
            "높음",
            "중간",
            "낮음"});
            this.cboPriority.Location = new System.Drawing.Point(183, 563);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(150, 32);
            this.cboPriority.TabIndex = 3;
            // 
            // btnChangePriority
            // 
            this.btnChangePriority.Location = new System.Drawing.Point(613, 562);
            this.btnChangePriority.Name = "btnChangePriority";
            this.btnChangePriority.Size = new System.Drawing.Size(210, 32);
            this.btnChangePriority.TabIndex = 4;
            this.btnChangePriority.Text = "우선순위 변경";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(854, 660);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(127, 51);
            this.btnComplete.TabIndex = 5;
            this.btnComplete.Text = "완료";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(531, 660);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 51);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "삭제";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(696, 660);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 51);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "저장";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(362, 660);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(127, 51);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "불러오기";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 933);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Name = "MainForm";
            this.Text = "PlanEase";
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // 왼쪽 패널, 달력, 날짜 라벨
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.MonthCalendar monthCalendarCurrent;
        private System.Windows.Forms.MonthCalendar monthCalendarNext;
        private System.Windows.Forms.Label lblTodayDate;

        // 오른쪽 패널, 할 일 테이블 및 추가 기능
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.DataGridView tblTasks;
        private System.Windows.Forms.TextBox txtAddTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.Button btnChangePriority;

        // 완료, 삭제, 저장, 불러오기 버튼들
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}


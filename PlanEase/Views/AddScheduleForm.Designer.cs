namespace PlanEase.Views
{
    partial class AddScheduleForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlMain = new SiticoneNetFrameworkUI.SiticonePanel();
            this.btnCancel = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnConfirm = new SiticoneNetFrameworkUI.SiticoneButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cboTag = new System.Windows.Forms.ComboBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtTitle = new SiticoneNetFrameworkUI.SiticoneTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnConfirm);
            this.pnlMain.Controls.Add(this.txtDescription);
            this.pnlMain.Controls.Add(this.lblDescription);
            this.pnlMain.Controls.Add(this.cboTag);
            this.pnlMain.Controls.Add(this.lblTag);
            this.pnlMain.Controls.Add(this.dtpEndTime);
            this.pnlMain.Controls.Add(this.lblEndTime);
            this.pnlMain.Controls.Add(this.dtpStartTime);
            this.pnlMain.Controls.Add(this.lblStartTime);
            this.pnlMain.Controls.Add(this.txtTitle);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Location = new System.Drawing.Point(8, 8);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(440, 240);
            this.pnlMain.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Text = "취소";
            this.btnCancel.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ButtonBackColor = System.Drawing.Color.LightGray;
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(344, 192);
            this.btnCancel.Size = new System.Drawing.Size(76, 32);
            this.btnCancel.TabIndex = 11;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Text = "확인";
            this.btnConfirm.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ButtonBackColor = System.Drawing.Color.FromArgb(110, 146, 236);
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(256, 192);
            this.btnConfirm.Size = new System.Drawing.Size(76, 32);
            this.btnConfirm.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(95, 120);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(325, 55);
            this.txtDescription.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.txtDescription.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(22, 120);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(43, 15);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "설명 :";
            // 
            // cboTag
            // 
            this.cboTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTag.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.cboTag.Items.AddRange(new object[] {
                "업무",
                "개인",
                "중요",
                "기타"
            });
            this.cboTag.Location = new System.Drawing.Point(95, 90);
            this.cboTag.Name = "cboTag";
            this.cboTag.Size = new System.Drawing.Size(110, 23);
            this.cboTag.TabIndex = 7;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblTag.ForeColor = System.Drawing.Color.DimGray;
            this.lblTag.Location = new System.Drawing.Point(22, 93);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(43, 15);
            this.lblTag.TabIndex = 6;
            this.lblTag.Text = "태그 :";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.dtpEndTime.Location = new System.Drawing.Point(95, 61);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(160, 23);
            this.dtpEndTime.TabIndex = 5;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblEndTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblEndTime.Location = new System.Drawing.Point(22, 65);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(67, 15);
            this.lblEndTime.TabIndex = 4;
            this.lblEndTime.Text = "종료 시간 :";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.dtpStartTime.Location = new System.Drawing.Point(95, 33);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(160, 23);
            this.dtpStartTime.TabIndex = 3;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblStartTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblStartTime.Location = new System.Drawing.Point(22, 37);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(67, 15);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.Text = "시작 시간 :";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.txtTitle.Location = new System.Drawing.Point(95, 7);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(325, 23);
            this.txtTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(22, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(43, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "제목 :";
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 256);
            this.Controls.Add(this.pnlMain);
            this.Name = "AddScheduleForm";
            this.Text = "일정 추가";
            this.Load += new System.EventHandler(this.AddScheduleForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private SiticoneNetFrameworkUI.SiticonePanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private SiticoneNetFrameworkUI.SiticoneTextBox txtTitle;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.ComboBox cboTag;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private SiticoneNetFrameworkUI.SiticoneButton btnConfirm;
        private SiticoneNetFrameworkUI.SiticoneButton btnCancel;
    }
}
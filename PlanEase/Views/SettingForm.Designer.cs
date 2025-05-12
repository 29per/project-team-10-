namespace PlanEase.Views
{
    partial class SettingForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNotificationTime = new System.Windows.Forms.TextBox();
            this.lblNotificationTime = new System.Windows.Forms.Label();
            this.chkNotification = new System.Windows.Forms.CheckBox();
            this.lblNotification = new System.Windows.Forms.Label();
            this.cboDefaultView = new System.Windows.Forms.ComboBox();
            this.lblDefaultView = new System.Windows.Forms.Label();
            this.cboTheme = new System.Windows.Forms.ComboBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.txtNotificationTime);
            this.pnlMain.Controls.Add(this.lblNotificationTime);
            this.pnlMain.Controls.Add(this.chkNotification);
            this.pnlMain.Controls.Add(this.lblNotification);
            this.pnlMain.Controls.Add(this.cboDefaultView);
            this.pnlMain.Controls.Add(this.lblDefaultView);
            this.pnlMain.Controls.Add(this.cboTheme);
            this.pnlMain.Controls.Add(this.lblTheme);
            this.pnlMain.Location = new System.Drawing.Point(6, 6);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(418, 213);
            this.pnlMain.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(350, 180);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 20);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(291, 180);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 20);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtNotificationTime
            // 
            this.txtNotificationTime.Location = new System.Drawing.Point(103, 87);
            this.txtNotificationTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNotificationTime.Name = "txtNotificationTime";
            this.txtNotificationTime.Size = new System.Drawing.Size(56, 21);
            this.txtNotificationTime.TabIndex = 7;
            this.txtNotificationTime.Text = "10";
            // 
            // lblNotificationTime
            // 
            this.lblNotificationTime.AutoSize = true;
            this.lblNotificationTime.Location = new System.Drawing.Point(16, 90);
            this.lblNotificationTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotificationTime.Name = "lblNotificationTime";
            this.lblNotificationTime.Size = new System.Drawing.Size(83, 12);
            this.lblNotificationTime.TabIndex = 6;
            this.lblNotificationTime.Text = "알림 시간(분):";
            // 
            // chkNotification
            // 
            this.chkNotification.AutoSize = true;
            this.chkNotification.Location = new System.Drawing.Point(81, 65);
            this.chkNotification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkNotification.Name = "chkNotification";
            this.chkNotification.Size = new System.Drawing.Size(88, 16);
            this.chkNotification.TabIndex = 5;
            this.chkNotification.Text = "알림 활성화";
            this.chkNotification.UseVisualStyleBackColor = true;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Location = new System.Drawing.Point(16, 65);
            this.lblNotification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(33, 12);
            this.lblNotification.TabIndex = 4;
            this.lblNotification.Text = "알림:";
            // 
            // cboDefaultView
            // 
            this.cboDefaultView.Items.AddRange(new object[] {
            "일간",
            "주간",
            "월간"});
            this.cboDefaultView.Location = new System.Drawing.Point(81, 38);
            this.cboDefaultView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDefaultView.Name = "cboDefaultView";
            this.cboDefaultView.Size = new System.Drawing.Size(83, 20);
            this.cboDefaultView.TabIndex = 3;
            // 
            // lblDefaultView
            // 
            this.lblDefaultView.AutoSize = true;
            this.lblDefaultView.Location = new System.Drawing.Point(16, 40);
            this.lblDefaultView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDefaultView.Name = "lblDefaultView";
            this.lblDefaultView.Size = new System.Drawing.Size(49, 12);
            this.lblDefaultView.TabIndex = 2;
            this.lblDefaultView.Text = "기본 뷰:";
            // 
            // cboTheme
            // 
            this.cboTheme.Items.AddRange(new object[] {
            "밝은 모드",
            "어두운 모드"});
            this.cboTheme.Location = new System.Drawing.Point(81, 12);
            this.cboTheme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTheme.Name = "cboTheme";
            this.cboTheme.Size = new System.Drawing.Size(83, 20);
            this.cboTheme.TabIndex = 1;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(16, 15);
            this.lblTheme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(33, 12);
            this.lblTheme.TabIndex = 0;
            this.lblTheme.Text = "테마:";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 225);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SettingForm";
            this.Text = "설정";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ComboBox cboTheme;
        private System.Windows.Forms.Label lblDefaultView;
        private System.Windows.Forms.ComboBox cboDefaultView;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.CheckBox chkNotification;
        private System.Windows.Forms.Label lblNotificationTime;
        private System.Windows.Forms.TextBox txtNotificationTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
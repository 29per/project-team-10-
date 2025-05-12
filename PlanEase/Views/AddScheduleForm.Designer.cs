namespace PlanEase.Views
{
    partial class AddScheduleForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cboTag = new System.Windows.Forms.ComboBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            



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
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(776, 426);
            this.pnlMain.TabIndex = 0;
            



            this.btnCancel.Location = new System.Drawing.Point(650, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
           
            


            this.btnConfirm.Location = new System.Drawing.Point(540, 360);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 40);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            



            this.txtDescription.Location = new System.Drawing.Point(150, 230);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(600, 100);
            this.txtDescription.TabIndex = 9;
            



            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 230);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 24);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "설명:";
            



            this.cboTag.Items.AddRange(new object[] {
                "업무",
                "개인",
                "중요",
                "기타"});
            this.cboTag.Location = new System.Drawing.Point(150, 175);
            this.cboTag.Name = "cboTag";
            this.cboTag.Size = new System.Drawing.Size(150, 32);
            this.cboTag.TabIndex = 7;
            



            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(30, 180);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(60, 24);
            this.lblTag.TabIndex = 6;
            this.lblTag.Text = "태그:";
            



            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpEndTime.Location = new System.Drawing.Point(150, 125);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(200, 35);
            this.dtpEndTime.TabIndex = 5;
            



            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(30, 130);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(90, 24);
            this.lblEndTime.TabIndex = 4;
            this.lblEndTime.Text = "종료 시간:";
            



            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpStartTime.Location = new System.Drawing.Point(150, 75);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(200, 35);
            this.dtpStartTime.TabIndex = 3;
            




            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(30, 80);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(90, 24);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.Text = "시작 시간:";
            




            this.txtTitle.Location = new System.Drawing.Point(150, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(600, 35);
            this.txtTitle.TabIndex = 1;
            




            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "제목:";
            
            


            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Name = "AddScheduleForm";
            this.Text = "일정 추가";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.ComboBox cboTag;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}
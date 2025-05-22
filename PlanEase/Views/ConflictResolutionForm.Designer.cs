namespace PlanEase.Views
{
    partial class ConflictResolutionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpStrategy = new System.Windows.Forms.GroupBox();
            this.radioChangeTime = new System.Windows.Forms.RadioButton();
            this.radioMerge = new System.Windows.Forms.RadioButton();
            this.radioDelete = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpStrategy.SuspendLayout();
            this.SuspendLayout();
            



            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(16, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(235, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "일정 충돌 해결 방법을 선택하세요";
            



            this.grpStrategy.Controls.Add(this.radioChangeTime);
            this.grpStrategy.Controls.Add(this.radioMerge);
            this.grpStrategy.Controls.Add(this.radioDelete);
            this.grpStrategy.Location = new System.Drawing.Point(20, 81);
            this.grpStrategy.Name = "grpStrategy";
            this.grpStrategy.Size = new System.Drawing.Size(350, 52);
            this.grpStrategy.TabIndex = 2;
            this.grpStrategy.TabStop = false;
            this.grpStrategy.Text = "해결 전략";
            



            this.radioChangeTime.AutoSize = true;
            this.radioChangeTime.Location = new System.Drawing.Point(20, 23);
            this.radioChangeTime.Name = "radioChangeTime";
            this.radioChangeTime.Size = new System.Drawing.Size(75, 16);
            this.radioChangeTime.TabIndex = 0;
            this.radioChangeTime.Text = "시간 변경";
            



            this.radioMerge.AutoSize = true;
            this.radioMerge.Location = new System.Drawing.Point(120, 23);
            this.radioMerge.Name = "radioMerge";
            this.radioMerge.Size = new System.Drawing.Size(47, 16);
            this.radioMerge.TabIndex = 1;
            this.radioMerge.Text = "병합";
            



            this.radioDelete.AutoSize = true;
            this.radioDelete.Location = new System.Drawing.Point(200, 23);
            this.radioDelete.Name = "radioDelete";
            this.radioDelete.Size = new System.Drawing.Size(47, 16);
            this.radioDelete.TabIndex = 2;
            this.radioDelete.Text = "삭제";
            



            this.btnOk.Location = new System.Drawing.Point(211, 355);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 27);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "확인";
            



            this.btnCancel.Location = new System.Drawing.Point(311, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "취소";
            



            this.ClientSize = new System.Drawing.Size(415, 394);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpStrategy);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConflictResolutionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "일정 충돌 해결";
            this.grpStrategy.ResumeLayout(false);
            this.grpStrategy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpStrategy;
        private System.Windows.Forms.RadioButton radioChangeTime;
        private System.Windows.Forms.RadioButton radioMerge;
        private System.Windows.Forms.RadioButton radioDelete;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}
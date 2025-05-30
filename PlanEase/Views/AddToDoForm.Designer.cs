namespace PlanEase.Views
{
    partial class AddToDoForm
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
            this.clbTags = new System.Windows.Forms.CheckedListBox();
            this.chkDueDate = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTag = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.clbTags);
            this.pnlMain.Controls.Add(this.chkDueDate);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnAdd);
            this.pnlMain.Controls.Add(this.lblTag);
            this.pnlMain.Controls.Add(this.dtpDueDate);
            this.pnlMain.Controls.Add(this.lblDueDate);
            this.pnlMain.Controls.Add(this.cmbPriority);
            this.pnlMain.Controls.Add(this.lblPriority);
            this.pnlMain.Controls.Add(this.txtContent);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(776, 576);
            this.pnlMain.TabIndex = 0;
            // 
            // clbTags
            // 
            this.clbTags.FormattingEnabled = true;
            this.clbTags.Location = new System.Drawing.Point(150, 206);
            this.clbTags.Name = "clbTags";
            this.clbTags.Size = new System.Drawing.Size(250, 292);
            this.clbTags.TabIndex = 13;
            // 
            // chkDueDate
            // 
            this.chkDueDate.AutoSize = true;
            this.chkDueDate.Location = new System.Drawing.Point(372, 87);
            this.chkDueDate.Name = "chkDueDate";
            this.chkDueDate.Size = new System.Drawing.Size(28, 27);
            this.chkDueDate.TabIndex = 12;
            this.chkDueDate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(630, 518);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(509, 518);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "확인";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(38, 206);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(66, 24);
            this.lblTag.TabIndex = 6;
            this.lblTag.Text = "태그:";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(150, 83);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 35);
            this.dtpDueDate.TabIndex = 5;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(30, 90);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(90, 24);
            this.lblDueDate.TabIndex = 4;
            this.lblDueDate.Text = "마감일:";
            // 
            // cmbPriority
            // 
            this.cmbPriority.Location = new System.Drawing.Point(150, 147);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(150, 32);
            this.cmbPriority.TabIndex = 3;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(30, 147);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(114, 24);
            this.lblPriority.TabIndex = 2;
            this.lblPriority.Text = "우선순위:";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(150, 25);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(600, 35);
            this.txtContent.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "할 일:";
            // 
            // AddToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlMain);
            this.Name = "AddToDoForm";
            this.Text = "할 일 추가";
            this.Load += new System.EventHandler(this.AddToDoForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckedListBox clbTags;
        private System.Windows.Forms.CheckBox chkDueDate;
    }
}
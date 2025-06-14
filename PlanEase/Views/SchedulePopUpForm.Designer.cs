namespace PlanEase.Views
{
    partial class SchedulePopUpForm
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
            this.components = new System.ComponentModel.Container();
            this.siticoneBorderlessForm1 = new SiticoneNetFrameworkUI.SiticoneBorderlessForm(this.components);
            this.siticoneCloseButton2 = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.pnlList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.NavBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneBorderlessForm1.NavBarHeight = 30;
            this.siticoneBorderlessForm1.TargetForm = this;
            // 
            // siticoneCloseButton2
            // 
            this.siticoneCloseButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneCloseButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCloseButton2.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCloseButton2.EnableSound = false;
            this.siticoneCloseButton2.Location = new System.Drawing.Point(127, 0);
            this.siticoneCloseButton2.Name = "siticoneCloseButton2";
            this.siticoneCloseButton2.Size = new System.Drawing.Size(33, 33);
            this.siticoneCloseButton2.TabIndex = 11;
            this.siticoneCloseButton2.Text = "siticoneCloseButton2";
            this.siticoneCloseButton2.TooltipText = "Close";
            this.siticoneCloseButton2.Click += new System.EventHandler(this.siticoneCloseButton2_Click);
            // 
            // pnlList
            // 
            this.pnlList.AutoScroll = true;
            this.pnlList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlList.Location = new System.Drawing.Point(20, 30);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(120, 170);
            this.pnlList.TabIndex = 12;
            this.pnlList.WrapContents = false;
            // 
            // SchedulePopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 200);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.siticoneCloseButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SchedulePopUpForm";
            this.Text = "SchedulePopUpForm";
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneBorderlessForm siticoneBorderlessForm1;
        private SiticoneNetFrameworkUI.SiticoneCloseButton siticoneCloseButton2;
        private System.Windows.Forms.FlowLayoutPanel pnlList;
    }
}
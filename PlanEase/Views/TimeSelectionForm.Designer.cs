namespace PlanEase.Views
{
    partial class TimeSelectionForm
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
            this.cmbStartHour = new System.Windows.Forms.ComboBox();
            this.cmbStartMinute = new System.Windows.Forms.ComboBox();
            this.cmbEndHour = new System.Windows.Forms.ComboBox();
            this.cmbEndMinute = new System.Windows.Forms.ComboBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.btnOk = new SiticoneNetFrameworkUI.SiticoneButton();
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
            this.siticoneCloseButton2.Location = new System.Drawing.Point(218, -1);
            this.siticoneCloseButton2.Name = "siticoneCloseButton2";
            this.siticoneCloseButton2.Size = new System.Drawing.Size(33, 33);
            this.siticoneCloseButton2.TabIndex = 11;
            this.siticoneCloseButton2.Text = "siticoneCloseButton2";
            this.siticoneCloseButton2.TooltipText = "Close";
            this.siticoneCloseButton2.Click += new System.EventHandler(this.siticoneCloseButton2_Click);
            // 
            // cmbStartHour
            // 
            this.cmbStartHour.FormattingEnabled = true;
            this.cmbStartHour.Location = new System.Drawing.Point(98, 104);
            this.cmbStartHour.Name = "cmbStartHour";
            this.cmbStartHour.Size = new System.Drawing.Size(60, 20);
            this.cmbStartHour.TabIndex = 28;
            // 
            // cmbStartMinute
            // 
            this.cmbStartMinute.FormattingEnabled = true;
            this.cmbStartMinute.Location = new System.Drawing.Point(176, 104);
            this.cmbStartMinute.Name = "cmbStartMinute";
            this.cmbStartMinute.Size = new System.Drawing.Size(60, 20);
            this.cmbStartMinute.TabIndex = 29;
            // 
            // cmbEndHour
            // 
            this.cmbEndHour.FormattingEnabled = true;
            this.cmbEndHour.Location = new System.Drawing.Point(98, 165);
            this.cmbEndHour.Name = "cmbEndHour";
            this.cmbEndHour.Size = new System.Drawing.Size(60, 20);
            this.cmbEndHour.TabIndex = 30;
            // 
            // cmbEndMinute
            // 
            this.cmbEndMinute.FormattingEnabled = true;
            this.cmbEndMinute.Location = new System.Drawing.Point(176, 165);
            this.cmbEndMinute.Name = "cmbEndMinute";
            this.cmbEndMinute.Size = new System.Drawing.Size(60, 20);
            this.cmbEndMinute.TabIndex = 31;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStartTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStartTime.Location = new System.Drawing.Point(11, 108);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(81, 16);
            this.lblStartTime.TabIndex = 32;
            this.lblStartTime.Text = "시작 시간:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEndTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEndTime.Location = new System.Drawing.Point(12, 169);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(81, 16);
            this.lblEndTime.TabIndex = 33;
            this.lblEndTime.Text = "종료 시간:";
            // 
            // btnOk
            // 
            this.btnOk.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnOk.AccessibleName = "확인";
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.AutoSizeBasedOnText = false;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BadgeBackColor = System.Drawing.Color.Black;
            this.btnOk.BadgeFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.BadgeValue = 0;
            this.btnOk.BadgeValueForeColor = System.Drawing.Color.White;
            this.btnOk.BorderColor = System.Drawing.Color.Lavender;
            this.btnOk.BorderWidth = 2;
            this.btnOk.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.btnOk.ButtonImage = null;
            this.btnOk.ButtonTextLeftPadding = 0;
            this.btnOk.CanBeep = true;
            this.btnOk.CanGlow = true;
            this.btnOk.CanShake = true;
            this.btnOk.ContextMenuStripEx = null;
            this.btnOk.CornerRadiusBottomLeft = 15;
            this.btnOk.CornerRadiusBottomRight = 15;
            this.btnOk.CornerRadiusTopLeft = 15;
            this.btnOk.CornerRadiusTopRight = 15;
            this.btnOk.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnOk.EnableLongPress = false;
            this.btnOk.EnablePressAnimation = true;
            this.btnOk.EnableRippleEffect = false;
            this.btnOk.EnableShadow = true;
            this.btnOk.EnableTextWrapping = false;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.GlowColor = System.Drawing.Color.MediumSpringGreen;
            this.btnOk.GlowIntensity = 100;
            this.btnOk.GlowRadius = 20F;
            this.btnOk.GradientBackground = true;
            this.btnOk.GradientColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOk.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnOk.HintText = null;
            this.btnOk.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.btnOk.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnOk.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.btnOk.HoverTransitionDuration = 250;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.ImagePadding = 5;
            this.btnOk.ImageSize = new System.Drawing.Size(16, 16);
            this.btnOk.IsRadial = false;
            this.btnOk.IsReadOnly = false;
            this.btnOk.IsToggleButton = false;
            this.btnOk.IsToggled = false;
            this.btnOk.Location = new System.Drawing.Point(76, 234);
            this.btnOk.LongPressDurationMS = 1000;
            this.btnOk.Name = "btnOk";
            this.btnOk.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnOk.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnOk.ParticleCount = 15;
            this.btnOk.PressAnimationScale = 0.97F;
            this.btnOk.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnOk.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnOk.PressTransitionDuration = 150;
            this.btnOk.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnOk.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOk.RippleOpacity = 0.3F;
            this.btnOk.RippleRadiusMultiplier = 0.6F;
            this.btnOk.ShadowBlur = 6;
            this.btnOk.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnOk.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnOk.ShakeDuration = 500;
            this.btnOk.ShakeIntensity = 5;
            this.btnOk.Size = new System.Drawing.Size(91, 39);
            this.btnOk.TabIndex = 34;
            this.btnOk.Text = "확인";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.TextColor = System.Drawing.Color.White;
            this.btnOk.TooltipText = null;
            this.btnOk.UseAdvancedRendering = true;
            this.btnOk.UseParticles = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // TimeSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(250, 300);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.cmbEndMinute);
            this.Controls.Add(this.cmbEndHour);
            this.Controls.Add(this.cmbStartMinute);
            this.Controls.Add(this.cmbStartHour);
            this.Controls.Add(this.siticoneCloseButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeSelectionForm";
            this.Text = "TimeSelectionForm";
            this.Load += new System.EventHandler(this.TimeSelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneBorderlessForm siticoneBorderlessForm1;
        private SiticoneNetFrameworkUI.SiticoneCloseButton siticoneCloseButton2;
        private System.Windows.Forms.ComboBox cmbStartHour;
        private System.Windows.Forms.ComboBox cmbStartMinute;
        private System.Windows.Forms.ComboBox cmbEndHour;
        private System.Windows.Forms.ComboBox cmbEndMinute;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private SiticoneNetFrameworkUI.SiticoneButton btnOk;
    }
}
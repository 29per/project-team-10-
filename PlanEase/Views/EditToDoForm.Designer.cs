namespace PlanEase.Views
{
    partial class EditToDoForm
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.chkDueDate = new System.Windows.Forms.CheckBox();
            this.btnCancel = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnSave = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnDelete = new SiticoneNetFrameworkUI.SiticoneButton();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.pnlMain = new SiticoneNetFrameworkUI.SiticonePanel();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(25, 43);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(298, 32);
            this.txtContent.TabIndex = 0;
            // 
            // chkDueDate
            // 
            this.chkDueDate.AutoSize = true;
            this.chkDueDate.Location = new System.Drawing.Point(301, 115);
            this.chkDueDate.Name = "chkDueDate";
            this.chkDueDate.Size = new System.Drawing.Size(22, 21);
            this.chkDueDate.TabIndex = 1;
            this.chkDueDate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnCancel.AccessibleName = "취소";
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.AutoSizeBasedOnText = false;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BadgeBackColor = System.Drawing.Color.Black;
            this.btnCancel.BadgeFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.BadgeValue = 0;
            this.btnCancel.BadgeValueForeColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.Lavender;
            this.btnCancel.BorderWidth = 2;
            this.btnCancel.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.btnCancel.ButtonImage = null;
            this.btnCancel.ButtonTextLeftPadding = 0;
            this.btnCancel.CanBeep = true;
            this.btnCancel.CanGlow = true;
            this.btnCancel.CanShake = true;
            this.btnCancel.ContextMenuStripEx = null;
            this.btnCancel.CornerRadiusBottomLeft = 15;
            this.btnCancel.CornerRadiusBottomRight = 15;
            this.btnCancel.CornerRadiusTopLeft = 15;
            this.btnCancel.CornerRadiusTopRight = 15;
            this.btnCancel.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnCancel.EnableLongPress = false;
            this.btnCancel.EnablePressAnimation = true;
            this.btnCancel.EnableRippleEffect = false;
            this.btnCancel.EnableShadow = true;
            this.btnCancel.EnableTextWrapping = false;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.GlowIntensity = 100;
            this.btnCancel.GlowRadius = 20F;
            this.btnCancel.GradientBackground = true;
            this.btnCancel.GradientColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnCancel.HintText = null;
            this.btnCancel.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.btnCancel.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnCancel.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.btnCancel.HoverTransitionDuration = 250;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImagePadding = 5;
            this.btnCancel.ImageSize = new System.Drawing.Size(16, 16);
            this.btnCancel.IsRadial = false;
            this.btnCancel.IsReadOnly = false;
            this.btnCancel.IsToggleButton = false;
            this.btnCancel.IsToggled = false;
            this.btnCancel.Location = new System.Drawing.Point(255, 186);
            this.btnCancel.LongPressDurationMS = 1000;
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnCancel.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCancel.ParticleCount = 15;
            this.btnCancel.PressAnimationScale = 0.97F;
            this.btnCancel.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnCancel.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnCancel.PressTransitionDuration = 150;
            this.btnCancel.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancel.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.RippleOpacity = 0.3F;
            this.btnCancel.RippleRadiusMultiplier = 0.6F;
            this.btnCancel.ShadowBlur = 6;
            this.btnCancel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnCancel.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnCancel.ShakeDuration = 500;
            this.btnCancel.ShakeIntensity = 5;
            this.btnCancel.Size = new System.Drawing.Size(104, 44);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.TooltipText = null;
            this.btnCancel.UseAdvancedRendering = true;
            this.btnCancel.UseParticles = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnSave.AccessibleName = "저장";
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.AutoSizeBasedOnText = false;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BadgeBackColor = System.Drawing.Color.Black;
            this.btnSave.BadgeFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.BadgeValue = 0;
            this.btnSave.BadgeValueForeColor = System.Drawing.Color.White;
            this.btnSave.BorderColor = System.Drawing.Color.Lavender;
            this.btnSave.BorderWidth = 2;
            this.btnSave.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.btnSave.ButtonImage = null;
            this.btnSave.ButtonTextLeftPadding = 0;
            this.btnSave.CanBeep = true;
            this.btnSave.CanGlow = true;
            this.btnSave.CanShake = true;
            this.btnSave.ContextMenuStripEx = null;
            this.btnSave.CornerRadiusBottomLeft = 15;
            this.btnSave.CornerRadiusBottomRight = 15;
            this.btnSave.CornerRadiusTopLeft = 15;
            this.btnSave.CornerRadiusTopRight = 15;
            this.btnSave.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnSave.EnableLongPress = false;
            this.btnSave.EnablePressAnimation = true;
            this.btnSave.EnableRippleEffect = false;
            this.btnSave.EnableShadow = true;
            this.btnSave.EnableTextWrapping = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.GlowIntensity = 100;
            this.btnSave.GlowRadius = 20F;
            this.btnSave.GradientBackground = true;
            this.btnSave.GradientColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnSave.HintText = null;
            this.btnSave.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.btnSave.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnSave.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.btnSave.HoverTransitionDuration = 250;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImagePadding = 5;
            this.btnSave.ImageSize = new System.Drawing.Size(16, 16);
            this.btnSave.IsRadial = false;
            this.btnSave.IsReadOnly = false;
            this.btnSave.IsToggleButton = false;
            this.btnSave.IsToggled = false;
            this.btnSave.Location = new System.Drawing.Point(27, 186);
            this.btnSave.LongPressDurationMS = 1000;
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnSave.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnSave.ParticleCount = 15;
            this.btnSave.PressAnimationScale = 0.97F;
            this.btnSave.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnSave.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnSave.PressTransitionDuration = 150;
            this.btnSave.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnSave.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.RippleOpacity = 0.3F;
            this.btnSave.RippleRadiusMultiplier = 0.6F;
            this.btnSave.ShadowBlur = 6;
            this.btnSave.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnSave.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnSave.ShakeDuration = 500;
            this.btnSave.ShakeIntensity = 5;
            this.btnSave.Size = new System.Drawing.Size(104, 44);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "저장";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.TooltipText = null;
            this.btnSave.UseAdvancedRendering = true;
            this.btnSave.UseParticles = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnDelete.AccessibleName = "삭제";
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.AutoSizeBasedOnText = false;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BadgeBackColor = System.Drawing.Color.Black;
            this.btnDelete.BadgeFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.BadgeValue = 0;
            this.btnDelete.BadgeValueForeColor = System.Drawing.Color.White;
            this.btnDelete.BorderColor = System.Drawing.Color.Lavender;
            this.btnDelete.BorderWidth = 2;
            this.btnDelete.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.btnDelete.ButtonImage = null;
            this.btnDelete.ButtonTextLeftPadding = 0;
            this.btnDelete.CanBeep = true;
            this.btnDelete.CanGlow = true;
            this.btnDelete.CanShake = true;
            this.btnDelete.ContextMenuStripEx = null;
            this.btnDelete.CornerRadiusBottomLeft = 15;
            this.btnDelete.CornerRadiusBottomRight = 15;
            this.btnDelete.CornerRadiusTopLeft = 15;
            this.btnDelete.CornerRadiusTopRight = 15;
            this.btnDelete.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnDelete.EnableLongPress = false;
            this.btnDelete.EnablePressAnimation = true;
            this.btnDelete.EnableRippleEffect = false;
            this.btnDelete.EnableShadow = true;
            this.btnDelete.EnableTextWrapping = false;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.GlowIntensity = 100;
            this.btnDelete.GlowRadius = 20F;
            this.btnDelete.GradientBackground = true;
            this.btnDelete.GradientColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnDelete.HintText = null;
            this.btnDelete.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.btnDelete.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnDelete.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.btnDelete.HoverTransitionDuration = 250;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImagePadding = 5;
            this.btnDelete.ImageSize = new System.Drawing.Size(16, 16);
            this.btnDelete.IsRadial = false;
            this.btnDelete.IsReadOnly = false;
            this.btnDelete.IsToggleButton = false;
            this.btnDelete.IsToggled = false;
            this.btnDelete.Location = new System.Drawing.Point(141, 186);
            this.btnDelete.LongPressDurationMS = 1000;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnDelete.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDelete.ParticleCount = 15;
            this.btnDelete.PressAnimationScale = 0.97F;
            this.btnDelete.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnDelete.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnDelete.PressTransitionDuration = 150;
            this.btnDelete.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDelete.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.RippleOpacity = 0.3F;
            this.btnDelete.RippleRadiusMultiplier = 0.6F;
            this.btnDelete.ShadowBlur = 6;
            this.btnDelete.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnDelete.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnDelete.ShakeDuration = 500;
            this.btnDelete.ShakeIntensity = 5;
            this.btnDelete.Size = new System.Drawing.Size(104, 44);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "삭제";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.TooltipText = null;
            this.btnDelete.UseAdvancedRendering = true;
            this.btnDelete.UseParticles = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(27, 106);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(268, 32);
            this.dtpDueDate.TabIndex = 29;
            // 
            // pnlMain
            // 
            this.pnlMain.AcrylicTintColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            this.pnlMain.BorderDashPattern = null;
            this.pnlMain.BorderGradientEndColor = System.Drawing.Color.Purple;
            this.pnlMain.BorderGradientStartColor = System.Drawing.Color.Blue;
            this.pnlMain.BorderThickness = 2F;
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.dtpDueDate);
            this.pnlMain.Controls.Add(this.txtContent);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.chkDueDate);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.CornerRadiusBottomLeft = 0F;
            this.pnlMain.CornerRadiusBottomRight = 0F;
            this.pnlMain.CornerRadiusTopLeft = 0F;
            this.pnlMain.CornerRadiusTopRight = 0F;
            this.pnlMain.EnableAcrylicEffect = false;
            this.pnlMain.EnableMicaEffect = false;
            this.pnlMain.EnableRippleEffect = false;
            this.pnlMain.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.pnlMain.GradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.Gray};
            this.pnlMain.GradientPositions = new float[] {
        0F,
        0.5F,
        1F};
            this.pnlMain.Location = new System.Drawing.Point(2, 14);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.PatternStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid;
            this.pnlMain.RippleAlpha = 50;
            this.pnlMain.RippleAlphaDecrement = 3;
            this.pnlMain.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlMain.RippleMaxSize = 600F;
            this.pnlMain.RippleSpeed = 15F;
            this.pnlMain.ShowBorder = true;
            this.pnlMain.Size = new System.Drawing.Size(386, 269);
            this.pnlMain.TabIndex = 30;
            this.pnlMain.TabStop = true;
            this.pnlMain.TrackSystemTheme = false;
            this.pnlMain.UseBorderGradient = false;
            this.pnlMain.UseMultiGradient = false;
            this.pnlMain.UsePatternTexture = false;
            this.pnlMain.UseRadialGradient = false;
            // 
            // EditToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 281);
            this.Controls.Add(this.pnlMain);
            this.Name = "EditToDoForm";
            this.Text = "할 일 수정";
            this.Load += new System.EventHandler(this.EditToDoForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.CheckBox chkDueDate;
        private SiticoneNetFrameworkUI.SiticoneButton btnCancel;
        private SiticoneNetFrameworkUI.SiticoneButton btnSave;
        private SiticoneNetFrameworkUI.SiticoneButton btnDelete;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private SiticoneNetFrameworkUI.SiticonePanel pnlMain;
    }
}
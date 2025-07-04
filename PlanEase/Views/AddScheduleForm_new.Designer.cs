﻿namespace PlanEase.Views
{
    partial class AddScheduleForm_new_
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
            this.btnClose = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.panelTextbox = new SiticoneNetFrameworkUI.SiticonePanel();
            this.btnCancel = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnAdd = new SiticoneNetFrameworkUI.SiticoneButton();
            this.cmbPriority = new RJCodeAdvance.RJControls.RJComboBox();
            this.dtpEndTime = new RJCodeAdvance.RJControls.RJDatePicker();
            this.dtpStartTime = new RJCodeAdvance.RJControls.RJDatePicker();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbStartHour = new System.Windows.Forms.ComboBox();
            this.cmbStartMinute = new System.Windows.Forms.ComboBox();
            this.cmbEndHour = new System.Windows.Forms.ComboBox();
            this.cmbEndMinute = new System.Windows.Forms.ComboBox();
            this.btnTag = new FontAwesome.Sharp.IconButton();
            this.panelTextbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.NavBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneBorderlessForm1.NavBarHeight = 30;
            this.siticoneBorderlessForm1.TargetForm = this;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.EnableSound = false;
            this.btnClose.Location = new System.Drawing.Point(526, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 33);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "siticoneCloseButton2";
            this.btnClose.TooltipText = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelTextbox
            // 
            this.panelTextbox.AcrylicTintColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelTextbox.BackColor = System.Drawing.Color.Transparent;
            this.panelTextbox.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            this.panelTextbox.BorderDashPattern = null;
            this.panelTextbox.BorderGradientEndColor = System.Drawing.Color.Purple;
            this.panelTextbox.BorderGradientStartColor = System.Drawing.Color.Blue;
            this.panelTextbox.BorderThickness = 2F;
            this.panelTextbox.Controls.Add(this.btnTag);
            this.panelTextbox.Controls.Add(this.cmbEndMinute);
            this.panelTextbox.Controls.Add(this.cmbEndHour);
            this.panelTextbox.Controls.Add(this.cmbStartMinute);
            this.panelTextbox.Controls.Add(this.cmbStartHour);
            this.panelTextbox.Controls.Add(this.txtDescription);
            this.panelTextbox.Controls.Add(this.txtTag);
            this.panelTextbox.Controls.Add(this.txtTitle);
            this.panelTextbox.Controls.Add(this.btnCancel);
            this.panelTextbox.Controls.Add(this.btnAdd);
            this.panelTextbox.Controls.Add(this.cmbPriority);
            this.panelTextbox.Controls.Add(this.dtpEndTime);
            this.panelTextbox.Controls.Add(this.dtpStartTime);
            this.panelTextbox.Controls.Add(this.lblPriority);
            this.panelTextbox.Controls.Add(this.lblDescription);
            this.panelTextbox.Controls.Add(this.lblTag);
            this.panelTextbox.Controls.Add(this.lblEndTime);
            this.panelTextbox.Controls.Add(this.lblStartTime);
            this.panelTextbox.Controls.Add(this.lblTitle);
            this.panelTextbox.CornerRadiusBottomLeft = 0F;
            this.panelTextbox.CornerRadiusBottomRight = 0F;
            this.panelTextbox.CornerRadiusTopLeft = 0F;
            this.panelTextbox.CornerRadiusTopRight = 0F;
            this.panelTextbox.EnableAcrylicEffect = false;
            this.panelTextbox.EnableMicaEffect = false;
            this.panelTextbox.EnableRippleEffect = false;
            this.panelTextbox.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.panelTextbox.GradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.Gray};
            this.panelTextbox.GradientPositions = new float[] {
        0F,
        0.5F,
        1F};
            this.panelTextbox.Location = new System.Drawing.Point(0, 30);
            this.panelTextbox.Name = "panelTextbox";
            this.panelTextbox.PatternStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid;
            this.panelTextbox.RippleAlpha = 50;
            this.panelTextbox.RippleAlphaDecrement = 3;
            this.panelTextbox.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelTextbox.RippleMaxSize = 600F;
            this.panelTextbox.RippleSpeed = 15F;
            this.panelTextbox.ShowBorder = true;
            this.panelTextbox.Size = new System.Drawing.Size(557, 370);
            this.panelTextbox.TabIndex = 14;
            this.panelTextbox.TabStop = true;
            this.panelTextbox.TrackSystemTheme = false;
            this.panelTextbox.UseBorderGradient = false;
            this.panelTextbox.UseMultiGradient = false;
            this.panelTextbox.UsePatternTexture = false;
            this.panelTextbox.UseRadialGradient = false;
            this.panelTextbox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTextbox_Paint);
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
            this.btnCancel.Location = new System.Drawing.Point(278, 296);
            this.btnCancel.LongPressDurationMS = 1000;
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
            this.btnCancel.Size = new System.Drawing.Size(91, 39);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.TooltipText = null;
            this.btnCancel.UseAdvancedRendering = true;
            this.btnCancel.UseParticles = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnAdd.AccessibleName = "확인";
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.AutoSizeBasedOnText = false;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BadgeBackColor = System.Drawing.Color.Black;
            this.btnAdd.BadgeFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.BadgeValue = 0;
            this.btnAdd.BadgeValueForeColor = System.Drawing.Color.White;
            this.btnAdd.BorderColor = System.Drawing.Color.Lavender;
            this.btnAdd.BorderWidth = 2;
            this.btnAdd.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.btnAdd.ButtonImage = null;
            this.btnAdd.ButtonTextLeftPadding = 0;
            this.btnAdd.CanBeep = true;
            this.btnAdd.CanGlow = true;
            this.btnAdd.CanShake = true;
            this.btnAdd.ContextMenuStripEx = null;
            this.btnAdd.CornerRadiusBottomLeft = 15;
            this.btnAdd.CornerRadiusBottomRight = 15;
            this.btnAdd.CornerRadiusTopLeft = 15;
            this.btnAdd.CornerRadiusTopRight = 15;
            this.btnAdd.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnAdd.EnableLongPress = false;
            this.btnAdd.EnablePressAnimation = true;
            this.btnAdd.EnableRippleEffect = false;
            this.btnAdd.EnableShadow = true;
            this.btnAdd.EnableTextWrapping = false;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.GlowColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAdd.GlowIntensity = 100;
            this.btnAdd.GlowRadius = 20F;
            this.btnAdd.GradientBackground = true;
            this.btnAdd.GradientColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnAdd.HintText = null;
            this.btnAdd.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.btnAdd.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnAdd.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.btnAdd.HoverTransitionDuration = 250;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImagePadding = 5;
            this.btnAdd.ImageSize = new System.Drawing.Size(16, 16);
            this.btnAdd.IsRadial = false;
            this.btnAdd.IsReadOnly = false;
            this.btnAdd.IsToggleButton = false;
            this.btnAdd.IsToggled = false;
            this.btnAdd.Location = new System.Drawing.Point(155, 296);
            this.btnAdd.LongPressDurationMS = 1000;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnAdd.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAdd.ParticleCount = 15;
            this.btnAdd.PressAnimationScale = 0.97F;
            this.btnAdd.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnAdd.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnAdd.PressTransitionDuration = 150;
            this.btnAdd.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAdd.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.RippleOpacity = 0.3F;
            this.btnAdd.RippleRadiusMultiplier = 0.6F;
            this.btnAdd.ShadowBlur = 6;
            this.btnAdd.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnAdd.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnAdd.ShakeDuration = 500;
            this.btnAdd.ShakeIntensity = 5;
            this.btnAdd.Size = new System.Drawing.Size(91, 39);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "확인";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.TooltipText = null;
            this.btnAdd.UseAdvancedRendering = true;
            this.btnAdd.UseParticles = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbPriority
            // 
            this.cmbPriority.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPriority.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbPriority.BorderSize = 1;
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbPriority.Font = new System.Drawing.Font("굴림", 10F);
            this.cmbPriority.ForeColor = System.Drawing.Color.DimGray;
            this.cmbPriority.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbPriority.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbPriority.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbPriority.Location = new System.Drawing.Point(155, 166);
            this.cmbPriority.MinimumSize = new System.Drawing.Size(186, 25);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cmbPriority.Size = new System.Drawing.Size(214, 25);
            this.cmbPriority.TabIndex = 20;
            this.cmbPriority.Texts = "";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpEndTime.BorderSize = 3;
            this.dtpEndTime.CustomFormat = "yyyy-MM-dd";
            this.dtpEndTime.Font = new System.Drawing.Font("굴림", 9.5F);
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(158, 96);
            this.dtpEndTime.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(120, 25);
            this.dtpEndTime.SkinColor = System.Drawing.Color.Lavender;
            this.dtpEndTime.TabIndex = 18;
            this.dtpEndTime.TextColor = System.Drawing.Color.Black;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpStartTime.BorderSize = 3;
            this.dtpStartTime.CustomFormat = "yyyy-MM-dd";
            this.dtpStartTime.Font = new System.Drawing.Font("굴림", 9.5F);
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(156, 55);
            this.dtpStartTime.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(120, 25);
            this.dtpStartTime.SkinColor = System.Drawing.Color.Lavender;
            this.dtpStartTime.TabIndex = 17;
            this.dtpStartTime.TextColor = System.Drawing.Color.Black;
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dtpStartTime_ValueChanged);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPriority.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPriority.Location = new System.Drawing.Point(77, 175);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(65, 16);
            this.lblPriority.TabIndex = 10;
            this.lblPriority.Text = "중요도: ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDescription.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescription.Location = new System.Drawing.Point(77, 208);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(44, 16);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "설명:";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTag.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTag.Location = new System.Drawing.Point(77, 139);
            this.lblTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(44, 16);
            this.lblTag.TabIndex = 7;
            this.lblTag.Text = "태그:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEndTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEndTime.Location = new System.Drawing.Point(77, 101);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(81, 16);
            this.lblEndTime.TabIndex = 5;
            this.lblEndTime.Text = "종료 시간:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStartTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblStartTime.Location = new System.Drawing.Point(77, 60);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(81, 16);
            this.lblStartTime.TabIndex = 3;
            this.lblStartTime.Text = "시작 시간:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(77, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "제목:";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(157, 18);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(214, 21);
            this.txtTitle.TabIndex = 24;
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(156, 130);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(214, 21);
            this.txtTag.TabIndex = 25;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(155, 208);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(214, 70);
            this.txtDescription.TabIndex = 26;
            // 
            // cmbStartHour
            // 
            this.cmbStartHour.FormattingEnabled = true;
            this.cmbStartHour.Location = new System.Drawing.Point(282, 56);
            this.cmbStartHour.Name = "cmbStartHour";
            this.cmbStartHour.Size = new System.Drawing.Size(60, 20);
            this.cmbStartHour.TabIndex = 27;
            // 
            // cmbStartMinute
            // 
            this.cmbStartMinute.FormattingEnabled = true;
            this.cmbStartMinute.Location = new System.Drawing.Point(354, 55);
            this.cmbStartMinute.Name = "cmbStartMinute";
            this.cmbStartMinute.Size = new System.Drawing.Size(60, 20);
            this.cmbStartMinute.TabIndex = 28;
            // 
            // cmbEndHour
            // 
            this.cmbEndHour.FormattingEnabled = true;
            this.cmbEndHour.Location = new System.Drawing.Point(282, 97);
            this.cmbEndHour.Name = "cmbEndHour";
            this.cmbEndHour.Size = new System.Drawing.Size(60, 20);
            this.cmbEndHour.TabIndex = 29;
            // 
            // cmbEndMinute
            // 
            this.cmbEndMinute.FormattingEnabled = true;
            this.cmbEndMinute.Location = new System.Drawing.Point(354, 96);
            this.cmbEndMinute.Name = "cmbEndMinute";
            this.cmbEndMinute.Size = new System.Drawing.Size(60, 20);
            this.cmbEndMinute.TabIndex = 30;
            // 
            // btnTag
            // 
            this.btnTag.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnTag.IconChar = FontAwesome.Sharp.IconChar.Hashtag;
            this.btnTag.IconColor = System.Drawing.Color.AliceBlue;
            this.btnTag.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTag.IconSize = 16;
            this.btnTag.Location = new System.Drawing.Point(376, 124);
            this.btnTag.Name = "btnTag";
            this.btnTag.Size = new System.Drawing.Size(38, 30);
            this.btnTag.TabIndex = 31;
            this.btnTag.UseVisualStyleBackColor = false;
            this.btnTag.Click += new System.EventHandler(this.btnTag_Click);
            // 
            // AddScheduleForm_new_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(557, 400);
            this.Controls.Add(this.panelTextbox);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddScheduleForm_new_";
            this.Text = "AddScheduleForm_new_";
            this.Load += new System.EventHandler(this.AddScheduleForm_new__Load);
            this.panelTextbox.ResumeLayout(false);
            this.panelTextbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneBorderlessForm siticoneBorderlessForm1;
        private SiticoneNetFrameworkUI.SiticoneCloseButton btnClose;
        private SiticoneNetFrameworkUI.SiticonePanel panelTextbox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblDescription;
        private RJCodeAdvance.RJControls.RJDatePicker dtpStartTime;
        private RJCodeAdvance.RJControls.RJDatePicker dtpEndTime;
        private RJCodeAdvance.RJControls.RJComboBox cmbPriority;
        private SiticoneNetFrameworkUI.SiticoneButton btnCancel;
        private SiticoneNetFrameworkUI.SiticoneButton btnAdd;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbEndMinute;
        private System.Windows.Forms.ComboBox cmbEndHour;
        private System.Windows.Forms.ComboBox cmbStartMinute;
        private System.Windows.Forms.ComboBox cmbStartHour;
        private FontAwesome.Sharp.IconButton btnTag;
    }
}
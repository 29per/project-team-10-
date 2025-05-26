namespace PlanEase.Views
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
            this.dtpStartTime = new RJCodeAdvance.RJControls.RJDatePicker();
            this.txtTitle = new SiticoneNetFrameworkUI.SiticoneTextBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpEndTime = new RJCodeAdvance.RJControls.RJDatePicker();
            this.txtTag = new SiticoneNetFrameworkUI.SiticoneTextBox();
            this.cmbPriority = new RJCodeAdvance.RJControls.RJComboBox();
            this.txtDescription = new SiticoneNetFrameworkUI.SiticoneTextArea();
            this.btnAdd = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnCancel = new SiticoneNetFrameworkUI.SiticoneButton();
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
            this.btnClose.Location = new System.Drawing.Point(567, -1);
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
            this.panelTextbox.Controls.Add(this.btnCancel);
            this.panelTextbox.Controls.Add(this.btnAdd);
            this.panelTextbox.Controls.Add(this.txtDescription);
            this.panelTextbox.Controls.Add(this.cmbPriority);
            this.panelTextbox.Controls.Add(this.txtTag);
            this.panelTextbox.Controls.Add(this.dtpEndTime);
            this.panelTextbox.Controls.Add(this.dtpStartTime);
            this.panelTextbox.Controls.Add(this.txtTitle);
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
            this.panelTextbox.Size = new System.Drawing.Size(600, 370);
            this.panelTextbox.TabIndex = 14;
            this.panelTextbox.TabStop = true;
            this.panelTextbox.TrackSystemTheme = false;
            this.panelTextbox.UseBorderGradient = false;
            this.panelTextbox.UseMultiGradient = false;
            this.panelTextbox.UsePatternTexture = false;
            this.panelTextbox.UseRadialGradient = false;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpStartTime.BorderSize = 3;
            this.dtpStartTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpStartTime.Font = new System.Drawing.Font("굴림", 9.5F);
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(168, 55);
            this.dtpStartTime.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(230, 25);
            this.dtpStartTime.SkinColor = System.Drawing.Color.Lavender;
            this.dtpStartTime.TabIndex = 17;
            this.dtpStartTime.TextColor = System.Drawing.Color.Black;
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dtpStartTime_ValueChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.AccessibleDescription = "A customizable text input field.";
            this.txtTitle.AccessibleName = "Text Box";
            this.txtTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtTitle.BlinkCount = 3;
            this.txtTitle.BlinkShadow = false;
            this.txtTitle.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.txtTitle.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.txtTitle.BorderFocusColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtTitle.BorderFocusColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtTitle.BorderSize = 2;
            this.txtTitle.CanShake = true;
            this.txtTitle.ContinuousBlink = false;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.CursorBlinkRate = 500;
            this.txtTitle.CursorColor = System.Drawing.Color.Black;
            this.txtTitle.CursorHeight = 26;
            this.txtTitle.CursorOffset = 0;
            this.txtTitle.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            this.txtTitle.CursorWidth = 1;
            this.txtTitle.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitle.DisabledBorderColor = System.Drawing.Color.LightGray;
            this.txtTitle.DisabledTextColor = System.Drawing.Color.Gray;
            this.txtTitle.EnableDropShadow = false;
            this.txtTitle.FillColor1 = System.Drawing.Color.White;
            this.txtTitle.FillColor2 = System.Drawing.Color.White;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTitle.HoverBorderColor1 = System.Drawing.Color.Gray;
            this.txtTitle.HoverBorderColor2 = System.Drawing.Color.Gray;
            this.txtTitle.IsEnabled = true;
            this.txtTitle.Location = new System.Drawing.Point(169, 18);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtTitle.PlaceholderText = "Enter text here...";
            this.txtTitle.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray;
            this.txtTitle.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray;
            this.txtTitle.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke;
            this.txtTitle.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke;
            this.txtTitle.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTitle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtTitle.ShadowAnimationDuration = 1;
            this.txtTitle.ShadowBlur = 10;
            this.txtTitle.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTitle.Size = new System.Drawing.Size(231, 25);
            this.txtTitle.SolidBorderColor = System.Drawing.Color.LightSlateGray;
            this.txtTitle.SolidBorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtTitle.SolidBorderHoverColor = System.Drawing.Color.Gray;
            this.txtTitle.SolidFillColor = System.Drawing.Color.White;
            this.txtTitle.TabIndex = 16;
            this.txtTitle.TextPadding = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.txtTitle.ValidationErrorMessage = "Invalid input.";
            this.txtTitle.ValidationFunction = null;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPriority.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPriority.Location = new System.Drawing.Point(83, 175);
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
            this.lblDescription.Location = new System.Drawing.Point(83, 208);
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
            this.lblTag.Location = new System.Drawing.Point(83, 139);
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
            this.lblEndTime.Location = new System.Drawing.Point(83, 101);
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
            this.lblStartTime.Location = new System.Drawing.Point(83, 60);
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
            this.lblTitle.Location = new System.Drawing.Point(83, 28);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "제목:";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpEndTime.BorderSize = 3;
            this.dtpEndTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpEndTime.Font = new System.Drawing.Font("굴림", 9.5F);
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(170, 96);
            this.dtpEndTime.MinimumSize = new System.Drawing.Size(4, 25);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(230, 25);
            this.dtpEndTime.SkinColor = System.Drawing.Color.Lavender;
            this.dtpEndTime.TabIndex = 18;
            this.dtpEndTime.TextColor = System.Drawing.Color.Black;
            // 
            // txtTag
            // 
            this.txtTag.AccessibleDescription = "A customizable text input field.";
            this.txtTag.AccessibleName = "Text Box";
            this.txtTag.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtTag.BackColor = System.Drawing.Color.Transparent;
            this.txtTag.BlinkCount = 3;
            this.txtTag.BlinkShadow = false;
            this.txtTag.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.txtTag.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.txtTag.BorderFocusColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtTag.BorderFocusColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtTag.BorderSize = 2;
            this.txtTag.CanShake = true;
            this.txtTag.ContinuousBlink = false;
            this.txtTag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTag.CursorBlinkRate = 500;
            this.txtTag.CursorColor = System.Drawing.Color.Black;
            this.txtTag.CursorHeight = 26;
            this.txtTag.CursorOffset = 0;
            this.txtTag.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            this.txtTag.CursorWidth = 1;
            this.txtTag.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTag.DisabledBorderColor = System.Drawing.Color.LightGray;
            this.txtTag.DisabledTextColor = System.Drawing.Color.Gray;
            this.txtTag.EnableDropShadow = false;
            this.txtTag.FillColor1 = System.Drawing.Color.White;
            this.txtTag.FillColor2 = System.Drawing.Color.White;
            this.txtTag.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTag.HoverBorderColor1 = System.Drawing.Color.Gray;
            this.txtTag.HoverBorderColor2 = System.Drawing.Color.Gray;
            this.txtTag.IsEnabled = true;
            this.txtTag.Location = new System.Drawing.Point(168, 130);
            this.txtTag.Name = "txtTag";
            this.txtTag.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtTag.PlaceholderText = "Enter text here...";
            this.txtTag.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray;
            this.txtTag.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray;
            this.txtTag.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke;
            this.txtTag.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke;
            this.txtTag.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTag.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtTag.ShadowAnimationDuration = 1;
            this.txtTag.ShadowBlur = 10;
            this.txtTag.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTag.Size = new System.Drawing.Size(231, 25);
            this.txtTag.SolidBorderColor = System.Drawing.Color.LightSlateGray;
            this.txtTag.SolidBorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtTag.SolidBorderHoverColor = System.Drawing.Color.Gray;
            this.txtTag.SolidFillColor = System.Drawing.Color.White;
            this.txtTag.TabIndex = 19;
            this.txtTag.TextPadding = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.txtTag.ValidationErrorMessage = "Invalid input.";
            this.txtTag.ValidationFunction = null;
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
            this.cmbPriority.Location = new System.Drawing.Point(167, 166);
            this.cmbPriority.MinimumSize = new System.Drawing.Size(200, 25);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Padding = new System.Windows.Forms.Padding(1);
            this.cmbPriority.Size = new System.Drawing.Size(231, 25);
            this.cmbPriority.TabIndex = 20;
            this.cmbPriority.Texts = "";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtDescription.Location = new System.Drawing.Point(167, 208);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescription.MinimumSize = new System.Drawing.Size(100, 70);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(231, 70);
            this.txtDescription.TabIndex = 21;
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
            this.btnAdd.Location = new System.Drawing.Point(167, 296);
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
            this.btnAdd.Size = new System.Drawing.Size(98, 39);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "확인";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.TooltipText = null;
            this.btnAdd.UseAdvancedRendering = true;
            this.btnAdd.UseParticles = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(300, 296);
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
            this.btnCancel.Size = new System.Drawing.Size(98, 39);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.TooltipText = null;
            this.btnCancel.UseAdvancedRendering = true;
            this.btnCancel.UseParticles = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddScheduleForm_new_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
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
        private SiticoneNetFrameworkUI.SiticoneTextBox txtTitle;
        private RJCodeAdvance.RJControls.RJDatePicker dtpStartTime;
        private RJCodeAdvance.RJControls.RJDatePicker dtpEndTime;
        private SiticoneNetFrameworkUI.SiticoneTextArea txtDescription;
        private RJCodeAdvance.RJControls.RJComboBox cmbPriority;
        private SiticoneNetFrameworkUI.SiticoneTextBox txtTag;
        private SiticoneNetFrameworkUI.SiticoneButton btnCancel;
        private SiticoneNetFrameworkUI.SiticoneButton btnAdd;
    }
}
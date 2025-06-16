namespace PlanEase.Views
{
    partial class ConflictResolutionForm
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
            this.siticoneBorderlessForm1 = new SiticoneNetFrameworkUI.SiticoneBorderlessForm(this.components);
            this.panelMain = new SiticoneNetFrameworkUI.SiticonePanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpStrategy = new System.Windows.Forms.GroupBox();
            this.radioChangeTime = new SiticoneNetFrameworkUI.SiticoneRadioButton();
            this.radioMerge = new SiticoneNetFrameworkUI.SiticoneRadioButton();
            this.radioDelete = new SiticoneNetFrameworkUI.SiticoneRadioButton();
            this.btnOk = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnCancel = new SiticoneNetFrameworkUI.SiticoneButton();
            this.panelMain.SuspendLayout();
            this.grpStrategy.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.NavBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneBorderlessForm1.NavBarHeight = 30;
            this.siticoneBorderlessForm1.TargetForm = this;
            // 
            // panelMain
            // 
            this.panelMain.AcrylicTintColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            this.panelMain.BorderDashPattern = null;
            this.panelMain.BorderGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panelMain.BorderGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panelMain.BorderThickness = 2F;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.grpStrategy);
            this.panelMain.Controls.Add(this.btnOk);
            this.panelMain.Controls.Add(this.btnCancel);
            this.panelMain.CornerRadiusBottomLeft = 0F;
            this.panelMain.CornerRadiusBottomRight = 0F;
            this.panelMain.CornerRadiusTopLeft = 0F;
            this.panelMain.CornerRadiusTopRight = 0F;
            this.panelMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMain.EnableAcrylicEffect = false;
            this.panelMain.EnableMicaEffect = false;
            this.panelMain.EnableRippleEffect = false;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelMain.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panelMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMain.GradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.Gray};
            this.panelMain.GradientPositions = new float[] {
        0F,
        0.5F,
        1F};
            this.panelMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelMain.Location = new System.Drawing.Point(0, 22);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.PatternStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid;
            this.panelMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelMain.RippleAlpha = 50;
            this.panelMain.RippleAlphaDecrement = 3;
            this.panelMain.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelMain.RippleMaxSize = 600F;
            this.panelMain.RippleSpeed = 15F;
            this.panelMain.ShowBorder = true;
            this.panelMain.Size = new System.Drawing.Size(725, 330);
            this.panelMain.TabIndex = 0;
            this.panelMain.TabStop = true;
            this.panelMain.TrackSystemTheme = false;
            this.panelMain.UseBorderGradient = true;
            this.panelMain.UseMultiGradient = false;
            this.panelMain.UsePatternTexture = false;
            this.panelMain.UseRadialGradient = false;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(44, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "일정 충돌 해결 방법을 선택하세요";
            // 
            // grpStrategy
            // 
            this.grpStrategy.BackColor = System.Drawing.Color.Transparent;
            this.grpStrategy.Controls.Add(this.radioChangeTime);
            this.grpStrategy.Controls.Add(this.radioMerge);
            this.grpStrategy.Controls.Add(this.radioDelete);
            this.grpStrategy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpStrategy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpStrategy.Location = new System.Drawing.Point(44, 75);
            this.grpStrategy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStrategy.Name = "grpStrategy";
            this.grpStrategy.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStrategy.Size = new System.Drawing.Size(656, 95);
            this.grpStrategy.TabIndex = 1;
            this.grpStrategy.TabStop = false;
            this.grpStrategy.Text = "해결 전략";
            // 
            // radioChangeTime
            // 
            this.radioChangeTime.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.radioChangeTime.BackColor = System.Drawing.Color.Transparent;
            this.radioChangeTime.CanBeep = true;
            this.radioChangeTime.CanShake = true;
            this.radioChangeTime.Checked = false;
            this.radioChangeTime.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.radioChangeTime.ContainerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioChangeTime.ContainerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioChangeTime.ContainerBorderWidth = 1;
            this.radioChangeTime.ContainerBottomLeftRadius = 8;
            this.radioChangeTime.ContainerBottomRightRadius = 8;
            this.radioChangeTime.ContainerCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioChangeTime.ContainerCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioChangeTime.ContainerCheckedHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioChangeTime.ContainerCheckedPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioChangeTime.ContainerHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioChangeTime.ContainerPadding = 8;
            this.radioChangeTime.ContainerPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioChangeTime.ContainerTopLeftRadius = 8;
            this.radioChangeTime.ContainerTopRightRadius = 8;
            this.radioChangeTime.EnableRipple = false;
            this.radioChangeTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radioChangeTime.HoverCursor = System.Windows.Forms.Cursors.Hand;
            this.radioChangeTime.IsContained = false;
            this.radioChangeTime.IsReadOnly = false;
            this.radioChangeTime.Location = new System.Drawing.Point(22, 41);
            this.radioChangeTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioChangeTime.MinimumSize = new System.Drawing.Size(178, 24);
            this.radioChangeTime.Name = "radioChangeTime";
            this.radioChangeTime.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.radioChangeTime.RippleDuration = 0.5F;
            this.radioChangeTime.RippleStyle = SiticoneNetFrameworkUI.SiticoneRadioButton.RippleAnimationStyle.Standard;
            this.radioChangeTime.ShakeDuration = 0.5F;
            this.radioChangeTime.Size = new System.Drawing.Size(178, 24);
            this.radioChangeTime.TabIndex = 0;
            this.radioChangeTime.Text = "시간 변경";
            this.radioChangeTime.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.radioChangeTime.ToolTipText = "";
            this.radioChangeTime.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            // 
            // radioMerge
            // 
            this.radioMerge.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.radioMerge.BackColor = System.Drawing.Color.Transparent;
            this.radioMerge.CanBeep = true;
            this.radioMerge.CanShake = true;
            this.radioMerge.Checked = false;
            this.radioMerge.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.radioMerge.ContainerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioMerge.ContainerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioMerge.ContainerBorderWidth = 1;
            this.radioMerge.ContainerBottomLeftRadius = 8;
            this.radioMerge.ContainerBottomRightRadius = 8;
            this.radioMerge.ContainerCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioMerge.ContainerCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioMerge.ContainerCheckedHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioMerge.ContainerCheckedPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioMerge.ContainerHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioMerge.ContainerPadding = 8;
            this.radioMerge.ContainerPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioMerge.ContainerTopLeftRadius = 8;
            this.radioMerge.ContainerTopRightRadius = 8;
            this.radioMerge.EnableRipple = false;
            this.radioMerge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radioMerge.HoverCursor = System.Windows.Forms.Cursors.Hand;
            this.radioMerge.IsContained = false;
            this.radioMerge.IsReadOnly = false;
            this.radioMerge.Location = new System.Drawing.Point(206, 41);
            this.radioMerge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioMerge.MinimumSize = new System.Drawing.Size(178, 24);
            this.radioMerge.Name = "radioMerge";
            this.radioMerge.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.radioMerge.RippleDuration = 0.5F;
            this.radioMerge.RippleStyle = SiticoneNetFrameworkUI.SiticoneRadioButton.RippleAnimationStyle.Standard;
            this.radioMerge.ShakeDuration = 0.5F;
            this.radioMerge.Size = new System.Drawing.Size(178, 24);
            this.radioMerge.TabIndex = 1;
            this.radioMerge.Text = "병합";
            this.radioMerge.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.radioMerge.ToolTipText = "";
            this.radioMerge.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            // 
            // radioDelete
            // 
            this.radioDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.radioDelete.BackColor = System.Drawing.Color.Transparent;
            this.radioDelete.CanBeep = true;
            this.radioDelete.CanShake = true;
            this.radioDelete.Checked = false;
            this.radioDelete.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.radioDelete.ContainerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioDelete.ContainerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioDelete.ContainerBorderWidth = 1;
            this.radioDelete.ContainerBottomLeftRadius = 8;
            this.radioDelete.ContainerBottomRightRadius = 8;
            this.radioDelete.ContainerCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioDelete.ContainerCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioDelete.ContainerCheckedHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioDelete.ContainerCheckedPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radioDelete.ContainerHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioDelete.ContainerPadding = 8;
            this.radioDelete.ContainerPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.radioDelete.ContainerTopLeftRadius = 8;
            this.radioDelete.ContainerTopRightRadius = 8;
            this.radioDelete.EnableRipple = false;
            this.radioDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radioDelete.HoverCursor = System.Windows.Forms.Cursors.Hand;
            this.radioDelete.IsContained = false;
            this.radioDelete.IsReadOnly = false;
            this.radioDelete.Location = new System.Drawing.Point(390, 41);
            this.radioDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioDelete.MinimumSize = new System.Drawing.Size(178, 24);
            this.radioDelete.Name = "radioDelete";
            this.radioDelete.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.radioDelete.RippleDuration = 0.5F;
            this.radioDelete.RippleStyle = SiticoneNetFrameworkUI.SiticoneRadioButton.RippleAnimationStyle.Standard;
            this.radioDelete.ShakeDuration = 0.5F;
            this.radioDelete.Size = new System.Drawing.Size(178, 24);
            this.radioDelete.TabIndex = 2;
            this.radioDelete.Text = "삭제";
            this.radioDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.radioDelete.ToolTipText = "";
            this.radioDelete.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.radioDelete.Click += new System.EventHandler(this.radioDelete_Click);
            // 
            // btnOk
            // 
            this.btnOk.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnOk.AccessibleName = "확인";
            this.btnOk.AutoSizeBasedOnText = false;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BadgeBackColor = System.Drawing.Color.Black;
            this.btnOk.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnOk.BadgeValue = 0;
            this.btnOk.BadgeValueForeColor = System.Drawing.Color.White;
            this.btnOk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOk.BorderWidth = 2;
            this.btnOk.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnOk.ButtonImage = null;
            this.btnOk.ButtonTextLeftPadding = 0;
            this.btnOk.CanBeep = true;
            this.btnOk.CanGlow = false;
            this.btnOk.CanShake = true;
            this.btnOk.ContextMenuStripEx = null;
            this.btnOk.CornerRadiusBottomLeft = 5;
            this.btnOk.CornerRadiusBottomRight = 5;
            this.btnOk.CornerRadiusTopLeft = 5;
            this.btnOk.CornerRadiusTopRight = 5;
            this.btnOk.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnOk.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnOk.EnableLongPress = false;
            this.btnOk.EnablePressAnimation = true;
            this.btnOk.EnableRippleEffect = true;
            this.btnOk.EnableShadow = false;
            this.btnOk.EnableTextWrapping = false;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnOk.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOk.GlowIntensity = 100;
            this.btnOk.GlowRadius = 20F;
            this.btnOk.GradientBackground = false;
            this.btnOk.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnOk.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnOk.HintText = null;
            this.btnOk.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOk.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnOk.HoverTextColor = System.Drawing.Color.White;
            this.btnOk.HoverTransitionDuration = 250;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.ImagePadding = 5;
            this.btnOk.ImageSize = new System.Drawing.Size(16, 16);
            this.btnOk.IsRadial = false;
            this.btnOk.IsReadOnly = false;
            this.btnOk.IsToggleButton = false;
            this.btnOk.IsToggled = false;
            this.btnOk.Location = new System.Drawing.Point(349, 270);
            this.btnOk.LongPressDurationMS = 1000;
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnOk.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnOk.ParticleCount = 15;
            this.btnOk.PressAnimationScale = 0.97F;
            this.btnOk.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnOk.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnOk.PressTransitionDuration = 150;
            this.btnOk.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnOk.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOk.RippleOpacity = 0.3F;
            this.btnOk.RippleRadiusMultiplier = 0.6F;
            this.btnOk.ShadowBlur = 5;
            this.btnOk.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOk.ShadowOffset = new System.Drawing.Point(2, 2);
            this.btnOk.ShakeDuration = 500;
            this.btnOk.ShakeIntensity = 5;
            this.btnOk.Size = new System.Drawing.Size(96, 38);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "확인";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.TextColor = System.Drawing.Color.White;
            this.btnOk.TooltipText = null;
            this.btnOk.UseAdvancedRendering = true;
            this.btnOk.UseParticles = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnCancel.AccessibleName = "취소";
            this.btnCancel.AutoSizeBasedOnText = false;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BadgeBackColor = System.Drawing.Color.Black;
            this.btnCancel.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.BadgeValue = 0;
            this.btnCancel.BadgeValueForeColor = System.Drawing.Color.White;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancel.BorderWidth = 2;
            this.btnCancel.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.btnCancel.ButtonImage = null;
            this.btnCancel.ButtonTextLeftPadding = 0;
            this.btnCancel.CanBeep = true;
            this.btnCancel.CanGlow = false;
            this.btnCancel.CanShake = true;
            this.btnCancel.ContextMenuStripEx = null;
            this.btnCancel.CornerRadiusBottomLeft = 5;
            this.btnCancel.CornerRadiusBottomRight = 5;
            this.btnCancel.CornerRadiusTopLeft = 5;
            this.btnCancel.CornerRadiusTopRight = 5;
            this.btnCancel.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnCancel.EnableLongPress = false;
            this.btnCancel.EnablePressAnimation = true;
            this.btnCancel.EnableRippleEffect = true;
            this.btnCancel.EnableShadow = false;
            this.btnCancel.EnableTextWrapping = false;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.btnCancel.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.GlowIntensity = 100;
            this.btnCancel.GlowRadius = 20F;
            this.btnCancel.GradientBackground = false;
            this.btnCancel.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCancel.HintText = null;
            this.btnCancel.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.btnCancel.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnCancel.HoverTextColor = System.Drawing.Color.White;
            this.btnCancel.HoverTransitionDuration = 250;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImagePadding = 5;
            this.btnCancel.ImageSize = new System.Drawing.Size(16, 16);
            this.btnCancel.IsRadial = false;
            this.btnCancel.IsReadOnly = false;
            this.btnCancel.IsToggleButton = false;
            this.btnCancel.IsToggled = false;
            this.btnCancel.Location = new System.Drawing.Point(467, 270);
            this.btnCancel.LongPressDurationMS = 1000;
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnCancel.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCancel.ParticleCount = 15;
            this.btnCancel.PressAnimationScale = 0.97F;
            this.btnCancel.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnCancel.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnCancel.PressTransitionDuration = 150;
            this.btnCancel.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnCancel.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.RippleOpacity = 0.3F;
            this.btnCancel.RippleRadiusMultiplier = 0.6F;
            this.btnCancel.ShadowBlur = 5;
            this.btnCancel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.ShadowOffset = new System.Drawing.Point(2, 2);
            this.btnCancel.ShakeDuration = 500;
            this.btnCancel.ShakeIntensity = 5;
            this.btnCancel.Size = new System.Drawing.Size(96, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.TooltipText = null;
            this.btnCancel.UseAdvancedRendering = true;
            this.btnCancel.UseParticles = false;
            // 
            // ConflictResolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 351);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConflictResolutionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "일정 충돌 해결";
            this.Load += new System.EventHandler(this.ConflictResolutionForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.grpStrategy.ResumeLayout(false);
            this.grpStrategy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneBorderlessForm siticoneBorderlessForm1;
        private SiticoneNetFrameworkUI.SiticonePanel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpStrategy;
        private SiticoneNetFrameworkUI.SiticoneRadioButton radioChangeTime;
        private SiticoneNetFrameworkUI.SiticoneRadioButton radioMerge;
        private SiticoneNetFrameworkUI.SiticoneRadioButton radioDelete;
        private SiticoneNetFrameworkUI.SiticoneButton btnOk;
        private SiticoneNetFrameworkUI.SiticoneButton btnCancel;
    }
}
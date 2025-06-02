namespace PlanEase.Views.panelDesktop
{
    partial class SettingControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.chkAutoResolve = new SiticoneNetFrameworkUI.SiticoneCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTheme = new RJCodeAdvance.RJControls.RJComboBox();
            this.rdoAskUser = new SiticoneNetFrameworkUI.SiticoneRadioButton();
            this.rdoCheckTime = new SiticoneNetFrameworkUI.SiticoneRadioButton();
            this.rdoMerege = new SiticoneNetFrameworkUI.SiticoneRadioButton();
            this.rdoDelete = new SiticoneNetFrameworkUI.SiticoneRadioButton();
            this.siticoneGroupBox1 = new SiticoneNetFrameworkUI.SiticoneGroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnReset = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.siticoneGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른펜", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(50, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "알정 중복 시 자동 해결 여부";
            // 
            // chkAutoResolve
            // 
            this.chkAutoResolve.AccessibleName = "지동 처리";
            this.chkAutoResolve.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.chkAutoResolve.AllowIndeterminate = false;
            this.chkAutoResolve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoResolve.BackColor = System.Drawing.Color.Transparent;
            this.chkAutoResolve.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.chkAutoResolve.BorderWidth = 2;
            this.chkAutoResolve.BottomLeftRadius = 5;
            this.chkAutoResolve.BottomRightRadius = 5;
            this.chkAutoResolve.CanBeep = true;
            this.chkAutoResolve.CanShake = true;
            this.chkAutoResolve.CheckBoxSize = 20;
            this.chkAutoResolve.Checked = false;
            this.chkAutoResolve.CheckedBackColor = System.Drawing.Color.MediumSlateBlue;
            this.chkAutoResolve.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkAutoResolve.CheckmarkColor = System.Drawing.Color.White;
            this.chkAutoResolve.CheckState = SiticoneNetFrameworkUI.CheckState.Unchecked;
            this.chkAutoResolve.ContainerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkAutoResolve.ContainerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkAutoResolve.ContainerBorderWidth = 1;
            this.chkAutoResolve.ContainerBottomLeftRadius = 8;
            this.chkAutoResolve.ContainerBottomRightRadius = 8;
            this.chkAutoResolve.ContainerCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkAutoResolve.ContainerCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkAutoResolve.ContainerCheckedHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkAutoResolve.ContainerCheckedPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkAutoResolve.ContainerHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkAutoResolve.ContainerPadding = 8;
            this.chkAutoResolve.ContainerPressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkAutoResolve.ContainerTopLeftRadius = 8;
            this.chkAutoResolve.ContainerTopRightRadius = 8;
            this.chkAutoResolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAutoResolve.EnableRippleEffect = true;
            this.chkAutoResolve.FocusBorderWidth = 2;
            this.chkAutoResolve.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.chkAutoResolve.Font = new System.Drawing.Font("나눔바른펜", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkAutoResolve.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkAutoResolve.HoverBackColor = System.Drawing.Color.Gainsboro;
            this.chkAutoResolve.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.chkAutoResolve.IndeterminateColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.chkAutoResolve.IsContained = false;
            this.chkAutoResolve.IsReadOnly = false;
            this.chkAutoResolve.Location = new System.Drawing.Point(270, 107);
            this.chkAutoResolve.MinimumSize = new System.Drawing.Size(178, 24);
            this.chkAutoResolve.Name = "chkAutoResolve";
            this.chkAutoResolve.PressedBackColor = System.Drawing.Color.DarkGray;
            this.chkAutoResolve.ShowFocusCue = false;
            this.chkAutoResolve.Size = new System.Drawing.Size(178, 44);
            this.chkAutoResolve.Style = SiticoneNetFrameworkUI.CheckBoxStyle.Material;
            this.chkAutoResolve.SwitchCheckedTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkAutoResolve.SwitchTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkAutoResolve.TabIndex = 2;
            this.chkAutoResolve.Text = "지동 처리";
            this.chkAutoResolve.TopLeftRadius = 5;
            this.chkAutoResolve.TopRightRadius = 5;
            this.chkAutoResolve.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.chkAutoResolve.Click += new System.EventHandler(this.chkAutoResolve_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른펜", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(50, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "일정 중복 해결 방법";
            // 
            // cmbTheme
            // 
            this.cmbTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTheme.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTheme.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTheme.BorderSize = 2;
            this.cmbTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTheme.Font = new System.Drawing.Font("굴림", 10F);
            this.cmbTheme.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTheme.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbTheme.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTheme.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbTheme.Location = new System.Drawing.Point(54, 356);
            this.cmbTheme.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Padding = new System.Windows.Forms.Padding(2);
            this.cmbTheme.Size = new System.Drawing.Size(289, 33);
            this.cmbTheme.TabIndex = 4;
            this.cmbTheme.Texts = "";
            // 
            // rdoAskUser
            // 
            this.rdoAskUser.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.rdoAskUser.BackColor = System.Drawing.Color.Transparent;
            this.rdoAskUser.CanBeep = true;
            this.rdoAskUser.CanShake = true;
            this.rdoAskUser.Checked = false;
            this.rdoAskUser.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.rdoAskUser.ContainerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoAskUser.ContainerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoAskUser.ContainerBorderWidth = 1;
            this.rdoAskUser.ContainerBottomLeftRadius = 8;
            this.rdoAskUser.ContainerBottomRightRadius = 8;
            this.rdoAskUser.ContainerCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoAskUser.ContainerCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoAskUser.ContainerCheckedHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoAskUser.ContainerCheckedPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoAskUser.ContainerHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoAskUser.ContainerPadding = 8;
            this.rdoAskUser.ContainerPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoAskUser.ContainerTopLeftRadius = 8;
            this.rdoAskUser.ContainerTopRightRadius = 8;
            this.rdoAskUser.EnableRipple = false;
            this.rdoAskUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoAskUser.HoverCursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAskUser.IsContained = false;
            this.rdoAskUser.IsReadOnly = false;
            this.rdoAskUser.Location = new System.Drawing.Point(14, 46);
            this.rdoAskUser.MinimumSize = new System.Drawing.Size(178, 24);
            this.rdoAskUser.Name = "rdoAskUser";
            this.rdoAskUser.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.rdoAskUser.RippleDuration = 0.5F;
            this.rdoAskUser.RippleStyle = SiticoneNetFrameworkUI.SiticoneRadioButton.RippleAnimationStyle.Standard;
            this.rdoAskUser.ShakeDuration = 0.5F;
            this.rdoAskUser.Size = new System.Drawing.Size(178, 43);
            this.rdoAskUser.TabIndex = 5;
            this.rdoAskUser.Text = "사용자에게 물어보기";
            this.rdoAskUser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rdoAskUser.ToolTipText = "";
            this.rdoAskUser.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            // 
            // rdoCheckTime
            // 
            this.rdoCheckTime.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.rdoCheckTime.BackColor = System.Drawing.Color.Transparent;
            this.rdoCheckTime.CanBeep = true;
            this.rdoCheckTime.CanShake = true;
            this.rdoCheckTime.Checked = false;
            this.rdoCheckTime.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.rdoCheckTime.ContainerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoCheckTime.ContainerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoCheckTime.ContainerBorderWidth = 1;
            this.rdoCheckTime.ContainerBottomLeftRadius = 8;
            this.rdoCheckTime.ContainerBottomRightRadius = 8;
            this.rdoCheckTime.ContainerCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoCheckTime.ContainerCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoCheckTime.ContainerCheckedHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoCheckTime.ContainerCheckedPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoCheckTime.ContainerHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoCheckTime.ContainerPadding = 8;
            this.rdoCheckTime.ContainerPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoCheckTime.ContainerTopLeftRadius = 8;
            this.rdoCheckTime.ContainerTopRightRadius = 8;
            this.rdoCheckTime.EnableRipple = false;
            this.rdoCheckTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoCheckTime.HoverCursor = System.Windows.Forms.Cursors.Hand;
            this.rdoCheckTime.IsContained = false;
            this.rdoCheckTime.IsReadOnly = false;
            this.rdoCheckTime.Location = new System.Drawing.Point(208, 55);
            this.rdoCheckTime.MinimumSize = new System.Drawing.Size(178, 24);
            this.rdoCheckTime.Name = "rdoCheckTime";
            this.rdoCheckTime.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.rdoCheckTime.RippleDuration = 0.5F;
            this.rdoCheckTime.RippleStyle = SiticoneNetFrameworkUI.SiticoneRadioButton.RippleAnimationStyle.Standard;
            this.rdoCheckTime.ShakeDuration = 0.5F;
            this.rdoCheckTime.Size = new System.Drawing.Size(178, 24);
            this.rdoCheckTime.TabIndex = 6;
            this.rdoCheckTime.Text = "시간 변경";
            this.rdoCheckTime.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rdoCheckTime.ToolTipText = "";
            this.rdoCheckTime.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            // 
            // rdoMerege
            // 
            this.rdoMerege.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.rdoMerege.BackColor = System.Drawing.Color.Transparent;
            this.rdoMerege.CanBeep = true;
            this.rdoMerege.CanShake = true;
            this.rdoMerege.Checked = false;
            this.rdoMerege.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.rdoMerege.ContainerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoMerege.ContainerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoMerege.ContainerBorderWidth = 1;
            this.rdoMerege.ContainerBottomLeftRadius = 8;
            this.rdoMerege.ContainerBottomRightRadius = 8;
            this.rdoMerege.ContainerCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoMerege.ContainerCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoMerege.ContainerCheckedHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoMerege.ContainerCheckedPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoMerege.ContainerHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoMerege.ContainerPadding = 8;
            this.rdoMerege.ContainerPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoMerege.ContainerTopLeftRadius = 8;
            this.rdoMerege.ContainerTopRightRadius = 8;
            this.rdoMerege.EnableRipple = false;
            this.rdoMerege.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoMerege.HoverCursor = System.Windows.Forms.Cursors.Hand;
            this.rdoMerege.IsContained = false;
            this.rdoMerege.IsReadOnly = false;
            this.rdoMerege.Location = new System.Drawing.Point(392, 55);
            this.rdoMerege.MinimumSize = new System.Drawing.Size(178, 24);
            this.rdoMerege.Name = "rdoMerege";
            this.rdoMerege.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.rdoMerege.RippleDuration = 0.5F;
            this.rdoMerege.RippleStyle = SiticoneNetFrameworkUI.SiticoneRadioButton.RippleAnimationStyle.Standard;
            this.rdoMerege.ShakeDuration = 0.5F;
            this.rdoMerege.Size = new System.Drawing.Size(178, 24);
            this.rdoMerege.TabIndex = 7;
            this.rdoMerege.Text = "병합";
            this.rdoMerege.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rdoMerege.ToolTipText = "";
            this.rdoMerege.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            // 
            // rdoDelete
            // 
            this.rdoDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.rdoDelete.BackColor = System.Drawing.Color.Transparent;
            this.rdoDelete.CanBeep = true;
            this.rdoDelete.CanShake = true;
            this.rdoDelete.Checked = false;
            this.rdoDelete.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.rdoDelete.ContainerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoDelete.ContainerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoDelete.ContainerBorderWidth = 1;
            this.rdoDelete.ContainerBottomLeftRadius = 8;
            this.rdoDelete.ContainerBottomRightRadius = 8;
            this.rdoDelete.ContainerCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoDelete.ContainerCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoDelete.ContainerCheckedHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoDelete.ContainerCheckedPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rdoDelete.ContainerHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoDelete.ContainerPadding = 8;
            this.rdoDelete.ContainerPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdoDelete.ContainerTopLeftRadius = 8;
            this.rdoDelete.ContainerTopRightRadius = 8;
            this.rdoDelete.EnableRipple = false;
            this.rdoDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoDelete.HoverCursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDelete.IsContained = false;
            this.rdoDelete.IsReadOnly = false;
            this.rdoDelete.Location = new System.Drawing.Point(576, 55);
            this.rdoDelete.MinimumSize = new System.Drawing.Size(178, 24);
            this.rdoDelete.Name = "rdoDelete";
            this.rdoDelete.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.rdoDelete.RippleDuration = 0.5F;
            this.rdoDelete.RippleStyle = SiticoneNetFrameworkUI.SiticoneRadioButton.RippleAnimationStyle.Standard;
            this.rdoDelete.ShakeDuration = 0.5F;
            this.rdoDelete.Size = new System.Drawing.Size(178, 24);
            this.rdoDelete.TabIndex = 8;
            this.rdoDelete.Text = "삭제";
            this.rdoDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rdoDelete.ToolTipText = "";
            this.rdoDelete.UncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox1.BadgeColor = System.Drawing.Color.Red;
            this.siticoneGroupBox1.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.siticoneGroupBox1.BadgeLeftPadding = 12;
            this.siticoneGroupBox1.BadgeValue = 0;
            this.siticoneGroupBox1.BadgeVisible = false;
            this.siticoneGroupBox1.BlinkInterval = 500;
            this.siticoneGroupBox1.BlinkMinOpacity = 0.3F;
            this.siticoneGroupBox1.BlinkOpacityStep = 0.05F;
            this.siticoneGroupBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.siticoneGroupBox1.BorderWidth = 2F;
            this.siticoneGroupBox1.CanHover = true;
            this.siticoneGroupBox1.ChevronColor = System.Drawing.Color.MediumSlateBlue;
            this.siticoneGroupBox1.ChevronLeftSpacing = 4F;
            this.siticoneGroupBox1.ChevronSize = 10F;
            this.siticoneGroupBox1.ChevronThickness = 2F;
            this.siticoneGroupBox1.ContentPadding = 5;
            this.siticoneGroupBox1.Controls.Add(this.rdoAskUser);
            this.siticoneGroupBox1.Controls.Add(this.rdoDelete);
            this.siticoneGroupBox1.Controls.Add(this.rdoCheckTime);
            this.siticoneGroupBox1.Controls.Add(this.rdoMerege);
            this.siticoneGroupBox1.CornerRadius = 0;
            this.siticoneGroupBox1.EnableBlinking = false;
            this.siticoneGroupBox1.EnableHoverAnimation = true;
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneGroupBox1.GradientEndColor = System.Drawing.Color.LightGray;
            this.siticoneGroupBox1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneGroupBox1.GradientStartColor = System.Drawing.Color.White;
            this.siticoneGroupBox1.GroupTitle = "Default strategy";
            this.siticoneGroupBox1.HoveredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.siticoneGroupBox1.HoveredTitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.siticoneGroupBox1.IsCollapsed = false;
            this.siticoneGroupBox1.IsCollapsible = true;
            this.siticoneGroupBox1.Location = new System.Drawing.Point(54, 196);
            this.siticoneGroupBox1.MaxBlinkCount = 3;
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.siticoneGroupBox1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneGroupBox1.ShadowDepth = 3;
            this.siticoneGroupBox1.ShowShadow = true;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(677, 102);
            this.siticoneGroupBox1.SolidFillColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneGroupBox1.StatusIcon = null;
            this.siticoneGroupBox1.StatusText = "";
            this.siticoneGroupBox1.TabIndex = 9;
            this.siticoneGroupBox1.Text = "siticoneGroupBox1";
            this.siticoneGroupBox1.TitleBackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox1.TitleColor = System.Drawing.Color.RoyalBlue;
            this.siticoneGroupBox1.TitlePadding = new System.Windows.Forms.Padding(0, 8, 0, 12);
            this.siticoneGroupBox1.TitlePos = SiticoneNetFrameworkUI.TitlePosition.TopLeft;
            this.siticoneGroupBox1.UseGradient = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른펜", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(50, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "테마 선택";
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
            this.btnSave.GlowColor = System.Drawing.Color.MediumSpringGreen;
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
            this.btnSave.Location = new System.Drawing.Point(233, 437);
            this.btnSave.LongPressDurationMS = 1000;
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
            this.btnSave.Size = new System.Drawing.Size(110, 45);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "저장";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.TooltipText = null;
            this.btnSave.UseAdvancedRendering = true;
            this.btnSave.UseParticles = false;
            // 
            // btnReset
            // 
            this.btnReset.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnReset.AccessibleName = "기본 값 복원";
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.AutoSizeBasedOnText = false;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BadgeBackColor = System.Drawing.Color.Black;
            this.btnReset.BadgeFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.BadgeValue = 0;
            this.btnReset.BadgeValueForeColor = System.Drawing.Color.White;
            this.btnReset.BorderColor = System.Drawing.Color.Lavender;
            this.btnReset.BorderWidth = 2;
            this.btnReset.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.btnReset.ButtonImage = null;
            this.btnReset.ButtonTextLeftPadding = 0;
            this.btnReset.CanBeep = true;
            this.btnReset.CanGlow = true;
            this.btnReset.CanShake = true;
            this.btnReset.ContextMenuStripEx = null;
            this.btnReset.CornerRadiusBottomLeft = 15;
            this.btnReset.CornerRadiusBottomRight = 15;
            this.btnReset.CornerRadiusTopLeft = 15;
            this.btnReset.CornerRadiusTopRight = 15;
            this.btnReset.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnReset.EnableLongPress = false;
            this.btnReset.EnablePressAnimation = true;
            this.btnReset.EnableRippleEffect = false;
            this.btnReset.EnableShadow = true;
            this.btnReset.EnableTextWrapping = false;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReset.GlowIntensity = 100;
            this.btnReset.GlowRadius = 20F;
            this.btnReset.GradientBackground = true;
            this.btnReset.GradientColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReset.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnReset.HintText = null;
            this.btnReset.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.btnReset.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnReset.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.btnReset.HoverTransitionDuration = 250;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.ImagePadding = 5;
            this.btnReset.ImageSize = new System.Drawing.Size(16, 16);
            this.btnReset.IsRadial = false;
            this.btnReset.IsReadOnly = false;
            this.btnReset.IsToggleButton = false;
            this.btnReset.IsToggled = false;
            this.btnReset.Location = new System.Drawing.Point(475, 437);
            this.btnReset.LongPressDurationMS = 1000;
            this.btnReset.Name = "btnReset";
            this.btnReset.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnReset.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnReset.ParticleCount = 15;
            this.btnReset.PressAnimationScale = 0.97F;
            this.btnReset.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnReset.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnReset.PressTransitionDuration = 150;
            this.btnReset.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnReset.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReset.RippleOpacity = 0.3F;
            this.btnReset.RippleRadiusMultiplier = 0.6F;
            this.btnReset.ShadowBlur = 6;
            this.btnReset.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnReset.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnReset.ShakeDuration = 500;
            this.btnReset.ShakeIntensity = 5;
            this.btnReset.Size = new System.Drawing.Size(110, 45);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "기본 값 복원";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.TooltipText = null;
            this.btnReset.UseAdvancedRendering = true;
            this.btnReset.UseParticles = false;
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSetting.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 32;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(339, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSetting.Size = new System.Drawing.Size(180, 72);
            this.btnSetting.TabIndex = 25;
            this.btnSetting.Text = "Settting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // SettingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Controls.Add(this.cmbTheme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkAutoResolve);
            this.Controls.Add(this.label1);
            this.Name = "SettingControl";
            this.Size = new System.Drawing.Size(844, 530);
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private SiticoneNetFrameworkUI.SiticoneCheckBox chkAutoResolve;
        private System.Windows.Forms.Label label2;
        private RJCodeAdvance.RJControls.RJComboBox cmbTheme;
        private SiticoneNetFrameworkUI.SiticoneRadioButton rdoAskUser;
        private SiticoneNetFrameworkUI.SiticoneRadioButton rdoCheckTime;
        private SiticoneNetFrameworkUI.SiticoneRadioButton rdoMerege;
        private SiticoneNetFrameworkUI.SiticoneRadioButton rdoDelete;
        private SiticoneNetFrameworkUI.SiticoneGroupBox siticoneGroupBox1;
        private System.Windows.Forms.Label label3;
        private SiticoneNetFrameworkUI.SiticoneButton btnSave;
        private SiticoneNetFrameworkUI.SiticoneButton btnReset;
        private FontAwesome.Sharp.IconButton btnSetting;
    }
}

namespace PlanEase.Views.Controls
{
    partial class TodoItemControl
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
            this.chkCompleted = new SiticoneNetFrameworkUI.SiticoneCheckBox();
            this.lblTodoText = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticonePanel1 = new SiticoneNetFrameworkUI.SiticonePanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkCompleted
            // 
            this.chkCompleted.AccessibleName = "";
            this.chkCompleted.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.chkCompleted.AllowIndeterminate = false;
            this.chkCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkCompleted.BackColor = System.Drawing.Color.Transparent;
            this.chkCompleted.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.chkCompleted.BorderWidth = 2;
            this.chkCompleted.BottomLeftRadius = 3;
            this.chkCompleted.BottomRightRadius = 3;
            this.chkCompleted.CanBeep = true;
            this.chkCompleted.CanShake = true;
            this.chkCompleted.CheckBoxSize = 20;
            this.chkCompleted.Checked = false;
            this.chkCompleted.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkCompleted.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkCompleted.CheckmarkColor = System.Drawing.Color.White;
            this.chkCompleted.CheckState = SiticoneNetFrameworkUI.CheckState.Unchecked;
            this.chkCompleted.ContainerBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkCompleted.ContainerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkCompleted.ContainerBorderWidth = 1;
            this.chkCompleted.ContainerBottomLeftRadius = 8;
            this.chkCompleted.ContainerBottomRightRadius = 8;
            this.chkCompleted.ContainerCheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkCompleted.ContainerCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkCompleted.ContainerCheckedHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkCompleted.ContainerCheckedPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkCompleted.ContainerHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkCompleted.ContainerPadding = 8;
            this.chkCompleted.ContainerPressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkCompleted.ContainerTopLeftRadius = 8;
            this.chkCompleted.ContainerTopRightRadius = 8;
            this.chkCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkCompleted.EnableRippleEffect = true;
            this.chkCompleted.FocusBorderWidth = 2;
            this.chkCompleted.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.chkCompleted.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkCompleted.ForeColor = System.Drawing.Color.DimGray;
            this.chkCompleted.HoverBackColor = System.Drawing.Color.Gainsboro;
            this.chkCompleted.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.chkCompleted.IndeterminateColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.chkCompleted.IsContained = false;
            this.chkCompleted.IsReadOnly = false;
            this.chkCompleted.Location = new System.Drawing.Point(6, 23);
            this.chkCompleted.Margin = new System.Windows.Forms.Padding(2);
            this.chkCompleted.MinimumSize = new System.Drawing.Size(18, 18);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.PressedBackColor = System.Drawing.Color.DarkGray;
            this.chkCompleted.ShowFocusCue = false;
            this.chkCompleted.Size = new System.Drawing.Size(25, 25);
            this.chkCompleted.Style = SiticoneNetFrameworkUI.CheckBoxStyle.Classic;
            this.chkCompleted.SwitchCheckedTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(56)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkCompleted.SwitchTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.chkCompleted.TabIndex = 0;
            this.chkCompleted.TopLeftRadius = 3;
            this.chkCompleted.TopRightRadius = 3;
            this.chkCompleted.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            // 
            // lblTodoText
            // 
            this.lblTodoText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTodoText.BackColor = System.Drawing.Color.Transparent;
            this.lblTodoText.Font = new System.Drawing.Font("맑은 고딕", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTodoText.ForeColor = System.Drawing.Color.White;
            this.lblTodoText.Location = new System.Drawing.Point(40, 26);
            this.lblTodoText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTodoText.Name = "lblTodoText";
            this.lblTodoText.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTodoText.Size = new System.Drawing.Size(180, 22);
            this.lblTodoText.TabIndex = 3;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.AcrylicTintColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticonePanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            this.siticonePanel1.BorderDashPattern = null;
            this.siticonePanel1.BorderGradientEndColor = System.Drawing.Color.Purple;
            this.siticonePanel1.BorderGradientStartColor = System.Drawing.Color.Blue;
            this.siticonePanel1.BorderThickness = 2F;
            this.siticonePanel1.Controls.Add(this.iconButton1);
            this.siticonePanel1.Controls.Add(this.chkCompleted);
            this.siticonePanel1.Controls.Add(this.lblTodoText);
            this.siticonePanel1.CornerRadiusBottomLeft = 0F;
            this.siticonePanel1.CornerRadiusBottomRight = 0F;
            this.siticonePanel1.CornerRadiusTopLeft = 0F;
            this.siticonePanel1.CornerRadiusTopRight = 0F;
            this.siticonePanel1.EnableAcrylicEffect = false;
            this.siticonePanel1.EnableMicaEffect = false;
            this.siticonePanel1.EnableRippleEffect = false;
            this.siticonePanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticonePanel1.GradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.Gray};
            this.siticonePanel1.GradientPositions = new float[] {
        0F,
        0.5F,
        1F};
            this.siticonePanel1.Location = new System.Drawing.Point(-4, -8);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.PatternStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid;
            this.siticonePanel1.RippleAlpha = 50;
            this.siticonePanel1.RippleAlphaDecrement = 3;
            this.siticonePanel1.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticonePanel1.RippleMaxSize = 600F;
            this.siticonePanel1.RippleSpeed = 15F;
            this.siticonePanel1.ShowBorder = true;
            this.siticonePanel1.Size = new System.Drawing.Size(300, 75);
            this.siticonePanel1.TabIndex = 4;
            this.siticonePanel1.TabStop = true;
            this.siticonePanel1.TrackSystemTheme = false;
            this.siticonePanel1.UseBorderGradient = false;
            this.siticonePanel1.UseMultiGradient = false;
            this.siticonePanel1.UsePatternTexture = false;
            this.siticonePanel1.UseRadialGradient = false;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.iconButton1.IconColor = System.Drawing.Color.LightSlateGray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 38;
            this.iconButton1.Location = new System.Drawing.Point(241, 11);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(40, 50);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // TodoItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.siticonePanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TodoItemControl";
            this.Size = new System.Drawing.Size(280, 57);
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneCheckBox chkCompleted;
        private SiticoneNetFrameworkUI.SiticoneLabel lblTodoText;
        private SiticoneNetFrameworkUI.SiticonePanel siticonePanel1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

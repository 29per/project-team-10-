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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoItemControl));
            this.chkCompleted = new SiticoneNetFrameworkUI.SiticoneCheckBox();
            this.lblTodoText = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticonePanel1 = new SiticoneNetFrameworkUI.SiticonePanel();
            this.siticoneButton1 = new SiticoneNetFrameworkUI.SiticoneButton();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkCompleted
            // 
            this.chkCompleted.AccessibleName = "";
            this.chkCompleted.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.chkCompleted.AllowIndeterminate = false;
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
            this.chkCompleted.Location = new System.Drawing.Point(9, 40);
            this.chkCompleted.MinimumSize = new System.Drawing.Size(28, 32);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.PressedBackColor = System.Drawing.Color.DarkGray;
            this.chkCompleted.ShowFocusCue = false;
            this.chkCompleted.Size = new System.Drawing.Size(28, 43);
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
            this.lblTodoText.BackColor = System.Drawing.Color.Transparent;
            this.lblTodoText.Font = new System.Drawing.Font("맑은 고딕", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTodoText.ForeColor = System.Drawing.Color.White;
            this.lblTodoText.Location = new System.Drawing.Point(36, 46);
            this.lblTodoText.Name = "lblTodoText";
            this.lblTodoText.Size = new System.Drawing.Size(370, 38);
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
            this.siticonePanel1.Controls.Add(this.chkCompleted);
            this.siticonePanel1.Controls.Add(this.siticoneButton1);
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
            this.siticonePanel1.Location = new System.Drawing.Point(-6, -14);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.PatternStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid;
            this.siticonePanel1.RippleAlpha = 50;
            this.siticonePanel1.RippleAlphaDecrement = 3;
            this.siticonePanel1.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticonePanel1.RippleMaxSize = 600F;
            this.siticonePanel1.RippleSpeed = 15F;
            this.siticonePanel1.ShowBorder = true;
            this.siticonePanel1.Size = new System.Drawing.Size(502, 132);
            this.siticonePanel1.TabIndex = 4;
            this.siticonePanel1.TabStop = true;
            this.siticonePanel1.TrackSystemTheme = false;
            this.siticonePanel1.UseBorderGradient = false;
            this.siticonePanel1.UseMultiGradient = false;
            this.siticonePanel1.UsePatternTexture = false;
            this.siticonePanel1.UseRadialGradient = false;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.siticoneButton1.AccessibleName = "";
            this.siticoneButton1.AutoSizeBasedOnText = false;
            this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.siticoneButton1.BadgeBackColor = System.Drawing.Color.Black;
            this.siticoneButton1.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.siticoneButton1.BadgeValue = 0;
            this.siticoneButton1.BadgeValueForeColor = System.Drawing.Color.White;
            this.siticoneButton1.BorderColor = System.Drawing.Color.White;
            this.siticoneButton1.BorderWidth = 2;
            this.siticoneButton1.ButtonBackColor = System.Drawing.SystemColors.Control;
            this.siticoneButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("siticoneButton1.ButtonImage")));
            this.siticoneButton1.ButtonTextLeftPadding = 0;
            this.siticoneButton1.CanBeep = true;
            this.siticoneButton1.CanGlow = false;
            this.siticoneButton1.CanShake = true;
            this.siticoneButton1.ContextMenuStripEx = null;
            this.siticoneButton1.CornerRadiusBottomLeft = 5;
            this.siticoneButton1.CornerRadiusBottomRight = 5;
            this.siticoneButton1.CornerRadiusTopLeft = 5;
            this.siticoneButton1.CornerRadiusTopRight = 5;
            this.siticoneButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneButton1.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.siticoneButton1.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.siticoneButton1.EnableLongPress = false;
            this.siticoneButton1.EnablePressAnimation = true;
            this.siticoneButton1.EnableRippleEffect = true;
            this.siticoneButton1.EnableShadow = false;
            this.siticoneButton1.EnableTextWrapping = false;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.siticoneButton1.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneButton1.GlowIntensity = 100;
            this.siticoneButton1.GlowRadius = 20F;
            this.siticoneButton1.GradientBackground = false;
            this.siticoneButton1.GradientColor = System.Drawing.Color.White;
            this.siticoneButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneButton1.HintText = null;
            this.siticoneButton1.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneButton1.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneButton1.HoverTransitionDuration = 250;
            this.siticoneButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneButton1.ImagePadding = 5;
            this.siticoneButton1.ImageSize = new System.Drawing.Size(40, 35);
            this.siticoneButton1.IsRadial = false;
            this.siticoneButton1.IsReadOnly = false;
            this.siticoneButton1.IsToggleButton = false;
            this.siticoneButton1.IsToggled = false;
            this.siticoneButton1.Location = new System.Drawing.Point(412, 36);
            this.siticoneButton1.LongPressDurationMS = 1000;
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton1.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.siticoneButton1.ParticleCount = 15;
            this.siticoneButton1.PressAnimationScale = 0.97F;
            this.siticoneButton1.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneButton1.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton1.PressTransitionDuration = 150;
            this.siticoneButton1.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.siticoneButton1.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneButton1.RippleOpacity = 0.3F;
            this.siticoneButton1.RippleRadiusMultiplier = 0.6F;
            this.siticoneButton1.ShadowBlur = 5;
            this.siticoneButton1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton1.ShadowOffset = new System.Drawing.Point(2, 2);
            this.siticoneButton1.ShakeDuration = 500;
            this.siticoneButton1.ShakeIntensity = 5;
            this.siticoneButton1.Size = new System.Drawing.Size(65, 58);
            this.siticoneButton1.TabIndex = 2;
            this.siticoneButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneButton1.TextColor = System.Drawing.Color.Black;
            this.siticoneButton1.TooltipText = null;
            this.siticoneButton1.UseAdvancedRendering = true;
            this.siticoneButton1.UseParticles = false;
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // TodoItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.siticonePanel1);
            this.Name = "TodoItemControl";
            this.Size = new System.Drawing.Size(477, 99);
            this.siticonePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneCheckBox chkCompleted;
        private SiticoneNetFrameworkUI.SiticoneButton siticoneButton1;
        private SiticoneNetFrameworkUI.SiticoneLabel lblTodoText;
        private SiticoneNetFrameworkUI.SiticonePanel siticonePanel1;
    }
}

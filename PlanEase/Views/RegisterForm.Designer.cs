namespace PlanEase.Views
{
    partial class RegisterForm
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
            this.siticoneCloseButton = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.txtUsername = new SiticoneNetFrameworkUI.SiticoneMaterialTextbox();
            this.txtPassword = new SiticoneNetFrameworkUI.SiticoneMaterialTextbox();
            this.btnRegister = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnCancel = new SiticoneNetFrameworkUI.SiticoneButton();
            this.SuspendLayout();
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.NavBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneBorderlessForm1.NavBarHeight = 30;
            this.siticoneBorderlessForm1.TargetForm = this;
            // 
            // siticoneCloseButton
            // 
            this.siticoneCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCloseButton.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCloseButton.EnableSound = false;
            this.siticoneCloseButton.Location = new System.Drawing.Point(767, 0);
            this.siticoneCloseButton.Name = "siticoneCloseButton";
            this.siticoneCloseButton.Size = new System.Drawing.Size(33, 33);
            this.siticoneCloseButton.TabIndex = 11;
            this.siticoneCloseButton.Text = "siticoneCloseButton2";
            this.siticoneCloseButton.TooltipText = "Close";
            this.siticoneCloseButton.Click += new System.EventHandler(this.siticoneCloseButton_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.AccessibleDescription = "A customizable text input field.";
            this.txtUsername.AccessibleName = "Text Box";
            this.txtUsername.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BlinkCount = 3;
            this.txtUsername.BlinkShadow = false;
            this.txtUsername.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.txtUsername.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.txtUsername.BorderFocusColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtUsername.BorderFocusColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtUsername.CanShake = true;
            this.txtUsername.ContinuousBlink = false;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.CursorBlinkRate = 500;
            this.txtUsername.CursorColor = System.Drawing.Color.Black;
            this.txtUsername.CursorHeight = 26;
            this.txtUsername.CursorOffset = 0;
            this.txtUsername.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            this.txtUsername.CursorWidth = 1;
            this.txtUsername.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.DisabledBorderColor = System.Drawing.Color.LightGray;
            this.txtUsername.DisabledTextColor = System.Drawing.Color.Gray;
            this.txtUsername.EnableDropShadow = true;
            this.txtUsername.FillColor1 = System.Drawing.Color.White;
            this.txtUsername.FillColor2 = System.Drawing.Color.White;
            this.txtUsername.FocusIndicatorThickness = 2;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Navy;
            this.txtUsername.HoverBorderColor1 = System.Drawing.Color.Gray;
            this.txtUsername.HoverBorderColor2 = System.Drawing.Color.Gray;
            this.txtUsername.IsEnabled = true;
            this.txtUsername.IsRequired = false;
            this.txtUsername.Location = new System.Drawing.Point(200, 171);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtUsername.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(87)))));
            this.txtUsername.PlaceholderText = "아이디를 입력하세요.";
            this.txtUsername.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray;
            this.txtUsername.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray;
            this.txtUsername.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtUsername.ShadowAnimationDuration = 1;
            this.txtUsername.ShadowBlur = 3;
            this.txtUsername.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtUsername.Size = new System.Drawing.Size(400, 50);
            this.txtUsername.SolidBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.txtUsername.SolidBorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtUsername.SolidBorderHoverColor = System.Drawing.Color.Gray;
            this.txtUsername.SolidFillColor = System.Drawing.Color.White;
            this.txtUsername.TabIndex = 12;
            this.txtUsername.TextPadding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.txtUsername.ValidationErrorMessage = "Invalid input.";
            this.txtUsername.ValidationFunction = null;
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleDescription = "A customizable text input field.";
            this.txtPassword.AccessibleName = "Text Box";
            this.txtPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BlinkCount = 3;
            this.txtPassword.BlinkShadow = false;
            this.txtPassword.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.txtPassword.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.txtPassword.BorderFocusColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtPassword.BorderFocusColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtPassword.CanShake = true;
            this.txtPassword.ContinuousBlink = false;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.CursorBlinkRate = 500;
            this.txtPassword.CursorColor = System.Drawing.Color.Black;
            this.txtPassword.CursorHeight = 26;
            this.txtPassword.CursorOffset = 0;
            this.txtPassword.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            this.txtPassword.CursorWidth = 1;
            this.txtPassword.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.DisabledBorderColor = System.Drawing.Color.LightGray;
            this.txtPassword.DisabledTextColor = System.Drawing.Color.Gray;
            this.txtPassword.EnableDropShadow = true;
            this.txtPassword.FillColor1 = System.Drawing.Color.White;
            this.txtPassword.FillColor2 = System.Drawing.Color.White;
            this.txtPassword.FocusIndicatorThickness = 2;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPassword.ForeColor = System.Drawing.Color.Navy;
            this.txtPassword.HoverBorderColor1 = System.Drawing.Color.Gray;
            this.txtPassword.HoverBorderColor2 = System.Drawing.Color.Gray;
            this.txtPassword.IsEnabled = true;
            this.txtPassword.IsRequired = false;
            this.txtPassword.Location = new System.Drawing.Point(200, 256);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.txtPassword.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(50)))), ((int)(((byte)(87)))));
            this.txtPassword.PlaceholderText = "비밀번호를 입력하세요.";
            this.txtPassword.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray;
            this.txtPassword.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray;
            this.txtPassword.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtPassword.ShadowAnimationDuration = 1;
            this.txtPassword.ShadowBlur = 3;
            this.txtPassword.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.txtPassword.Size = new System.Drawing.Size(400, 50);
            this.txtPassword.SolidBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.txtPassword.SolidBorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtPassword.SolidBorderHoverColor = System.Drawing.Color.Gray;
            this.txtPassword.SolidFillColor = System.Drawing.Color.White;
            this.txtPassword.TabIndex = 13;
            this.txtPassword.TextPadding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.ValidationErrorMessage = "Invalid input.";
            this.txtPassword.ValidationFunction = null;
            // 
            // btnRegister
            // 
            this.btnRegister.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnRegister.AccessibleName = "회원가입";
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegister.AutoSizeBasedOnText = false;
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BadgeBackColor = System.Drawing.Color.Black;
            this.btnRegister.BadgeFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.BadgeValue = 0;
            this.btnRegister.BadgeValueForeColor = System.Drawing.Color.White;
            this.btnRegister.BorderColor = System.Drawing.Color.Lavender;
            this.btnRegister.BorderWidth = 2;
            this.btnRegister.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.btnRegister.ButtonImage = null;
            this.btnRegister.ButtonTextLeftPadding = 0;
            this.btnRegister.CanBeep = true;
            this.btnRegister.CanGlow = true;
            this.btnRegister.CanShake = true;
            this.btnRegister.ContextMenuStripEx = null;
            this.btnRegister.CornerRadiusBottomLeft = 20;
            this.btnRegister.CornerRadiusBottomRight = 20;
            this.btnRegister.CornerRadiusTopLeft = 20;
            this.btnRegister.CornerRadiusTopRight = 20;
            this.btnRegister.CustomCursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnRegister.EnableLongPress = false;
            this.btnRegister.EnablePressAnimation = true;
            this.btnRegister.EnableRippleEffect = false;
            this.btnRegister.EnableShadow = true;
            this.btnRegister.EnableTextWrapping = false;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.GlowColor = System.Drawing.Color.MediumSpringGreen;
            this.btnRegister.GlowIntensity = 100;
            this.btnRegister.GlowRadius = 20F;
            this.btnRegister.GradientBackground = true;
            this.btnRegister.GradientColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRegister.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnRegister.HintText = null;
            this.btnRegister.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.btnRegister.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnRegister.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.btnRegister.HoverTransitionDuration = 250;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.ImagePadding = 5;
            this.btnRegister.ImageSize = new System.Drawing.Size(16, 16);
            this.btnRegister.IsRadial = false;
            this.btnRegister.IsReadOnly = false;
            this.btnRegister.IsToggleButton = false;
            this.btnRegister.IsToggled = false;
            this.btnRegister.Location = new System.Drawing.Point(200, 350);
            this.btnRegister.LongPressDurationMS = 1000;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnRegister.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnRegister.ParticleCount = 15;
            this.btnRegister.PressAnimationScale = 0.97F;
            this.btnRegister.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(194)))), ((int)(((byte)(221)))));
            this.btnRegister.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnRegister.PressTransitionDuration = 150;
            this.btnRegister.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnRegister.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRegister.RippleOpacity = 0.3F;
            this.btnRegister.RippleRadiusMultiplier = 0.6F;
            this.btnRegister.ShadowBlur = 6;
            this.btnRegister.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btnRegister.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btnRegister.ShakeDuration = 500;
            this.btnRegister.ShakeIntensity = 5;
            this.btnRegister.Size = new System.Drawing.Size(175, 49);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "회원가입";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.TextColor = System.Drawing.Color.White;
            this.btnRegister.TooltipText = null;
            this.btnRegister.UseAdvancedRendering = true;
            this.btnRegister.UseParticles = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnCancel.AccessibleName = "취소";
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnCancel.CornerRadiusBottomLeft = 20;
            this.btnCancel.CornerRadiusBottomRight = 20;
            this.btnCancel.CornerRadiusTopLeft = 20;
            this.btnCancel.CornerRadiusTopRight = 20;
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
            this.btnCancel.Location = new System.Drawing.Point(425, 350);
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
            this.btnCancel.Size = new System.Drawing.Size(175, 49);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.TooltipText = null;
            this.btnCancel.UseAdvancedRendering = true;
            this.btnCancel.UseParticles = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.siticoneCloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);

        }

        #endregion
        private SiticoneNetFrameworkUI.SiticoneBorderlessForm siticoneBorderlessForm1;
        private SiticoneNetFrameworkUI.SiticoneCloseButton siticoneCloseButton;
        private SiticoneNetFrameworkUI.SiticoneMaterialTextbox txtUsername;
        private SiticoneNetFrameworkUI.SiticoneMaterialTextbox txtPassword;
        private SiticoneNetFrameworkUI.SiticoneButton btnRegister;
        private SiticoneNetFrameworkUI.SiticoneButton btnCancel;
    }
}
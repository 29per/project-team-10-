namespace PlanEase.Views.panelDesktop
{
    partial class Adventure
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picMonster = new System.Windows.Forms.PictureBox();
            this.lblMonsterName = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.progressHP = new System.Windows.Forms.ProgressBar();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblTaskDesc = new System.Windows.Forms.Label();
            this.progressExp = new System.Windows.Forms.ProgressBar();
            this.lblExp = new System.Windows.Forms.Label();
            this.btnDoTask = new SiticoneNetFrameworkUI.SiticoneButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.siticoneLabel1 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneLabel2 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneLabel3 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneLabel4 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneLabel5 = new SiticoneNetFrameworkUI.SiticoneLabel();
            this.siticoneLabel6 = new SiticoneNetFrameworkUI.SiticoneLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster)).BeginInit();
            this.SuspendLayout();
            // 
            // picMonster
            // 
            this.picMonster.BackColor = System.Drawing.Color.Transparent;
            this.picMonster.Location = new System.Drawing.Point(40, 40);
            this.picMonster.Name = "picMonster";
            this.picMonster.Size = new System.Drawing.Size(129, 124);
            this.picMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMonster.TabIndex = 0;
            this.picMonster.TabStop = false;
            this.picMonster.Click += new System.EventHandler(this.picMonster_Click);
            // 
            // lblMonsterName
            // 
            this.lblMonsterName.AutoSize = true;
            this.lblMonsterName.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblMonsterName.ForeColor = System.Drawing.Color.White;
            this.lblMonsterName.Location = new System.Drawing.Point(190, 40);
            this.lblMonsterName.Name = "lblMonsterName";
            this.lblMonsterName.Size = new System.Drawing.Size(129, 31);
            this.lblMonsterName.TabIndex = 1;
            this.lblMonsterName.Text = "몬스터이름";
            this.lblMonsterName.Click += new System.EventHandler(this.lblMonsterName_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLevel.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblLevel.Location = new System.Drawing.Point(190, 75);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(37, 19);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "LV. ?";
            // 
            // progressHP
            // 
            this.progressHP.Location = new System.Drawing.Point(190, 110);
            this.progressHP.Name = "progressHP";
            this.progressHP.Size = new System.Drawing.Size(270, 20);
            this.progressHP.TabIndex = 3;
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHP.Location = new System.Drawing.Point(470, 110);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(41, 15);
            this.lblHP.TabIndex = 4;
            this.lblHP.Text = "HP ?/?";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTaskName.ForeColor = System.Drawing.Color.Lime;
            this.lblTaskName.Location = new System.Drawing.Point(40, 190);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(149, 25);
            this.lblTaskName.TabIndex = 5;
            this.lblTaskName.Text = "할 일: (바인딩용)";
            // 
            // lblTaskDesc
            // 
            this.lblTaskDesc.AutoSize = true;
            this.lblTaskDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTaskDesc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTaskDesc.Location = new System.Drawing.Point(40, 225);
            this.lblTaskDesc.Name = "lblTaskDesc";
            this.lblTaskDesc.Size = new System.Drawing.Size(141, 19);
            this.lblTaskDesc.TabIndex = 6;
            this.lblTaskDesc.Text = "할 일 설명 (바인딩용)";
            // 
            // progressExp
            // 
            this.progressExp.Location = new System.Drawing.Point(40, 270);
            this.progressExp.Name = "progressExp";
            this.progressExp.Size = new System.Drawing.Size(400, 18);
            this.progressExp.TabIndex = 7;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblExp.ForeColor = System.Drawing.Color.Gold;
            this.lblExp.Location = new System.Drawing.Point(450, 270);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(45, 15);
            this.lblExp.TabIndex = 8;
            this.lblExp.Text = "EXP ?/?";
            // 
            // btnDoTask
            // 
            this.btnDoTask.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnDoTask.AccessibleName = "할 일 완료(공격!)";
            this.btnDoTask.AutoSizeBasedOnText = false;
            this.btnDoTask.BackColor = System.Drawing.Color.Transparent;
            this.btnDoTask.BadgeBackColor = System.Drawing.Color.Black;
            this.btnDoTask.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnDoTask.BadgeValue = 0;
            this.btnDoTask.BadgeValueForeColor = System.Drawing.Color.White;
            this.btnDoTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDoTask.BorderWidth = 2;
            this.btnDoTask.ButtonBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDoTask.ButtonImage = null;
            this.btnDoTask.ButtonTextLeftPadding = 0;
            this.btnDoTask.CanBeep = true;
            this.btnDoTask.CanGlow = false;
            this.btnDoTask.CanShake = true;
            this.btnDoTask.ContextMenuStripEx = null;
            this.btnDoTask.CornerRadiusBottomLeft = 5;
            this.btnDoTask.CornerRadiusBottomRight = 5;
            this.btnDoTask.CornerRadiusTopLeft = 5;
            this.btnDoTask.CornerRadiusTopRight = 5;
            this.btnDoTask.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnDoTask.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnDoTask.EnableLongPress = false;
            this.btnDoTask.EnablePressAnimation = true;
            this.btnDoTask.EnableRippleEffect = true;
            this.btnDoTask.EnableShadow = false;
            this.btnDoTask.EnableTextWrapping = false;
            this.btnDoTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDoTask.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDoTask.GlowIntensity = 100;
            this.btnDoTask.GlowRadius = 20F;
            this.btnDoTask.GradientBackground = false;
            this.btnDoTask.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnDoTask.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnDoTask.HintText = null;
            this.btnDoTask.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDoTask.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnDoTask.HoverTextColor = System.Drawing.Color.White;
            this.btnDoTask.HoverTransitionDuration = 250;
            this.btnDoTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoTask.ImagePadding = 5;
            this.btnDoTask.ImageSize = new System.Drawing.Size(16, 16);
            this.btnDoTask.IsRadial = false;
            this.btnDoTask.IsReadOnly = false;
            this.btnDoTask.IsToggleButton = false;
            this.btnDoTask.IsToggled = false;
            this.btnDoTask.Location = new System.Drawing.Point(310, 320);
            this.btnDoTask.LongPressDurationMS = 1000;
            this.btnDoTask.Name = "btnDoTask";
            this.btnDoTask.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnDoTask.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDoTask.ParticleCount = 15;
            this.btnDoTask.PressAnimationScale = 0.97F;
            this.btnDoTask.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btnDoTask.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnDoTask.PressTransitionDuration = 150;
            this.btnDoTask.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDoTask.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDoTask.RippleOpacity = 0.3F;
            this.btnDoTask.RippleRadiusMultiplier = 0.6F;
            this.btnDoTask.ShadowBlur = 5;
            this.btnDoTask.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDoTask.ShadowOffset = new System.Drawing.Point(2, 2);
            this.btnDoTask.ShakeDuration = 500;
            this.btnDoTask.ShakeIntensity = 5;
            this.btnDoTask.Size = new System.Drawing.Size(170, 45);
            this.btnDoTask.TabIndex = 9;
            this.btnDoTask.Text = "할 일 완료(공격!)";
            this.btnDoTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDoTask.TextColor = System.Drawing.Color.White;
            this.btnDoTask.TooltipText = null;
            this.btnDoTask.UseAdvancedRendering = true;
            this.btnDoTask.UseParticles = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel1.Location = new System.Drawing.Point(636, 116);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(139, 37);
            this.siticoneLabel1.TabIndex = 10;
            this.siticoneLabel1.Text = "Lv1. 브론즈";
            this.siticoneLabel1.Click += new System.EventHandler(this.siticoneLabel1_Click);
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel2.Location = new System.Drawing.Point(636, 153);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(139, 37);
            this.siticoneLabel2.TabIndex = 11;
            this.siticoneLabel2.Text = "Lv2. 실버";
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneLabel3.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel3.Location = new System.Drawing.Point(636, 190);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(139, 37);
            this.siticoneLabel3.TabIndex = 12;
            this.siticoneLabel3.Text = "Lv3. 골드";
            // 
            // siticoneLabel4
            // 
            this.siticoneLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneLabel4.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel4.Location = new System.Drawing.Point(636, 307);
            this.siticoneLabel4.Name = "siticoneLabel4";
            this.siticoneLabel4.Size = new System.Drawing.Size(139, 37);
            this.siticoneLabel4.TabIndex = 15;
            this.siticoneLabel4.Text = "Lv6. 마스터";
            // 
            // siticoneLabel5
            // 
            this.siticoneLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneLabel5.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel5.Location = new System.Drawing.Point(636, 270);
            this.siticoneLabel5.Name = "siticoneLabel5";
            this.siticoneLabel5.Size = new System.Drawing.Size(139, 37);
            this.siticoneLabel5.TabIndex = 14;
            this.siticoneLabel5.Text = "Lv5. 다이아";
            // 
            // siticoneLabel6
            // 
            this.siticoneLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneLabel6.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel6.Location = new System.Drawing.Point(636, 233);
            this.siticoneLabel6.Name = "siticoneLabel6";
            this.siticoneLabel6.Size = new System.Drawing.Size(139, 37);
            this.siticoneLabel6.TabIndex = 13;
            this.siticoneLabel6.Text = "Lv4. 에메랄드";
            // 
            // Adventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.Controls.Add(this.siticoneLabel4);
            this.Controls.Add(this.siticoneLabel5);
            this.Controls.Add(this.siticoneLabel6);
            this.Controls.Add(this.siticoneLabel3);
            this.Controls.Add(this.siticoneLabel2);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.picMonster);
            this.Controls.Add(this.lblMonsterName);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.progressHP);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.lblTaskDesc);
            this.Controls.Add(this.progressExp);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.btnDoTask);
            this.Name = "Adventure";
            this.Size = new System.Drawing.Size(873, 578);
            this.Load += new System.EventHandler(this.Adventure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMonster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMonster;
        private System.Windows.Forms.Label lblMonsterName;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ProgressBar progressHP;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblTaskDesc;
        private System.Windows.Forms.ProgressBar progressExp;
        private System.Windows.Forms.Label lblExp;
        private SiticoneNetFrameworkUI.SiticoneButton btnDoTask;
        private System.Windows.Forms.ImageList imageList1;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel1;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel2;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel3;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel4;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel5;
        private SiticoneNetFrameworkUI.SiticoneLabel siticoneLabel6;
    }
}
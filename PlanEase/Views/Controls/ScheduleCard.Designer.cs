namespace PlanEase.Views.Controls
{
    partial class ScheduleCard
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
            this.siticoneCard1 = new SiticoneNetFrameworkUI.SiticoneCard();
            this.btnDel = new RJCodeAdvance.RJControls.RJButton();
            this.lblTags = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.siticoneCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneCard1
            // 
            this.siticoneCard1.AnimationScaleStep = 0.02F;
            this.siticoneCard1.BackColor = System.Drawing.Color.Lavender;
            this.siticoneCard1.BackgroundAngle = 45F;
            this.siticoneCard1.BackgroundColor1 = System.Drawing.Color.Transparent;
            this.siticoneCard1.BackgroundColor2 = System.Drawing.Color.Lavender;
            this.siticoneCard1.BadgeColor = System.Drawing.Color.Red;
            this.siticoneCard1.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.siticoneCard1.BadgePosition = SiticoneNetFrameworkUI.BadgePosition.TopRight;
            this.siticoneCard1.BadgeTextColor = System.Drawing.Color.White;
            this.siticoneCard1.BadgeValue = 0;
            this.siticoneCard1.BorderAngle = 45F;
            this.siticoneCard1.BorderColor1 = System.Drawing.Color.MediumSlateBlue;
            this.siticoneCard1.BorderColor2 = System.Drawing.Color.Plum;
            this.siticoneCard1.BorderStyleEx = SiticoneNetFrameworkUI.CustomBorderStyleFx.Solid;
            this.siticoneCard1.BorderWidth = 20F;
            this.siticoneCard1.BottomLeftRadius = 25;
            this.siticoneCard1.BottomRightRadius = 25;
            this.siticoneCard1.CanBeep = true;
            this.siticoneCard1.CanShake = true;
            this.siticoneCard1.ClickScaleEffect = 0.98F;
            this.siticoneCard1.ContentGenerator = null;
            this.siticoneCard1.Controls.Add(this.btnDel);
            this.siticoneCard1.Controls.Add(this.lblTags);
            this.siticoneCard1.Controls.Add(this.lblPriority);
            this.siticoneCard1.Controls.Add(this.lblTime);
            this.siticoneCard1.Controls.Add(this.lblTitle);
            this.siticoneCard1.CustomDashPattern = null;
            this.siticoneCard1.DataSource = null;
            this.siticoneCard1.Elevation = 20;
            this.siticoneCard1.EnableClickEffect = true;
            this.siticoneCard1.EnableContextMenu = false;
            this.siticoneCard1.EnableCustomBorderStyle = false;
            this.siticoneCard1.EnableDragging = false;
            this.siticoneCard1.EnableDynamicContent = false;
            this.siticoneCard1.EnableHoverEffect = true;
            this.siticoneCard1.EnableRippleEffect = false;
            this.siticoneCard1.EnableShimmerEffect = false;
            this.siticoneCard1.HoverBackColor = System.Drawing.Color.Azure;
            this.siticoneCard1.HoverBorderColor = System.Drawing.Color.Empty;
            this.siticoneCard1.HoverBorderSize = 2;
            this.siticoneCard1.HoverShadowDepth = -1;
            this.siticoneCard1.IsReadonly = false;
            this.siticoneCard1.Location = new System.Drawing.Point(5, 5);
            this.siticoneCard1.Name = "siticoneCard1";
            this.siticoneCard1.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneCard1.RippleDuration = 750;
            this.siticoneCard1.RippleMaxOpacity = 0.3F;
            this.siticoneCard1.RippleOpacityDecay = 450;
            this.siticoneCard1.ShadowColor = System.Drawing.Color.DarkSlateBlue;
            this.siticoneCard1.ShadowDepth = 10;
            this.siticoneCard1.ShadowOpacity = 3;
            this.siticoneCard1.ShimmerAngle = 45F;
            this.siticoneCard1.ShimmerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneCard1.ShimmerSpeed = 5F;
            this.siticoneCard1.ShimmerWidth = 50F;
            this.siticoneCard1.ShowBorder = false;
            this.siticoneCard1.Size = new System.Drawing.Size(227, 190);
            this.siticoneCard1.TabIndex = 0;
            this.siticoneCard1.TopLeftRadius = 25;
            this.siticoneCard1.TopRightRadius = 25;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDel.BorderRadius = 0;
            this.btnDel.BorderSize = 0;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.Salmon;
            this.btnDel.Location = new System.Drawing.Point(181, 16);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(25, 31);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "X";
            this.btnDel.TextColor = System.Drawing.Color.Salmon;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // lblTags
            // 
            this.lblTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTags.AutoSize = true;
            this.lblTags.BackColor = System.Drawing.Color.Transparent;
            this.lblTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTags.Font = new System.Drawing.Font("나눔바른펜", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTags.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTags.Location = new System.Drawing.Point(50, 120);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(51, 24);
            this.lblTags.TabIndex = 4;
            this.lblTags.Text = "label1";
            this.lblTags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.BackColor = System.Drawing.Color.Transparent;
            this.lblPriority.Font = new System.Drawing.Font("나눔바른펜", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPriority.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblPriority.Location = new System.Drawing.Point(50, 95);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(51, 24);
            this.lblPriority.TabIndex = 3;
            this.lblPriority.Text = "label1";
            this.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("나눔바른펜", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTime.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTime.Location = new System.Drawing.Point(50, 70);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(51, 24);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "label1";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("나눔바른펜", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblTitle.Location = new System.Drawing.Point(50, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScheduleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.siticoneCard1);
            this.Name = "ScheduleCard";
            this.Size = new System.Drawing.Size(237, 200);
            this.Load += new System.EventHandler(this.ScheduleCard_Load);
            this.siticoneCard1.ResumeLayout(false);
            this.siticoneCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneCard siticoneCard1;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTags;
        private RJCodeAdvance.RJControls.RJButton btnDel;
    }
}

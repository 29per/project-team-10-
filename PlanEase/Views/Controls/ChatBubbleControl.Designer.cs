namespace PlanEase.Views.Controls
{
    partial class ChatBubbleControl
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.siticoneCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneCard1
            // 
            this.siticoneCard1.AnimationScaleStep = 0.02F;
            this.siticoneCard1.AutoSize = true;
            this.siticoneCard1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCard1.BackgroundAngle = 45F;
            this.siticoneCard1.BackgroundColor1 = System.Drawing.Color.White;
            this.siticoneCard1.BackgroundColor2 = System.Drawing.Color.White;
            this.siticoneCard1.BadgeColor = System.Drawing.Color.Red;
            this.siticoneCard1.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.siticoneCard1.BadgePosition = SiticoneNetFrameworkUI.BadgePosition.TopRight;
            this.siticoneCard1.BadgeTextColor = System.Drawing.Color.White;
            this.siticoneCard1.BadgeValue = 0;
            this.siticoneCard1.BorderAngle = 45F;
            this.siticoneCard1.BorderColor1 = System.Drawing.Color.Black;
            this.siticoneCard1.BorderColor2 = System.Drawing.Color.Black;
            this.siticoneCard1.BorderStyleEx = SiticoneNetFrameworkUI.CustomBorderStyleFx.Solid;
            this.siticoneCard1.BorderWidth = 2F;
            this.siticoneCard1.BottomLeftRadius = 15;
            this.siticoneCard1.BottomRightRadius = 15;
            this.siticoneCard1.CanBeep = true;
            this.siticoneCard1.CanShake = true;
            this.siticoneCard1.ClickScaleEffect = 0.98F;
            this.siticoneCard1.ContentGenerator = null;
            this.siticoneCard1.Controls.Add(this.lblMessage);
            this.siticoneCard1.CustomDashPattern = null;
            this.siticoneCard1.DataSource = null;
            this.siticoneCard1.Elevation = 0;
            this.siticoneCard1.EnableClickEffect = false;
            this.siticoneCard1.EnableContextMenu = false;
            this.siticoneCard1.EnableCustomBorderStyle = false;
            this.siticoneCard1.EnableDragging = false;
            this.siticoneCard1.EnableDynamicContent = false;
            this.siticoneCard1.EnableHoverEffect = false;
            this.siticoneCard1.EnableRippleEffect = false;
            this.siticoneCard1.EnableShimmerEffect = false;
            this.siticoneCard1.HoverBackColor = System.Drawing.Color.White;
            this.siticoneCard1.HoverBorderColor = System.Drawing.Color.Empty;
            this.siticoneCard1.HoverBorderSize = 2;
            this.siticoneCard1.HoverShadowDepth = -1;
            this.siticoneCard1.IsReadonly = false;
            this.siticoneCard1.Location = new System.Drawing.Point(0, 0);
            this.siticoneCard1.Margin = new System.Windows.Forms.Padding(0);
            this.siticoneCard1.MaximumSize = new System.Drawing.Size(400, 250);
            this.siticoneCard1.MinimumSize = new System.Drawing.Size(200, 50);
            this.siticoneCard1.Name = "siticoneCard1";
            this.siticoneCard1.Padding = new System.Windows.Forms.Padding(1);
            this.siticoneCard1.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneCard1.RippleDuration = 750;
            this.siticoneCard1.RippleMaxOpacity = 0.3F;
            this.siticoneCard1.RippleOpacityDecay = 450;
            this.siticoneCard1.ShadowColor = System.Drawing.Color.Black;
            this.siticoneCard1.ShadowDepth = 10;
            this.siticoneCard1.ShadowOpacity = 3;
            this.siticoneCard1.ShimmerAngle = 45F;
            this.siticoneCard1.ShimmerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneCard1.ShimmerSpeed = 5F;
            this.siticoneCard1.ShimmerWidth = 50F;
            this.siticoneCard1.ShowBorder = true;
            this.siticoneCard1.Size = new System.Drawing.Size(200, 50);
            this.siticoneCard1.TabIndex = 0;
            this.siticoneCard1.TopLeftRadius = 15;
            this.siticoneCard1.TopRightRadius = 15;
            this.siticoneCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.siticoneCard1_Paint);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(26, 19);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblMessage.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.lblMessage.Size = new System.Drawing.Size(39, 12);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "label1";
            // 
            // ChatBubbleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.siticoneCard1);
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(210, 50);
            this.Name = "ChatBubbleControl";
            this.Size = new System.Drawing.Size(310, 50);
            this.siticoneCard1.ResumeLayout(false);
            this.siticoneCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SiticoneNetFrameworkUI.SiticoneCard siticoneCard1;
        private System.Windows.Forms.Label lblMessage;
    }
}

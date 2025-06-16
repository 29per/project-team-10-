namespace PlanEase.Views.Controls
{
    partial class DateCellControl
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
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlScheduleList = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMore = new System.Windows.Forms.Label();
            this.panelContent = new SiticoneNetFrameworkUI.SiticonePanel();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDate.ForeColor = System.Drawing.Color.Indigo;
            this.lblDate.Location = new System.Drawing.Point(5, 5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 15);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "lblDate";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlScheduleList
            // 
            this.pnlScheduleList.BackColor = System.Drawing.Color.Transparent;
            this.pnlScheduleList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlScheduleList.Location = new System.Drawing.Point(5, 25);
            this.pnlScheduleList.Name = "pnlScheduleList";
            this.pnlScheduleList.Size = new System.Drawing.Size(90, 60);
            this.pnlScheduleList.TabIndex = 1;
            this.pnlScheduleList.WrapContents = false;
            // 
            // lblMore
            // 
            this.lblMore.AutoSize = true;
            this.lblMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMore.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblMore.Location = new System.Drawing.Point(5, 85);
            this.lblMore.Name = "lblMore";
            this.lblMore.Size = new System.Drawing.Size(47, 12);
            this.lblMore.TabIndex = 2;
            this.lblMore.Text = "lblMore";
            this.lblMore.Visible = false;
            this.lblMore.Click += new System.EventHandler(this.lblMore_Click);
            // 
            // panelContent
            // 
            this.panelContent.AcrylicTintColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            this.panelContent.BorderDashPattern = null;
            this.panelContent.BorderGradientEndColor = System.Drawing.Color.Purple;
            this.panelContent.BorderGradientStartColor = System.Drawing.Color.Blue;
            this.panelContent.BorderThickness = 2F;
            this.panelContent.Controls.Add(this.lblMore);
            this.panelContent.Controls.Add(this.pnlScheduleList);
            this.panelContent.Controls.Add(this.lblDate);
            this.panelContent.CornerRadiusBottomLeft = 15F;
            this.panelContent.CornerRadiusBottomRight = 15F;
            this.panelContent.CornerRadiusTopLeft = 15F;
            this.panelContent.CornerRadiusTopRight = 15F;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.EnableAcrylicEffect = false;
            this.panelContent.EnableMicaEffect = false;
            this.panelContent.EnableRippleEffect = false;
            this.panelContent.FillColor = System.Drawing.Color.GhostWhite;
            this.panelContent.ForeColor = System.Drawing.Color.Black;
            this.panelContent.GradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.Gray};
            this.panelContent.GradientPositions = new float[] {
        0F,
        0.5F,
        1F};
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelContent.Name = "panelContent";
            this.panelContent.PatternStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid;
            this.panelContent.RippleAlpha = 50;
            this.panelContent.RippleAlphaDecrement = 3;
            this.panelContent.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelContent.RippleMaxSize = 600F;
            this.panelContent.RippleSpeed = 15F;
            this.panelContent.ShowBorder = false;
            this.panelContent.Size = new System.Drawing.Size(110, 110);
            this.panelContent.TabIndex = 0;
            this.panelContent.TabStop = true;
            this.panelContent.TrackSystemTheme = false;
            this.panelContent.UseBorderGradient = false;
            this.panelContent.UseMultiGradient = false;
            this.panelContent.UsePatternTexture = false;
            this.panelContent.UseRadialGradient = false;
            // 
            // DateCellControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelContent);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DateCellControl";
            this.Size = new System.Drawing.Size(110, 110);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.FlowLayoutPanel pnlScheduleList;
        private System.Windows.Forms.Label lblMore;
        private SiticoneNetFrameworkUI.SiticonePanel panelContent;
    }
}

namespace PlanEase.Views.panelDesktop
{
    partial class Tags
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
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.flowTagPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowSchedulePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnToggleTags = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
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
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Hashtag;
            this.btnSetting.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 34;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(335, 15);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSetting.Size = new System.Drawing.Size(144, 72);
            this.btnSetting.TabIndex = 26;
            this.btnSetting.Text = "Tags";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // flowTagPanel
            // 
            this.flowTagPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowTagPanel.Location = new System.Drawing.Point(20, 90);
            this.flowTagPanel.Name = "flowTagPanel";
            this.flowTagPanel.Size = new System.Drawing.Size(780, 45);
            this.flowTagPanel.TabIndex = 27;
            // 
            // flowSchedulePanel
            // 
            this.flowSchedulePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowSchedulePanel.AutoScroll = true;
            this.flowSchedulePanel.BackColor = System.Drawing.Color.Lavender;
            this.flowSchedulePanel.Location = new System.Drawing.Point(20, 165);
            this.flowSchedulePanel.Name = "flowSchedulePanel";
            this.flowSchedulePanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowSchedulePanel.Size = new System.Drawing.Size(780, 320);
            this.flowSchedulePanel.TabIndex = 28;
            // 
            // btnToggleTags
            // 
            this.btnToggleTags.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleTags.FlatAppearance.BorderSize = 0;
            this.btnToggleTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleTags.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnToggleTags.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnToggleTags.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnToggleTags.IconColor = System.Drawing.Color.Black;
            this.btnToggleTags.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnToggleTags.Location = new System.Drawing.Point(797, 107);
            this.btnToggleTags.Name = "btnToggleTags";
            this.btnToggleTags.Size = new System.Drawing.Size(27, 28);
            this.btnToggleTags.TabIndex = 29;
            this.btnToggleTags.Text = "⯆";
            this.btnToggleTags.UseVisualStyleBackColor = false;
            // 
            // Tags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnToggleTags);
            this.Controls.Add(this.flowSchedulePanel);
            this.Controls.Add(this.flowTagPanel);
            this.Controls.Add(this.btnSetting);
            this.Name = "Tags";
            this.Size = new System.Drawing.Size(844, 530);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnSetting;
        private System.Windows.Forms.FlowLayoutPanel flowTagPanel;
        private System.Windows.Forms.FlowLayoutPanel flowSchedulePanel;
        private FontAwesome.Sharp.IconButton btnToggleTags;
    }
}

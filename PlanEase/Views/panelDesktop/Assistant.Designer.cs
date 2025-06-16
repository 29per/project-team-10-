namespace PlanEase.Views.panelDesktop
{
    partial class Assistant
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
            this.flowChatPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // flowChatPanel1
            // 
            this.flowChatPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowChatPanel1.AutoScroll = true;
            this.flowChatPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.flowChatPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowChatPanel1.Location = new System.Drawing.Point(200, 0);
            this.flowChatPanel1.Name = "flowChatPanel1";
            this.flowChatPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowChatPanel1.Size = new System.Drawing.Size(700, 520);
            this.flowChatPanel1.TabIndex = 0;
            this.flowChatPanel1.WrapContents = false;
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(200, 530);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(700, 130);
            this.txtInput.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSend.IconChar = FontAwesome.Sharp.IconChar.Rocketchat;
            this.btnSend.IconColor = System.Drawing.Color.Black;
            this.btnSend.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSend.Location = new System.Drawing.Point(844, 608);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(56, 52);
            this.btnSend.TabIndex = 2;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Assistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.flowChatPanel1);
            this.Name = "Assistant";
            this.Size = new System.Drawing.Size(1100, 720);
            this.Load += new System.EventHandler(this.Assistant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowChatPanel1;
        private System.Windows.Forms.TextBox txtInput;
        private FontAwesome.Sharp.IconButton btnSend;
    }
}

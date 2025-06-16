using SiticoneNetFrameworkUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanEase.Views.Controls
{
    public partial class ChatBubbleControl : UserControl
    {
        public ChatBubbleControl()
        {
            InitializeComponent();
        }
        public ChatBubbleControl(string message, bool isUser)
        {
            InitializeComponent();

            lblMessage.Text = message;
            lblMessage.AutoSize = true;
            //lblMessage.MaximumSize = new Size(350, 0); // 가로 제한, 줄바꿈 유도

            siticoneCard1.BackColor = isUser ? Color.SkyBlue : Color.LightGray;
            siticoneCard1.ForeColor = isUser ? Color.White : Color.Black;

            //this.Dock = isUser ? DockStyle.Right : DockStyle.Left;
            //this.Anchor = isUser ? AnchorStyles.Right : AnchorStyles.Left;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowOnly;

           
        }

        private void siticoneCard1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

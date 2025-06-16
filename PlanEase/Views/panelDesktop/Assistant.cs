using PlanEase.Views.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanEase.Views.Controls;
using PlanEase.LLM.Agents;
using PlanEase.Services;

namespace PlanEase.Views.panelDesktop
{
    public partial class Assistant : UserControl
    {
        ScheduleManager scheduleManager;
        private readonly int userId;
        private PlannerAgent plannerAgent;
        public Assistant(ScheduleManager shceduleManager, int userId)
        {
            InitializeComponent();
            this.scheduleManager = shceduleManager;
            this.userId = userId;
            plannerAgent = new PlannerAgent(scheduleManager, userId);
        }

        private void Assistant_Load(object sender, EventArgs e)
        {
            // 초기 안내 메시지
            // 말풍선 만들고 바로 message, isUser 지정
            var welcome = new ChatBubbleControl("안녕하세요! 저는 PlanEase Assistant입니다. 😊", isUser: false);
            flowChatPanel1.Controls.Add(welcome);

        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(userInput)) return;

            // 사용자 말풍선 추가
            var userBubble = new ChatBubbleControl(userInput, true);
            flowChatPanel1.Controls.Add(userBubble);

            txtInput.Clear();

            // GPT 처리
            string assistantReply = await plannerAgent.HandleUserInputAsync(userInput); // 핵심 처리
            var botBubble = new ChatBubbleControl(assistantReply, false);
            flowChatPanel1.Controls.Add(botBubble);

            // 스크롤 맨 아래로
            flowChatPanel1.ScrollControlIntoView(botBubble);
        }
    }
}

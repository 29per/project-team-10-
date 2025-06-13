using PlanEase.Models;
using PlanEase.Services;
using PlanEase.Views.Controls;
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


namespace PlanEase.Views.panelDesktop
{
    public partial class Tags : UserControl
    {
        private HashSet<string> selectedTags = new HashSet<string>();
        private bool isTagPanelExpanded = true;
        private readonly TagManager tagManager;
        private readonly ScheduleManager scheduleManager;
        private readonly int userId;

        public Tags(TagManager tagManager, ScheduleManager scheduleManager, int userId)
        {
            InitializeComponent();
            this.tagManager = tagManager;
            this.scheduleManager = scheduleManager;
            this.userId = userId;

            LoadTagButtons();
            //btnToggleTags.Click += BtnToggleTags_Click;
            UpdateScheduleCards();

        }
        // 태그 버튼 로딩 함수
        private void LoadTagButtons()
        {
            flowTagPanel.Controls.Clear();

            foreach (var tag in tagManager.GetAllTags())
            {
                var btn = new Button
                {
                    Text = tag.Name,
                    Tag = tag.Name,
                    AutoSize = true,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.Transparent,
                    ForeColor = Color.Black,
                    Font = new Font("Segoe UI", 15, FontStyle.Regular),
                    Margin = new Padding(5),
                    Cursor = Cursors.Hand
                };

                // Border 없애기
                btn.FlatAppearance.BorderSize = 0;
                //btn.FlatAppearance.MouseOverBackColor = Color.Lavender;
                //btn.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;

                btn.Click += TagButton_Click;
                flowTagPanel.Controls.Add(btn);
            }
        }

        // 태그 버튼 클릭 이벤트 핸들러
        private void TagButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var tag = btn.Tag.ToString().ToLower();

            if (selectedTags.Contains(tag))
            {
                selectedTags.Remove(tag);
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            }
            else
            {
                selectedTags.Add(tag);
                btn.ForeColor = Color.DeepSkyBlue;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }

            UpdateScheduleCards(); // 선택된 태그 기준으로 일정 갱신
        }


        // 접기/펴기 버튼 이벤트 핸들러
        private void BtnToggleTags_Click(object sender, EventArgs e)
        {
            isTagPanelExpanded = !isTagPanelExpanded;
            flowTagPanel.Visible = isTagPanelExpanded;
            //btnToggleTags.Text = isTagPanelExpanded ? "⯅" : "⯆";
        }

        // 태그 필터링 및 카드 추가
        private void UpdateScheduleCards()
        {
            flowSchedulePanel.Controls.Clear();

            var allSchedules = scheduleManager.GetAllSchedules(); // 모든 일정 가져오기
            var normalizedSelectedTags = selectedTags.Select(t => t.Trim().ToLower().TrimStart('#')).ToHashSet(); // #제거
            var filtered = allSchedules.Where(s => normalizedSelectedTags.Count == 0 ||
                                        s.Tags.Any(tag => normalizedSelectedTags
                                        .Contains(tag.Trim().ToLower().TrimStart('#')))) // tag도 # 제거
                                        .ToList();

            foreach (var schedule in filtered)
            {
                var card = new ScheduleCard(schedule, (id) =>
                {
                    scheduleManager.RemoveSchedule(id);
                    UpdateScheduleCards();
                });

                flowSchedulePanel.Controls.Add(card);
            }

            //foreach (var schedule in filtered)
            //{
            //    var card = CreateScheduleCard(schedule);
            //    flowSchedulePanel.Controls.Add(card);
            //}
        }


        //SiticoneCard 동적 생성
        //private SiticoneCard CreateScheduleCard(Schedule s)
        //{
        //    var card = new SiticoneCard
        //    {
        //        Size = new Size(180, 150),
        //        BackColor = Color.Transparent,
        //        BackgroundColor1 = Color.Lavender,
        //        BackgroundColor2 = Color.Lavender,
        //        BorderColor1 = Color.MediumSlateBlue,
        //        BorderColor2 = Color.Plum,
        //        BorderAngle = 45,
        //        BorderWidth = 5,
        //        BorderStyleEx = CustomBorderStyleFx.Solid,
        //        ShowBorder = true,
        //        TopLeftRadius = 30,
        //        TopRightRadius = 30,
        //        BottomLeftRadius = 30,
        //        BottomRightRadius = 30,
        //        ShadowColor = Color.DarkSlateBlue,
        //        ShadowDepth = 15,
        //        ShadowOpacity = 10,
        //        Elevation = 20,
        //        EnableHoverEffect = true,
        //        HoverBackColor = Color.White,
        //        Margin = new Padding(8)
        //    };

        //    // 제목
        //    var lblTitle = new Label
        //    {
        //        Text = s.Title,
        //        Font = new Font("Segoe UI", 12, FontStyle.Bold),
        //        AutoSize = false,
        //        TextAlign = ContentAlignment.MiddleCenter,
        //        Dock = DockStyle.Top,
        //        Height = 40
        //    };

        //    // 시간
        //    var lblTime = new Label
        //    {
        //        Text = $"{s.StartTime:MM/dd HH:mm} - {s.EndTime:HH:mm}",
        //        Font = new Font("Segoe UI", 9),
        //        Dock = DockStyle.Top,
        //        Height = 30,
        //        TextAlign = ContentAlignment.MiddleCenter
        //    };

        //    // 중요도
        //    var lblPriority = new Label
        //    {
        //        Text = $"중요도: {s.Priority}",
        //        Font = new Font("Segoe UI", 9, FontStyle.Italic),
        //        Dock = DockStyle.Top,
        //        Height = 25,
        //        TextAlign = ContentAlignment.MiddleCenter
        //    };

        //    // 태그
        //    var lblTags = new Label
        //    {
        //        Text = $"#{string.Join(" #", s.Tags)}",
        //        Font = new Font("Segoe UI", 9),
        //        Dock = DockStyle.Top,
        //        Height = 30,
        //        TextAlign = ContentAlignment.MiddleCenter
        //    };

        //    // 삭제 버튼
        //    var btnDelete = new Button
        //    {
        //        Text = "✕",
        //        ForeColor = Color.Red,
        //        BackColor = Color.Transparent,
        //        FlatStyle = FlatStyle.Flat,
        //        Font = new Font("Segoe UI", 9, FontStyle.Bold),
        //        Size = new Size(24, 24),
        //        Location = new Point(card.Width - 40, 10),
        //        Cursor = Cursors.Hand
        //    };
        //    btnDelete.FlatAppearance.BorderSize = 0;
        //    btnDelete.FlatAppearance.MouseOverBackColor = Color.LightPink;

        //    btnDelete.Click += (sender, e) =>
        //    {
        //        var confirm = MessageBox.Show(
        //            "이 일정을 삭제하시겠습니까?", "삭제 확인",
        //            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        //        if (confirm == DialogResult.Yes)
        //        {
        //            scheduleManager.RemoveSchedule(s.Id); // 
        //            UpdateScheduleCards(); // UI 갱신
        //        }
        //    };

        //    // 컨트롤 추가
        //    card.Controls.Add(lblTags);
        //    card.Controls.Add(lblPriority);
        //    card.Controls.Add(lblTime);
        //    card.Controls.Add(lblTitle);
        //    card.Controls.Add(btnDelete);
        //    btnDelete.BringToFront();


        //    return card;
        //}

    }
}

using PlanEase.LLM.Chains;
using PlanEase.Models;
using PlanEase.Services;
using PlanEase.Services.ScheduleConflict;
using PlanEase.Views.panelDesktop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PlanEase.LLM.Chains;

namespace PlanEase.Views
{
    public partial class AddScheduleForm_new_ : Form
    {
        private readonly ScheduleManager scheduleManager;
        private readonly TagManager tagManager;
        private readonly int userId;
        private readonly Planner planner;

        private Schedule? editingSchedule = null;
        private Action? refreshCallback = null;

        public AddScheduleForm_new_()
        {
            InitializeComponent();
        }

        public AddScheduleForm_new_(int userId, ScheduleManager scheduleManager, TagManager tagManager, Planner planner)
        {
            InitializeComponent();
            this.scheduleManager = scheduleManager;
            this.tagManager = tagManager;
            this.userId = userId;
            this.planner = planner;
        }
        //  일정 수정용
        public AddScheduleForm_new_(Schedule editing, ScheduleManager scheduleManager, TagManager tagManager, Action? refreshCallback = null)
        {
            InitializeComponent();
            this.scheduleManager = scheduleManager;
            this.tagManager = tagManager;
            this.userId = editing.UserId;
            this.editingSchedule = editing;
            this.refreshCallback = refreshCallback;

            cmbPriority.Items.AddRange(new string[]
   {
        "매우 낮음",
        "낮음",
        "보통",
        "높음",
        "매우 높음"
   });

            // 안전한 범위 내에서 SelectedIndex 설정
            int index = (int)editing.Priority - 1;
            if (index >= 0 && index < cmbPriority.Items.Count)
                cmbPriority.SelectedIndex = index;
            else
                cmbPriority.SelectedIndex = 2; // 기본값 (보통)

            // 시간/분 콤보박스도 미리 채움
            string[] hours = Enumerable.Range(0, 24).Select(h => h.ToString("D2")).ToArray();
            string[] minutes = Enumerable.Range(0, 60).Select(m => m.ToString("D2")).ToArray();
            cmbStartHour.Items.AddRange(hours);
            cmbEndHour.Items.AddRange(hours);
            cmbStartMinute.Items.AddRange(minutes);
            cmbEndMinute.Items.AddRange(minutes);

            // UI 채우기
            txtTitle.Text = editing.Title;
            txtTag.Text = string.Join(", ", editing.Tags);
            txtDescription.Text = editing.Description;

            dtpStartTime.Value = editing.StartTime.Date;
            dtpEndTime.Value = editing.EndTime.Date;
            cmbStartHour.SelectedItem = editing.StartTime.Hour.ToString("D2");
            cmbStartMinute.SelectedItem = editing.StartTime.Minute.ToString("D2");
            cmbEndHour.SelectedItem = editing.EndTime.Hour.ToString("D2");
            cmbEndMinute.SelectedItem = editing.EndTime.Minute.ToString("D2");

            cmbPriority.SelectedIndex = (int)editing.Priority - 1;

            this.Text = "일정 수정";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e) { }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e) { }

        private void AddScheduleForm_new__Load(object sender, EventArgs e)
        {
            cmbPriority.Items.AddRange(new string[]
            {
                "매우 낮음",
                "낮음",
                "보통",
                "높음",
                "매우 높음"
            });

            cmbPriority.SelectedIndex = 2; // Medium

            // 시간(00~23), 분(00~59) 콤보박스 채우기
            string[] hours = Enumerable.Range(0, 24).Select(h => h.ToString("D2")).ToArray();
            string[] minutes = Enumerable.Range(0, 60).Select(m => m.ToString("D2")).ToArray();

            cmbStartHour.Items.AddRange(hours);
            cmbEndHour.Items.AddRange(hours);
            cmbStartMinute.Items.AddRange(minutes);
            cmbEndMinute.Items.AddRange(minutes);

            // 기본값 설정 (예: 09:00 ~ 10:00)
            cmbStartHour.SelectedItem = "09";
            cmbStartMinute.SelectedItem = "00";
            cmbEndHour.SelectedItem = "10";
            cmbEndMinute.SelectedItem = "00";

            float dpiScale = this.DeviceDpi / 96f; // 96 DPI = 1.0
            this.siticoneBorderlessForm1.NavBarHeight = (int)(30 * dpiScale);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. 필수값 유효성 검사
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("제목을 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 날짜 + 시간 조합
            DateTime startDate = dtpStartTime.Value.Date;
            DateTime endDate = dtpEndTime.Value.Date;

            if (!int.TryParse(cmbStartHour.SelectedItem?.ToString(), out int startHour) ||
                !int.TryParse(cmbStartMinute.SelectedItem?.ToString(), out int startMinute) ||
                !int.TryParse(cmbEndHour.SelectedItem?.ToString(), out int endHour) ||
                !int.TryParse(cmbEndMinute.SelectedItem?.ToString(), out int endMinute))
            {
                MessageBox.Show("시작/종료 시간과 분을 정확히 선택해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime startTime = startDate.AddHours(startHour).AddMinutes(startMinute);
            DateTime endTime = endDate.AddHours(endHour).AddMinutes(endMinute);

            if (endTime <= startTime)
            {
                MessageBox.Show("종료 시간이 시작 시간보다 빠를 수 없습니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. 태그 파싱 및 등록
            List<string> tagList = txtTag.Text
                .Split(new[] { ',', ' ', '|' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim())
                .Where(t => !string.IsNullOrWhiteSpace(t))
                .Distinct()
                .ToList();
            foreach (var tag in tagList)
            {
                tagManager.RegisterIfNew(tag, userId);
            }

            // 3. Schedule 객체 생성
            var schedule = new Schedule
            {
                Title = txtTitle.Text.Trim(),
                StartTime = dtpStartTime.Value,
                EndTime = dtpEndTime.Value,
                Tags = tagList, // Schedule.cs가 List<string>이면 OK, List<Tag>라면 매핑 필요
                Priority = (PriorityLevel)(cmbPriority.SelectedIndex + 1),
                Description = txtDescription.Text.Trim(),
                IsCompleted = false,
                UserId = userId
            };

                var allSchedules = scheduleManager.GetAllSchedules();
                var conflicts = allSchedules.Where(s => ConflictChecker.IsConflict(schedule, s)).ToList();

            // 5. 충돌 검사
            var conflictingSchedules = allSchedules
                .Where(s => ConflictChecker.IsConflict(schedule, s))
                .ToList();

            if (conflictingSchedules.Any())
            {
                // 6. 충돌 시 ConflictResolutionForm 띄우기
                var resolver = new ConflictResolver(scheduleManager);
                var conflictForm = new ConflictResolutionForm(schedule, conflictingSchedules, resolver);
                var result = conflictForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                // 사용자가 취소 또는 무시하면 일정 등록 안 함
                return;
            }
            else
            {
                // 7. 충돌 없으면 일정 추가
                scheduleManager.AddSchedule(schedule);
                planner.calendar.ShowMonth(schedule.StartTime);

                MessageBox.Show("일정이 성공적으로 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTextbox_Paint(object sender, PaintEventArgs e) { }

        private async void btnTag_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("일정 제목을 입력하세요.");
                return;
            }

            txtTag.Text = "GPT 호출 중...";

            try
            {
                var pipeline = new TagRecommendationPipeline();
                var resultTags = await pipeline.RecommendTagsAsync(title);

                txtTag.Text = string.Join(", ", resultTags);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
                txtTag.Text = "";
            }
        }

      
    }
}
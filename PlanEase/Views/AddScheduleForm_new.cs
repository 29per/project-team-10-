using PlanEase.Models;
using PlanEase.Services;
using PlanEase.Services.ScheduleConflict;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PlanEase.Views
{
    public partial class AddScheduleForm_new_ : Form
    {
        private readonly ScheduleManager scheduleManager;
        private readonly TagManager tagManager;
        private readonly int userId;

        public AddScheduleForm_new_()
        {
            InitializeComponent();
        }

        public AddScheduleForm_new_(int userId, ScheduleManager scheduleManager, TagManager tagManager)
        {
            InitializeComponent();
            this.scheduleManager = scheduleManager;
            this.tagManager = tagManager;
            this.userId = userId;
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
            if (dtpEndTime.Value <= dtpStartTime.Value)
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

            // 4. 기존 일정 가져오기
            List<Schedule> allSchedules = scheduleManager.GetAllSchedules();

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
    }
}
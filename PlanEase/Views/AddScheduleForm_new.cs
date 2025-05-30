using PlanEase.Models;
using PlanEase.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanEase.Views
{
    public partial class AddScheduleForm_new_ : Form
    {
        private  readonly ScheduleManager scheduleManager;
        private readonly int userId;

        public AddScheduleForm_new_()
        {
            InitializeComponent();
        }

        public AddScheduleForm_new_(int userId, ScheduleManager scheduleManager)
        {
            InitializeComponent();
            this.scheduleManager = scheduleManager;
            this.userId = userId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {

        }

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

            cmbPriority.SelectedIndex = 2; // 기본값: 보통 = Medium
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //1.필수값 유효성 검사
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

            // 2. Schedule 객체 생성
            var schedule = new Schedule
            {
                Title = txtTitle.Text.Trim(),
                StartTime = dtpStartTime.Value,
                EndTime = dtpEndTime.Value,
                Tags = txtTag.Text
                    .Split(new[] { ',', ' ', '|' }, StringSplitOptions.RemoveEmptyEntries)
                    .Distinct()
                    .ToList(),
                Priority = (PriorityLevel)(cmbPriority.SelectedIndex + 1), // Enum: 1부터 시작
                Description = txtDescription.Text.Trim(),
                IsCompleted = false, // 새 일정은 미완료 상태로 추가
                UserId = userId // ⚠ 필요 시 전역 또는 폼 생성자에서 받은 값
            };

            // 3. 일정 추가
            scheduleManager.AddSchedule(schedule);

            // 4. 사용자 알림
            MessageBox.Show("일정이 성공적으로 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

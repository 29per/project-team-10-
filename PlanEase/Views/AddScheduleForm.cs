using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PlanEase.Models;
using PlanEase.Services;
using PlanEase.Services.ScheduleConflict;

namespace PlanEase.Views
{
    public partial class AddScheduleForm : Form
    {
        private readonly ScheduleManager _scheduleManager;
        private readonly TagManager _tagManager;
        private readonly int _userId;

        public AddScheduleForm(ScheduleManager scheduleManager, TagManager tagManager, int userId)
        {
            InitializeComponent();
            _scheduleManager = scheduleManager;
            _tagManager = tagManager;
            _userId = userId;

            // 1. 유저별 태그 불러오기 (DB에서 로드)
            _tagManager.LoadTagsFromDb(_userId);

            // 2. 콤보박스에 태그 바인딩
            cboTag.DataSource = _tagManager.GetAllTags();
            cboTag.DisplayMember = "Name";
            cboTag.ValueMember = "Id";

            btnConfirm.Click += btnConfirm_Click;
        }

        private void AddScheduleForm_Load(object sender, EventArgs e)
        {
            // 여기에 로드시 초기화 코드 삽입
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Tag 객체 선택
            var selectedTag = cboTag.SelectedItem as Tag;

            var newSchedule = new Schedule
            {
                Title = txtTitle.Text,
                StartTime = dtpStartTime.Value,
                EndTime = dtpEndTime.Value,
                //Tag = selectedTag,
                Description = txtDescription.Text,
                UserId = _userId
            };

            // 2. 기존 일정 가져오기
            List<Schedule> allSchedules = _scheduleManager.GetAllSchedules();

            // 3. 충돌 검사
            var conflictingSchedules = allSchedules
                .Where(s => ConflictChecker.IsConflict(newSchedule, s))
                .ToList();

            if (conflictingSchedules.Any())
            {
                var resolver = new ConflictResolver(_scheduleManager);
                var conflictForm = new ConflictResolutionForm(newSchedule, conflictingSchedules, resolver);
                var result = conflictForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                return;
            }
            else
            {
                _scheduleManager.AddSchedule(newSchedule);
                MessageBox.Show("일정이 등록되었습니다!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
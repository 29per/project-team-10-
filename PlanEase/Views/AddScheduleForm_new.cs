using PlanEase.Models;
using PlanEase.Services;
using PlanEase.Services.ScheduleConflict;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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
                Tags = tagList,
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
                // 6. 충돌 시 처리
                var resolver = new ConflictResolver(scheduleManager);

                // SettingManager를 통해 현재 설정 가져오기
                var settingManager = new SettingManager();
                settingManager.LoadSetting(userId);
                var currentSetting = settingManager.GetSetting();

                // 자동 충돌 해결 여부 확인
                bool autoResolveEnabled = currentSetting.UseAutoConflictResolution;

                if (autoResolveEnabled)
                {
                    // 자동 해결 활성화 - 충돌 유형에 따라 자동 해결
                    resolver.SetAutoResolution(true);

                    // 충돌 유형별로 그룹화하여 처리
                    var conflictsByType = ConflictChecker.FindConflictsByType(schedule, conflictingSchedules);

                    // 충돌 유형별로 처리 결과 추적
                    StringBuilder resultMessage = new StringBuilder("충돌이 자동으로 처리되었습니다:\n\n");
                    bool hasProcessed = false;

                    // 각 충돌 유형별 처리
                    foreach (var conflictGroup in conflictsByType)
                    {
                        ConflictType conflictType = conflictGroup.Key;
                        List<Schedule> conflicts = conflictGroup.Value;

                        // 충돌 유형에 따른 기본 처리 방식 결정
                        switch (conflictType)
                        {
                            case ConflictType.Same: // 완전 일치
                                                    // 동일한 일정은 병합 처리
                                foreach (var conflict in conflicts)
                                {
                                    resolver.Merge(schedule, conflict);
                                }
                                resultMessage.AppendLine($"- 동일한 일정 {conflicts.Count}개가 병합되었습니다.");
                                hasProcessed = true;
                                break;

                            case ConflictType.Contain: // A가 B를 포함
                                                       // 새 일정이 기존 일정을 포함하면 기존 일정 삭제
                                foreach (var conflict in conflicts)
                                {
                                    resolver.Delete(conflict);
                                }
                                resultMessage.AppendLine($"- 포함된 일정 {conflicts.Count}개가 삭제되었습니다.");
                                hasProcessed = true;
                                break;

                            case ConflictType.Contain2: // B가 A를 포함
                                                        // 기존 일정이 새 일정을 포함하면 시간 변경
                                                        // 가장 늦은 종료 시간 이후로 설정
                                DateTime newStartTime = schedule.StartTime;
                                foreach (var conflict in conflicts)
                                {
                                    if (conflict.EndTime > newStartTime)
                                    {
                                        newStartTime = conflict.EndTime;
                                    }
                                }

                                TimeSpan duration = schedule.EndTime - schedule.StartTime;
                                DateTime newEndTime = newStartTime.Add(duration);

                                schedule.StartTime = newStartTime;
                                schedule.EndTime = newEndTime;

                                resultMessage.AppendLine($"- 일정이 포함된 경우, 시간이 변경되었습니다: {newStartTime:HH:mm}~{newEndTime:HH:mm}");
                                hasProcessed = true;
                                break;

                            case ConflictType.Overlap: // A가 먼저 시작, 일부 겹침
                            case ConflictType.Overlap2: // B가 먼저 시작, 일부 겹침
                                                        // 일부 겹침은 시간 변경으로 처리
                                                        // 가장 늦은 종료 시간 이후로 설정
                                DateTime overlapNewStart = schedule.StartTime;
                                foreach (var conflict in conflicts)
                                {
                                    if (conflict.EndTime > overlapNewStart)
                                    {
                                        overlapNewStart = conflict.EndTime;
                                    }
                                }

                                TimeSpan overlapDuration = schedule.EndTime - schedule.StartTime;
                                DateTime overlapNewEnd = overlapNewStart.Add(overlapDuration);

                                schedule.StartTime = overlapNewStart;
                                schedule.EndTime = overlapNewEnd;

                                resultMessage.AppendLine($"- 일부 겹친 일정이 있어 시간이 변경되었습니다: {overlapNewStart:HH:mm}~{overlapNewEnd:HH:mm}");
                                hasProcessed = true;
                                break;

                            case ConflictType.After: // A 다음에 B
                            case ConflictType.Before: // B 다음에 A
                                                      // 연속된 일정은 그대로 두거나 병합 가능
                                                      // 여기서는 그대로 둠
                                resultMessage.AppendLine($"- 연속된 일정 {conflicts.Count}개가 유지되었습니다.");
                                hasProcessed = true;
                                break;

                            default:
                                // 기타 충돌 유형은 일단 무시
                                break;
                        }
                    }

                    // 처리 결과 메시지 표시
                    if (hasProcessed)
                    {
                        MessageBox.Show(resultMessage.ToString(), "충돌 자동 해결", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 충돌이 해결된 경우 일정 추가
                        scheduleManager.AddSchedule(schedule);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        // 처리되지 않은 충돌이 있는 경우 사용자에게 물어봄
                        MessageBox.Show("자동으로 처리할 수 없는 충돌이 있습니다. 수동으로 해결해주세요.",
                            "충돌 해결 필요", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        var conflictForm = new ConflictResolutionForm(schedule, conflictingSchedules, resolver);
                        var result = conflictForm.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        return;
                    }
                }
                else
                {
                    // 자동 충돌 해결이 비활성화된 경우
                    // 전략에 따라 처리
                    var strategy = currentSetting.DefaultStrategy;

                    if (strategy == ConflictResolutionStrategy.AskUser)
                    {
                        // 사용자에게 물어보는 전략
                        var conflictForm = new ConflictResolutionForm(schedule, conflictingSchedules, resolver);
                        var result = conflictForm.ShowDialog();

                        if (result != DialogResult.OK)
                        {
                            // 사용자가 취소 또는 무시하면 일정 등록 안 함
                            return;
                        }

                        // ConflictResolutionForm에서 OK를 누르면 이미 처리되었을 수 있음
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        return;
                    }
                    else
                    {
                        // 다른 전략은 기존 코드와 동일하게 처리
                        switch (strategy)
                        {
                            case ConflictResolutionStrategy.Merge:
                                // 병합 전략
                                foreach (var conflictingSchedule in conflictingSchedules)
                                {
                                    resolver.Merge(schedule, conflictingSchedule);
                                }
                                MessageBox.Show("충돌이 자동으로 병합 처리되었습니다.", "충돌 해결", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;

                            case ConflictResolutionStrategy.ChangeTime:
                                // 시간 변경 전략
                                DateTime newStartTime = schedule.StartTime;
                                DateTime newEndTime = schedule.EndTime;

                                foreach (var conflictingSchedule in conflictingSchedules)
                                {
                                    if (conflictingSchedule.EndTime > newStartTime)
                                    {
                                        newStartTime = conflictingSchedule.EndTime;
                                        TimeSpan duration = schedule.EndTime - schedule.StartTime;
                                        newEndTime = newStartTime.Add(duration);
                                    }
                                }

                                schedule.StartTime = newStartTime;
                                schedule.EndTime = newEndTime;

                                MessageBox.Show($"충돌이 자동으로 시간 변경으로 처리되었습니다.\n새 시간: {newStartTime:HH:mm}~{newEndTime:HH:mm}",
                                    "충돌 해결", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;

                            case ConflictResolutionStrategy.Delete:
                                // 삭제 전략
                                foreach (var conflictingSchedule in conflictingSchedules)
                                {
                                    resolver.Delete(conflictingSchedule);
                                }
                                MessageBox.Show("충돌이 자동으로 기존 일정 삭제로 처리되었습니다.", "충돌 해결", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;

                            default:
                                MessageBox.Show("알 수 없는 충돌 해결 전략입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }

                        // 충돌이 해결된 경우 일정 추가
                        scheduleManager.AddSchedule(schedule);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PlanEase.Models;
using PlanEase.Services.ScheduleConflict;

namespace PlanEase.Views
{
    public partial class ConflictResolutionForm : Form
    {
        private readonly Schedule _currentSchedule;
        private readonly List<Schedule> _conflictingSchedules;
        private readonly ConflictResolver _conflictResolver;

        // 동적 입력 패널
        private Panel panelTimeChange;
        private Label lblNewStart, lblNewEnd;
        private DateTimePicker dtpNewStart, dtpNewEnd;

        private Panel panelMerge;
        private Label lblMerge;
        private ComboBox cmbMergeTarget;

        public ConflictResolutionForm(
            Schedule currentSchedule,
            List<Schedule> conflictingSchedules,
            ConflictResolver conflictResolver)
        {
            InitializeComponent();

            _currentSchedule = currentSchedule;
            _conflictingSchedules = conflictingSchedules;
            _conflictResolver = conflictResolver;

            // 동적 UI 패널 추가
            SetupDynamicPanels();

            // 라디오 버튼 이벤트 연결
            radioChangeTime.CheckedChanged += OnStrategyChanged;
            radioMerge.CheckedChanged += OnStrategyChanged;
            radioDelete.CheckedChanged += OnStrategyChanged;

            btnOk.Click += btnOk_Click;
            btnCancel.Click += (s, e) => this.Close();

            // 최초엔 시간 변경 UI 보이기
            radioChangeTime.Checked = true;
            ShowPanel(panelTimeChange);
        }

        private void SetupDynamicPanels()
        {
            // 시간 변경 입력 패널
            panelTimeChange = new Panel
            {
                Location = new System.Drawing.Point(44, 180),
                Size = new System.Drawing.Size(400, 40),
                Visible = false
            };
            lblNewStart = new Label { Text = "시작 시간:", Location = new System.Drawing.Point(0, 10), ForeColor = System.Drawing.Color.WhiteSmoke, AutoSize = true };
            dtpNewStart = new DateTimePicker { Format = DateTimePickerFormat.Custom, CustomFormat = "yyyy-MM-dd HH:mm", Location = new System.Drawing.Point(70, 5), Width = 120 };
            lblNewEnd = new Label { Text = "종료 시간:", Location = new System.Drawing.Point(200, 10), ForeColor = System.Drawing.Color.WhiteSmoke, AutoSize = true };
            dtpNewEnd = new DateTimePicker { Format = DateTimePickerFormat.Custom, CustomFormat = "yyyy-MM-dd HH:mm", Location = new System.Drawing.Point(270, 5), Width = 120 };
            panelTimeChange.Controls.Add(lblNewStart);
            panelTimeChange.Controls.Add(dtpNewStart);
            panelTimeChange.Controls.Add(lblNewEnd);
            panelTimeChange.Controls.Add(dtpNewEnd);
            panelMain.Controls.Add(panelTimeChange);

            // 병합 패널
            panelMerge = new Panel
            {
                Location = new System.Drawing.Point(44, 180),
                Size = new System.Drawing.Size(400, 40),
                Visible = false
            };
            lblMerge = new Label { Text = "병합 대상 선택:", Location = new System.Drawing.Point(0, 10), ForeColor = System.Drawing.Color.WhiteSmoke, AutoSize = true };
            cmbMergeTarget = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Location = new System.Drawing.Point(110, 7), Width = 250 };
            foreach (var sch in _conflictingSchedules)
                cmbMergeTarget.Items.Add($"{sch.Title} [{sch.StartTime:g} ~ {sch.EndTime:g}]");
            if (cmbMergeTarget.Items.Count > 0) cmbMergeTarget.SelectedIndex = 0;
            panelMerge.Controls.Add(lblMerge);
            panelMerge.Controls.Add(cmbMergeTarget);
            panelMain.Controls.Add(panelMerge);
        }

        private void OnStrategyChanged(object sender, EventArgs e)
        {
            if (radioChangeTime.Checked)
                ShowPanel(panelTimeChange);
            else if (radioMerge.Checked)
                ShowPanel(panelMerge);
            else
                ShowPanel(null);
        }

        private void ShowPanel(Panel panelToShow)
        {
            panelTimeChange.Visible = panelToShow == panelTimeChange;
            panelMerge.Visible = panelToShow == panelMerge;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // 충돌이 여전히 존재하는지 확인
            // ConflictChecker.IsConflict는 static 메서드이므로 아래처럼 사용합니다.
            bool stillConflict = _conflictingSchedules.Any(s =>
                PlanEase.Services.ScheduleConflict.ConflictChecker.IsConflict(_currentSchedule, s));
            if (!_conflictingSchedules.Any() || !stillConflict)
            {
                MessageBox.Show("충돌 대상이 없습니다.", "알림");
                this.Close();
                return;
            }

            if (radioChangeTime.Checked)
            {
                DateTime newStart = dtpNewStart.Value;
                DateTime newEnd = dtpNewEnd.Value;
                if (newStart >= newEnd)
                {
                    MessageBox.Show("시작 시간이 종료 시간보다 늦거나 같습니다.", "입력 오류");
                    return;
                }
                _conflictResolver.ChangeTime(_currentSchedule, newStart, newEnd);
                MessageBox.Show("시간 변경 방식으로 해결되었습니다.", "완료");
                this.Close();
            }
            else if (radioMerge.Checked)
            {
                if (cmbMergeTarget.SelectedIndex < 0)
                {
                    MessageBox.Show("병합 대상을 선택하세요.", "입력 오류");
                    return;
                }
                var mergeTarget = _conflictingSchedules[cmbMergeTarget.SelectedIndex];
                _conflictResolver.Merge(_currentSchedule, mergeTarget);
                MessageBox.Show("병합 방식으로 해결되었습니다.", "완료");
                this.Close();
            }
            else if (radioDelete.Checked)
            {
                _conflictResolver.Delete(_currentSchedule);
                MessageBox.Show("삭제 방식으로 해결되었습니다.", "완료");
                this.Close();
            }
        }

        // (디자이너 연결용 빈 메서드, 필요 없다면 .Designer.cs에서 이벤트 연결부분을 지워도 됨)
        private void panelMain_Paint(object sender, PaintEventArgs e) { }

        private void siticoneRadioButton1_Click(object sender, EventArgs e)
        {

        }

        private void radioDelete_Click(object sender, EventArgs e) { }
        private void ConflictResolutionForm_Load(object sender, EventArgs e) { }
    }
}
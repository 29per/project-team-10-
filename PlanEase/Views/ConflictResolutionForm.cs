using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanEase.Models;
using PlanEase.Services;
using PlanEase.Services.ScheduleConflict;

namespace PlanEase.Views
{
    public partial class ConflictResolutionForm : Form
    {
        private ConflictResolver _conflictResolver;
        private Schedule _currentSchedule;
        private Schedule _conflictingSchedule; // 병합 등에서 쓸 대상. 상황에 따라 주입 필요.

        // 생성자에서 전달받거나 별도 set 필요
        public ConflictResolutionForm(Schedule current, Schedule conflicting, ConflictResolver resolver)
        {
            InitializeComponent();
            _currentSchedule = current;
            _conflictingSchedule = conflicting;
            _conflictResolver = resolver;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (radioChangeTime.Checked)
            {
                // 시간 변경: 새 시간은 UI 입력값으로 받아야 함 (예시: DateTimePicker 등)
                DateTime newStart = /* UI에서 가져오기 */;
                DateTime newEnd = /* UI에서 가져오기 */;
                _conflictResolver.ChangeTime(_currentSchedule, newStart, newEnd);
                MessageBox.Show("시간 변경 방식으로 충돌이 해결되었습니다.");
                this.Close();
            }
            else if (radioMerge.Checked)
            {
                // 병합: 두 일정 병합 (여러 개가 있을 경우 선택 UI 필요)
                _conflictResolver.Merge(_currentSchedule, _conflictingSchedule);
                MessageBox.Show("병합 방식으로 충돌이 해결되었습니다.");
                this.Close();
            }
            else if (radioDelete.Checked)
            {
                // 삭제: 현재 일정 삭제
                _conflictResolver.Delete(_currentSchedule);
                MessageBox.Show("삭제 방식으로 충돌이 해결되었습니다.");
                this.Close();
            }
            else
            {
                MessageBox.Show("충돌 처리 방식을 선택해주세요.");
            }
        }
    }
    }

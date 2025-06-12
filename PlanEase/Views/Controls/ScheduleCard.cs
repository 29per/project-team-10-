using PlanEase.Models;
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
    public partial class ScheduleCard : UserControl
    {
        private readonly Schedule schedule;
        private readonly Action<int> onDelete; // 콜백

        public ScheduleCard(Schedule schedule, Action<int> onDelete)
        {
            InitializeComponent();
            this.schedule = schedule;
            this.onDelete = onDelete;

            ApplyData();
            CenterLabelHorizontally(lblTitle);
            CenterLabelHorizontally(lblTime);
            CenterLabelHorizontally(lblPriority);
            CenterLabelHorizontally(lblTags);

        }

        private void ApplyData()
        {
            lblTitle.Text = schedule.Title;
            lblTime.Text = $"{schedule.StartTime:MM/dd HH:mm} - {schedule.EndTime:HH:mm}";
            lblPriority.Text = $"중요도: {schedule.Priority}";
            lblTags.Text = $"#{string.Join(" #", schedule.Tags)}";
        }

        private void CenterLabelHorizontally(Label label)
        {
            label.Left = (this.ClientSize.Width - label.Width) / 2;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("이 일정을 삭제하시겠습니까?", "삭제 확인",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    onDelete?.Invoke(schedule.Id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("삭제 처리 중 오류 발생: " + ex.Message);
                }
            }
        }


    }
}

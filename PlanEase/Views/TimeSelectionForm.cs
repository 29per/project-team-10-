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
    public partial class TimeSelectionForm : Form
    {
        public TimeSelectionForm()
        {
            InitializeComponent();
            for (int i = 0; i < 24; i++)
            {
                cmbStartHour.Items.Add(i.ToString("D2"));
                cmbEndHour.Items.Add(i.ToString("D2"));
            }
            for (int i = 0; i < 60; i++)
            {
                cmbStartMinute.Items.Add(i.ToString("D2"));
                cmbEndMinute.Items.Add(i.ToString("D2"));
            }
            cmbStartHour.SelectedIndex = 9;
            cmbStartMinute.SelectedIndex = 0;
            cmbEndHour.SelectedIndex = 10;
            cmbEndMinute.SelectedIndex = 0;
        }

        public (int, int, int, int) GetSelectedTime()
        {
            return (
                int.Parse(cmbStartHour.SelectedItem.ToString()),
                int.Parse(cmbStartMinute.SelectedItem.ToString()),
                int.Parse(cmbEndHour.SelectedItem.ToString()),
                int.Parse(cmbEndMinute.SelectedItem.ToString())
            );
        }

        private void TimeSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void siticoneCloseButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbStartHour.SelectedItem == null || cmbStartMinute.SelectedItem == null ||
        cmbEndHour.SelectedItem == null || cmbEndMinute.SelectedItem == null)
            {
                MessageBox.Show("시작 시간과 종료 시간을 모두 선택해주세요.");
                return;
            }

            int startHour = int.Parse(cmbStartHour.SelectedItem.ToString());
            int startMinute = int.Parse(cmbStartMinute.SelectedItem.ToString());
            int endHour = int.Parse(cmbEndHour.SelectedItem.ToString());
            int endMinute = int.Parse(cmbEndMinute.SelectedItem.ToString());

            var start = new TimeSpan(startHour, startMinute, 0);
            var end = new TimeSpan(endHour, endMinute, 0);

            if (start >= end)
            {
                MessageBox.Show("종료 시간은 시작 시간보다 늦어야 합니다.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

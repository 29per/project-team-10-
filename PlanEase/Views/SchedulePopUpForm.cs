using MySqlX.XDevAPI;
using PlanEase.Models;
using PlanEase.Views.Controls;
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
    public partial class SchedulePopUpForm : Form
    {
        public static SchedulePopUpForm CurrentInstance { get; private set; }
        public DateTime Date { get; private set; }
        public SchedulePopUpForm(DateTime date, List<Schedule> schedules)
        {
            InitializeComponent();

            this.TopMost = true;
            this.Date = date;
            CurrentInstance = this;

            RefreshScheduleList(schedules);
            this.FormClosed += SchedulePopUpForm_FormClosed;

        }

        public void RemoveScheduleItemById(int id)
        {
            // 일정 ID와 일치하는 컨트롤 제거
            Control toRemove = null;

            foreach (Control ctrl in pnlList.Controls)
            {
                if (ctrl is ScheduleItemControl item && item.ScheduleId == id)
                {
                    toRemove = item;
                    break;
                }
            }

            if (toRemove != null)
                pnlList.Controls.Remove(toRemove);
        }

        public void RefreshScheduleList(List<Schedule> schedules)
        {
            pnlList.Controls.Clear();

            foreach (var sched in schedules)
            {
                var item = new ScheduleItemControl(sched.Title, sched.Priority);
                item.ScheduleId = sched.Id;

                // 드래그를 위해 이벤트 핸들러 추가
                item.MouseDown += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                        DoDragDrop(sched.Id.ToString(), DragDropEffects.Move);
                };

                pnlList.Controls.Add(item);
            }
        }




        private void siticoneCloseButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SchedulePopUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CurrentInstance = null;
        }
    }
}

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

namespace PlanEase.Views.Controls
{
    public partial class ScheduleItemControl : UserControl
    {
        public int ScheduleId { get; set; }
        private ToolTip tooltip;
        private ScheduleManager scheduleManager;
        private ContextMenuStrip contextMenu;
        public event Action<Schedule>? ScheduleEditRequested;


        public ScheduleItemControl(string title, PriorityLevel importance, ScheduleManager shceduleManager)
        {
            InitializeComponent();
            lblTitle.Text = title;
            tooltip = new ToolTip();
            tooltip.SetToolTip(lblTitle, title);

            SetImportanceColor(importance);
            this.scheduleManager = shceduleManager;
            this.MouseDown += ScheduleItem_MouseDown;
            lblTitle.MouseDown += ScheduleItem_MouseDown; // 내부 Label에도 이벤트 연결
            this.MouseUp += ScheduleItem_MouseUp;
            lblTitle.MouseUp += ScheduleItem_MouseUp;

            // Context Menu 설정
            contextMenu = new ContextMenuStrip();
            var editItem = new ToolStripMenuItem("수정하기");
            var editItem2 = new ToolStripMenuItem("복사하기");
            var editItem3 = new ToolStripMenuItem("붙여하기");
            editItem.Click += (s, e) => TriggerEdit();
            contextMenu.Items.Add(editItem);
        }


        private void SetImportanceColor(PriorityLevel importance)
        {
            // 1~5 중요도에 따라 파스텔톤 색상
            switch (importance)
            {
                case PriorityLevel.VeryHigh:
                    this.BackColor = Color.MistyRose; break;
                case PriorityLevel.High:
                    this.BackColor = Color.LemonChiffon; break;
                case PriorityLevel.Medium:
                    this.BackColor = Color.Honeydew; break;
                case PriorityLevel.Low:
                    this.BackColor = Color.LightCyan; break;
                case PriorityLevel.VeryLow:
                    this.BackColor = Color.MediumPurple; break;
                default:
                    this.BackColor = Color.WhiteSmoke; break;
            }
        }

        private void ScheduleItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(ScheduleId.ToString(), DragDropEffects.Move);
            }
        }
        private void ScheduleItem_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenu.Show(Cursor.Position);
            }
        }

        private void TriggerEdit()
        {
            if (this.scheduleManager != null)
            {
                var schedule = scheduleManager.GetAllSchedules()
                                              .FirstOrDefault(s => s.Id == this.ScheduleId);
                if (schedule != null)
                {
                    ScheduleEditRequested?.Invoke(schedule);
                }
            }
        }
    }
}

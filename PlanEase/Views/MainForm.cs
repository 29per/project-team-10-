using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PlanEase.Models;
using FontAwesome.Sharp;
using PlanEase.Views.panelDesktop;
using PlanEase.Services;

namespace PlanEase
{
    public partial class MainForm : Form
    {
        private User loggedInUser;
        private ScheduleManager scheduleManager;
        private SettingManager settingManager;
        private TagManager tagManager;
        private ToDoManager toDoManager;

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private UserControl currentControl;

        public MainForm(User user)
        {
            InitializeComponent();
            //SetupCalendarTable();
            loggedInUser = user;
            scheduleManager = new ScheduleManager();
            scheduleManager.LoadSchedules(loggedInUser.Id);
            settingManager = new SettingManager();
            settingManager.LoadSetting(loggedInUser.Id);
            tagManager = new TagManager();
            tagManager.LoadTagsFromDb(loggedInUser.Id);
            toDoManager = new ToDoManager();
            toDoManager.LoadToDosFromDb(loggedInUser.Id);


            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, btnCalendar.Size.Height);
            //leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            //SetupCalendarTable();
        }

        private void OpenChildControl(UserControl newControl)
        {
            // 기존 컨트롤 제거
            if (currentControl != null)
            {
                panelDesktop.Controls.Remove(currentControl);
                currentControl.Dispose();  // 메모리 해제
            }

            currentControl = newControl;
            currentControl.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(currentControl);
            currentControl.BringToFront();
        }
        //private void SetupCalendarTable()
        //{
        //    // calendarTable 스타일 초기화 및 설정 담당 (중복 호출 대비 안전)
        //    calendarTable.SuspendLayout();

        //    // Clear 이전 스타일
        //    calendarTable.ColumnStyles.Clear();
        //    calendarTable.RowStyles.Clear();

        //    // 고정 열, 행 설정
        //    calendarTable.ColumnCount = 7;
        //    calendarTable.RowCount = 6;

        //    // Dock 및 Margin 설정도 여기서 통합 관리 (필요 시)
        //    calendarTable.Dock = DockStyle.Fill;
        //    calendarTable.Margin = new Padding(0);

        //    // 열 비율 지정 (7일)
        //    for (int i = 0; i < 7; i++)
        //    {
        //        calendarTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));
        //    }

        //    // 행 비율 지정 (6주)
        //    for (int i = 0; i < 6; i++)
        //    {
        //        calendarTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 6));
        //    }

        //    calendarTable.ResumeLayout();
        //}

        private void TestDbConnection()
        {
            string connStr = "Server=gondola.proxy.rlwy.net;Port=22404;Database=railway;Uid=root;Pwd=vMbiAFpyuiYNKkWXyMCsxdbOFmkqbUHt;SslMode=Required;";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("MySQL 연결 성공!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("연결 실패: " + ex.Message);
                }
            }
        }

        private DateTime currentWeekStartDate;


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 전체 프로그램 종료
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            // DPI-Aware NavBarHeight 설정
            float dpiScale = this.DeviceDpi / 96f; // 96 DPI가 기본 DPI
            this.siticoneBorderlessForm1.NavBarHeight = (int)(30 * dpiScale); // 30px을 DPI에 맞게 조정



            OpenChildControl(new Planner(loggedInUser, scheduleManager,tagManager, toDoManager));

        }


        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPlanner_Click(object sender, EventArgs e)
        {

        }

        private void btnAssistant_Click(object sender, EventArgs e)
        {

        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildControl(new Planner(loggedInUser,scheduleManager,tagManager, toDoManager));
        }

        private void btnTag_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildControl(new Tags(tagManager, scheduleManager, loggedInUser.Id));
        }

        private void btnPlants_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildControl(new Adventure());
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildControl(new Assistant(scheduleManager,loggedInUser.Id));
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildControl(new Views.panelDesktop.SettingControl(settingManager));
        }

        private void siticoneCloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            //if (currentChildForm != null)
            //{
            //    currentChildForm.Close();
            //}
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        
    }
}


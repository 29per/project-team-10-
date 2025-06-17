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
            Console.WriteLine("MainForm 생성자 호출됨. UserId: " + loggedInUser.Id);

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
            public static Color color1 = Color.FromArgb(226, 203, 247);
            public static Color color2 = Color.FromArgb(214, 246, 255);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(179, 245, 188);
            public static Color color5 = Color.FromArgb(249, 255, 181);
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
            OpenChildControl(new Adventure(loggedInUser.Id));
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildControl(new Assistant(scheduleManager,loggedInUser.Id));
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildControl(new Views.panelDesktop.SettingControl(settingManager, scheduleManager));
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

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


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

namespace PlanEase
{
    public partial class MainForm : Form
    {
        private User loggedInUser;

        public MainForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }

        public MainForm()
        {
            InitializeComponent();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            TestDbConnection();

            // 초기에는 월 보기만 활성화
            panelMonthView.Visible = true;
            panelWeekView.Visible = false;
            panelDayView.Visible = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 전체 프로그램 종료
        }

        private void btnDayView_Click(object sender, EventArgs e)
        {
            panelDayView.Visible = true;
            panelWeekView.Visible = false;
            panelMonthView.Visible = false;

            // 예시 콘텐츠
            panelDayView.Controls.Clear();
            Label lbl = new Label
            {
                Text = "오늘의 일정 보기",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("맑은 고딕", 20)
            };
            panelDayView.Controls.Add(lbl);
        }

        private void btnWeekView_Click(object sender, EventArgs e)
        {
            panelDayView.Visible = false;
            panelWeekView.Visible = true;
            panelMonthView.Visible = false;

            // 예시 콘텐츠
            panelWeekView.Controls.Clear();
            Label lbl = new Label
            {
                Text = "이번 주 일정 보기",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("맑은 고딕", 20)
            };
            panelWeekView.Controls.Add(lbl);
        }

        private void btnMonthView_Click(object sender, EventArgs e)
        {
            panelDayView.Visible = false;
            panelWeekView.Visible = false;
            panelMonthView.Visible = true;
        }
    }
}

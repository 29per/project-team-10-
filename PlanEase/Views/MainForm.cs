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
        public MainForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
        }
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void tblTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendarCurrent_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TestDbConnection();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // 전체 프로그램 종료
        }
    }
}

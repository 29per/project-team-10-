using MySql.Data.MySqlClient;
using PlanEase.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanEase.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("아이디와 비밀번호를 입력하세요.");
                return;
            }

            var service = new UserService();
            var user = service.LoginUser(username, password);

            if (user != null)
            {
                MessageBox.Show("로그인 성공!");

                // MainForm에 로그인한 사용자 정보 전달 (선택)
                MainForm main = new MainForm(user);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 잘못되었습니다.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

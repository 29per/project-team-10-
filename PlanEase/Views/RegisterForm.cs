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

namespace PlanEase.Views
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요.");
                return;
            }

            // 1. UserService 인스턴스 생성
            var service = new UserService();

            // 2. 사용자 정보 객체 생성
            var newUser = new User
            {
                Username = username,
                PasswordHash = UserService.HashPassword(password),  // 정적 메서드
                Level = 1,
                XP = 0
            };

            try
            {
                // 3. 회원가입 실행
                bool result = service.RegisterUser(newUser);

                if (result)
                {
                    MessageBox.Show("회원가입이 완료되었습니다!");
                    this.Close();  // 회원가입 창 닫기
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("회원가입 실패: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

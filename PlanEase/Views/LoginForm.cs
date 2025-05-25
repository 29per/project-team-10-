using MySql.Data.MySqlClient;
using PlanEase.Helpers;
using PlanEase.Models;
using PlanEase.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
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

        

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

      
    
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername2.Text.Trim();
            string password = txtPassword2.Text;

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

        private void btnRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var registerForm = new RegisterForm();
            registerForm.FormClosed += (s, args) => this.Show();
            registerForm.Show();
        }

        
        private async void button1_Click(object sender, EventArgs e)
        {

            // 테스트용 사용자 입력
            string testInput = "5월 28일 오후 2시부터 4시까지 졸업 작품 발표가 있어. #졸업 #프로젝트"; //  정상 입력 (모든 정보 제공)
            //string testInput = "6월 3일 오전 10시에 병원 예약 있음."; //종료 시간 누락
            //string testInput = "다음주 수요일 오후 6시에 프로젝트 회의 있어."; // 시간만 있음
            //string testInput = "다음주 수요일 오후 6시에 프로젝트 회의 있어."; // 상대 날짜 적용
            //string testInput = "5월 30일 from 2pm to 4pm까지 카페에서 friend 만나기로 했어."; // 혼합 언어 입력
            //string testInput = "고양이가 귀여워"; // 엉뚱한 입력


            try
            {
                var result = await GptService.GenerateScheduleFromText(testInput);

                if (!result.IsComplete)
                {
                    MessageBox.Show($"[불완전한 응답]\n{result.FollowUpMessage}", "GPT 응답", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Schedule s = result.Schedule!;
                string info =
                    $"제목: {s.Title}\n" +
                    $"시작: {s.StartTime}\n" +
                    $"종료: {s.EndTime}\n" +
                    $"태그: {string.Join(", ", s.Tags)}\n" +
                    $"설명: {(string.IsNullOrWhiteSpace(s.Description) ? "(없음)" : s.Description)}";

                MessageBox.Show($"[일정 생성 성공]\n{info}", "GPT 일정", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"예외 발생: {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void siticoneCloseButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        
    }
}

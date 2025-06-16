using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanEase.Helpers;
using PlanEase.Models;

namespace PlanEase.Views.panelDesktop
{
    public partial class Adventure : UserControl
    {
        private GptService.Monster currentMonster;
        private Schedule currentSchedule;
        private int playerExp = 0;
        private int playerLevel = 1;
        private int expToNextLevel = 100;

        public Adventure()
        {
            InitializeComponent();
            btnDoTask.Click += BtnDoTask_Click;
            picMonster.Click += picMonster_Click;
        }

        private async void Adventure_Load(object sender, EventArgs e)
        {
            // 초기에는 데이터베이스에서 미완료 일정 확인
            await LoadNextUndoneSchedule();
        }

        // 공개 메서드: 새 일정이 추가되었을 때 호출됨
        public async Task HandleNewSchedule(Schedule newSchedule)
        {
            // 새로운 일정이 추가되면 해당 일정으로 몬스터 생성
            if (newSchedule != null)
            {
                await LoadCurrentScheduleAndGenerateMonster(newSchedule);
            }
        }

        // 미완료 일정 로드
        public async Task LoadNextUndoneSchedule()
        {
            try
            {
                // 데이터베이스에서 미완료 일정 가져오기
                Schedule undoneSchedule = await DatabaseHelper.GetNextUndoneScheduleAsync();

                if (undoneSchedule != null)
                {
                    // 미완료 일정이 있으면 몬스터 생성
                    await LoadCurrentScheduleAndGenerateMonster(undoneSchedule);
                }
                else
                {
                    // 미완료 일정이 없으면 빈 화면 표시
                    ShowNoScheduleMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"일정을 불러오는 중 오류가 발생했습니다: {ex.Message}",
                    "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ShowErrorMessage();
            }
        }

        // 일정이 없을 때 메시지 표시
        private void ShowNoScheduleMessage()
        {
            // 현재 일정과 몬스터 초기화
            currentSchedule = null;
            currentMonster = null;

            // UI 업데이트
            lblMonsterName.Text = "일정 없음";
            lblLevel.Text = "LV. -";
            lblHP.Text = "HP -/-";
            progressHP.Value = 0;
            lblTaskName.Text = "할 일: 없음";
            lblTaskDesc.Text = "완료되지 않은 일정이 없습니다. 새로운 일정을 추가해보세요!";

            // 버튼 비활성화
            btnDoTask.Enabled = false;

            // 이미지 초기화
            if (picMonster.Image != null)
            {
                picMonster.Image.Dispose();
                picMonster.Image = null;
            }
            picMonster.BackColor = Color.LightGray;

            // 경험치 바 유지 (플레이어 상태는 유지)
            progressExp.Value = playerExp;
            lblExp.Text = $"EXP {playerExp}/{expToNextLevel}";
        }

        // 오류 발생 시 메시지 표시
        private void ShowErrorMessage()
        {
            // UI 업데이트
            lblMonsterName.Text = "오류 발생";
            lblLevel.Text = "LV. -";
            lblHP.Text = "HP -/-";
            progressHP.Value = 0;
            lblTaskName.Text = "할 일: 로드 실패";
            lblTaskDesc.Text = "일정을 불러오는 중 오류가 발생했습니다.";

            // 버튼 비활성화
            btnDoTask.Enabled = false;

            // 이미지 초기화
            if (picMonster.Image != null)
            {
                picMonster.Image.Dispose();
                picMonster.Image = null;
            }
            picMonster.BackColor = Color.LightPink;
        }

        // 현재 선택된 일정 로드 및 몬스터 생성
        private async Task LoadCurrentScheduleAndGenerateMonster(Schedule schedule)
        {
            if (schedule == null)
            {
                ShowNoScheduleMessage();
                return;
            }

            try
            {
                // 일정 설정
                currentSchedule = schedule;

                // 로딩 표시
                UpdateUIForLoading(true);

                // GPT 서비스를 사용하여 몬스터 생성
                currentMonster = await GptService.GenerateMonsterFromSchedule(currentSchedule);

                // UI 업데이트
                UpdateUIForLoading(false);
                UpdateMonsterUI();
                UpdateTaskUI();

                // 버튼 활성화
                btnDoTask.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"몬스터 생성 중 오류가 발생했습니다: {ex.Message}",
                    "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // 기본 몬스터 생성
                CreateDefaultMonster();
                UpdateMonsterUI();
                UpdateTaskUI();
            }
        }

        // 로딩 중 UI 업데이트
        private void UpdateUIForLoading(bool isLoading)
        {
            if (isLoading)
            {
                // 로딩 표시 UI 업데이트
                lblMonsterName.Text = "몬스터 생성 중...";
                lblLevel.Text = "LV. ?";
                lblHP.Text = "HP ?/?";
                progressHP.Value = 0;

                // 버튼 비활성화
                btnDoTask.Enabled = false;

                // 투명 이미지 설정
                if (picMonster.Image != null)
                {
                    picMonster.Image.Dispose();
                    picMonster.Image = null;
                }
                picMonster.BackColor = Color.LightGray;
            }
        }

        // 기본 몬스터 생성
        private void CreateDefaultMonster()
        {
            Random rand = new Random();
            currentMonster = new GptService.Monster
            {
                Name = "기본 몬스터",
                Level = 1,
                MaxHP = 100,
                CurrentHP = 100,
                ImageNumber = rand.Next(1, 6), // 1~5 사이 랜덤 이미지 번호
                Description = "GPT 서비스 연결에 실패하여 생성된 기본 몬스터입니다."
            };
        }

        // 몬스터 UI 업데이트
        private void UpdateMonsterUI()
        {
            if (currentMonster == null) return;

            // 몬스터 정보 업데이트
            lblMonsterName.Text = currentMonster.Name;
            lblLevel.Text = $"LV. {currentMonster.Level}";

            progressHP.Maximum = currentMonster.MaxHP;
            progressHP.Value = currentMonster.CurrentHP;
            lblHP.Text = $"HP {currentMonster.CurrentHP}/{currentMonster.MaxHP}";

            // 몬스터 이미지 설정
            try
            {
                string imagePath = GetMonsterImagePath(currentMonster.ImageNumber);
                if (File.Exists(imagePath))
                {
                    // 기존 이미지가 있으면 해제
                    if (picMonster.Image != null)
                    {
                        picMonster.Image.Dispose();
                        picMonster.Image = null;
                    }

                    // 새 이미지 로드
                    picMonster.Image = Image.FromFile(imagePath);
                    picMonster.BackColor = Color.Transparent;
                }
                else
                {
                    // 이미지가 없을 경우 랜덤 이미지 사용
                    Random rand = new Random();
                    int randomNumber = rand.Next(1, 6); // 1~5 사이 랜덤
                    string randomImagePath = GetMonsterImagePath(randomNumber);

                    if (File.Exists(randomImagePath))
                    {
                        picMonster.Image = Image.FromFile(randomImagePath);
                        picMonster.BackColor = Color.Transparent;
                    }
                    else
                    {
                        // 이미지를 찾을 수 없으면 색상으로 표시
                        picMonster.Image = null;
                        picMonster.BackColor = GetMonsterColor(currentMonster.Level);
                    }
                }
            }
            catch
            {
                // 이미지 로드 실패 시 색상으로 표시
                picMonster.Image = null;
                picMonster.BackColor = GetMonsterColor(currentMonster.Level);
            }
        }

        // 레벨에 따른 몬스터 색상
        private Color GetMonsterColor(int level)
        {
            if (level <= 2) return Color.LightGreen;      // 레벨 1-2: 녹색
            else if (level <= 4) return Color.LightBlue;  // 레벨 3-4: 파란색
            else if (level <= 6) return Color.Yellow;     // 레벨 5-6: 노란색
            else if (level <= 8) return Color.Orange;     // 레벨 7-8: 주황색
            else return Color.Red;                        // 레벨 9-10: 빨간색
        }

        // 이미지 번호에 따른 이미지 경로 반환
        private string GetMonsterImagePath(int imageNum)
        {
            string basePath = Path.Combine(Application.StartupPath, "Images", "Monsters");

            // 이미지 디렉토리가 없으면 생성
            try
            {
                if (!Directory.Exists(basePath))
                {
                    Directory.CreateDirectory(basePath);
                }
            }
            catch
            {
                // 디렉토리 생성 실패 - 무시
            }

            // 이미지 번호가 1~5 범위를 벗어나면 기본값으로 1 사용
            if (imageNum < 1 || imageNum > 5)
            {
                imageNum = 1;
            }

            return Path.Combine(basePath, imageNum.ToString() + ".png");
        }

        // 일정 UI 업데이트
        private void UpdateTaskUI()
        {
            if (currentSchedule == null) return;

            // 일정 정보 업데이트
            lblTaskName.Text = $"할 일: {currentSchedule.Title}";
            lblTaskDesc.Text = string.IsNullOrEmpty(currentSchedule.Description)
                ? "설명 없음"
                : currentSchedule.Description;

            // 경험치 바 업데이트
            progressExp.Maximum = expToNextLevel;
            progressExp.Value = playerExp;
            lblExp.Text = $"EXP {playerExp}/{expToNextLevel}";
        }

        // 일정 완료(몬스터 공격) 버튼 클릭 처리
        private void BtnDoTask_Click(object sender, EventArgs e)
        {
            if (currentMonster == null || currentSchedule == null)
            {
                // 몬스터나 일정이 없으면 새 일정 로드 시도
                LoadNextUndoneSchedule();
                return;
            }

            // 일정 완료(몬스터 공격) 처리
            AttackMonster();
        }

        // 몬스터 공격 처리
        private void AttackMonster()
        {
            if (currentMonster == null) return;

            // 공격 데미지 계산
            int damage = CalculateDamage();

            // 몬스터 체력 감소
            currentMonster.CurrentHP = Math.Max(0, currentMonster.CurrentHP - damage);

            // UI 업데이트
            progressHP.Value = currentMonster.CurrentHP;
            lblHP.Text = $"HP {currentMonster.CurrentHP}/{currentMonster.MaxHP}";

            // 공격 애니메이션 효과 (버튼 깜빡이기로 대체)
            ShowAttackAnimation();

            // 몬스터 처치 확인
            if (currentMonster.CurrentHP <= 0)
            {
                HandleMonsterDefeated();
            }
        }

        // 공격 애니메이션 효과 (버튼 깜빡이기)
        private async void ShowAttackAnimation()
        {
            // 버튼 색상 변경으로 애니메이션 효과
            var originalColor = btnDoTask.ButtonBackColor;
            btnDoTask.ButtonBackColor = Color.Red;

            // 잠시 대기
            await Task.Delay(100);

            // 원래 색상으로 복원
            btnDoTask.ButtonBackColor = originalColor;
        }

        // 공격 데미지 계산
        private int CalculateDamage()
        {
            // 데미지 계산 로직 (레벨, 일정 난이도 등을 고려)
            Random rand = new Random();
            int baseDamage = rand.Next(20, 40);
            int levelBonus = playerLevel * 5;

            return baseDamage + levelBonus;
        }

        // 몬스터 처치 처리
        private async void HandleMonsterDefeated()
        {
            if (currentMonster == null) return;

            // 경험치 획득
            int expGained = currentMonster.Level * 30;
            playerExp += expGained;

            // 레벨업 확인
            bool leveledUp = false;
            while (playerExp >= expToNextLevel)
            {
                playerLevel++;
                playerExp -= expToNextLevel;
                expToNextLevel = (int)(expToNextLevel * 1.5); // 다음 레벨 필요 경험치 증가
                leveledUp = true;
            }

            // 메시지 표시
            string message = $"'{currentMonster.Name}' 몬스터를 처치했습니다!\n획득 경험치: {expGained}";
            if (leveledUp)
            {
                message += $"\n축하합니다! 레벨 {playerLevel}로 레벨업했습니다!";
            }

            MessageBox.Show(message, "몬스터 처치", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // UI 업데이트
            progressExp.Maximum = expToNextLevel;
            progressExp.Value = playerExp;
            lblExp.Text = $"EXP {playerExp}/{expToNextLevel}";

            // 일정 완료 처리
            await MarkScheduleAsCompleted();

            // 다음 미완료 일정 로드
            await LoadNextUndoneSchedule();
        }

        // 일정 완료로 표시
        private async Task MarkScheduleAsCompleted()
        {
            if (currentSchedule == null) return;

            try
            {
                // 데이터베이스에 일정 완료 상태 업데이트
                await DatabaseHelper.MarkScheduleAsCompletedAsync(currentSchedule.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"일정 완료 처리 중 오류가 발생했습니다: {ex.Message}",
                    "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 몬스터 클릭 시 상세 정보 표시
        private void picMonster_Click(object sender, EventArgs e)
        {
            if (currentMonster == null) return;

            MessageBox.Show(
                $"몬스터 이름: {currentMonster.Name}\n" +
                $"레벨: {currentMonster.Level}\n\n" +
                $"설명: {currentMonster.Description}",
                "몬스터 정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // 데이터베이스 접근 헬퍼 클래스 (실제 구현은 별도로 해야 함)
    public static class DatabaseHelper
    {
        // 완료되지 않은 다음 일정 가져오기
        public static async Task<Schedule> GetNextUndoneScheduleAsync()
        {
            // 실제로는 여기에 데이터베이스 쿼리 코드가 들어갑니다
            await Task.Delay(100); // 데이터베이스 액세스 시뮬레이션

            // 여기서는 null 반환 (일정이 없음을 시뮬레이션)
            // 실제 구현에서는 DB에서 미완료 일정을 가져와야 함
            return null;
        }

        // 일정 완료로 표시
        public static async Task MarkScheduleAsCompletedAsync(int scheduleId)
        {
            // 실제로는 여기에 데이터베이스 업데이트 코드가 들어갑니다
            await Task.Delay(100); // 데이터베이스 액세스 시뮬레이션
        }
    }
}
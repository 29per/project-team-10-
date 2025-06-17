using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanEase.Models;
using PlanEase.Services;
using System.Linq;
using PlanEase.Helpers;
using System.Collections.Concurrent;

namespace PlanEase.Views.panelDesktop
{
    public partial class Adventure : UserControl
    {
        // 필요한 필드
        private GptService.Monster currentMonster;
        private ToDo currentTodo;
        private int playerExp = 0;
        private int playerLevel = 1;
        private int expToNextLevel = 100;

        // 컨트롤 상태 관리
        private bool isLoaded = false;
        private readonly ConcurrentQueue<ToDo> pendingTodos = new ConcurrentQueue<ToDo>();
        private readonly UserService userService;
        private User currentUser; // 로그인한 사용자 정보 저장
        

        // 싱글톤 인스턴스 - 다른 클래스에서 접근할 수 있도록
        public static Adventure Instance { get; private set; }

        public Adventure(int userID)
        {
            InitializeComponent();
            Instance = this; // 싱글톤 인스턴스 설정

           

            userService = new UserService();

            LoadUserById(userID);

            // 이벤트 핸들러 연결
            btnDoTask.Click += BtnDoTask_Click;
            picMonster.Click += picMonster_Click;
            this.Load += Adventure_Load;
            this.HandleCreated += Adventure_HandleCreated;
        }

        private void LoadUserById(int userId)
        {
            try
            {
                // userId를 저장
                this.userID = userId;
                Console.WriteLine($"Adventure: 사용자 ID {userId} 설정됨");

                // 필요시 DB에서 전체 사용자 정보 로드 (옵션)
                // 이 부분은 UserService에 GetUserById 메서드가 있다면 활성화
                // Task.Run(async () => {
                //     currentUser = await userService.GetUserByIdAsync(userId);
                //     if (currentUser != null)
                //     {
                //         playerExp = currentUser.XP;
                //         playerLevel = currentUser.Level;
                //         expToNextLevel = CalculateExpToNextLevel(playerLevel);
                //     }
                // });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"사용자 정보 로드 오류: {ex.Message}");
            }
        }



        private void Adventure_HandleCreated(object sender, EventArgs e)
        {
            // 핸들이 생성되면 isLoaded 플래그 설정
            isLoaded = true;

            // 대기 중인 할 일 처리
            ProcessPendingTodos();
        }

        public void SetCurrentUser(User user)
        {
            currentUser = user;
            // 사용자의 경험치와 레벨 설정
            if (user != null)
            {
                playerExp = user.XP;
                playerLevel = user.Level;
                // 레벨에 따른 다음 레벨 경험치 계산
                expToNextLevel = CalculateExpToNextLevel(playerLevel);

                // UI 업데이트
                if (isLoaded)
                {
                    UpdateExpUI();
                }
            }
        }

        private int CalculateExpToNextLevel(int level)
        {
            // 기본 경험치 100에서 레벨당 50% 증가
            return (int)(100 * Math.Pow(1.5, level - 1));
        }


        private void UpdateExpUI()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(UpdateExpUI));
                return;
            }

            try
            {
                progressExp.Maximum = expToNextLevel;
                progressExp.Value = playerExp;
                lblExp.Text = $"EXP {playerExp}/{expToNextLevel}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"UpdateExpUI 오류: {ex.Message}");
            }
        }


        private void Adventure_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Adventure_Load 시작");

            // 초기 상태 설정
            ShowNoTodoMessage();
            Console.WriteLine("초기 메시지 표시");

            // 핸들이 생성되면 isLoaded 플래그 설정
            isLoaded = true;
            Console.WriteLine("isLoaded 플래그 설정됨");

            // 대기 중인 할 일 처리
            ProcessPendingTodos();

            // UI가 완전히 로드된 후에 할 일을 로드하기 위해 타이머 사용
            System.Windows.Forms.Timer loadTimer = new System.Windows.Forms.Timer();
            loadTimer.Interval = 500; // 500ms 지연
            loadTimer.Tick += async (s, args) => {
                loadTimer.Stop();
                loadTimer.Dispose();

                try
                {
                    await LoadNextTodoAndGenerateMonster();
                    Console.WriteLine("초기 할 일 로딩 완료");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"초기 할 일 로딩 타이머 오류: {ex.Message}");
                }
            };
            loadTimer.Start();
        }

        // 대기 중인 할 일 처리
        private void ProcessPendingTodos()
        {
            // 대기 중인 할 일이 있고 현재 처리 중인 할 일이 없을 때만 처리
            if (!pendingTodos.IsEmpty && currentTodo == null)
            {
                if (pendingTodos.TryDequeue(out ToDo todo))
                {
                    Console.WriteLine($"대기 중인 할 일 처리: {todo.Content}");

                    // UI 스레드에서 안전하게 처리하기 위해 타이머 사용
                    System.Windows.Forms.Timer processTimer = new System.Windows.Forms.Timer();
                    processTimer.Interval = 200; // 200ms 지연
                    processTimer.Tick += (s, e) => {
                        processTimer.Stop();
                        processTimer.Dispose();

                        // 할 일 처리 메서드 호출
                        HandleNewTodo(todo);
                    };
                    processTimer.Start();
                }
            }
        }

        // 할 일로부터 몬스터를 생성하는 공개 메서드
        public void HandleNewTodo(ToDo todo)
        {
            if (todo == null) return;

            Console.WriteLine($"HandleNewTodo 호출됨: {todo.Content}");

            try
            {
                // 현재 처리중인 할 일이 없을 때만 새로운 몬스터 생성
                if (currentTodo == null)
                {
                    // 컨트롤이 로드되었는지 확인
                    if (isLoaded)
                    {
                        Console.WriteLine("새 할 일로 몬스터 생성 시작");

                        // 로딩 상태 표시
                        ShowLoadingMessage();

                        // 비동기 작업 시작
                        Task.Run(async () => {
                            try
                            {
                                // 현재 할 일 설정
                                currentTodo = todo;

                                // ToDo를 Schedule로 변환
                                Schedule scheduleFromTodo = ConvertTodoToSchedule(todo);

                                // 몬스터 생성
                                currentMonster = await GptService.GenerateMonsterFromSchedule(scheduleFromTodo);
                                Console.WriteLine($"몬스터 생성 완료: {currentMonster.Name}");

                                // UI 업데이트
                                UpdateMonsterUI();
                                UpdateTodoUI();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"새 할 일 처리 비동기 오류: {ex.Message}");
                                ShowErrorMessage(ex.Message);
                            }
                        });
                    }
                    else
                    {
                        // 아직 로드되지 않았으면 큐에 추가
                        Console.WriteLine("Adventure 컨트롤이 아직 로드되지 않았습니다. 큐에 할 일 추가");
                        pendingTodos.Enqueue(todo);
                    }
                }
                else
                {
                    Console.WriteLine("이미 처리 중인 할 일이 있습니다. 새 할 일은 큐에 추가합니다.");
                    pendingTodos.Enqueue(todo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"할 일 처리 오류: {ex.Message}");
            }
        }

        // 모든 할 일을 확인하고 처리되지 않은 할 일이 있으면 몬스터 생성
        public async Task LoadNextTodoAndGenerateMonster()
        {
            Console.WriteLine("LoadNextTodoAndGenerateMonster 시작");

            try
            {
                // 컨트롤이 로드되지 않았으면 무시
                if (!isLoaded)
                {
                    Console.WriteLine("Adventure 컨트롤이 아직 로드되지 않았습니다.");
                    return;
                }

                // 로딩 상태 표시 (UI 스레드에서 호출됨)
                ShowLoadingMessage();
                Console.WriteLine("로딩 메시지 표시 완료");

                // 비동기 작업은 별도 스레드에서 실행
                await Task.Run(async () => {
                    try
                    {
                        // 미완료 할 일 가져오기
                        int userId = GetCurrentUserId();
                        Console.WriteLine($"현재 사용자 ID: {userId}");

                        var todoManager = new ToDoManager();
                        todoManager.LoadToDosFromDb(userId);
                        Console.WriteLine("DB에서 할 일 로드 완료");

                        var incompleteTodos = todoManager.GetToDoList();
                        Console.WriteLine($"미완료 할 일 개수: {incompleteTodos.Count}");

                        if (incompleteTodos.Count > 0)
                        {
                            // 첫 번째 미완료 할 일로 몬스터 생성
                            ToDo firstTodo = incompleteTodos[0];
                            Console.WriteLine($"첫 번째 할 일: {firstTodo.Content}");

                            // 현재 할 일 설정
                            currentTodo = firstTodo;

                            // ToDo를 Schedule로 변환
                            Schedule scheduleFromTodo = ConvertTodoToSchedule(firstTodo);
                            Console.WriteLine("Schedule 변환 완료");

                            // 몬스터 생성
                            currentMonster = await GptService.GenerateMonsterFromSchedule(scheduleFromTodo);
                            Console.WriteLine($"몬스터 생성 완료: {currentMonster.Name}");

                            // UI 업데이트 (UI 스레드에서 호출됨)
                            UpdateMonsterUI();
                            UpdateTodoUI();
                        }
                        else
                        {
                            Console.WriteLine("미완료 할 일이 없습니다.");
                            ShowNoTodoMessage();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"할 일 로딩 비동기 처리 오류: {ex.Message}");
                        Console.WriteLine($"스택 트레이스: {ex.StackTrace}");
                        ShowErrorMessage(ex.Message);
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"할 일 로딩 오류: {ex.Message}");
                Console.WriteLine($"스택 트레이스: {ex.StackTrace}");
                ShowErrorMessage(ex.Message);
            }
        }
        private int userID = 1;
        // 현재 로그인한 사용자 ID를 가져오는 메서드
        private int GetCurrentUserId()
        {
            return userID; // 현재 로그인한 사용자 ID를 반환
        }

        // 로딩 메시지 표시 (UI 스레드 안전)
        private void ShowLoadingMessage()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(ShowLoadingMessage));
                return;
            }

            try
            {
                // UI 업데이트는 여기서 안전하게 수행
                lblMonsterName.Text = "몬스터 생성 중...";
                lblLevel.Text = "LV. ?";
                lblHP.Text = "HP ?/?";
                progressHP.Value = 0;
                lblTaskName.Text = "할 일: 로딩 중...";
                lblTaskDesc.Text = "잠시만 기다려주세요...";

                // 버튼 비활성화
                btnDoTask.Enabled = false;

                // 이미지 초기화
                if (picMonster.Image != null)
                {
                    picMonster.Image.Dispose();
                    picMonster.Image = null;
                }
                picMonster.BackColor = Color.LightGray;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ShowLoadingMessage 오류: {ex.Message}");
            }
        }

        // 할 일로부터 몬스터 생성 및 UI 업데이트 (UI 스레드 안전)
        private async Task LoadTodoAndGenerateMonster(ToDo todo)
        {
            if (todo == null)
            {
                Console.WriteLine("전달된 할 일이 null입니다.");
                return;
            }

            try
            {
                // 로딩 상태 표시
                ShowLoadingMessage();
                Console.WriteLine("몬스터 생성 로딩 시작");

                // 현재 할 일 설정
                currentTodo = todo;
                Console.WriteLine($"현재 할 일 설정: {todo.Content}, ID: {todo.Id}");

                // ToDo를 Schedule로 변환 (GptService가 Schedule 형식을 요구하므로)
                Schedule scheduleFromTodo = ConvertTodoToSchedule(todo);
                Console.WriteLine($"할 일을 일정으로 변환: {scheduleFromTodo.Title}");

                // GptService를 통해 몬스터 생성
                Console.WriteLine("GptService를 통해 몬스터 생성 시작...");
                currentMonster = await GptService.GenerateMonsterFromSchedule(scheduleFromTodo);
                Console.WriteLine($"몬스터 생성 완료: {currentMonster.Name}, Lv. {currentMonster.Level}");

                // UI 업데이트
                UpdateMonsterUI();
                UpdateTodoUI();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"몬스터 생성 오류: {ex.Message}");
                Console.WriteLine($"오류 스택 트레이스: {ex.StackTrace}");

                // 기본 몬스터 생성
                Console.WriteLine("기본 몬스터 생성");
                CreateDefaultMonster();

                // UI 업데이트
                UpdateMonsterUI();
                UpdateTodoUI();
            }
        }

        // ToDo를 Schedule로 변환 (GptService에 전달하기 위한 변환)
        private Schedule ConvertTodoToSchedule(ToDo todo)
        {
            // 우선순위에 따른 설명 추가
            string priorityDescription = GetPriorityText(todo.Priority);

            return new Schedule
            {
                Title = todo.Content,
                StartTime = DateTime.Now, // 시간 정보는 사용하지 않지만 필드는 채워넣음
                EndTime = todo.DueDate ?? DateTime.Now.AddDays(1),
                Tags = new List<string> { "할일" }, // 기본 태그
                Description = priorityDescription, // 우선순위 설명
                UserId = todo.UserId,
                IsCompleted = todo.IsDone
            };
        }

        // 우선순위 텍스트 반환
        private string GetPriorityText(int priority)
        {
            switch (priority)
            {
                case 1: return "매우 높음 (가장 중요한 할 일)";
                case 2: return "높음 (중요한 할 일)";
                case 3: return "중간 (보통 중요도의 할 일)";
                case 4: return "낮음 (덜 중요한 할 일)";
                case 5: return "매우 낮음 (중요도가 낮은 할 일)";
                default: return "보통 (기본 중요도의 할 일)";
            }
        }

        // 기본 몬스터 생성
        private void CreateDefaultMonster()
        {
            Random rand = new Random();
            currentMonster = new GptService.Monster
            {
                Name = currentTodo != null ? $"{currentTodo.Content}의 수호자" : "기본 몬스터",
                Level = rand.Next(1, 6), // 1~5 사이 랜덤 레벨
                MaxHP = rand.Next(5, 11) * 20, // 100~200 사이 랜덤 체력
                CurrentHP = rand.Next(5, 11) * 20, // 처음에는 최대 체력으로 설정
                ImageNumber = rand.Next(1, 6), // 1~5 사이 랜덤 이미지 번호
                Description = currentTodo != null
                    ? $"'{currentTodo.Content}'에서 생성된 기본 몬스터입니다. 이 할 일을 완료하면 처치할 수 있습니다."
                    : "기본 몬스터입니다. 할 일을 완료하면 처치할 수 있습니다."
            };
        }

        // 할 일이 없을 때 메시지 표시
        private void ShowNoTodoMessage()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(ShowNoTodoMessage));
                return;
            }

            try
            {
                // 현재 할 일과 몬스터 초기화
                currentTodo = null;
                currentMonster = null;

                // UI 업데이트
                lblMonsterName.Text = "할 일 없음";
                lblLevel.Text = "LV. -";
                lblHP.Text = "HP -/-";
                progressHP.Value = 0;
                lblTaskName.Text = "할 일: 없음";
                lblTaskDesc.Text = "완료되지 않은 할 일이 없습니다. 새로운 할 일을 추가해보세요!";

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
            catch (Exception ex)
            {
                Console.WriteLine($"ShowNoTodoMessage 오류: {ex.Message}");
            }
        }

        // 오류 발생 시 메시지 표시
        private void ShowErrorMessage(string errorMessage)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(() => ShowErrorMessage(errorMessage)));
                return;
            }

            try
            {
                lblMonsterName.Text = "오류 발생";
                lblLevel.Text = "LV. -";
                lblHP.Text = "HP -/-";
                progressHP.Value = 0;
                lblTaskName.Text = "할 일: 로드 실패";
                lblTaskDesc.Text = $"오류: {errorMessage}";

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
            catch (Exception ex)
            {
                Console.WriteLine($"ShowErrorMessage 오류: {ex.Message}");
            }
        }

        // 몬스터 UI 업데이트
        private void UpdateMonsterUI()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(UpdateMonsterUI));
                return;
            }

            try
            {
                if (currentMonster == null)
                {
                    Console.WriteLine("UpdateMonsterUI: 현재 몬스터가 null입니다.");
                    return;
                }

                // 몬스터 정보 업데이트
                lblMonsterName.Text = currentMonster.Name;
                lblLevel.Text = $"LV. {currentMonster.Level}";

                // 보정: MaxHP가 0 이하인 경우 기본값 설정
                if (currentMonster.MaxHP <= 0)
                {
                    currentMonster.MaxHP = 100;
                }

                // 보정: CurrentHP가 MaxHP보다 큰 경우 MaxHP로 제한
                if (currentMonster.CurrentHP > currentMonster.MaxHP)
                {
                    currentMonster.CurrentHP = currentMonster.MaxHP;
                }

                // 보정: CurrentHP가 음수인 경우 0으로 설정
                if (currentMonster.CurrentHP < 0)
                {
                    currentMonster.CurrentHP = 0;
                }

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
                        // 이미지 파일이 없으면 색상으로 대체
                        picMonster.Image = null;
                        picMonster.BackColor = GetMonsterColor(currentMonster.Level);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"이미지 로드 오류: {ex.Message}");
                    // 이미지 로드 실패 시 색상으로 대체
                    picMonster.Image = null;
                    picMonster.BackColor = GetMonsterColor(currentMonster.Level);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"UpdateMonsterUI 오류: {ex.Message}");
            }
        }

        // 레벨에 따른 몬스터 색상 반환
        private Color GetMonsterColor(int level)
        {
            if (level <= 2) return Color.LightGreen;      // 레벨 1-2: 녹색
            else if (level <= 4) return Color.LightBlue;  // 레벨 3-4: 파란색
            else if (level <= 6) return Color.Yellow;     // 레벨 5-6: 노란색
            else if (level <= 8) return Color.Orange;     // 레벨 7-8: 주황색
            else return Color.Red;                        // 레벨 9-10: 빨간색
        }

        // 할 일 UI 업데이트
        private void UpdateTodoUI()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(UpdateTodoUI));
                return;
            }

            try
            {
                if (currentTodo == null)
                {
                    Console.WriteLine("UpdateTodoUI: 현재 할 일이 null입니다.");
                    return;
                }

                // 할 일 정보 업데이트
                lblTaskName.Text = $"할 일: {currentTodo.Content}";

                string description = "설명 없음";
                if (currentTodo.DueDate.HasValue)
                {
                    description = $"마감일: {currentTodo.DueDate.Value.ToShortDateString()}";

                    // 마감일이 가까우면 강조
                    TimeSpan timeLeft = currentTodo.DueDate.Value - DateTime.Now;
                    if (timeLeft.TotalDays < 1)
                        description += " (오늘 마감!)";
                    else if (timeLeft.TotalDays < 3)
                        description += " (마감 임박!)";
                }

                lblTaskDesc.Text = description;

                // 경험치 바 업데이트
                progressExp.Maximum = expToNextLevel;
                progressExp.Value = playerExp;
                lblExp.Text = $"EXP {playerExp}/{expToNextLevel}";

                // 버튼 활성화
                btnDoTask.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"UpdateTodoUI 오류: {ex.Message}");
            }
        }

        // 이미지 번호에 따른 이미지 경로 반환
        private string GetMonsterImagePath(int imageNum)
        {
            try
            {
                // 여러 가능한 경로 시도
                List<string> possiblePaths = new List<string>
                {
                    // 1. 프로젝트 폴더에 직접 있는 경우
                    Path.Combine(Directory.GetCurrentDirectory(), imageNum.ToString() + ".png"),
                    
                    // 2. 프로젝트 폴더의 Images 하위 폴더에 있는 경우
                    Path.Combine(Directory.GetCurrentDirectory(), "Images", imageNum.ToString() + ".png"),
                    
                    // 3. 프로젝트 폴더의 Images/Monsters 하위 폴더에 있는 경우
                    Path.Combine(Directory.GetCurrentDirectory(), "Images", "Monsters", imageNum.ToString() + ".png"),
                    
                    // 4. 실행 파일 위치에 직접 있는 경우
                    Path.Combine(Application.StartupPath, imageNum.ToString() + ".png"),
                    
                    // 5. 실행 파일 위치의 Images 하위 폴더에 있는 경우
                    Path.Combine(Application.StartupPath, "Images", imageNum.ToString() + ".png"),
                    
                    // 6. 실행 파일 위치의 Images/Monsters 하위 폴더에 있는 경우
                    Path.Combine(Application.StartupPath, "Images", "Monsters", imageNum.ToString() + ".png")
                };

                // 존재하는 첫 번째 경로 반환
                foreach (string path in possiblePaths)
                {
                    if (File.Exists(path))
                    {
                        Console.WriteLine($"이미지 파일 발견: {path}");
                        return path;
                    }
                }

                // 기본 경로 반환 (없을 경우 색상으로 대체됨)
                string defaultPath = Path.Combine(Directory.GetCurrentDirectory(), imageNum.ToString() + ".png");
                Console.WriteLine($"이미지 파일이 없어 기본 경로 반환: {defaultPath}");
                return defaultPath;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"이미지 경로 생성 오류: {ex.Message}");
                return Path.Combine(Directory.GetCurrentDirectory(), "1.png"); // 기본 이미지 경로
            }
        }

        // 할 일 완료(몬스터 공격) 버튼 클릭
        private void BtnDoTask_Click(object sender, EventArgs e)
        {
            if (currentMonster == null || currentTodo == null)
            {
                // 몬스터나 할 일이 없으면 새로 불러오기
                LoadNextTodoAndGenerateMonster();
                return;
            }

            // 몬스터 공격 처리
            AttackMonster();
        }

        // 몬스터 공격 처리
        private void AttackMonster()
        {
            // 공격 데미지 계산
            int damage = CalculateDamage();

            // 몬스터 체력 감소
            currentMonster.CurrentHP = Math.Max(0, currentMonster.CurrentHP - damage);

            // UI 업데이트
            progressHP.Value = currentMonster.CurrentHP;
            lblHP.Text = $"HP {currentMonster.CurrentHP}/{currentMonster.MaxHP}";

            // 공격 애니메이션 효과
            ShowAttackAnimation();

            // 몬스터 처치 확인
            if (currentMonster.CurrentHP <= 0)
            {
                HandleMonsterDefeated();
            }
        }

        // 공격 애니메이션 효과
        private async void ShowAttackAnimation()
        {
            // 버튼 색상 변경
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
            // 데미지 계산 로직
            Random rand = new Random();
            int baseDamage = rand.Next(20, 40);
            int levelBonus = playerLevel * 5;

            return baseDamage + levelBonus;
        }

        // 몬스터 처치 처리
        private async void HandleMonsterDefeated()
        {
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
            UpdateExpUI();

            // 사용자 경험치 및 레벨 업데이트 (DB에 저장)
            if (currentUser != null)
            {
                try
                {
                    // 사용자 경험치 및 레벨 업데이트 (사용자 서비스에 메서드 추가 필요)
                    currentUser.XP = playerExp;
                    currentUser.Level = playerLevel;

                    // TODO: UserService에 UpdateUserXpAndLevel 메서드를 추가하고 주석 해제
                    // await Task.Run(() => userService.UpdateUserXpAndLevel(currentUser.Id, playerExp, playerLevel));
                    Console.WriteLine($"사용자 경험치/레벨 업데이트: XP={playerExp}, Level={playerLevel}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"사용자 경험치 업데이트 오류: {ex.Message}");
                }
            }

            // 할 일 완료 처리
            MarkTodoAsCompleted();

            // 다음 할 일 로드
            await LoadNextTodoAndGenerateMonster();
        }

        // 할 일 완료로 표시
        private void MarkTodoAsCompleted()
        {
            if (currentTodo == null) return;

            try
            {
                // 할 일 완료 처리 (ToDoManager를 통해)
                var todoManager = new ToDoManager(); // 실제로는 주입받거나 다른 방식으로 가져와야 함
                todoManager.ToggleDone(currentTodo.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"할 일 완료 처리 오류: {ex.Message}");
                MessageBox.Show($"할 일 완료 처리 중 오류가 발생했습니다: {ex.Message}",
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

        private void lblMonsterName_Click(object sender, EventArgs e)
        {
            // 몬스터 이름 클릭 시 몬스터 정보 표시 (picMonster_Click과 동일 기능)
            if (currentMonster == null) return;

            MessageBox.Show(
                $"몬스터 이름: {currentMonster.Name}\n" +
                $"레벨: {currentMonster.Level}\n\n" +
                $"설명: {currentMonster.Description}",
                "몬스터 정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void siticoneLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
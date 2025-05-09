# 🗂️ PlanEase 일정 관리 프로그램 – 구현 계획서

## 📌 프로젝트 개요

**PlanEase**는 C#과 Windows Forms를 기반으로 개발된 일정 관리 프로그램입니다.  
사용자는 일정과 할 일을 효율적으로 등록, 조회, 관리할 수 있으며,  
태그 기반 필터링, 일정 충돌 감지 및 우선순위 기반 처리 기능도 제공합니다.

- 개발 언어: C# (.NET Framework 4.8)
- UI: Windows Forms
- 파일 저장 방식: CSV 기반 텍스트 파일
- 팀원: 3명 (모델 및 서비스, 충돌 처리, UI 분담)
    [팀원A]
         Models : Schedule, Tag, ToDo, UserPreferences
         Services : FileManager, ScheduleManager, ToDoManager, TagManager
    [팀원B]
         Models : UserPreferences
         Services : UserConflict(ConflictChecker, ConfictResolver), PrefereneceManager
         Views : ConflictResolutionForm
    [팀원C]
          Views : MainForm, AddScheduleForm, AddToDoForm, SettingForm


---

## 📁 프로젝트 폴더 구조

| 폴더명 | 설명 |
|--------|------|
| `Models` | 데이터 구조 정의 (일정, 태그, 할 일, 설정 등) |
| `Services` | 비즈니스 로직 처리 (일정/할 일/태그 관리, 파일 입출력 등) |
| `Views` | UI 화면 구성 (폼, 다이얼로그 등) |
| `Resources` | 리소스 및 설정 저장 |
| `docs` | 구현 계획서 및 기술 문서 보관용 |

---

## 📂 Models 폴더 상세 설명

### 1. Schedule.cs

**설명**: 일정 정보를 담는 데이터 클래스입니다.

| 필드명 | 타입 | 설명 |
|--------|------|------|
| `Id` | int | 일정 고유 ID |
| `Title` | string | 일정 제목 |
| `StartTime` | DateTime | 일정 시작 시각 |
| `EndTime` | DateTime | 일정 종료 시각 |
| `Tags` | List<string> | 연결된 태그 목록 |
| `Priority` | PriorityLevel | 우선순위 (VeryLow ~ VeryHigh) |
| `IsCompleted` | bool | 완료 여부 |
| `Description` | string | 상세 설명 |

| 함수 시그니처 | 기능 설명 |
|---------------|-----------|
| `string ToCsv()` | 객체를 CSV 형식 문자열로 변환 |
| `static Schedule FromCsv(string line)` | CSV 문자열을 Schedule 객체로 복원 |

---

### 2. ToDo.cs

**설명**: 할 일(Todo) 항목 정보를 담는 클래스입니다.

| 필드명 | 타입 | 설명 |
|--------|------|------|
| `Id` | int | 고유 ID |
| `Content` | string | 할 일 내용 |
| `IsDone` | bool | 완료 여부 |
| `DueDate` | DateTime? | 마감 기한 (null 허용) |

| 함수 시그니처 | 기능 설명 |
|---------------|-----------|
| `string ToCsv()` | 할 일 정보를 문자열로 직렬화 |
| `static ToDo FromCsv(string line)` | 문자열을 ToDo 객체로 복원 |

---

### 3. Tag.cs

**설명**: 일정에 부착할 수 있는 태그 정보를 표현하는 클래스입니다.

| 필드명 | 타입 | 설명 |
|--------|------|------|
| `Name` | string | 태그 이름 (`#업무` 형식) |
| `DisplayColor` | Color | 태그 글자색 |
| `IsDefaultTag` | bool | 기본 시스템 태그 여부 |

| 함수 시그니처 | 기능 설명 |
|---------------|-----------|
| `string ToCsv()` | 태그 정보를 CSV 형식 문자열로 직렬화 |
| `static Tag FromCsv(string line)` | 문자열을 Tag 객체로 복원 |

---

### 4. UserPreferences.cs

**설명**: 사용자 개인 설정(테마, 폰트, 충돌 처리 전략 등)을 저장하는 클래스입니다.

| 필드명 | 타입 | 설명 |
|--------|------|------|
| `UseAutoConflictResolution` | bool | 충돌 시 자동 처리 여부 |
| `DefaultStrategy` | ConflictResolutionStrategy | 기본 충돌 해결 전략 |
| `Theme` | string | UI 테마 이름 |
| `FontName` | string | 폰트 이름 |

| 함수 시그니처 | 기능 설명 |
|---------------|-----------|
| `string ToCsv()` | 설정 정보를 CSV 문자열로 변환 |
| `static UserPreferences FromCsv(string line)` | 문자열에서 설정 객체로 복원 |

---

## 📚 Enum 정의

### PriorityLevel
- `VeryLow`, `Low`, `Medium`, `High`, `VeryHigh`

### ConflictResolutionStrategy

| 값 | 설명 | UI 노출 여부 |
|-----|------|---------------|
| `AskUser` | 사용자에게 전략을 물어봄) |
| `ChangeTime` | 대상 일정의 시간을 변경 | 
| `Merge` | 두 일정을 병합하여 하나로 통합 | 
| `Delete` | 대상 일정을 삭제 | 

⚠️ `AskUser`는 자동 처리가 비활성화된 경우 기본 전략으로 사용되며,  
UI 설정창의 전략 선택 콤보박스에서는 노출되지 않습니다.

---

## 📂 Services 폴더 상세 설명

### 1. ScheduleManager.cs

**설명**: 일정(Schedule) 데이터에 대한 CRUD 및 파일 입출력을 관리하는 클래스입니다.

| 필드명 | 타입 | 설명 |
|--------|------|------|
| `schedules` | List<Schedule> | 메모리 내 일정 리스트 |
| `FilePath` | string | 파일 저장 경로 (schedules.txt) |

| 함수 시그니처 | 기능 설명 |
|---------------|-----------|
| `void AddSchedule(Schedule s)` | 일정을 리스트에 추가하고 파일에 저장 |
| `void RemoveSchedule(int id)` | ID에 해당하는 일정을 삭제하고 저장 |
| `List<Schedule> GetAllSchedules()` | 전체 일정 목록을 반환 |
| `void LoadSchedules()` | 파일에서 일정 데이터를 불러옴 |
| `void SaveSchedules()` | 현재 리스트를 파일에 저장 (CSV 문자열 변환 후)

---

### 2. ToDoManager.cs

**설명**: 할 일(ToDo)에 대한 CRUD 및 파일 입출력을 담당하는 클래스입니다.

| 필드명 | 타입 | 설명 |
|--------|------|------|
| `todos` | List<ToDo> | 메모리 내 할 일 리스트 |
| `FilePath` | string | 파일 저장 경로 (todos.txt) |

| 함수 시그니처 | 기능 설명 |
|---------------|-----------|
| `void AddToDo(ToDo t)` | 할 일을 리스트에 추가하고 저장 |
| `void RemoveToDo(int id)` | ID에 해당하는 할 일을 삭제하고 저장 |
| `void ToggleDone(int id)` | 완료 여부를 반전시킴 (true ↔ false) |
| `List<ToDo> GetAllToDos()` | 전체 할 일 목록 반환 |
| `void LoadToDos()` | 파일에서 할 일 데이터를 불러옴 |
| `void SaveToDos()` | 현재 리스트를 파일에 저장

---

### 3. TagManager.cs

**설명**: 태그(Tag) 등록 및 조회, 파일 입출력을 처리하는 클래스입니다.

| 필드명 | 타입 | 설명 |
|--------|------|------|
| `tags` | List<Tag> | 전체 등록된 태그 목록 |
| `FilePath` | string | 태그 저장 경로 (tags.txt) |

| 함수 시그니처 | 기능 설명 |
|---------------|-----------|
| `void RegisterIfNew(string name)` | `#`로 시작하는 새 태그를 등록 (중복 방지) |
| `Tag GetTagByName(string name)` | 이름으로 태그 검색 |
| `List<Tag> GetAllTags()` | 전체 태그 리스트 반환 |
| `void LoadTags()` | 파일에서 태그 목록 불러오기 |
| `void SaveTags()` | 현재 태그 목록을 파일로 저장

---

### 4. PreferencesManager.cs

**설명**: 사용자 설정(UserPreferences)을 파일에 저장하거나 불러오는 유틸리티 클래스입니다.

| 함수 시그니처 | 기능 설명 |
|---------------|-----------|
| `static void Save(UserPreferences prefs)` | 사용자 설정을 파일로 저장 |
| `static UserPreferences Load()` | 파일에서 설정을 읽어 UserPreferences 객체로 복원 |
| `static bool Exists()` | 설정 파일이 존재하는지 여부 반환 |

※ 파일 경로는 `"userprefs.txt"`로 고정되어 있음

---

### 5. ScheduleConflict (ConflictChecker.cs, ConflictResolver.cs)

**설명**: 일정 간의 시간 충돌을 감지하고, 충돌 발생 시 선택된 전략과 조정 대상을 기반으로 실제 변경 로직을 수행하는 모듈입니다.

📌 `UserPreferences`의 자동 처리 여부 및 전략 선택, 조정 대상 판단은 **UI에서 선행되며**,  
이 모듈은 전달된 전략에 따라 충돌 일정을 조정하는 역할만 수행합니다.

---

#### ✅ ConflictChecker.cs

- 일정 간 시간 충돌 여부를 판별하는 유틸리티
- 예시 메서드:
  - `bool IsConflict(Schedule s1, Schedule s2)`
  - `List<Schedule> FindConflicts(Schedule newSchedule, List<Schedule> existingSchedules)`

---

#### ✅ ConflictResolver.cs

- 선택된 해결 전략(`ConflictResolutionStrategy`)에 따라  
  충돌된 일정 중 지정된 대상을 수정 또는 삭제 처리

- 조정 대상은 `UI`에서 미리 판단하여 전달하며, 이 클래스는 **실제 로직만** 담당함

---

#### 📌 전략별 처리 방식

##### 1. `ChangeTime`
- 입력: 일정 A (수정 대상), DateTime 새로운 시작/종료 시간
- 처리:
  - `A.StartTime`, `A.EndTime`을 새로운 값으로 갱신
  - 일정 변경 후 저장

##### 2. `Delete`
- 입력: 일정 A (삭제 대상)
- 처리:
  - `ScheduleManager.RemoveSchedule(A.Id)` 호출
  - 삭제 후 저장

##### 3. `Merge`
- 입력: 일정 A, 일정 B
- 처리 (자동 병합 기준):
  - 제목: `A.Title + " + " + B.Title`
  - 시작 시간: `Min(A.StartTime, B.StartTime)`
  - 종료 시간: `Max(A.EndTime, B.EndTime)`
  - 설명: `A.Description + "\n" + B.Description`
  - 태그: `A.Tags ∪ B.Tags` (중복 제거)
  - 우선순위: `(A.Priority + B.Priority) / 2` (반올림)
  - 기존 일정 삭제 후 병합 일정 새로 생성 및 저장

---

#### 🧩 구현 시 주의 사항

- `Merge`는 기존 일정을 삭제하고 병합 일정을 **새 일정으로 추가**해야 하므로  
  내부에서 `ScheduleManager.RemoveSchedule()` 및 `AddSchedule()`을 연속적으로 호출
- `ChangeTime` 전략 시, 새로 조정된 시간도 **UI에서 전달**하는 방식이므로  
  이 모듈은 시간 계산 책임을 가지지 않음
- `Delete` 전략은 매우 단순하므로 대상만 정확히 판단되면 안전하게 실행 가능

---

#### 🧪 예시 메서드 시그니처
void ResolveChangeTime(Schedule target, DateTime newStart, DateTime newEnd);
void ResolveDelete(Schedule target);
void ResolveMerge(Schedule s1, Schedule s2);

---



### 6. Views (MainForm.cs, AddScheduleForm.cs, AddToDoForm.cs, SettingForm.cs, ConflictResolutionForm.cs)

**설명**: 사용자 인터페이스를 구성하는 폼들로, 일정/할일 등록, 설정 변경, 충돌 해결을 포함한  
전체 앱의 흐름을 사용자와 연결하는 역할을 담당합니다.

---

#### ✅ MainForm.cs

**역할**:  
- 메인 화면으로, 일정/할일 목록을 표시하고 추가/조회/필터링 기능을 제공

**요구사항**:
- 좌측: 할 일 목록 패널
  - 완료 여부 체크박스 포함
  - 마감 기한이 가까운 항목 강조
  - 진행 여부 나타내는 프로그레스바
- 우측: 일정 캘린더 패널  
  - (일/주/월) 보기 모드 전환 가능
- 상단:
  - 보기 모드 전환 버튼:
     - [`일 보기`] [`주 보기`] [`월 보기`] 토글 버튼
     - 선택된 모드에 따라 캘린더 표시 방식 변경 (날짜별 일정 배치)
   - [설정] 버튼 → `SettingForm` 호출
- 하단:
  - [일정 추가] 버튼 → `AddScheduleForm` 호출
  - [할일 추가] 버튼 → `AddToDoForm` 호출
  - [설정] 버튼 → `SettingForm` 호출
  - [태그 검색] 버튼 → 태그 필터 화면 전환

- 태그 검색 상세 흐름:
  - 버튼 클릭 시 우측 `일정 캘린더 패널` 영역이 태그 검색 뷰로 전환
  - 콤보박스로 존재하는 태그 선택
  - 선택된 태그를 포함하는 일정만 캘린더에 표시
  - 선택된 태그 기반 일정은 수정/삭제 가능
  - [전체 보기] 버튼을 통해 캘린더 모드로 복귀

- 일정 클릭 시:
  - 해당 일정의 상세 정보 팝업 표시
  - 일정 수정/삭제/ 기능 제공
---

#### ✅ AddScheduleForm.cs

**역할**:  
- 새 일정을 입력받아 ScheduleManager를 통해 추가 요청

**요구사항**:
- 필수 입력 필드:
  - 제목 (TextBox)
  - 시작일/종료일 (DateTimePicker)
  - 우선순위 선택 (ComboBox)
  - 태그 입력 (TextBox or ListBox)
  - 설명 입력 (Multiline TextBox)
- [확인] 버튼 클릭 시:
  - `ConflictChecker` 호출
  - 충돌 시 `ConflictResolutionForm` 호출
  - 충돌 없으면 ScheduleManager에 추가
 
**표시 방식**:  
- `MainForm`에서 **모달 팝업(Form.ShowDialog)** 으로 호출  
- 사용자가 일정을 입력 완료하거나 취소하기 전까지 메인 화면 상호작용 차단

---

#### ✅ AddToDoForm.cs

**역할**:  
- 새 할 일을 입력받아 ToDoManager에 추가

**요구사항**:
- 입력 필드:
  - 내용 (TextBox)
  - 마감 기한 (선택형 DateTimePicker, 생략 가능)
- [확인] 버튼 클릭 시 ToDoManager에 추가

**표시 방식**:  
- `MainForm`에서 **모달 팝업(Form.ShowDialog)** 으로 호출  
- 할 일 추가 완료 또는 취소 전까지 다른 화면 조작 불가

---

#### ✅ SettingForm.cs

**역할**:  
- 사용자 설정 (`UserPreferences`)을 입력받아 저장
- 테마, 폰트, 충돌 해결 전략 및 처리 방식 등 앱 전반 동작 방식을 정의

**표시 방식**:  
- `MainForm`에서 **새로운 전체 화면(Form.Show)** 으로 전환  
- `ShowDialog()`가 아닌 **독립적인 화면 전환 (모달리스)** 방식 사용
- 설정 완료 후 [저장 및 닫기] 또는 [뒤로 가기]를 통해 `MainForm`으로 복귀

**요구사항**:
- 항목:
  - 충돌 처리 전략 선택 (ComboBox)
    - 선택지: `AskUser`, `ChangeTime`, `Merge`, `Delete`
  - 자동 처리 여부 체크박스 (`UseAutoConflictResolution`)
    - 체크 시: 충돌 시 사용자 개입 없이 자동 처리
    - 해제 시: 충돌 시 `ConflictResolutionForm` 팝업 호출
    - 전략과는 별개로 작동함
  - 테마 선택 (ComboBox 또는 라디오 버튼)
  - 폰트 선택 (ComboBox)

- 저장 버튼 클릭 시:
  - 설정 정보를 `UserPreferences`에 반영
  - `PreferenceManager.Save()` 호출로 파일 저장

---

#### ✅ ConflictResolutionForm.cs

**역할**:  
- 충돌 발생 시, 사용자로부터 처리 전략 및 조정 대상/방법을 입력받는 팝업 폼

**요구사항**:
- 상황 1: 전략이 `AskUser`일 경우
  - 방법 선택: `시간 변경`, `병합`, `삭제`
  - 자동 처리 시:
    - 조정 대상은 우선순위 기반으로 자동 결정
    - 시간 변경 시 자동 추천 시간 / 수동 입력 선택
        - 자동 추천 시간은 충돌된 일정의 시작/종료 시간 중 하나로 설정   
    - 병합은 미리 구성된 내용 자동 표시 (수정 불가) (자동 병합 양식은 Conflict Resolver 참고)
  - 수동 처리 시:
    - 조정 대상 수동 선택
    - 시간 변경은 수동 입력 필수
    - 병합 결과 미리보기 + 수정 가능 (제목/시간/태그/설명 등)

- 상황 2: 전략이 `ChangeTime`/`Merge`/`Delete`로 고정된 경우
  - 자동 처리:
    - ConflictResolver에서 자동 수행
  - 수동 처리:
    - 본 폼에서 조정 대상 선택 및 조정 입력 받기

**출력**:
- 사용자 선택 결과를 ConflictResolver에 전달 (전략, 대상, 필요 시 시간/병합내용 포함)

---






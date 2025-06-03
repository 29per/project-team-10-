using System;
using System.Windows.Forms;
using PlanEase.Services;

namespace PlanEase.Views.panelDesktop
{
    public partial class SettingControl : UserControl
    {

        private SettingManager settingManager;
        public SettingControl()
        {   
            InitializeComponent();
            // 이벤트 핸들러 연결
            btnSave.Click += btnSave_Click;
            btnReset.Click += btnReset_Click;
            chkAutoResolve.CheckedChanged += chkAutoResolve_CheckedChanged;
        }


        public SettingControl(SettingManager settingManager)
        : this() // 기본 생성자도 호출
        {
            this.settingManager = settingManager;
            // 필요하다면 settingManager로 초기화 작업
        }

        private void SettingControl_Load(object sender, EventArgs e)
        {
            // 테마 콤보박스 초기화 예시
            cmbTheme.Items.AddRange(new string[]
            {
                "라이트",
                "다크",
                "블루",
                "그린"
            });
            cmbTheme.SelectedIndex = 0;

            // 설정 불러오기
            var conf = ConflictSetting.Instance;
            chkAutoResolve.Checked = conf.AutoResolve;
            switch (conf.Strategy)
            {
                case ConflictResolveStrategy.AskUser: rdoAskUser.Checked = true; break;
                case ConflictResolveStrategy.ChangeTime: rdoCheckTime.Checked = true; break;
                case ConflictResolveStrategy.Merge: rdoMerege.Checked = true; break;
                case ConflictResolveStrategy.Delete: rdoDelete.Checked = true; break;
            }
            SetStrategyRadioEnabled(chkAutoResolve.Checked);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 설정 저장
            ConflictSetting.Instance.AutoResolve = chkAutoResolve.Checked;
            if (rdoAskUser.Checked) ConflictSetting.Instance.Strategy = ConflictResolveStrategy.AskUser;
            else if (rdoCheckTime.Checked) ConflictSetting.Instance.Strategy = ConflictResolveStrategy.ChangeTime;
            else if (rdoMerege.Checked) ConflictSetting.Instance.Strategy = ConflictResolveStrategy.Merge;
            else if (rdoDelete.Checked) ConflictSetting.Instance.Strategy = ConflictResolveStrategy.Delete;
            // 테마 저장 예시 (실제로는 테마 적용 로직 필요)
            string selectedTheme = cmbTheme.Text;

            MessageBox.Show("설정이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // 기본값 복원
            chkAutoResolve.Checked = false;
            rdoAskUser.Checked = true;
            cmbTheme.SelectedIndex = 0;
        }

        private void chkAutoResolve_Click(object sender, EventArgs e)
        {
            
        }

        private void chkAutoResolve_CheckedChanged(object sender, EventArgs e)
        {
            // 자동해결 체크시 라디오버튼 활성화, 아니면 AskUser만 활성화
            SetStrategyRadioEnabled(chkAutoResolve.Checked);
        }



        private void SetStrategyRadioEnabled(bool enabled)
        {
            // 자동해결 체크시 라디오버튼 활성, 아니면 AskUser만 활성
            rdoAskUser.Enabled = !enabled || (enabled && rdoAskUser.Checked);
            rdoCheckTime.Enabled = enabled;
            rdoMerege.Enabled = enabled;
            rdoDelete.Enabled = enabled;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }
    }

    // 아래는 설정 저장용 싱글톤 및 enum 예시입니다.
    public enum ConflictResolveStrategy
    {
        AskUser,
        ChangeTime,
        Merge,
        Delete
    }

    public class ConflictSetting
    {
        public bool AutoResolve { get; set; } = false;
        public ConflictResolveStrategy Strategy { get; set; } = ConflictResolveStrategy.AskUser;

        private static ConflictSetting _instance;
        public static ConflictSetting Instance => _instance ??= new ConflictSetting();
    }
}
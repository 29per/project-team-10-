using PlanEase.Models;
using PlanEase.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PlanEase.Views.panelDesktop
{
    public partial class SettingControl : UserControl
    {
        private int userId;
        private readonly SettingManager settingManager;

        public SettingControl(SettingManager manager)
        {
            InitializeComponent();
            this.settingManager = manager;

            InitializeUIFromSetting();
            BindEvents();
        }

        private void InitializeUIFromSetting()
        {
            Setting setting = settingManager.GetSetting();

            chkAutoResolve.Checked = setting.UseAutoConflictResolution;

            rdoAskUser.Checked = false;
            rdoCheckTime.Checked = false;
            rdoMerege.Checked = false;
            rdoDelete.Checked = false;

            // 라디오 버튼 선택
            switch (setting.DefaultStrategy)
            {
                case ConflictResolutionStrategy.AskUser:
                    rdoAskUser.Checked = true;
                    break;
                case ConflictResolutionStrategy.ChangeTime:
                    rdoCheckTime.Checked = true;
                    break;
                case ConflictResolutionStrategy.Merge:
                    rdoMerege.Checked = true;
                    break;
                case ConflictResolutionStrategy.Delete:
                    rdoDelete.Checked = true;
                    break;
            }
            cmbTheme.Items.Clear();
            cmbTheme.Items.Add("Purple");
            cmbTheme.SelectedItem = setting.Theme;
        }

        private void BindEvents()
        {

            btnSave.Click += (s, e) => SaveSetting();
            btnReset.Click += (s, e) => ResetSetting();
        }


        private void SaveSetting()
        {
            var setting = settingManager.GetSetting();

            setting.UseAutoConflictResolution = chkAutoResolve.Checked;

            if (rdoAskUser.Checked)
                setting.DefaultStrategy = ConflictResolutionStrategy.AskUser;
            else if (rdoCheckTime.Checked)
                setting.DefaultStrategy = ConflictResolutionStrategy.ChangeTime;
            else if (rdoMerege.Checked)
                setting.DefaultStrategy = ConflictResolutionStrategy.Merge;
            else if (rdoDelete.Checked)
                setting.DefaultStrategy = ConflictResolutionStrategy.Delete;

            setting.Theme = cmbTheme.SelectedItem?.ToString() ?? "Purple";

            settingManager.SaveOrUpdateSetting();

            MessageBox.Show("설정이 저장되었습니다.", "저장", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetSetting()
        {
            var confirm = MessageBox.Show(
                "정말로 설정을 기본값으로 복원하시겠습니까?",
                "설정 초기화",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            settingManager.ResetToDefault();
            InitializeUIFromSetting();

            MessageBox.Show("기본값으로 복원되었습니다.", "복원", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkAutoResolve_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;
using PlanEase.Models;
using PlanEase.Services;

namespace PlanEase.Views
{
    public partial class EditToDoForm : Form
    {
        private readonly ToDoManager toDoManager;
        private readonly ToDo originalToDo;
        private bool originalIsDone;

        public EditToDoForm(ToDo todo, ToDoManager manager)
        {
            InitializeComponent();
            originalToDo = todo;
            toDoManager = manager;
        }

        private void EditToDoForm_Load(object sender, EventArgs e)
        {
            txtContent.Text = originalToDo.Content;
            dtpDueDate.Value = originalToDo.DueDate ?? DateTime.Today;
            chkDueDate.Checked = originalToDo.DueDate.HasValue;

            originalIsDone = originalToDo.IsDone; //완료 상태 백업
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                MessageBox.Show("내용을 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            originalToDo.Content = txtContent.Text.Trim();
            originalToDo.DueDate = chkDueDate.Checked ? dtpDueDate.Value : (DateTime?)null;
            originalToDo.IsDone = originalIsDone; //완료 상태 백업

            toDoManager.UpdateToDo(originalToDo);

            MessageBox.Show("수정 완료!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("정말 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                toDoManager.RemoveToDo(originalToDo.Id);
                MessageBox.Show("삭제 완료!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}


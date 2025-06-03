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
using PlanEase.Views.panelDesktop;

namespace PlanEase.Views
{
    public partial class AddToDoForm : Form
    {
        private readonly ToDoManager toDoManager;
        private readonly int userId;
        //private readonly List<Tag> availableTags; // 사용 가능한 태그 목록

        public AddToDoForm(int userId, ToDoManager toDoManager) //List<Tag> tags)
        {
            InitializeComponent();
            this.userId = userId;
            this.toDoManager = toDoManager;
            //this.availableTags = tags;
        }

        private void AddToDoForm_Load(object sender, EventArgs e)
        {
            // 우선순위 콤보박스 초기화
            cmbPriority.Items.AddRange(new string[]
            {
                "매우 낮음",
                "낮음",
                "보통",
                "높음",
                "매우 높음"
            });
            cmbPriority.SelectedIndex = 2; // 기본값: 보통

            // 마감일 초기화
            dtpDueDate.Value = DateTime.Today;

            // 태그 체크리스트 초기화
            //clbTags.Items.Clear();
            //foreach (var tag in availableTags)
            //{
             //   clbTags.Items.Add(tag.Name);
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                MessageBox.Show("할 일 내용을 입력해주세요.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //var selectedTags = clbTags.CheckedIndices
            //  .Cast<int>()
            //.Select(i => availableTags[i])
            //.ToList();

            int priority = cmbPriority.SelectedIndex + 1;

            var todo = new ToDo
            {
                Content = txtContent.Text.Trim(),
                DueDate = chkDueDate.Checked ? dtpDueDate.Value : (DateTime?)null,
                Priority = priority,
                IsDone = false,
                UserId = userId,
                //Tags = selectedTags
            };

            ToDo newToDo = new ToDo
            {
                Content = txtContent.Text,
                DueDate = dtpDueDate.Value,
                Priority = cmbPriority.SelectedIndex + 1 // 예: ComboBox 0 = 높음 → 1
            };

            toDoManager.AddToDo(todo);

            MessageBox.Show("할 일이 성공적으로 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       



    }
}

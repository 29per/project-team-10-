﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanEase.Views.Controls
{
    public partial class TodoItemControl : UserControl
    {
        public event EventHandler EditRequested;
        public TodoItemControl()
        {
            InitializeComponent();
            // chkCompleted 체크박스의 상태가 변경될 때마다 chkCompleted_CheckedChanged 메서드를 실행하도록 연결
            chkCompleted.CheckedChanged += chkCompleted_CheckedChanged;

            // 더블클릭 이벤트 핸들러 연결Add commentMore actions
            this.DoubleClick += TodoItemControl_DoubleClick;
            lblTodoText.DoubleClick += TodoItemControl_DoubleClick; // 텍스트만 눌러도 반응

            // 드래그 앤 드롭 이벤트 연결
            this.MouseDown += TodoItemControl_MouseDown;
            lblTodoText.MouseDown += TodoItemControl_MouseDown;
        }

        // MainForm에서 할 일 텍스트를 이 컨트롤에 전달하기 위한 속성
        public string TodoText
        {
            get { return lblTodoText.Text; }
            set { lblTodoText.Text = value; }
        }

        // 삭제 버튼을 눌렀을 때 MainForm에 알리기 위한 이벤트
        public event EventHandler DeleteRequested;

        // 삭제 버튼 클릭 이벤트 핸들러
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            // DeleteRequested 이벤트를 발생시켜 MainForm에 삭제를 요청합니다.
            DeleteRequested?.Invoke(this, EventArgs.Empty);
        }

        // 외부(MainForm)에서 이 컨트롤의 체크 상태를 설정하거나 가져올 수 있는 속성
        public bool IsCompleted
        {
            get { return chkCompleted.Checked; }
            set { chkCompleted.Checked = value; }
        }

        // 체크 상태가 변경되었음을 MainForm에 알리기 위한 이벤트
        public event EventHandler CompletionToggled;

        // chkCompleted 체크박스의 상태가 변경될 때 실행되는 메서드
        private void chkCompleted_CheckedChanged(object sender, EventArgs e)
        {
            // 라벨 텍스트에 취소선 효과 주기
            if (chkCompleted.Checked)
            {
                lblTodoText.Font = new Font(lblTodoText.Font, FontStyle.Strikeout);
            }
            else
            {
                lblTodoText.Font = new Font(lblTodoText.Font, FontStyle.Regular);
            }

        }

        private void TodoItemControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // "TODO:<텍스트>" 형식으로 데이터 전달
                DoDragDrop("TODO:" + this.TodoText, DragDropEffects.Copy);
            }
        }
        private void TodoItemControl_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("더블클릭 감지됨");
            Console.WriteLine("DoubleClick 호출됨");
            EditRequested?.Invoke(this, EventArgs.Empty); // MainForm에 알림
        }


}
}

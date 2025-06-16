using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlanEase.Views.panelDesktop
{
    partial class Planner
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel calendarTableLayoutPanel;



        private void DateCell_Click(object sender, EventArgs e)
        {
            Panel cell = sender as Panel;
            if (cell?.Tag is DateTime date)
            {
                MessageBox.Show($"[{date:yyyy-MM-dd}] 클릭됨");
            }
        }

        private void CellPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void CellPanel_DragDrop(object sender, DragEventArgs e)
        {
            Panel cell = sender as Panel;
            if (cell?.Tag is DateTime date)
            {
                string todo = e.Data.GetData(typeof(string)) as string;
                MessageBox.Show($"'{todo}' 항목이 {date:yyyy-MM-dd}로 이동됨");
            }
        }

        private void CellPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Panel cell = sender as Panel;
                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("일정 수정", null, (s, args) => MessageBox.Show("수정"));
                menu.Items.Add("일정 삭제", null, (s, args) => MessageBox.Show("삭제"));
                menu.Show(cell, e.Location);
            }
        }

        #region Windows Form 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            this.lblTodoTitle = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.calendarTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrevMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.txtNewTodo = new SiticoneNetFrameworkUI.SiticoneTextBox();
            this.flpTodoList = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMonthDisplay = new FontAwesome.Sharp.IconButton();
            this.btnConfirm = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnAddSchedule = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btnAddTodo = new SiticoneNetFrameworkUI.SiticoneButton();
            this.SuspendLayout();
            // 
            // lblTodoTitle
            // 
            this.lblTodoTitle.AutoSize = true;
            this.lblTodoTitle.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTodoTitle.Location = new System.Drawing.Point(9, 75);
            this.lblTodoTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTodoTitle.Name = "lblTodoTitle";
            this.lblTodoTitle.Size = new System.Drawing.Size(88, 25);
            this.lblTodoTitle.TabIndex = 0;
            this.lblTodoTitle.Text = "할 일 목록";
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.AutoScroll = true;
            this.panelRight.Location = new System.Drawing.Point(300, 120);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(790, 580);
            this.panelRight.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 26.14285F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTitle.Location = new System.Drawing.Point(5, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 45);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "PLANEASE";
            // 
            // calendarTableLayoutPanel
            // 
            this.calendarTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.calendarTableLayoutPanel.ColumnCount = 7;
            this.calendarTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.calendarTableLayoutPanel.Name = "calendarTableLayoutPanel";
            this.calendarTableLayoutPanel.RowCount = 6;
            this.calendarTableLayoutPanel.Size = new System.Drawing.Size(200, 100);
            this.calendarTableLayoutPanel.TabIndex = 0;
            // 
            // btnPrevMonth
            // 
            this.btnPrevMonth.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPrevMonth.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPrevMonth.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPrevMonth.Location = new System.Drawing.Point(475, 48);
            this.btnPrevMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrevMonth.Name = "btnPrevMonth";
            this.btnPrevMonth.Size = new System.Drawing.Size(50, 25);
            this.btnPrevMonth.TabIndex = 0;
            this.btnPrevMonth.Text = "<";
            this.btnPrevMonth.UseVisualStyleBackColor = false;
            this.btnPrevMonth.Click += new System.EventHandler(this.BtnPrevMonth_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNextMonth.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNextMonth.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnNextMonth.Location = new System.Drawing.Point(892, 48);
            this.btnNextMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(50, 25);
            this.btnNextMonth.TabIndex = 11;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = false;
            this.btnNextMonth.Click += new System.EventHandler(this.BtnNextMonth_Click);
            // 
            // txtNewTodo
            // 
            this.txtNewTodo.AccessibleDescription = "A customizable text input field.";
            this.txtNewTodo.AccessibleName = "Text Box";
            this.txtNewTodo.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txtNewTodo.BackColor = System.Drawing.Color.Transparent;
            this.txtNewTodo.BlinkCount = 3;
            this.txtNewTodo.BlinkShadow = false;
            this.txtNewTodo.BorderColor1 = System.Drawing.Color.LightSlateGray;
            this.txtNewTodo.BorderColor2 = System.Drawing.Color.LightSlateGray;
            this.txtNewTodo.BorderFocusColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtNewTodo.BorderFocusColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtNewTodo.CanShake = true;
            this.txtNewTodo.ContinuousBlink = false;
            this.txtNewTodo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewTodo.CursorBlinkRate = 500;
            this.txtNewTodo.CursorColor = System.Drawing.Color.Black;
            this.txtNewTodo.CursorHeight = 26;
            this.txtNewTodo.CursorOffset = 0;
            this.txtNewTodo.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            this.txtNewTodo.CursorWidth = 1;
            this.txtNewTodo.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewTodo.DisabledBorderColor = System.Drawing.Color.LightGray;
            this.txtNewTodo.DisabledTextColor = System.Drawing.Color.Gray;
            this.txtNewTodo.EnableDropShadow = false;
            this.txtNewTodo.FillColor1 = System.Drawing.Color.White;
            this.txtNewTodo.FillColor2 = System.Drawing.Color.White;
            this.txtNewTodo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNewTodo.ForeColor = System.Drawing.Color.DimGray;
            this.txtNewTodo.HoverBorderColor1 = System.Drawing.Color.Gray;
            this.txtNewTodo.HoverBorderColor2 = System.Drawing.Color.Gray;
            this.txtNewTodo.IsEnabled = true;
            this.txtNewTodo.Location = new System.Drawing.Point(0, 151);
            this.txtNewTodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewTodo.Name = "txtNewTodo";
            this.txtNewTodo.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtNewTodo.PlaceholderText = "할 일을 입력하세요...";
            this.txtNewTodo.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray;
            this.txtNewTodo.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray;
            this.txtNewTodo.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke;
            this.txtNewTodo.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke;
            this.txtNewTodo.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewTodo.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtNewTodo.ShadowAnimationDuration = 1;
            this.txtNewTodo.ShadowBlur = 10;
            this.txtNewTodo.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNewTodo.Size = new System.Drawing.Size(249, 23);
            this.txtNewTodo.SolidBorderColor = System.Drawing.Color.LightSlateGray;
            this.txtNewTodo.SolidBorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txtNewTodo.SolidBorderHoverColor = System.Drawing.Color.Gray;
            this.txtNewTodo.SolidFillColor = System.Drawing.Color.White;
            this.txtNewTodo.TabIndex = 0;
            this.txtNewTodo.TextPadding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.txtNewTodo.ValidationErrorMessage = "Invalid input.";
            this.txtNewTodo.ValidationFunction = null;
            // 
            // flpTodoList
            // 
            this.flpTodoList.AutoScroll = true;
            this.flpTodoList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTodoList.Location = new System.Drawing.Point(2, 179);
            this.flpTodoList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpTodoList.Name = "flpTodoList";
            this.flpTodoList.Size = new System.Drawing.Size(295, 493);
            this.flpTodoList.TabIndex = 28;
            this.flpTodoList.WrapContents = false;
            // 
            // lblMonthDisplay
            // 
            this.lblMonthDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMonthDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthDisplay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.lblMonthDisplay.FlatAppearance.BorderSize = 0;
            this.lblMonthDisplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.lblMonthDisplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.lblMonthDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMonthDisplay.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthDisplay.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblMonthDisplay.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.lblMonthDisplay.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.lblMonthDisplay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.lblMonthDisplay.IconSize = 40;
            this.lblMonthDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMonthDisplay.Location = new System.Drawing.Point(611, 20);
            this.lblMonthDisplay.Name = "lblMonthDisplay";
            this.lblMonthDisplay.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.lblMonthDisplay.Size = new System.Drawing.Size(255, 80);
            this.lblMonthDisplay.TabIndex = 26;
            this.lblMonthDisplay.Text = "Calendar";
            this.lblMonthDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMonthDisplay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lblMonthDisplay.UseVisualStyleBackColor = false;
            this.lblMonthDisplay.Click += new System.EventHandler(this.LblMonthDisplay_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnConfirm.AccessibleName = "할 일 완료";
            this.btnConfirm.AutoSizeBasedOnText = false;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BadgeBackColor = System.Drawing.Color.Black;
            this.btnConfirm.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.BadgeValue = 0;
            this.btnConfirm.BadgeValueForeColor = System.Drawing.Color.White;
            this.btnConfirm.BorderColor = System.Drawing.Color.White;
            this.btnConfirm.BorderWidth = 2;
            this.btnConfirm.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConfirm.ButtonImage = null;
            this.btnConfirm.ButtonTextLeftPadding = 0;
            this.btnConfirm.CanBeep = true;
            this.btnConfirm.CanGlow = false;
            this.btnConfirm.CanShake = true;
            this.btnConfirm.ContextMenuStripEx = null;
            this.btnConfirm.CornerRadiusBottomLeft = 5;
            this.btnConfirm.CornerRadiusBottomRight = 5;
            this.btnConfirm.CornerRadiusTopLeft = 5;
            this.btnConfirm.CornerRadiusTopRight = 5;
            this.btnConfirm.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirm.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnConfirm.EnableLongPress = false;
            this.btnConfirm.EnablePressAnimation = true;
            this.btnConfirm.EnableRippleEffect = true;
            this.btnConfirm.EnableShadow = false;
            this.btnConfirm.EnableTextWrapping = false;
            this.btnConfirm.Font = new System.Drawing.Font("한컴 말랑말랑 Regular", 9.857142F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConfirm.GlowIntensity = 100;
            this.btnConfirm.GlowRadius = 20F;
            this.btnConfirm.GradientBackground = false;
            this.btnConfirm.GradientColor = System.Drawing.Color.White;
            this.btnConfirm.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnConfirm.HintText = null;
            this.btnConfirm.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConfirm.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnConfirm.HoverTextColor = System.Drawing.Color.White;
            this.btnConfirm.HoverTransitionDuration = 250;
            this.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirm.ImagePadding = 5;
            this.btnConfirm.ImageSize = new System.Drawing.Size(16, 16);
            this.btnConfirm.IsRadial = false;
            this.btnConfirm.IsReadOnly = false;
            this.btnConfirm.IsToggleButton = false;
            this.btnConfirm.IsToggled = false;
            this.btnConfirm.Location = new System.Drawing.Point(3, 117);
            this.btnConfirm.LongPressDurationMS = 1000;
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnConfirm.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnConfirm.ParticleCount = 15;
            this.btnConfirm.PressAnimationScale = 0.97F;
            this.btnConfirm.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConfirm.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnConfirm.PressTransitionDuration = 150;
            this.btnConfirm.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnConfirm.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConfirm.RippleOpacity = 0.3F;
            this.btnConfirm.RippleRadiusMultiplier = 0.6F;
            this.btnConfirm.ShadowBlur = 5;
            this.btnConfirm.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConfirm.ShadowOffset = new System.Drawing.Point(2, 2);
            this.btnConfirm.ShakeDuration = 500;
            this.btnConfirm.ShakeIntensity = 5;
            this.btnConfirm.Size = new System.Drawing.Size(81, 30);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "할 일 완료";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.TextColor = System.Drawing.Color.Black;
            this.btnConfirm.TooltipText = null;
            this.btnConfirm.UseAdvancedRendering = true;
            this.btnConfirm.UseParticles = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnAddSchedule.AccessibleName = "일정 추가";
            this.btnAddSchedule.AutoSizeBasedOnText = false;
            this.btnAddSchedule.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSchedule.BadgeBackColor = System.Drawing.Color.Black;
            this.btnAddSchedule.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddSchedule.BadgeValue = 0;
            this.btnAddSchedule.BadgeValueForeColor = System.Drawing.Color.White;
            this.btnAddSchedule.BorderColor = System.Drawing.Color.White;
            this.btnAddSchedule.BorderWidth = 2;
            this.btnAddSchedule.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddSchedule.ButtonImage = null;
            this.btnAddSchedule.ButtonTextLeftPadding = 0;
            this.btnAddSchedule.CanBeep = true;
            this.btnAddSchedule.CanGlow = false;
            this.btnAddSchedule.CanShake = true;
            this.btnAddSchedule.ContextMenuStripEx = null;
            this.btnAddSchedule.CornerRadiusBottomLeft = 5;
            this.btnAddSchedule.CornerRadiusBottomRight = 5;
            this.btnAddSchedule.CornerRadiusTopLeft = 5;
            this.btnAddSchedule.CornerRadiusTopRight = 5;
            this.btnAddSchedule.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddSchedule.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnAddSchedule.EnableLongPress = false;
            this.btnAddSchedule.EnablePressAnimation = true;
            this.btnAddSchedule.EnableRippleEffect = true;
            this.btnAddSchedule.EnableShadow = false;
            this.btnAddSchedule.EnableTextWrapping = false;
            this.btnAddSchedule.Font = new System.Drawing.Font("한컴 말랑말랑 Regular", 9.857142F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddSchedule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddSchedule.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddSchedule.GlowIntensity = 100;
            this.btnAddSchedule.GlowRadius = 20F;
            this.btnAddSchedule.GradientBackground = false;
            this.btnAddSchedule.GradientColor = System.Drawing.Color.White;
            this.btnAddSchedule.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddSchedule.HintText = null;
            this.btnAddSchedule.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddSchedule.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnAddSchedule.HoverTextColor = System.Drawing.Color.White;
            this.btnAddSchedule.HoverTransitionDuration = 250;
            this.btnAddSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSchedule.ImagePadding = 5;
            this.btnAddSchedule.ImageSize = new System.Drawing.Size(16, 16);
            this.btnAddSchedule.IsRadial = false;
            this.btnAddSchedule.IsReadOnly = false;
            this.btnAddSchedule.IsToggleButton = false;
            this.btnAddSchedule.IsToggled = false;
            this.btnAddSchedule.Location = new System.Drawing.Point(1008, 87);
            this.btnAddSchedule.LongPressDurationMS = 1000;
            this.btnAddSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnAddSchedule.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAddSchedule.ParticleCount = 15;
            this.btnAddSchedule.PressAnimationScale = 0.97F;
            this.btnAddSchedule.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddSchedule.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnAddSchedule.PressTransitionDuration = 150;
            this.btnAddSchedule.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAddSchedule.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddSchedule.RippleOpacity = 0.3F;
            this.btnAddSchedule.RippleRadiusMultiplier = 0.6F;
            this.btnAddSchedule.ShadowBlur = 5;
            this.btnAddSchedule.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddSchedule.ShadowOffset = new System.Drawing.Point(2, 2);
            this.btnAddSchedule.ShakeDuration = 500;
            this.btnAddSchedule.ShakeIntensity = 5;
            this.btnAddSchedule.Size = new System.Drawing.Size(82, 29);
            this.btnAddSchedule.TabIndex = 29;
            this.btnAddSchedule.Text = "일정 추가";
            this.btnAddSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddSchedule.TextColor = System.Drawing.Color.Black;
            this.btnAddSchedule.TooltipText = null;
            this.btnAddSchedule.UseAdvancedRendering = true;
            this.btnAddSchedule.UseParticles = false;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // btnAddTodo
            // 
            this.btnAddTodo.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btnAddTodo.AccessibleName = "추가";
            this.btnAddTodo.AutoSizeBasedOnText = false;
            this.btnAddTodo.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTodo.BadgeBackColor = System.Drawing.Color.Black;
            this.btnAddTodo.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddTodo.BadgeValue = 0;
            this.btnAddTodo.BadgeValueForeColor = System.Drawing.Color.White;
            this.btnAddTodo.BorderColor = System.Drawing.Color.White;
            this.btnAddTodo.BorderWidth = 2;
            this.btnAddTodo.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddTodo.ButtonImage = null;
            this.btnAddTodo.ButtonTextLeftPadding = 0;
            this.btnAddTodo.CanBeep = true;
            this.btnAddTodo.CanGlow = false;
            this.btnAddTodo.CanShake = true;
            this.btnAddTodo.ContextMenuStripEx = null;
            this.btnAddTodo.CornerRadiusBottomLeft = 5;
            this.btnAddTodo.CornerRadiusBottomRight = 5;
            this.btnAddTodo.CornerRadiusTopLeft = 5;
            this.btnAddTodo.CornerRadiusTopRight = 5;
            this.btnAddTodo.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddTodo.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnAddTodo.EnableLongPress = false;
            this.btnAddTodo.EnablePressAnimation = true;
            this.btnAddTodo.EnableRippleEffect = true;
            this.btnAddTodo.EnableShadow = false;
            this.btnAddTodo.EnableTextWrapping = false;
            this.btnAddTodo.Font = new System.Drawing.Font("한컴 말랑말랑 Regular", 9.857142F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddTodo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTodo.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddTodo.GlowIntensity = 100;
            this.btnAddTodo.GlowRadius = 20F;
            this.btnAddTodo.GradientBackground = false;
            this.btnAddTodo.GradientColor = System.Drawing.Color.White;
            this.btnAddTodo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddTodo.HintText = null;
            this.btnAddTodo.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddTodo.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btnAddTodo.HoverTextColor = System.Drawing.Color.White;
            this.btnAddTodo.HoverTransitionDuration = 250;
            this.btnAddTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTodo.ImagePadding = 5;
            this.btnAddTodo.ImageSize = new System.Drawing.Size(16, 16);
            this.btnAddTodo.IsRadial = false;
            this.btnAddTodo.IsReadOnly = false;
            this.btnAddTodo.IsToggleButton = false;
            this.btnAddTodo.IsToggled = false;
            this.btnAddTodo.Location = new System.Drawing.Point(251, 151);
            this.btnAddTodo.LongPressDurationMS = 1000;
            this.btnAddTodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTodo.Name = "btnAddTodo";
            this.btnAddTodo.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btnAddTodo.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnAddTodo.ParticleCount = 15;
            this.btnAddTodo.PressAnimationScale = 0.97F;
            this.btnAddTodo.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddTodo.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btnAddTodo.PressTransitionDuration = 150;
            this.btnAddTodo.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnAddTodo.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddTodo.RippleOpacity = 0.3F;
            this.btnAddTodo.RippleRadiusMultiplier = 0.6F;
            this.btnAddTodo.ShadowBlur = 5;
            this.btnAddTodo.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddTodo.ShadowOffset = new System.Drawing.Point(2, 2);
            this.btnAddTodo.ShakeDuration = 500;
            this.btnAddTodo.ShakeIntensity = 5;
            this.btnAddTodo.Size = new System.Drawing.Size(46, 23);
            this.btnAddTodo.TabIndex = 31;
            this.btnAddTodo.Text = "추가";
            this.btnAddTodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddTodo.TextColor = System.Drawing.Color.Black;
            this.btnAddTodo.TooltipText = null;
            this.btnAddTodo.UseAdvancedRendering = true;
            this.btnAddTodo.UseParticles = false;
            this.btnAddTodo.Click += new System.EventHandler(this.btnAddTodo_Click);
            // 
            // Planner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.btnAddTodo);
            this.Controls.Add(this.btnNextMonth);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.flpTodoList);
            this.Controls.Add(this.txtNewTodo);
            this.Controls.Add(this.lblMonthDisplay);
            this.Controls.Add(this.lblTodoTitle);
            this.Controls.Add(this.btnPrevMonth);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Planner";
            this.Size = new System.Drawing.Size(1100, 720);
            this.Load += new System.EventHandler(this.Planner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // 생성자 또는 Load 이벤트에서 호출
        //private void InitializeCalendarTable()
        //{
        //    // 컬럼 세팅
        //    this.calendarTable.ColumnCount = 7;
        //    this.calendarTable.ColumnStyles.Clear();
        //    for (int i = 0; i < 7; i++)
        //    {
        //        this.calendarTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28F));
        //    }

        //    // 행 세팅
        //    this.calendarTable.RowCount = 6;
        //    this.calendarTable.RowStyles.Clear();
        //    for (int i = 0; i < 6; i++)
        //    {
        //        this.calendarTable.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
        //    }

        //    this.calendarTable.Dock = DockStyle.Fill;
        //    this.calendarTable.Margin = new Padding(0);
        //}


        #endregion
        private System.Windows.Forms.Label lblTodoTitle;

        // 우측: 일정 영역 (3가지 보기)
        private System.Windows.Forms.Panel panelRight;

        // 상단: 제목, 버튼
        private System.Windows.Forms.Label lblTitle;
        private Button btnPrevMonth;
        private Button btnNextMonth;
        private FontAwesome.Sharp.IconButton lblMonthDisplay;
        private SiticoneNetFrameworkUI.SiticoneTextBox txtNewTodo;
        private FlowLayoutPanel flpTodoList;
        private SiticoneNetFrameworkUI.SiticoneButton btnConfirm;
        private SiticoneNetFrameworkUI.SiticoneButton btnAddSchedule;
        private SiticoneNetFrameworkUI.SiticoneButton btnAddTodo;
    }
}




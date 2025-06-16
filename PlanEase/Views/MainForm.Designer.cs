using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlanEase
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel calendarTableLayoutPanel;





        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

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


        //private void GenerateCalendar(DateTime targetMonth)
        //{
        //    calendarTable.Controls.Clear();

        //    DateTime firstDay = new DateTime(targetMonth.Year, targetMonth.Month, 1);
        //    int startDay = (int)firstDay.DayOfWeek;
        //    int daysInMonth = DateTime.DaysInMonth(targetMonth.Year, targetMonth.Month);



        //    int cellIndex = 0;

        //    for (int i = 0; i < 42; i++) // 7 x 6 = 42 cells
        //    {
        //        Panel cellPanel = new Panel
        //        {
        //            BorderStyle = BorderStyle.FixedSingle,
        //            Margin = new Padding(1),
        //            BackColor = Color.White,
        //            AllowDrop = true
        //        };

        //        if (i >= startDay && i < startDay + daysInMonth)
        //        {
        //            int day = i - startDay + 1;

        //            Label lblDate = new Label
        //            {
        //                Text = day.ToString(),
        //                Dock = DockStyle.Top,
        //                TextAlign = ContentAlignment.TopRight,
        //                Padding = new Padding(5),
        //                Font = new Font("Segoe UI", 9, FontStyle.Bold),
        //                ForeColor = Color.Black
        //            };

        //            cellPanel.Tag = new DateTime(targetMonth.Year, targetMonth.Month, day);
        //            cellPanel.Controls.Add(lblDate);

        //            // 이벤트 핸들링 (예시)
        //            cellPanel.Click += DateCell_Click;
        //            cellPanel.DragEnter += CellPanel_DragEnter;
        //            cellPanel.DragDrop += CellPanel_DragDrop;
        //            cellPanel.MouseDown += CellPanel_MouseDown;
        //        }

        //        calendarTable.Controls.Add(cellPanel);
        //        cellIndex++;
        //    }
        //}


        #region Windows Form 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.calendarTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelMenu = new SiticoneNetFrameworkUI.SiticoneAdvancedPanel();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnGuide = new FontAwesome.Sharp.IconButton();
            this.btnPlants = new FontAwesome.Sharp.IconButton();
            this.btnTag = new FontAwesome.Sharp.IconButton();
            this.btnCalendar = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new SiticoneNetFrameworkUI.SiticonePanel();
            this.btnLogo = new FontAwesome.Sharp.IconButton();
            this.siticoneBorderlessForm1 = new SiticoneNetFrameworkUI.SiticoneBorderlessForm(this.components);
            this.siticoneCloseButton = new SiticoneNetFrameworkUI.SiticoneCloseButton();
            this.panelDesktop = new SiticoneNetFrameworkUI.SiticoneAdvancedPanel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
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
            // panelMenu
            // 
            this.panelMenu.ActiveBackColor = System.Drawing.Color.Empty;
            this.panelMenu.ActiveBorderColor = System.Drawing.Color.Empty;
            this.panelMenu.AdvancedBorderStyle = SiticoneNetFrameworkUI.SiticoneAdvancedPanel.BorderStyleEx.Solid;
            this.panelMenu.AnimationDuration = 500;
            this.panelMenu.AnimationType = SiticoneNetFrameworkUI.SiticoneAdvancedPanel.AnimationTypeEx.Slide;
            this.panelMenu.BackColor = System.Drawing.Color.Lavender;
            this.panelMenu.BackgroundImageCustom = null;
            this.panelMenu.BackgroundImageOpacity = 1F;
            this.panelMenu.BackgroundImageSizeMode = SiticoneNetFrameworkUI.SiticoneAdvancedPanel.ImageSizeModeEx.Stretch;
            this.panelMenu.BackgroundOverlayColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelMenu.BorderColor = System.Drawing.Color.Gray;
            this.panelMenu.BorderDashPattern = null;
            this.panelMenu.BorderGlowColor = System.Drawing.Color.PaleTurquoise;
            this.panelMenu.BorderGlowSize = 3F;
            this.panelMenu.BorderWidth = 1F;
            this.panelMenu.BottomLeftRadius = 0;
            this.panelMenu.BottomRightRadius = 20;
            this.panelMenu.ContentAlignmentCustom = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnGuide);
            this.panelMenu.Controls.Add(this.btnPlants);
            this.panelMenu.Controls.Add(this.btnTag);
            this.panelMenu.Controls.Add(this.btnCalendar);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.CornerPadding = new System.Windows.Forms.Padding(5);
            this.panelMenu.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelMenu.DisabledBorderColor = System.Drawing.Color.Empty;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.DoubleBorderSpacing = 2F;
            this.panelMenu.EasingType = SiticoneNetFrameworkUI.SiticoneAdvancedPanel.EasingTypeEx.Linear;
            this.panelMenu.EnableAnimation = false;
            this.panelMenu.EnableBackgroundImage = false;
            this.panelMenu.EnableBorderGlow = false;
            this.panelMenu.EnableDoubleBorder = false;
            this.panelMenu.EnableGradient = true;
            this.panelMenu.EnableInnerShadow = false;
            this.panelMenu.EnableShadow = false;
            this.panelMenu.EnableSmartPadding = true;
            this.panelMenu.EnableStateStyles = false;
            this.panelMenu.FlowDirectionCustom = System.Windows.Forms.FlowDirection.LeftToRight;
            this.panelMenu.GradientAngle = 90F;
            this.panelMenu.GradientEndColor = System.Drawing.Color.Indigo;
            this.panelMenu.GradientStartColor = System.Drawing.Color.DarkSlateBlue;
            this.panelMenu.GradientType = SiticoneNetFrameworkUI.SiticoneAdvancedPanel.GradientTypeEx.Linear;
            this.panelMenu.HoverBackColor = System.Drawing.Color.Empty;
            this.panelMenu.HoverBorderColor = System.Drawing.Color.Empty;
            this.panelMenu.InnerShadowColor = System.Drawing.Color.Black;
            this.panelMenu.InnerShadowDepth = 3;
            this.panelMenu.InnerShadowOpacity = 0.2F;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(10);
            this.panelMenu.RadialGradientCenter = ((System.Drawing.PointF)(resources.GetObject("panelMenu.RadialGradientCenter")));
            this.panelMenu.RadialGradientRadius = 1F;
            this.panelMenu.ScaleRatio = 0.8F;
            this.panelMenu.SecondaryBorderColor = System.Drawing.Color.DarkGray;
            this.panelMenu.ShadowBlur = 10;
            this.panelMenu.ShadowColor = System.Drawing.Color.Black;
            this.panelMenu.ShadowDepth = 5;
            this.panelMenu.ShadowOffset = new System.Drawing.Point(2, 2);
            this.panelMenu.ShadowOpacity = 0.3F;
            this.panelMenu.Size = new System.Drawing.Size(250, 750);
            this.panelMenu.SlideDirection = new System.Drawing.Point(0, -30);
            this.panelMenu.TabIndex = 9;
            this.panelMenu.TopLeftRadius = 0;
            this.panelMenu.TopRightRadius = 20;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSetting.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 40;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(10, 410);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSetting.Size = new System.Drawing.Size(230, 75);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "   Settting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnGuide
            // 
            this.btnGuide.BackColor = System.Drawing.Color.Transparent;
            this.btnGuide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuide.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuide.FlatAppearance.BorderSize = 0;
            this.btnGuide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuide.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGuide.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGuide.IconChar = FontAwesome.Sharp.IconChar.PersonCircleQuestion;
            this.btnGuide.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGuide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuide.IconSize = 40;
            this.btnGuide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuide.Location = new System.Drawing.Point(10, 335);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGuide.Size = new System.Drawing.Size(230, 75);
            this.btnGuide.TabIndex = 4;
            this.btnGuide.Text = "   Guide";
            this.btnGuide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuide.UseVisualStyleBackColor = false;
            this.btnGuide.Click += new System.EventHandler(this.btnGuide_Click);
            // 
            // btnPlants
            // 
            this.btnPlants.BackColor = System.Drawing.Color.Transparent;
            this.btnPlants.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlants.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlants.FlatAppearance.BorderSize = 0;
            this.btnPlants.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlants.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlants.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlants.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlants.IconChar = FontAwesome.Sharp.IconChar.Sprout;
            this.btnPlants.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPlants.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlants.IconSize = 40;
            this.btnPlants.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlants.Location = new System.Drawing.Point(10, 260);
            this.btnPlants.Name = "btnPlants";
            this.btnPlants.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPlants.Size = new System.Drawing.Size(230, 75);
            this.btnPlants.TabIndex = 3;
            this.btnPlants.Text = "   Adventure";
            this.btnPlants.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlants.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlants.UseVisualStyleBackColor = false;
            this.btnPlants.Click += new System.EventHandler(this.btnPlants_Click);
            // 
            // btnTag
            // 
            this.btnTag.BackColor = System.Drawing.Color.Transparent;
            this.btnTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTag.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTag.FlatAppearance.BorderSize = 0;
            this.btnTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTag.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTag.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTag.IconChar = FontAwesome.Sharp.IconChar.Hashtag;
            this.btnTag.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTag.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTag.IconSize = 40;
            this.btnTag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTag.Location = new System.Drawing.Point(10, 185);
            this.btnTag.Name = "btnTag";
            this.btnTag.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTag.Size = new System.Drawing.Size(230, 75);
            this.btnTag.TabIndex = 2;
            this.btnTag.Text = "   Tags";
            this.btnTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTag.UseVisualStyleBackColor = false;
            this.btnTag.Click += new System.EventHandler(this.btnTag_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.Transparent;
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCalendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCalendar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCalendar.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnCalendar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalendar.IconSize = 40;
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(10, 110);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCalendar.Size = new System.Drawing.Size(230, 75);
            this.btnCalendar.TabIndex = 1;
            this.btnCalendar.Text = "   Planner";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.AcrylicTintColor = System.Drawing.Color.Transparent;
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            this.panelLogo.BorderDashPattern = null;
            this.panelLogo.BorderGradientEndColor = System.Drawing.Color.Purple;
            this.panelLogo.BorderGradientStartColor = System.Drawing.Color.Blue;
            this.panelLogo.BorderThickness = 2F;
            this.panelLogo.Controls.Add(this.btnLogo);
            this.panelLogo.CornerRadiusBottomLeft = 0F;
            this.panelLogo.CornerRadiusBottomRight = 0F;
            this.panelLogo.CornerRadiusTopLeft = 0F;
            this.panelLogo.CornerRadiusTopRight = 0F;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.EnableAcrylicEffect = false;
            this.panelLogo.EnableMicaEffect = false;
            this.panelLogo.EnableRippleEffect = false;
            this.panelLogo.FillColor = System.Drawing.Color.Transparent;
            this.panelLogo.GradientColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.Gray};
            this.panelLogo.GradientPositions = new float[] {
        0F,
        0.5F,
        1F};
            this.panelLogo.Location = new System.Drawing.Point(10, 10);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.PatternStyle = System.Drawing.Drawing2D.HatchStyle.LargeGrid;
            this.panelLogo.RippleAlpha = 50;
            this.panelLogo.RippleAlphaDecrement = 3;
            this.panelLogo.RippleColor = System.Drawing.Color.Transparent;
            this.panelLogo.RippleMaxSize = 600F;
            this.panelLogo.RippleSpeed = 15F;
            this.panelLogo.ShowBorder = false;
            this.panelLogo.Size = new System.Drawing.Size(230, 100);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.TabStop = true;
            this.panelLogo.TrackSystemTheme = false;
            this.panelLogo.UseBorderGradient = false;
            this.panelLogo.UseMultiGradient = false;
            this.panelLogo.UsePatternTexture = false;
            this.panelLogo.UseRadialGradient = false;
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogo.ForeColor = System.Drawing.Color.White;
            this.btnLogo.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            this.btnLogo.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogo.IconSize = 62;
            this.btnLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Padding = new System.Windows.Forms.Padding(0, 15, 10, 0);
            this.btnLogo.Size = new System.Drawing.Size(230, 100);
            this.btnLogo.TabIndex = 2;
            this.btnLogo.Text = "PlanEase";
            this.btnLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogo.UseVisualStyleBackColor = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.DropShadow = false;
            this.siticoneBorderlessForm1.NavBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneBorderlessForm1.NavBarHeight = 30;
            this.siticoneBorderlessForm1.TargetForm = this;
            // 
            // siticoneCloseButton
            // 
            this.siticoneCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.siticoneCloseButton.CountdownFont = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCloseButton.EnableSound = false;
            this.siticoneCloseButton.Location = new System.Drawing.Point(1367, 0);
            this.siticoneCloseButton.Name = "siticoneCloseButton";
            this.siticoneCloseButton.Size = new System.Drawing.Size(36, 36);
            this.siticoneCloseButton.TabIndex = 11;
            this.siticoneCloseButton.Text = "siticoneCloseButton2";
            this.siticoneCloseButton.TooltipText = "Close";
            this.siticoneCloseButton.Click += new System.EventHandler(this.siticoneCloseButton_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.ActiveBackColor = System.Drawing.Color.Empty;
            this.panelDesktop.ActiveBorderColor = System.Drawing.Color.Empty;
            this.panelDesktop.AdvancedBorderStyle = SiticoneNetFrameworkUI.SiticoneAdvancedPanel.BorderStyleEx.Solid;
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.AnimationDuration = 500;
            this.panelDesktop.AnimationType = SiticoneNetFrameworkUI.SiticoneAdvancedPanel.AnimationTypeEx.Fade;
            this.panelDesktop.BackColor = System.Drawing.Color.Lavender;
            this.panelDesktop.BackgroundImageCustom = null;
            this.panelDesktop.BackgroundImageOpacity = 1F;
            this.panelDesktop.BackgroundImageSizeMode = SiticoneNetFrameworkUI.SiticoneAdvancedPanel.ImageSizeModeEx.Stretch;
            this.panelDesktop.BackgroundOverlayColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDesktop.BorderColor = System.Drawing.Color.Gray;
            this.panelDesktop.BorderDashPattern = null;
            this.panelDesktop.BorderGlowColor = System.Drawing.Color.Cyan;
            this.panelDesktop.BorderGlowSize = 3F;
            this.panelDesktop.BorderWidth = 1F;
            this.panelDesktop.BottomLeftRadius = 5;
            this.panelDesktop.BottomRightRadius = 5;
            this.panelDesktop.ContentAlignmentCustom = System.Drawing.ContentAlignment.MiddleCenter;
            this.panelDesktop.CornerPadding = new System.Windows.Forms.Padding(5);
            this.panelDesktop.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelDesktop.DisabledBorderColor = System.Drawing.Color.Empty;
            this.panelDesktop.DoubleBorderSpacing = 2F;
            this.panelDesktop.EasingType = SiticoneNetFrameworkUI.SiticoneAdvancedPanel.EasingTypeEx.Linear;
            this.panelDesktop.EnableAnimation = false;
            this.panelDesktop.EnableBackgroundImage = false;
            this.panelDesktop.EnableBorderGlow = false;
            this.panelDesktop.EnableDoubleBorder = false;
            this.panelDesktop.EnableGradient = false;
            this.panelDesktop.EnableInnerShadow = false;
            this.panelDesktop.EnableShadow = false;
            this.panelDesktop.EnableSmartPadding = true;
            this.panelDesktop.EnableStateStyles = false;
            this.panelDesktop.FlowDirectionCustom = System.Windows.Forms.FlowDirection.LeftToRight;
            this.panelDesktop.GradientAngle = 90F;
            this.panelDesktop.GradientEndColor = System.Drawing.Color.LightGray;
            this.panelDesktop.GradientStartColor = System.Drawing.Color.White;
            this.panelDesktop.GradientType = SiticoneNetFrameworkUI.SiticoneAdvancedPanel.GradientTypeEx.Linear;
            this.panelDesktop.HoverBackColor = System.Drawing.Color.Empty;
            this.panelDesktop.HoverBorderColor = System.Drawing.Color.Empty;
            this.panelDesktop.InnerShadowColor = System.Drawing.Color.Black;
            this.panelDesktop.InnerShadowDepth = 3;
            this.panelDesktop.InnerShadowOpacity = 0.2F;
            this.panelDesktop.Location = new System.Drawing.Point(250, 30);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Padding = new System.Windows.Forms.Padding(10);
            this.panelDesktop.RadialGradientCenter = ((System.Drawing.PointF)(resources.GetObject("panelDesktop.RadialGradientCenter")));
            this.panelDesktop.RadialGradientRadius = 1F;
            this.panelDesktop.ScaleRatio = 0.8F;
            this.panelDesktop.SecondaryBorderColor = System.Drawing.Color.DarkGray;
            this.panelDesktop.ShadowBlur = 10;
            this.panelDesktop.ShadowColor = System.Drawing.Color.Black;
            this.panelDesktop.ShadowDepth = 5;
            this.panelDesktop.ShadowOffset = new System.Drawing.Point(2, 2);
            this.panelDesktop.ShadowOpacity = 0.3F;
            this.panelDesktop.Size = new System.Drawing.Size(1150, 720);
            this.panelDesktop.SlideDirection = new System.Drawing.Point(0, -30);
            this.panelDesktop.TabIndex = 12;
            this.panelDesktop.TopLeftRadius = 5;
            this.panelDesktop.TopRightRadius = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.siticoneCloseButton);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private SiticoneNetFrameworkUI.SiticoneAdvancedPanel panelMenu;
        private SiticoneNetFrameworkUI.SiticonePanel panelLogo;
        private FontAwesome.Sharp.IconButton btnCalendar;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnGuide;
        private FontAwesome.Sharp.IconButton btnPlants;
        private FontAwesome.Sharp.IconButton btnTag;
        private SiticoneNetFrameworkUI.SiticoneBorderlessForm siticoneBorderlessForm1;
        private SiticoneNetFrameworkUI.SiticoneCloseButton siticoneCloseButton;
        private FontAwesome.Sharp.IconButton btnLogo;
        private SiticoneNetFrameworkUI.SiticoneAdvancedPanel panelDesktop;
    }
}




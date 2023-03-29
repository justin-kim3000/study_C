namespace _3_project.ui
{
    partial class m_todayPlan
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(m_todayPlan));
            this.headLayout = new System.Windows.Forms.Panel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.headLine = new Sunny.UI.UILine();
            this.trainerLayout = new System.Windows.Forms.Panel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLine5 = new Sunny.UI.UILine();
            this.uiLine4 = new Sunny.UI.UILine();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLine3 = new Sunny.UI.UILine();
            this.trainer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customerTime = new System.Windows.Forms.Panel();
            this.botLayout = new System.Windows.Forms.Panel();
            this.textSummary = new Sunny.UI.UITextBox();
            this.trainerRunTime = new System.Windows.Forms.Timer(this.components);
            this.cusOne = new Sunny.UI.UIButton();
            this.cusFour = new Sunny.UI.UIButton();
            this.cusTwo = new Sunny.UI.UIButton();
            this.cusThree = new Sunny.UI.UIButton();
            this.headLayout.SuspendLayout();
            this.trainerLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customerTime.SuspendLayout();
            this.botLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // headLayout
            // 
            this.headLayout.Controls.Add(this.uiMarkLabel1);
            this.headLayout.Controls.Add(this.headLine);
            this.headLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.headLayout.Location = new System.Drawing.Point(0, 0);
            this.headLayout.Name = "headLayout";
            this.headLayout.Size = new System.Drawing.Size(600, 55);
            this.headLayout.TabIndex = 8;
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiMarkLabel1.Location = new System.Drawing.Point(10, 10);
            this.uiMarkLabel1.MarkColor = System.Drawing.Color.DarkSlateBlue;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(400, 35);
            this.uiMarkLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiMarkLabel1.TabIndex = 64;
            this.uiMarkLabel1.Text = "당일 일정";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // headLine
            // 
            this.headLine.BackColor = System.Drawing.Color.Transparent;
            this.headLine.FillColor = System.Drawing.Color.Transparent;
            this.headLine.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.headLine.LineColor = System.Drawing.Color.DarkViolet;
            this.headLine.LineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.headLine.LineSize = 5;
            this.headLine.Location = new System.Drawing.Point(68, 78);
            this.headLine.MinimumSize = new System.Drawing.Size(1, 1);
            this.headLine.Name = "headLine";
            this.headLine.Size = new System.Drawing.Size(464, 15);
            this.headLine.Style = Sunny.UI.UIStyle.Custom;
            this.headLine.TabIndex = 2;
            this.headLine.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // trainerLayout
            // 
            this.trainerLayout.BackColor = System.Drawing.Color.Transparent;
            this.trainerLayout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trainerLayout.BackgroundImage")));
            this.trainerLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trainerLayout.Controls.Add(this.uiLabel1);
            this.trainerLayout.Controls.Add(this.uiLine5);
            this.trainerLayout.Controls.Add(this.uiLine4);
            this.trainerLayout.Controls.Add(this.uiLine2);
            this.trainerLayout.Controls.Add(this.uiLine1);
            this.trainerLayout.Controls.Add(this.uiLine3);
            this.trainerLayout.Controls.Add(this.trainer);
            this.trainerLayout.Controls.Add(this.pictureBox1);
            this.trainerLayout.Location = new System.Drawing.Point(0, 55);
            this.trainerLayout.Name = "trainerLayout";
            this.trainerLayout.Size = new System.Drawing.Size(600, 281);
            this.trainerLayout.TabIndex = 6;
            // 
            // uiLabel1
            // 
            this.uiLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiLabel1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLabel1.Location = new System.Drawing.Point(20, 231);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(560, 30);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 90;
            this.uiLabel1.Text = "6시 7시 8시 9시 10시 11시 12시 1시 2시 3시 4시 5시 6시 7시 8시 9시 10시";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel1.UseCompatibleTextRendering = true;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine5
            // 
            this.uiLine5.BackColor = System.Drawing.Color.Transparent;
            this.uiLine5.FillColor = System.Drawing.Color.Transparent;
            this.uiLine5.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiLine5.ForeColor = System.Drawing.Color.Black;
            this.uiLine5.LineColor = System.Drawing.Color.Black;
            this.uiLine5.LineColor2 = System.Drawing.Color.Black;
            this.uiLine5.Location = new System.Drawing.Point(-9, 221);
            this.uiLine5.Margin = new System.Windows.Forms.Padding(0);
            this.uiLine5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine5.Name = "uiLine5";
            this.uiLine5.Size = new System.Drawing.Size(650, 1);
            this.uiLine5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine5.TabIndex = 89;
            this.uiLine5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine4
            // 
            this.uiLine4.BackColor = System.Drawing.Color.Transparent;
            this.uiLine4.FillColor = System.Drawing.Color.Transparent;
            this.uiLine4.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiLine4.ForeColor = System.Drawing.Color.Black;
            this.uiLine4.LineColor = System.Drawing.Color.Black;
            this.uiLine4.LineColor2 = System.Drawing.Color.Black;
            this.uiLine4.Location = new System.Drawing.Point(-13, 223);
            this.uiLine4.Margin = new System.Windows.Forms.Padding(0);
            this.uiLine4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine4.Name = "uiLine4";
            this.uiLine4.Size = new System.Drawing.Size(650, 1);
            this.uiLine4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine4.TabIndex = 88;
            this.uiLine4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine2
            // 
            this.uiLine2.BackColor = System.Drawing.Color.Transparent;
            this.uiLine2.FillColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiLine2.ForeColor = System.Drawing.Color.Black;
            this.uiLine2.LineColor = System.Drawing.Color.Black;
            this.uiLine2.LineColor2 = System.Drawing.Color.Black;
            this.uiLine2.Location = new System.Drawing.Point(-11, 219);
            this.uiLine2.Margin = new System.Windows.Forms.Padding(0);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(650, 1);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 87;
            this.uiLine2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiLine1.ForeColor = System.Drawing.Color.Black;
            this.uiLine1.LineColor = System.Drawing.Color.Black;
            this.uiLine1.LineColor2 = System.Drawing.Color.Black;
            this.uiLine1.Location = new System.Drawing.Point(-11, 217);
            this.uiLine1.Margin = new System.Windows.Forms.Padding(0);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(650, 1);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 86;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine3
            // 
            this.uiLine3.BackColor = System.Drawing.Color.Transparent;
            this.uiLine3.FillColor = System.Drawing.Color.Transparent;
            this.uiLine3.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiLine3.ForeColor = System.Drawing.Color.Black;
            this.uiLine3.LineColor = System.Drawing.Color.Black;
            this.uiLine3.LineColor2 = System.Drawing.Color.Black;
            this.uiLine3.Location = new System.Drawing.Point(-12, 215);
            this.uiLine3.Margin = new System.Windows.Forms.Padding(0);
            this.uiLine3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(650, 1);
            this.uiLine3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine3.TabIndex = 85;
            this.uiLine3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // trainer
            // 
            this.trainer.BackColor = System.Drawing.Color.Transparent;
            this.trainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trainer.BackgroundImage")));
            this.trainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.trainer.Location = new System.Drawing.Point(30, 2);
            this.trainer.Name = "trainer";
            this.trainer.Size = new System.Drawing.Size(95, 125);
            this.trainer.TabIndex = 6;
            this.trainer.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // customerTime
            // 
            this.customerTime.Controls.Add(this.cusOne);
            this.customerTime.Controls.Add(this.cusFour);
            this.customerTime.Controls.Add(this.cusTwo);
            this.customerTime.Controls.Add(this.cusThree);
            this.customerTime.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customerTime.ForeColor = System.Drawing.Color.Black;
            this.customerTime.Location = new System.Drawing.Point(0, 332);
            this.customerTime.Margin = new System.Windows.Forms.Padding(0);
            this.customerTime.Name = "customerTime";
            this.customerTime.Size = new System.Drawing.Size(600, 248);
            this.customerTime.TabIndex = 9;
            // 
            // botLayout
            // 
            this.botLayout.Controls.Add(this.textSummary);
            this.botLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botLayout.ForeColor = System.Drawing.Color.Black;
            this.botLayout.Location = new System.Drawing.Point(0, 581);
            this.botLayout.Margin = new System.Windows.Forms.Padding(0);
            this.botLayout.Name = "botLayout";
            this.botLayout.Size = new System.Drawing.Size(600, 139);
            this.botLayout.TabIndex = 10;
            // 
            // textSummary
            // 
            this.textSummary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSummary.FillColor2 = System.Drawing.Color.White;
            this.textSummary.FillDisableColor = System.Drawing.Color.White;
            this.textSummary.FillReadOnlyColor = System.Drawing.Color.White;
            this.textSummary.Font = new System.Drawing.Font("나눔고딕", 9.75F);
            this.textSummary.ForeColor = System.Drawing.Color.Black;
            this.textSummary.ForeDisableColor = System.Drawing.Color.Black;
            this.textSummary.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.textSummary.Location = new System.Drawing.Point(10, 10);
            this.textSummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSummary.MinimumSize = new System.Drawing.Size(1, 16);
            this.textSummary.Multiline = true;
            this.textSummary.Name = "textSummary";
            this.textSummary.Radius = 0;
            this.textSummary.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.textSummary.RectColor = System.Drawing.Color.Black;
            this.textSummary.RectDisableColor = System.Drawing.Color.Black;
            this.textSummary.RectReadOnlyColor = System.Drawing.Color.Black;
            this.textSummary.ScrollBarBackColor = System.Drawing.Color.DarkGray;
            this.textSummary.ScrollBarColor = System.Drawing.Color.MediumSlateBlue;
            this.textSummary.ShowText = false;
            this.textSummary.Size = new System.Drawing.Size(580, 119);
            this.textSummary.Style = Sunny.UI.UIStyle.Custom;
            this.textSummary.TabIndex = 1;
            this.textSummary.Text = "ex) 000트레이너님, 12-27일 당일\r\n12시 000회원, (오후)3시 000회원 PT가 있습니다.";
            this.textSummary.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.textSummary.Watermark = "";
            this.textSummary.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // trainerRunTime
            // 
            this.trainerRunTime.Tick += new System.EventHandler(this.trainerRunTime_Tick);
            // 
            // cusOne
            // 
            this.cusOne.BackColor = System.Drawing.Color.Transparent;
            this.cusOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cusOne.FillColor = System.Drawing.Color.White;
            this.cusOne.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cusOne.Location = new System.Drawing.Point(14, 32);
            this.cusOne.MinimumSize = new System.Drawing.Size(1, 1);
            this.cusOne.Name = "cusOne";
            this.cusOne.Radius = 0;
            this.cusOne.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.cusOne.RectColor = System.Drawing.Color.White;
            this.cusOne.RectDisableColor = System.Drawing.Color.White;
            this.cusOne.RectHoverColor = System.Drawing.Color.White;
            this.cusOne.RectPressColor = System.Drawing.Color.White;
            this.cusOne.RectSelectedColor = System.Drawing.Color.White;
            this.cusOne.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cusOne.Size = new System.Drawing.Size(220, 35);
            this.cusOne.Style = Sunny.UI.UIStyle.Custom;
            this.cusOne.TabIndex = 0;
            this.cusOne.Text = "ex) 1004번 회원 박수인님 10시 PT";
            this.cusOne.TipsForeColor = System.Drawing.Color.DimGray;
            this.cusOne.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cusOne.Click += new System.EventHandler(this.cusOne_Click);
            // 
            // cusFour
            // 
            this.cusFour.BackColor = System.Drawing.Color.Transparent;
            this.cusFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cusFour.FillColor = System.Drawing.Color.White;
            this.cusFour.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cusFour.Location = new System.Drawing.Point(364, 160);
            this.cusFour.MinimumSize = new System.Drawing.Size(1, 1);
            this.cusFour.Name = "cusFour";
            this.cusFour.Radius = 0;
            this.cusFour.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.cusFour.RectColor = System.Drawing.Color.White;
            this.cusFour.RectDisableColor = System.Drawing.Color.White;
            this.cusFour.RectHoverColor = System.Drawing.Color.White;
            this.cusFour.RectPressColor = System.Drawing.Color.White;
            this.cusFour.RectSelectedColor = System.Drawing.Color.White;
            this.cusFour.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cusFour.Size = new System.Drawing.Size(220, 35);
            this.cusFour.Style = Sunny.UI.UIStyle.Custom;
            this.cusFour.TabIndex = 3;
            this.cusFour.Text = "ex) 1004번 회원 박수인님 10시 PT";
            this.cusFour.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cusFour.Click += new System.EventHandler(this.cusFour_Click);
            // 
            // cusTwo
            // 
            this.cusTwo.BackColor = System.Drawing.Color.Transparent;
            this.cusTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cusTwo.FillColor = System.Drawing.Color.White;
            this.cusTwo.FillColor2 = System.Drawing.Color.White;
            this.cusTwo.FillHoverColor = System.Drawing.Color.White;
            this.cusTwo.FillPressColor = System.Drawing.Color.White;
            this.cusTwo.FillSelectedColor = System.Drawing.Color.White;
            this.cusTwo.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cusTwo.ForeColor = System.Drawing.Color.Black;
            this.cusTwo.ForeDisableColor = System.Drawing.Color.Black;
            this.cusTwo.ForeHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.cusTwo.ForePressColor = System.Drawing.Color.DarkSlateBlue;
            this.cusTwo.ForeSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.cusTwo.Location = new System.Drawing.Point(128, 73);
            this.cusTwo.MinimumSize = new System.Drawing.Size(1, 1);
            this.cusTwo.Name = "cusTwo";
            this.cusTwo.Radius = 0;
            this.cusTwo.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.cusTwo.RectColor = System.Drawing.Color.White;
            this.cusTwo.RectDisableColor = System.Drawing.Color.White;
            this.cusTwo.RectHoverColor = System.Drawing.Color.White;
            this.cusTwo.RectPressColor = System.Drawing.Color.White;
            this.cusTwo.RectSelectedColor = System.Drawing.Color.White;
            this.cusTwo.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cusTwo.Size = new System.Drawing.Size(220, 35);
            this.cusTwo.Style = Sunny.UI.UIStyle.Custom;
            this.cusTwo.TabIndex = 1;
            this.cusTwo.Text = "ex) 1004번 회원 박수인님 10시 PT";
            this.cusTwo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cusTwo.Click += new System.EventHandler(this.cusTwo_Click);
            // 
            // cusThree
            // 
            this.cusThree.BackColor = System.Drawing.Color.Transparent;
            this.cusThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cusThree.FillColor = System.Drawing.Color.White;
            this.cusThree.FillColor2 = System.Drawing.Color.White;
            this.cusThree.FillHoverColor = System.Drawing.Color.White;
            this.cusThree.FillPressColor = System.Drawing.Color.White;
            this.cusThree.FillSelectedColor = System.Drawing.Color.White;
            this.cusThree.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cusThree.ForeColor = System.Drawing.Color.Black;
            this.cusThree.ForeDisableColor = System.Drawing.Color.Black;
            this.cusThree.ForeHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.cusThree.ForePressColor = System.Drawing.Color.DarkSlateBlue;
            this.cusThree.ForeSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.cusThree.Location = new System.Drawing.Point(283, 119);
            this.cusThree.MinimumSize = new System.Drawing.Size(1, 1);
            this.cusThree.Name = "cusThree";
            this.cusThree.Radius = 0;
            this.cusThree.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.cusThree.RectColor = System.Drawing.Color.White;
            this.cusThree.RectDisableColor = System.Drawing.Color.White;
            this.cusThree.RectHoverColor = System.Drawing.Color.White;
            this.cusThree.RectPressColor = System.Drawing.Color.White;
            this.cusThree.RectSelectedColor = System.Drawing.Color.White;
            this.cusThree.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.cusThree.Size = new System.Drawing.Size(220, 35);
            this.cusThree.Style = Sunny.UI.UIStyle.Custom;
            this.cusThree.TabIndex = 2;
            this.cusThree.Text = "ex) 1004번 회원 박수인님 10시 PT";
            this.cusThree.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.cusThree.Click += new System.EventHandler(this.cusThree_Click);
            // 
            // m_todayPlan
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.botLayout);
            this.Controls.Add(this.customerTime);
            this.Controls.Add(this.headLayout);
            this.Controls.Add(this.trainerLayout);
            this.Name = "m_todayPlan";
            this.Size = new System.Drawing.Size(600, 720);
            this.headLayout.ResumeLayout(false);
            this.trainerLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customerTime.ResumeLayout(false);
            this.botLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headLayout;
        private Sunny.UI.UILine headLine;
        private System.Windows.Forms.Panel trainerLayout;
        private System.Windows.Forms.PictureBox trainer;
        private System.Windows.Forms.Panel customerTime;
        private System.Windows.Forms.Panel botLayout;
        private Sunny.UI.UITextBox textSummary;
        private System.Windows.Forms.Timer trainerRunTime;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UILine uiLine3;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine4;
        private Sunny.UI.UILine uiLine5;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIButton cusOne;
        private Sunny.UI.UIButton cusFour;
        private Sunny.UI.UIButton cusTwo;
        private Sunny.UI.UIButton cusThree;
    }
}

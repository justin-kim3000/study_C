namespace Winfom1219
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTitle = new Sunny.UI.UISymbolLabel();
            this.topLayout = new System.Windows.Forms.Panel();
            this.uiSymbolButton6 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton5 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton4 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.mainMin = new Sunny.UI.UISymbolButton();
            this.leftLayout = new System.Windows.Forms.Panel();
            this.mainHelp = new Sunny.UI.UIHeaderButton();
            this.mainSetting = new Sunny.UI.UIHeaderButton();
            this.mainAdmin = new Sunny.UI.UIHeaderButton();
            this.mainInfo = new Sunny.UI.UIHeaderButton();
            this.mainScore = new Sunny.UI.UIHeaderButton();
            this.mainAdd = new Sunny.UI.UIHeaderButton();
            this.centerLayout = new System.Windows.Forms.Panel();
            this.mainHome = new Sunny.UI.UIHeaderButton();
            this.topLayout.SuspendLayout();
            this.leftLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainTitle.ForeColor = System.Drawing.Color.White;
            this.mainTitle.Location = new System.Drawing.Point(12, 12);
            this.mainTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.mainTitle.Size = new System.Drawing.Size(170, 35);
            this.mainTitle.Style = Sunny.UI.UIStyle.Custom;
            this.mainTitle.Symbol = 61447;
            this.mainTitle.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "사원관리 App 1.0";
            this.mainTitle.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // topLayout
            // 
            this.topLayout.BackColor = System.Drawing.Color.LightPink;
            this.topLayout.Controls.Add(this.mainTitle);
            this.topLayout.Controls.Add(this.uiSymbolButton6);
            this.topLayout.Controls.Add(this.uiSymbolButton5);
            this.topLayout.Controls.Add(this.uiSymbolButton4);
            this.topLayout.Controls.Add(this.uiSymbolButton3);
            this.topLayout.Controls.Add(this.mainExit);
            this.topLayout.Controls.Add(this.mainMin);
            this.topLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayout.Location = new System.Drawing.Point(0, 0);
            this.topLayout.Name = "topLayout";
            this.topLayout.Size = new System.Drawing.Size(800, 65);
            this.topLayout.TabIndex = 1;
            this.topLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topLayout_MouseMove);
            // 
            // uiSymbolButton6
            // 
            this.uiSymbolButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton6.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton6.Location = new System.Drawing.Point(450, 23);
            this.uiSymbolButton6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton6.Name = "uiSymbolButton6";
            this.uiSymbolButton6.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton6.Size = new System.Drawing.Size(37, 35);
            this.uiSymbolButton6.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton6.Symbol = 61799;
            this.uiSymbolButton6.TabIndex = 5;
            this.uiSymbolButton6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton5
            // 
            this.uiSymbolButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton5.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton5.Location = new System.Drawing.Point(407, 23);
            this.uiSymbolButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton5.Name = "uiSymbolButton5";
            this.uiSymbolButton5.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton5.Size = new System.Drawing.Size(37, 35);
            this.uiSymbolButton5.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton5.Symbol = 61595;
            this.uiSymbolButton5.TabIndex = 4;
            this.uiSymbolButton5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton4
            // 
            this.uiSymbolButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton4.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton4.Location = new System.Drawing.Point(364, 23);
            this.uiSymbolButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton4.Name = "uiSymbolButton4";
            this.uiSymbolButton4.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton4.Size = new System.Drawing.Size(37, 35);
            this.uiSymbolButton4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton4.Symbol = 62117;
            this.uiSymbolButton4.TabIndex = 3;
            this.uiSymbolButton4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton3
            // 
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton3.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton3.Location = new System.Drawing.Point(321, 23);
            this.uiSymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.Size = new System.Drawing.Size(37, 35);
            this.uiSymbolButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton3.Symbol = 62000;
            this.uiSymbolButton3.TabIndex = 2;
            this.uiSymbolButton3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // mainExit
            // 
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.Transparent;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.Location = new System.Drawing.Point(756, 23);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.Transparent;
            this.mainExit.Size = new System.Drawing.Size(32, 35);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61453;
            this.mainExit.TabIndex = 1;
            this.mainExit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // mainMin
            // 
            this.mainMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainMin.FillColor = System.Drawing.Color.Transparent;
            this.mainMin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainMin.Location = new System.Drawing.Point(718, 23);
            this.mainMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainMin.Name = "mainMin";
            this.mainMin.RectColor = System.Drawing.Color.Transparent;
            this.mainMin.Size = new System.Drawing.Size(32, 35);
            this.mainMin.Style = Sunny.UI.UIStyle.Custom;
            this.mainMin.Symbol = 62161;
            this.mainMin.TabIndex = 0;
            this.mainMin.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainMin.Click += new System.EventHandler(this.mainMin_Click);
            // 
            // leftLayout
            // 
            this.leftLayout.Controls.Add(this.mainHelp);
            this.leftLayout.Controls.Add(this.mainSetting);
            this.leftLayout.Controls.Add(this.mainAdmin);
            this.leftLayout.Controls.Add(this.mainInfo);
            this.leftLayout.Controls.Add(this.mainScore);
            this.leftLayout.Controls.Add(this.mainAdd);
            this.leftLayout.Controls.Add(this.mainHome);
            this.leftLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftLayout.Location = new System.Drawing.Point(0, 65);
            this.leftLayout.Name = "leftLayout";
            this.leftLayout.Size = new System.Drawing.Size(200, 507);
            this.leftLayout.TabIndex = 2;
            // 
            // mainHelp
            // 
            this.mainHelp.CircleColor = System.Drawing.Color.Transparent;
            this.mainHelp.FillColor = System.Drawing.Color.Transparent;
            this.mainHelp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainHelp.ForeColor = System.Drawing.Color.Black;
            this.mainHelp.Location = new System.Drawing.Point(0, 432);
            this.mainHelp.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainHelp.Name = "mainHelp";
            this.mainHelp.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.mainHelp.Radius = 0;
            this.mainHelp.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.mainHelp.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.mainHelp.Size = new System.Drawing.Size(200, 66);
            this.mainHelp.Style = Sunny.UI.UIStyle.Custom;
            this.mainHelp.Symbol = 61529;
            this.mainHelp.SymbolColor = System.Drawing.Color.Black;
            this.mainHelp.TabIndex = 6;
            this.mainHelp.Text = "도움말";
            this.mainHelp.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainHelp.Click += new System.EventHandler(this.mainHelp_Click);
            // 
            // mainSetting
            // 
            this.mainSetting.CircleColor = System.Drawing.Color.Transparent;
            this.mainSetting.FillColor = System.Drawing.Color.Transparent;
            this.mainSetting.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainSetting.ForeColor = System.Drawing.Color.Black;
            this.mainSetting.Location = new System.Drawing.Point(0, 360);
            this.mainSetting.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainSetting.Name = "mainSetting";
            this.mainSetting.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.mainSetting.Radius = 0;
            this.mainSetting.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.mainSetting.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.mainSetting.Size = new System.Drawing.Size(200, 66);
            this.mainSetting.Style = Sunny.UI.UIStyle.Custom;
            this.mainSetting.Symbol = 61459;
            this.mainSetting.SymbolColor = System.Drawing.Color.Black;
            this.mainSetting.TabIndex = 5;
            this.mainSetting.Text = "환경설정";
            this.mainSetting.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainSetting.Click += new System.EventHandler(this.mainSetting_Click);
            // 
            // mainAdmin
            // 
            this.mainAdmin.CircleColor = System.Drawing.Color.Transparent;
            this.mainAdmin.FillColor = System.Drawing.Color.Transparent;
            this.mainAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainAdmin.ForeColor = System.Drawing.Color.Black;
            this.mainAdmin.Location = new System.Drawing.Point(0, 288);
            this.mainAdmin.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainAdmin.Name = "mainAdmin";
            this.mainAdmin.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.mainAdmin.Radius = 0;
            this.mainAdmin.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.mainAdmin.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.mainAdmin.Size = new System.Drawing.Size(200, 66);
            this.mainAdmin.Style = Sunny.UI.UIStyle.Custom;
            this.mainAdmin.Symbol = 61550;
            this.mainAdmin.SymbolColor = System.Drawing.Color.Black;
            this.mainAdmin.TabIndex = 4;
            this.mainAdmin.Text = "관리자";
            this.mainAdmin.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainAdmin.Click += new System.EventHandler(this.mainAdmin_Click);
            // 
            // mainInfo
            // 
            this.mainInfo.CircleColor = System.Drawing.Color.Transparent;
            this.mainInfo.FillColor = System.Drawing.Color.Transparent;
            this.mainInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainInfo.ForeColor = System.Drawing.Color.Black;
            this.mainInfo.Location = new System.Drawing.Point(0, 216);
            this.mainInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainInfo.Name = "mainInfo";
            this.mainInfo.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.mainInfo.Radius = 0;
            this.mainInfo.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.mainInfo.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.mainInfo.Size = new System.Drawing.Size(200, 66);
            this.mainInfo.Style = Sunny.UI.UIStyle.Custom;
            this.mainInfo.Symbol = 61717;
            this.mainInfo.SymbolColor = System.Drawing.Color.Black;
            this.mainInfo.TabIndex = 3;
            this.mainInfo.Text = "정보 보기";
            this.mainInfo.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainInfo.Click += new System.EventHandler(this.mainInfo_Click);
            // 
            // mainScore
            // 
            this.mainScore.CircleColor = System.Drawing.Color.Transparent;
            this.mainScore.FillColor = System.Drawing.Color.Transparent;
            this.mainScore.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainScore.ForeColor = System.Drawing.Color.Black;
            this.mainScore.Location = new System.Drawing.Point(0, 144);
            this.mainScore.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainScore.Name = "mainScore";
            this.mainScore.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.mainScore.Radius = 0;
            this.mainScore.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.mainScore.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.mainScore.Size = new System.Drawing.Size(200, 66);
            this.mainScore.Style = Sunny.UI.UIStyle.Custom;
            this.mainScore.Symbol = 61786;
            this.mainScore.SymbolColor = System.Drawing.Color.Black;
            this.mainScore.TabIndex = 2;
            this.mainScore.Text = "급여 등급";
            this.mainScore.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainScore.Click += new System.EventHandler(this.mainScore_Click);
            // 
            // mainAdd
            // 
            this.mainAdd.CircleColor = System.Drawing.Color.Transparent;
            this.mainAdd.FillColor = System.Drawing.Color.Transparent;
            this.mainAdd.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainAdd.ForeColor = System.Drawing.Color.Black;
            this.mainAdd.Location = new System.Drawing.Point(0, 72);
            this.mainAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainAdd.Name = "mainAdd";
            this.mainAdd.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.mainAdd.Radius = 0;
            this.mainAdd.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.mainAdd.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.mainAdd.Size = new System.Drawing.Size(200, 66);
            this.mainAdd.Style = Sunny.UI.UIStyle.Custom;
            this.mainAdd.Symbol = 61447;
            this.mainAdd.SymbolColor = System.Drawing.Color.Black;
            this.mainAdd.TabIndex = 1;
            this.mainAdd.Text = "사원추가";
            this.mainAdd.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainAdd.Click += new System.EventHandler(this.mainAdd_Click);
            // 
            // centerLayout
            // 
            this.centerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerLayout.Location = new System.Drawing.Point(200, 65);
            this.centerLayout.Name = "centerLayout";
            this.centerLayout.Size = new System.Drawing.Size(600, 507);
            this.centerLayout.TabIndex = 2;
            // 
            // mainHome
            // 
            this.mainHome.FillColor = System.Drawing.Color.Transparent;
            this.mainHome.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainHome.ForeColor = System.Drawing.Color.Black;
            this.mainHome.Image = global::Winfom1219.Properties.Resources.icons8home;
            this.mainHome.Location = new System.Drawing.Point(0, 0);
            this.mainHome.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainHome.Name = "mainHome";
            this.mainHome.Padding = new System.Windows.Forms.Padding(0, 8, 0, 20);
            this.mainHome.Radius = 0;
            this.mainHome.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.mainHome.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.mainHome.Size = new System.Drawing.Size(200, 66);
            this.mainHome.Style = Sunny.UI.UIStyle.Custom;
            this.mainHome.Symbol = 361447;
            this.mainHome.TabIndex = 0;
            this.mainHome.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mainHome.Click += new System.EventHandler(this.mainHome_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.ControlBox = false;
            this.Controls.Add(this.centerLayout);
            this.Controls.Add(this.leftLayout);
            this.Controls.Add(this.topLayout);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "사원관리 App 1.0";
            this.topLayout.ResumeLayout(false);
            this.leftLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel mainTitle;
        private System.Windows.Forms.Panel topLayout;
        private System.Windows.Forms.Panel leftLayout;
        private System.Windows.Forms.Panel centerLayout;
        private Sunny.UI.UISymbolButton uiSymbolButton6;
        private Sunny.UI.UISymbolButton uiSymbolButton5;
        private Sunny.UI.UISymbolButton uiSymbolButton4;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolButton mainMin;
        private Sunny.UI.UIHeaderButton mainHelp;
        private Sunny.UI.UIHeaderButton mainSetting;
        private Sunny.UI.UIHeaderButton mainAdmin;
        private Sunny.UI.UIHeaderButton mainInfo;
        private Sunny.UI.UIHeaderButton mainScore;
        private Sunny.UI.UIHeaderButton mainAdd;
        private Sunny.UI.UIHeaderButton mainHome;
    }
}


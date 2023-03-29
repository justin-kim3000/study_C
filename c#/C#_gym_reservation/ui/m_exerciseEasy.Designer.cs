namespace _3_project.ui
{
    partial class m_exerciseEasy
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
            this.picturePanel = new System.Windows.Forms.Panel();
            this.walkButton = new Sunny.UI.UIImageButton();
            this.chestPressButton = new Sunny.UI.UIImageButton();
            this.indoorBikeButton = new Sunny.UI.UIImageButton();
            this.latpulldownButton = new Sunny.UI.UIImageButton();
            this.legcurlButton = new Sunny.UI.UIImageButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.uiTextBox4 = new Sunny.UI.UITextBox();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiTextBox3 = new Sunny.UI.UITextBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.ex_TextBox_Sum = new Sunny.UI.UITextBox();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.walkButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chestPressButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indoorBikeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.latpulldownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legcurlButton)).BeginInit();
            this.SuspendLayout();
            // 
            // picturePanel
            // 
            this.picturePanel.Controls.Add(this.walkButton);
            this.picturePanel.Controls.Add(this.chestPressButton);
            this.picturePanel.Controls.Add(this.indoorBikeButton);
            this.picturePanel.Controls.Add(this.latpulldownButton);
            this.picturePanel.Controls.Add(this.legcurlButton);
            this.picturePanel.Location = new System.Drawing.Point(10, 55);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(580, 565);
            this.picturePanel.TabIndex = 52;
            // 
            // walkButton
            // 
            this.walkButton.BackgroundImage = global::_3_project.Properties.Resources.걷기;
            this.walkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.walkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.walkButton.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.walkButton.ForeColor = System.Drawing.Color.Black;
            this.walkButton.Location = new System.Drawing.Point(0, 75);
            this.walkButton.Name = "walkButton";
            this.walkButton.Size = new System.Drawing.Size(164, 170);
            this.walkButton.Style = Sunny.UI.UIStyle.Custom;
            this.walkButton.TabIndex = 37;
            this.walkButton.TabStop = false;
            this.walkButton.Text = "걷기";
            this.walkButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.walkButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.walkButton.Click += new System.EventHandler(this.walkButton_Click);
            // 
            // chestPressButton
            // 
            this.chestPressButton.BackgroundImage = global::_3_project.Properties.Resources.체스트프레스;
            this.chestPressButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chestPressButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chestPressButton.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.chestPressButton.ForeColor = System.Drawing.Color.Black;
            this.chestPressButton.Location = new System.Drawing.Point(104, 320);
            this.chestPressButton.Name = "chestPressButton";
            this.chestPressButton.Size = new System.Drawing.Size(164, 170);
            this.chestPressButton.Style = Sunny.UI.UIStyle.Custom;
            this.chestPressButton.TabIndex = 43;
            this.chestPressButton.TabStop = false;
            this.chestPressButton.Text = "체스트 프레스";
            this.chestPressButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chestPressButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // indoorBikeButton
            // 
            this.indoorBikeButton.BackgroundImage = global::_3_project.Properties.Resources.실내자전거;
            this.indoorBikeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.indoorBikeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.indoorBikeButton.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.indoorBikeButton.ForeColor = System.Drawing.Color.Black;
            this.indoorBikeButton.Location = new System.Drawing.Point(312, 320);
            this.indoorBikeButton.Name = "indoorBikeButton";
            this.indoorBikeButton.Size = new System.Drawing.Size(164, 170);
            this.indoorBikeButton.Style = Sunny.UI.UIStyle.Custom;
            this.indoorBikeButton.TabIndex = 44;
            this.indoorBikeButton.TabStop = false;
            this.indoorBikeButton.Text = "자전거 타기";
            this.indoorBikeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.indoorBikeButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // latpulldownButton
            // 
            this.latpulldownButton.BackgroundImage = global::_3_project.Properties.Resources.랫풀다운;
            this.latpulldownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.latpulldownButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.latpulldownButton.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.latpulldownButton.ForeColor = System.Drawing.Color.Black;
            this.latpulldownButton.Location = new System.Drawing.Point(416, 75);
            this.latpulldownButton.Name = "latpulldownButton";
            this.latpulldownButton.Size = new System.Drawing.Size(164, 170);
            this.latpulldownButton.Style = Sunny.UI.UIStyle.Custom;
            this.latpulldownButton.TabIndex = 39;
            this.latpulldownButton.TabStop = false;
            this.latpulldownButton.Text = "랫풀다운";
            this.latpulldownButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.latpulldownButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.latpulldownButton.Click += new System.EventHandler(this.latpulldownButton_Click);
            // 
            // legcurlButton
            // 
            this.legcurlButton.BackgroundImage = global::_3_project.Properties.Resources.레그컬;
            this.legcurlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.legcurlButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.legcurlButton.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.legcurlButton.ForeColor = System.Drawing.Color.Black;
            this.legcurlButton.Location = new System.Drawing.Point(208, 75);
            this.legcurlButton.Name = "legcurlButton";
            this.legcurlButton.Size = new System.Drawing.Size(164, 170);
            this.legcurlButton.Style = Sunny.UI.UIStyle.Custom;
            this.legcurlButton.TabIndex = 38;
            this.legcurlButton.TabStop = false;
            this.legcurlButton.Text = "레그컬";
            this.legcurlButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.legcurlButton.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            this.uiMarkLabel1.TabIndex = 65;
            this.uiMarkLabel1.Text = "초급 추천 코스";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox4
            // 
            this.uiTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox4.FillColor = System.Drawing.Color.SlateBlue;
            this.uiTextBox4.FillColor2 = System.Drawing.Color.SlateBlue;
            this.uiTextBox4.FillDisableColor = System.Drawing.Color.SlateBlue;
            this.uiTextBox4.FillReadOnlyColor = System.Drawing.Color.SlateBlue;
            this.uiTextBox4.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiTextBox4.ForeColor = System.Drawing.Color.White;
            this.uiTextBox4.ForeDisableColor = System.Drawing.Color.White;
            this.uiTextBox4.ForeReadOnlyColor = System.Drawing.Color.White;
            this.uiTextBox4.Location = new System.Drawing.Point(451, 675);
            this.uiTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox4.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox4.Name = "uiTextBox4";
            this.uiTextBox4.Radius = 0;
            this.uiTextBox4.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiTextBox4.RectColor = System.Drawing.Color.Black;
            this.uiTextBox4.RectDisableColor = System.Drawing.Color.Black;
            this.uiTextBox4.RectReadOnlyColor = System.Drawing.Color.Black;
            this.uiTextBox4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiTextBox4.ScrollBarBackColor = System.Drawing.Color.DarkGray;
            this.uiTextBox4.ScrollBarColor = System.Drawing.Color.MediumPurple;
            this.uiTextBox4.ShowText = false;
            this.uiTextBox4.Size = new System.Drawing.Size(137, 35);
            this.uiTextBox4.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox4.SymbolColor = System.Drawing.Color.Black;
            this.uiTextBox4.TabIndex = 93;
            this.uiTextBox4.Text = "1100kcal";
            this.uiTextBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBox4.Watermark = "";
            this.uiTextBox4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.FillColor = System.Drawing.Color.SlateBlue;
            this.uiTextBox2.FillColor2 = System.Drawing.Color.SlateBlue;
            this.uiTextBox2.FillDisableColor = System.Drawing.Color.SlateBlue;
            this.uiTextBox2.FillReadOnlyColor = System.Drawing.Color.SlateBlue;
            this.uiTextBox2.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiTextBox2.ForeColor = System.Drawing.Color.White;
            this.uiTextBox2.ForeDisableColor = System.Drawing.Color.White;
            this.uiTextBox2.ForeReadOnlyColor = System.Drawing.Color.White;
            this.uiTextBox2.Location = new System.Drawing.Point(304, 675);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Radius = 0;
            this.uiTextBox2.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiTextBox2.RectColor = System.Drawing.Color.Black;
            this.uiTextBox2.RectDisableColor = System.Drawing.Color.Black;
            this.uiTextBox2.RectReadOnlyColor = System.Drawing.Color.Black;
            this.uiTextBox2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiTextBox2.ScrollBarBackColor = System.Drawing.Color.DarkGray;
            this.uiTextBox2.ScrollBarColor = System.Drawing.Color.MediumPurple;
            this.uiTextBox2.ShowText = false;
            this.uiTextBox2.Size = new System.Drawing.Size(137, 35);
            this.uiTextBox2.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox2.SymbolColor = System.Drawing.Color.Black;
            this.uiTextBox2.TabIndex = 94;
            this.uiTextBox2.Text = "소모 칼로리";
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBox2.Watermark = "";
            this.uiTextBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox3
            // 
            this.uiTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox3.FillColor = System.Drawing.Color.SlateBlue;
            this.uiTextBox3.FillColor2 = System.Drawing.Color.SlateBlue;
            this.uiTextBox3.FillDisableColor = System.Drawing.Color.SlateBlue;
            this.uiTextBox3.FillReadOnlyColor = System.Drawing.Color.SlateBlue;
            this.uiTextBox3.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiTextBox3.ForeColor = System.Drawing.Color.White;
            this.uiTextBox3.ForeDisableColor = System.Drawing.Color.White;
            this.uiTextBox3.ForeReadOnlyColor = System.Drawing.Color.White;
            this.uiTextBox3.Location = new System.Drawing.Point(157, 675);
            this.uiTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox3.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox3.Name = "uiTextBox3";
            this.uiTextBox3.Radius = 0;
            this.uiTextBox3.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiTextBox3.RectColor = System.Drawing.Color.Black;
            this.uiTextBox3.RectDisableColor = System.Drawing.Color.Black;
            this.uiTextBox3.RectReadOnlyColor = System.Drawing.Color.Black;
            this.uiTextBox3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiTextBox3.ScrollBarBackColor = System.Drawing.Color.DarkGray;
            this.uiTextBox3.ScrollBarColor = System.Drawing.Color.MediumPurple;
            this.uiTextBox3.ShowText = false;
            this.uiTextBox3.Size = new System.Drawing.Size(137, 35);
            this.uiTextBox3.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox3.SymbolColor = System.Drawing.Color.Black;
            this.uiTextBox3.TabIndex = 95;
            this.uiTextBox3.Text = "1hour";
            this.uiTextBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBox3.Watermark = "";
            this.uiTextBox3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.SlateBlue;
            this.uiTextBox1.FillColor2 = System.Drawing.Color.SlateBlue;
            this.uiTextBox1.FillDisableColor = System.Drawing.Color.SlateBlue;
            this.uiTextBox1.FillReadOnlyColor = System.Drawing.Color.SlateBlue;
            this.uiTextBox1.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiTextBox1.ForeColor = System.Drawing.Color.White;
            this.uiTextBox1.ForeDisableColor = System.Drawing.Color.White;
            this.uiTextBox1.ForeReadOnlyColor = System.Drawing.Color.White;
            this.uiTextBox1.Location = new System.Drawing.Point(10, 675);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Radius = 0;
            this.uiTextBox1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiTextBox1.RectColor = System.Drawing.Color.Black;
            this.uiTextBox1.RectDisableColor = System.Drawing.Color.Black;
            this.uiTextBox1.RectReadOnlyColor = System.Drawing.Color.Black;
            this.uiTextBox1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiTextBox1.ScrollBarBackColor = System.Drawing.Color.DarkGray;
            this.uiTextBox1.ScrollBarColor = System.Drawing.Color.MediumPurple;
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(137, 35);
            this.uiTextBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox1.SymbolColor = System.Drawing.Color.Black;
            this.uiTextBox1.TabIndex = 92;
            this.uiTextBox1.Text = "운동 시간";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBox1.Watermark = "";
            this.uiTextBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ex_TextBox_Sum
            // 
            this.ex_TextBox_Sum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ex_TextBox_Sum.FillColor = System.Drawing.Color.SlateBlue;
            this.ex_TextBox_Sum.FillColor2 = System.Drawing.Color.SlateBlue;
            this.ex_TextBox_Sum.FillDisableColor = System.Drawing.Color.SlateBlue;
            this.ex_TextBox_Sum.FillReadOnlyColor = System.Drawing.Color.SlateBlue;
            this.ex_TextBox_Sum.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.ex_TextBox_Sum.ForeColor = System.Drawing.Color.White;
            this.ex_TextBox_Sum.ForeDisableColor = System.Drawing.Color.White;
            this.ex_TextBox_Sum.ForeReadOnlyColor = System.Drawing.Color.White;
            this.ex_TextBox_Sum.Location = new System.Drawing.Point(10, 630);
            this.ex_TextBox_Sum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ex_TextBox_Sum.MinimumSize = new System.Drawing.Size(1, 16);
            this.ex_TextBox_Sum.Name = "ex_TextBox_Sum";
            this.ex_TextBox_Sum.Radius = 0;
            this.ex_TextBox_Sum.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.ex_TextBox_Sum.RectColor = System.Drawing.Color.Black;
            this.ex_TextBox_Sum.RectDisableColor = System.Drawing.Color.Black;
            this.ex_TextBox_Sum.RectReadOnlyColor = System.Drawing.Color.Black;
            this.ex_TextBox_Sum.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.ex_TextBox_Sum.ScrollBarBackColor = System.Drawing.Color.DarkGray;
            this.ex_TextBox_Sum.ScrollBarColor = System.Drawing.Color.MediumPurple;
            this.ex_TextBox_Sum.ShowText = false;
            this.ex_TextBox_Sum.Size = new System.Drawing.Size(580, 35);
            this.ex_TextBox_Sum.Style = Sunny.UI.UIStyle.Custom;
            this.ex_TextBox_Sum.SymbolColor = System.Drawing.Color.Black;
            this.ex_TextBox_Sum.TabIndex = 91;
            this.ex_TextBox_Sum.Text = "걷기 + 레그컬 + 랫풀다운 + 체스트 프레스 + 자전거 타기";
            this.ex_TextBox_Sum.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ex_TextBox_Sum.Watermark = "";
            this.ex_TextBox_Sum.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // m_exerciseEasy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiTextBox4);
            this.Controls.Add(this.uiTextBox2);
            this.Controls.Add(this.uiTextBox3);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.ex_TextBox_Sum);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.picturePanel);
            this.Font = new System.Drawing.Font("나눔고딕", 9.75F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "m_exerciseEasy";
            this.Size = new System.Drawing.Size(600, 720);
            this.Load += new System.EventHandler(this.m_exerciseEasy_Load);
            this.picturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.walkButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chestPressButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indoorBikeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.latpulldownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legcurlButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel picturePanel;
        private Sunny.UI.UIImageButton walkButton;
        private Sunny.UI.UIImageButton chestPressButton;
        private Sunny.UI.UIImageButton indoorBikeButton;
        private Sunny.UI.UIImageButton latpulldownButton;
        private Sunny.UI.UIImageButton legcurlButton;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UITextBox uiTextBox4;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UITextBox ex_TextBox_Sum;
    }
}

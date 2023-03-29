namespace _3_project.ui
{
    partial class m_home2
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
            this.headLayout = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.searchIdB = new System.Windows.Forms.Button();
            this.SymbolButton3 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new System.Windows.Forms.Button();
            this.uiSymbolButton4 = new System.Windows.Forms.Button();
            this.uiSymbolButton1 = new System.Windows.Forms.Button();
            this.headLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // headLayout
            // 
            this.headLayout.BackColor = System.Drawing.Color.White;
            this.headLayout.Controls.Add(this.SymbolButton3);
            this.headLayout.Controls.Add(this.button2);
            this.headLayout.Controls.Add(this.uiSymbolButton2);
            this.headLayout.Controls.Add(this.button1);
            this.headLayout.Controls.Add(this.uiSymbolButton4);
            this.headLayout.Controls.Add(this.loginButton);
            this.headLayout.Controls.Add(this.uiSymbolButton1);
            this.headLayout.Controls.Add(this.searchIdB);
            this.headLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.headLayout.ForeColor = System.Drawing.Color.Black;
            this.headLayout.Location = new System.Drawing.Point(0, 0);
            this.headLayout.Name = "headLayout";
            this.headLayout.Size = new System.Drawing.Size(600, 130);
            this.headLayout.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("나눔고딕", 8.25F);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.Location = new System.Drawing.Point(508, 87);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 30);
            this.button2.TabIndex = 15;
            this.button2.TabStop = false;
            this.button2.Text = "로그아웃";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("나눔고딕", 8.25F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(453, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 30);
            this.button1.TabIndex = 14;
            this.button1.TabStop = false;
            this.button1.Text = "담당 회원 |";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(403, 17);
            this.loginButton.Margin = new System.Windows.Forms.Padding(0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(180, 70);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "000 트레이너";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // searchIdB
            // 
            this.searchIdB.BackColor = System.Drawing.Color.White;
            this.searchIdB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchIdB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchIdB.FlatAppearance.BorderSize = 0;
            this.searchIdB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchIdB.Font = new System.Drawing.Font("나눔고딕", 8.25F);
            this.searchIdB.ForeColor = System.Drawing.Color.Black;
            this.searchIdB.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.searchIdB.Location = new System.Drawing.Point(421, 87);
            this.searchIdB.Margin = new System.Windows.Forms.Padding(0);
            this.searchIdB.Name = "searchIdB";
            this.searchIdB.Size = new System.Drawing.Size(70, 30);
            this.searchIdB.TabIndex = 13;
            this.searchIdB.TabStop = false;
            this.searchIdB.Text = "메일 |";
            this.searchIdB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchIdB.UseVisualStyleBackColor = false;
            // 
            // SymbolButton3
            // 
            this.SymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SymbolButton3.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.SymbolButton3.FillColor2 = System.Drawing.Color.DarkSlateBlue;
            this.SymbolButton3.FillDisableColor = System.Drawing.Color.DarkSlateBlue;
            this.SymbolButton3.FillHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.SymbolButton3.FillPressColor = System.Drawing.Color.DarkSlateBlue;
            this.SymbolButton3.FillSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.SymbolButton3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SymbolButton3.ForeDisableColor = System.Drawing.Color.White;
            this.SymbolButton3.Location = new System.Drawing.Point(297, 17);
            this.SymbolButton3.Margin = new System.Windows.Forms.Padding(0);
            this.SymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.SymbolButton3.Name = "SymbolButton3";
            this.SymbolButton3.Radius = 0;
            this.SymbolButton3.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.SymbolButton3.RectColor = System.Drawing.Color.White;
            this.SymbolButton3.RectDisableColor = System.Drawing.Color.White;
            this.SymbolButton3.RectHoverColor = System.Drawing.Color.White;
            this.SymbolButton3.RectPressColor = System.Drawing.Color.White;
            this.SymbolButton3.RectSelectedColor = System.Drawing.Color.White;
            this.SymbolButton3.Size = new System.Drawing.Size(80, 70);
            this.SymbolButton3.Style = Sunny.UI.UIStyle.Custom;
            this.SymbolButton3.Symbol = 61516;
            this.SymbolButton3.SymbolDisableColor = System.Drawing.Color.White;
            this.SymbolButton3.SymbolHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.SymbolButton3.SymbolPressColor = System.Drawing.Color.DarkSlateBlue;
            this.SymbolButton3.SymbolSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.SymbolButton3.TabIndex = 124;
            this.SymbolButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SymbolButton3.TipsColor = System.Drawing.Color.White;
            this.SymbolButton3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.uiSymbolButton2.FlatAppearance.BorderSize = 0;
            this.uiSymbolButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiSymbolButton2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold);
            this.uiSymbolButton2.ForeColor = System.Drawing.Color.White;
            this.uiSymbolButton2.Location = new System.Drawing.Point(206, 17);
            this.uiSymbolButton2.Margin = new System.Windows.Forms.Padding(0);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Size = new System.Drawing.Size(80, 70);
            this.uiSymbolButton2.TabIndex = 123;
            this.uiSymbolButton2.Text = "지구뿌셔";
            this.uiSymbolButton2.UseVisualStyleBackColor = false;
            // 
            // uiSymbolButton4
            // 
            this.uiSymbolButton4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.uiSymbolButton4.FlatAppearance.BorderSize = 0;
            this.uiSymbolButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiSymbolButton4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold);
            this.uiSymbolButton4.ForeColor = System.Drawing.Color.White;
            this.uiSymbolButton4.Location = new System.Drawing.Point(112, 17);
            this.uiSymbolButton4.Margin = new System.Windows.Forms.Padding(0);
            this.uiSymbolButton4.Name = "uiSymbolButton4";
            this.uiSymbolButton4.Size = new System.Drawing.Size(80, 70);
            this.uiSymbolButton4.TabIndex = 122;
            this.uiSymbolButton4.Text = "그뉵맛";
            this.uiSymbolButton4.UseVisualStyleBackColor = false;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.uiSymbolButton1.FlatAppearance.BorderSize = 0;
            this.uiSymbolButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiSymbolButton1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold);
            this.uiSymbolButton1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolButton1.Location = new System.Drawing.Point(20, 17);
            this.uiSymbolButton1.Margin = new System.Windows.Forms.Padding(0);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(80, 70);
            this.uiSymbolButton1.TabIndex = 121;
            this.uiSymbolButton1.Text = "마쵸맛";
            this.uiSymbolButton1.UseVisualStyleBackColor = false;
            // 
            // m_home2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.headLayout);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "m_home2";
            this.Size = new System.Drawing.Size(600, 720);
            this.headLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel headLayout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button searchIdB;
        private Sunny.UI.UISymbolButton SymbolButton3;
        private System.Windows.Forms.Button uiSymbolButton2;
        private System.Windows.Forms.Button uiSymbolButton4;
        private System.Windows.Forms.Button uiSymbolButton1;
    }
}

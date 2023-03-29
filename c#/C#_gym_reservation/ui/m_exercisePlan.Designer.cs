namespace _3_project.ui
{
    partial class m_exercisePlan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.Ex_GView = new Sunny.UI.UIDataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ex_TextBox_Sum = new Sunny.UI.UITextBox();
            this.Ex_diff_button = new Sunny.UI.UISymbolButton();
            this.Ex_mid_button = new Sunny.UI.UISymbolButton();
            this.Ex_easy_button = new Sunny.UI.UISymbolButton();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiButton5 = new Sunny.UI.UIButton();
            this.uiButton4 = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.Ex_GView)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.DarkGray;
            this.uiSymbolButton1.FillColor2 = System.Drawing.Color.DarkGray;
            this.uiSymbolButton1.FillHoverColor = System.Drawing.Color.Gray;
            this.uiSymbolButton1.FillPressColor = System.Drawing.Color.Gray;
            this.uiSymbolButton1.FillSelectedColor = System.Drawing.Color.Gray;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(555, 100);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Radius = 0;
            this.uiSymbolButton1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiSymbolButton1.RectColor = System.Drawing.Color.White;
            this.uiSymbolButton1.RectHoverColor = System.Drawing.Color.White;
            this.uiSymbolButton1.RectPressColor = System.Drawing.Color.White;
            this.uiSymbolButton1.RectSelectedColor = System.Drawing.Color.White;
            this.uiSymbolButton1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiSymbolButton1.Size = new System.Drawing.Size(35, 35);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.Symbol = 61442;
            this.uiSymbolButton1.TabIndex = 23;
            this.uiSymbolButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // Ex_GView
            // 
            this.Ex_GView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Ex_GView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Ex_GView.BackgroundColor = System.Drawing.Color.White;
            this.Ex_GView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Ex_GView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Ex_GView.ColumnHeadersHeight = 32;
            this.Ex_GView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Ex_GView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Ex_GView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Ex_GView.EnableHeadersVisualStyles = false;
            this.Ex_GView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.Ex_GView.GridColor = System.Drawing.Color.Gray;
            this.Ex_GView.Location = new System.Drawing.Point(10, 190);
            this.Ex_GView.Margin = new System.Windows.Forms.Padding(0);
            this.Ex_GView.Name = "Ex_GView";
            this.Ex_GView.ReadOnly = true;
            this.Ex_GView.RectColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Ex_GView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.Ex_GView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Ex_GView.RowTemplate.Height = 23;
            this.Ex_GView.ScrollBarBackColor = System.Drawing.Color.DarkGray;
            this.Ex_GView.ScrollBarColor = System.Drawing.Color.MediumSlateBlue;
            this.Ex_GView.ScrollBarRectColor = System.Drawing.Color.White;
            this.Ex_GView.SelectedIndex = -1;
            this.Ex_GView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Ex_GView.Size = new System.Drawing.Size(580, 475);
            this.Ex_GView.StripeOddColor = System.Drawing.Color.White;
            this.Ex_GView.Style = Sunny.UI.UIStyle.Custom;
            this.Ex_GView.TabIndex = 25;
            this.Ex_GView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Ex_GView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ex_GView_CellClick);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.FillWeight = 60.91373F;
            this.Column6.HeaderText = "순서";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 107.8173F;
            this.Column2.HeaderText = "운동분류";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 107.8173F;
            this.Column1.HeaderText = "운동종류";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 107.8173F;
            this.Column3.HeaderText = "kcal/15min";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 107.8173F;
            this.Column4.HeaderText = "kcal/30min";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 107.8173F;
            this.Column5.HeaderText = "kcal/60min";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ex_TextBox_Sum
            // 
            this.ex_TextBox_Sum.BackColor = System.Drawing.Color.White;
            this.ex_TextBox_Sum.ButtonFillColor = System.Drawing.Color.SlateBlue;
            this.ex_TextBox_Sum.ButtonFillHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.ex_TextBox_Sum.ButtonFillPressColor = System.Drawing.Color.DarkSlateBlue;
            this.ex_TextBox_Sum.ButtonRectColor = System.Drawing.Color.White;
            this.ex_TextBox_Sum.ButtonRectHoverColor = System.Drawing.Color.White;
            this.ex_TextBox_Sum.ButtonRectPressColor = System.Drawing.Color.White;
            this.ex_TextBox_Sum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ex_TextBox_Sum.FillColor = System.Drawing.Color.SlateBlue;
            this.ex_TextBox_Sum.FillColor2 = System.Drawing.Color.SlateBlue;
            this.ex_TextBox_Sum.FillReadOnlyColor = System.Drawing.Color.SlateBlue;
            this.ex_TextBox_Sum.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_TextBox_Sum.ForeColor = System.Drawing.Color.White;
            this.ex_TextBox_Sum.ForeReadOnlyColor = System.Drawing.Color.White;
            this.ex_TextBox_Sum.Location = new System.Drawing.Point(10, 675);
            this.ex_TextBox_Sum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ex_TextBox_Sum.MinimumSize = new System.Drawing.Size(1, 16);
            this.ex_TextBox_Sum.Name = "ex_TextBox_Sum";
            this.ex_TextBox_Sum.Radius = 0;
            this.ex_TextBox_Sum.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.ex_TextBox_Sum.RectColor = System.Drawing.Color.White;
            this.ex_TextBox_Sum.RectReadOnlyColor = System.Drawing.Color.White;
            this.ex_TextBox_Sum.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.ex_TextBox_Sum.ScrollBarColor = System.Drawing.Color.White;
            this.ex_TextBox_Sum.ShowText = false;
            this.ex_TextBox_Sum.Size = new System.Drawing.Size(580, 35);
            this.ex_TextBox_Sum.Style = Sunny.UI.UIStyle.Custom;
            this.ex_TextBox_Sum.StyleCustomMode = true;
            this.ex_TextBox_Sum.Symbol = 80;
            this.ex_TextBox_Sum.SymbolColor = System.Drawing.Color.White;
            this.ex_TextBox_Sum.SymbolOffset = new System.Drawing.Point(10, 0);
            this.ex_TextBox_Sum.SymbolSize = 20;
            this.ex_TextBox_Sum.TabIndex = 30;
            this.ex_TextBox_Sum.Text = "운동 합";
            this.ex_TextBox_Sum.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ex_TextBox_Sum.Watermark = "";
            this.ex_TextBox_Sum.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Ex_diff_button
            // 
            this.Ex_diff_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ex_diff_button.FillColor = System.Drawing.Color.SlateBlue;
            this.Ex_diff_button.FillColor2 = System.Drawing.Color.SlateBlue;
            this.Ex_diff_button.FillDisableColor = System.Drawing.Color.SlateBlue;
            this.Ex_diff_button.FillHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_diff_button.FillPressColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_diff_button.FillSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_diff_button.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ex_diff_button.ForeDisableColor = System.Drawing.Color.White;
            this.Ex_diff_button.Location = new System.Drawing.Point(404, 55);
            this.Ex_diff_button.Margin = new System.Windows.Forms.Padding(0);
            this.Ex_diff_button.MinimumSize = new System.Drawing.Size(1, 1);
            this.Ex_diff_button.Name = "Ex_diff_button";
            this.Ex_diff_button.Radius = 0;
            this.Ex_diff_button.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.Ex_diff_button.RectColor = System.Drawing.Color.White;
            this.Ex_diff_button.RectDisableColor = System.Drawing.Color.White;
            this.Ex_diff_button.RectHoverColor = System.Drawing.Color.White;
            this.Ex_diff_button.RectPressColor = System.Drawing.Color.White;
            this.Ex_diff_button.RectSelectedColor = System.Drawing.Color.White;
            this.Ex_diff_button.Size = new System.Drawing.Size(186, 35);
            this.Ex_diff_button.Style = Sunny.UI.UIStyle.Custom;
            this.Ex_diff_button.Symbol = 61703;
            this.Ex_diff_button.SymbolDisableColor = System.Drawing.Color.White;
            this.Ex_diff_button.SymbolHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_diff_button.SymbolOffset = new System.Drawing.Point(-5, 0);
            this.Ex_diff_button.SymbolPressColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_diff_button.SymbolSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_diff_button.SymbolSize = 20;
            this.Ex_diff_button.TabIndex = 33;
            this.Ex_diff_button.Text = "고급 추천 코스";
            this.Ex_diff_button.TipsColor = System.Drawing.Color.White;
            this.Ex_diff_button.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Ex_diff_button.Click += new System.EventHandler(this.Ex_diff_button_Click);
            // 
            // Ex_mid_button
            // 
            this.Ex_mid_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ex_mid_button.FillColor = System.Drawing.Color.SlateBlue;
            this.Ex_mid_button.FillColor2 = System.Drawing.Color.SlateBlue;
            this.Ex_mid_button.FillDisableColor = System.Drawing.Color.SlateBlue;
            this.Ex_mid_button.FillHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_mid_button.FillPressColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_mid_button.FillSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_mid_button.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ex_mid_button.ForeDisableColor = System.Drawing.Color.White;
            this.Ex_mid_button.Location = new System.Drawing.Point(207, 55);
            this.Ex_mid_button.Margin = new System.Windows.Forms.Padding(0);
            this.Ex_mid_button.MinimumSize = new System.Drawing.Size(1, 1);
            this.Ex_mid_button.Name = "Ex_mid_button";
            this.Ex_mid_button.Radius = 0;
            this.Ex_mid_button.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.Ex_mid_button.RectColor = System.Drawing.Color.White;
            this.Ex_mid_button.RectDisableColor = System.Drawing.Color.White;
            this.Ex_mid_button.RectHoverColor = System.Drawing.Color.White;
            this.Ex_mid_button.RectPressColor = System.Drawing.Color.White;
            this.Ex_mid_button.RectSelectedColor = System.Drawing.Color.White;
            this.Ex_mid_button.Size = new System.Drawing.Size(186, 35);
            this.Ex_mid_button.Style = Sunny.UI.UIStyle.Custom;
            this.Ex_mid_button.Symbol = 61703;
            this.Ex_mid_button.SymbolDisableColor = System.Drawing.Color.White;
            this.Ex_mid_button.SymbolHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_mid_button.SymbolOffset = new System.Drawing.Point(-5, 0);
            this.Ex_mid_button.SymbolPressColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_mid_button.SymbolSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_mid_button.SymbolSize = 20;
            this.Ex_mid_button.TabIndex = 32;
            this.Ex_mid_button.Text = "중급 추천 코스";
            this.Ex_mid_button.TipsColor = System.Drawing.Color.White;
            this.Ex_mid_button.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Ex_mid_button.Click += new System.EventHandler(this.Ex_mid_button_Click);
            // 
            // Ex_easy_button
            // 
            this.Ex_easy_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ex_easy_button.FillColor = System.Drawing.Color.SlateBlue;
            this.Ex_easy_button.FillColor2 = System.Drawing.Color.SlateBlue;
            this.Ex_easy_button.FillDisableColor = System.Drawing.Color.SlateBlue;
            this.Ex_easy_button.FillHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_easy_button.FillPressColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_easy_button.FillSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_easy_button.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ex_easy_button.ForeDisableColor = System.Drawing.Color.White;
            this.Ex_easy_button.Location = new System.Drawing.Point(10, 55);
            this.Ex_easy_button.Margin = new System.Windows.Forms.Padding(0);
            this.Ex_easy_button.MinimumSize = new System.Drawing.Size(1, 1);
            this.Ex_easy_button.Name = "Ex_easy_button";
            this.Ex_easy_button.Radius = 0;
            this.Ex_easy_button.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.Ex_easy_button.RectColor = System.Drawing.Color.White;
            this.Ex_easy_button.RectDisableColor = System.Drawing.Color.White;
            this.Ex_easy_button.RectHoverColor = System.Drawing.Color.White;
            this.Ex_easy_button.RectPressColor = System.Drawing.Color.White;
            this.Ex_easy_button.RectSelectedColor = System.Drawing.Color.White;
            this.Ex_easy_button.Size = new System.Drawing.Size(186, 35);
            this.Ex_easy_button.Style = Sunny.UI.UIStyle.Custom;
            this.Ex_easy_button.Symbol = 61703;
            this.Ex_easy_button.SymbolDisableColor = System.Drawing.Color.White;
            this.Ex_easy_button.SymbolHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_easy_button.SymbolOffset = new System.Drawing.Point(-5, 0);
            this.Ex_easy_button.SymbolPressColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_easy_button.SymbolSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.Ex_easy_button.SymbolSize = 20;
            this.Ex_easy_button.TabIndex = 31;
            this.Ex_easy_button.Text = "초보 추천 코스";
            this.Ex_easy_button.TipsColor = System.Drawing.Color.White;
            this.Ex_easy_button.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Ex_easy_button.Click += new System.EventHandler(this.Ex_easy_button_Click);
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
            this.uiMarkLabel1.TabIndex = 34;
            this.uiMarkLabel1.Text = "운동 루틴";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.BackColor = System.Drawing.Color.White;
            this.uiTextBox1.ButtonFillColor = System.Drawing.Color.DarkGray;
            this.uiTextBox1.ButtonFillHoverColor = System.Drawing.Color.Gray;
            this.uiTextBox1.ButtonFillPressColor = System.Drawing.Color.Gray;
            this.uiTextBox1.ButtonRectColor = System.Drawing.Color.White;
            this.uiTextBox1.ButtonRectHoverColor = System.Drawing.Color.White;
            this.uiTextBox1.ButtonRectPressColor = System.Drawing.Color.White;
            this.uiTextBox1.ButtonSymbol = 61452;
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.DarkGray;
            this.uiTextBox1.FillColor2 = System.Drawing.Color.DarkGray;
            this.uiTextBox1.FillDisableColor = System.Drawing.Color.DarkGray;
            this.uiTextBox1.FillReadOnlyColor = System.Drawing.Color.DarkGray;
            this.uiTextBox1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiTextBox1.ForeColor = System.Drawing.Color.White;
            this.uiTextBox1.ForeDisableColor = System.Drawing.Color.White;
            this.uiTextBox1.ForeReadOnlyColor = System.Drawing.Color.White;
            this.uiTextBox1.Location = new System.Drawing.Point(10, 100);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Radius = 0;
            this.uiTextBox1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiTextBox1.RectColor = System.Drawing.Color.White;
            this.uiTextBox1.RectDisableColor = System.Drawing.Color.White;
            this.uiTextBox1.RectReadOnlyColor = System.Drawing.Color.White;
            this.uiTextBox1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiTextBox1.ScrollBarColor = System.Drawing.Color.White;
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(535, 35);
            this.uiTextBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTextBox1.TabIndex = 35;
            this.uiTextBox1.Text = "찾으시는 운동을 검색하세요.";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            this.uiTextBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiTextBox1.MouseClick += new System.EventHandler(this.uiTextBox1_MouseClick);
            this.uiTextBox1.TextChanged += new System.EventHandler(this.uiTextBox1_TextChanged);
            this.uiTextBox1.DoEnter += new System.EventHandler(this.uiTextBox1_DoEnter);
            // 
            // uiButton5
            // 
            this.uiButton5.BackColor = System.Drawing.Color.White;
            this.uiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton5.FillColor = System.Drawing.Color.SlateBlue;
            this.uiButton5.FillColor2 = System.Drawing.Color.SlateBlue;
            this.uiButton5.FillDisableColor = System.Drawing.Color.SlateBlue;
            this.uiButton5.FillHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.uiButton5.FillPressColor = System.Drawing.Color.DarkSlateBlue;
            this.uiButton5.FillSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.uiButton5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiButton5.ForeDisableColor = System.Drawing.Color.White;
            this.uiButton5.Location = new System.Drawing.Point(482, 145);
            this.uiButton5.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton5.Name = "uiButton5";
            this.uiButton5.Radius = 0;
            this.uiButton5.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiButton5.RectColor = System.Drawing.Color.White;
            this.uiButton5.RectDisableColor = System.Drawing.Color.White;
            this.uiButton5.RectHoverColor = System.Drawing.Color.White;
            this.uiButton5.RectPressColor = System.Drawing.Color.White;
            this.uiButton5.RectSelectedColor = System.Drawing.Color.White;
            this.uiButton5.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiButton5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiButton5.Size = new System.Drawing.Size(108, 35);
            this.uiButton5.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton5.TabIndex = 40;
            this.uiButton5.Text = "프리웨이트";
            this.uiButton5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton5.Click += new System.EventHandler(this.uiButton5_Click);
            // 
            // uiButton4
            // 
            this.uiButton4.BackColor = System.Drawing.Color.White;
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.FillColor = System.Drawing.Color.SlateBlue;
            this.uiButton4.FillColor2 = System.Drawing.Color.SlateBlue;
            this.uiButton4.FillDisableColor = System.Drawing.Color.SlateBlue;
            this.uiButton4.FillHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.uiButton4.FillPressColor = System.Drawing.Color.DarkSlateBlue;
            this.uiButton4.FillSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.uiButton4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiButton4.ForeDisableColor = System.Drawing.Color.White;
            this.uiButton4.Location = new System.Drawing.Point(364, 145);
            this.uiButton4.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.Radius = 0;
            this.uiButton4.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiButton4.RectColor = System.Drawing.Color.White;
            this.uiButton4.RectDisableColor = System.Drawing.Color.White;
            this.uiButton4.RectHoverColor = System.Drawing.Color.White;
            this.uiButton4.RectPressColor = System.Drawing.Color.White;
            this.uiButton4.RectSelectedColor = System.Drawing.Color.White;
            this.uiButton4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiButton4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiButton4.Size = new System.Drawing.Size(108, 35);
            this.uiButton4.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton4.TabIndex = 39;
            this.uiButton4.Text = "머신 운동";
            this.uiButton4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton4.Click += new System.EventHandler(this.uiButton4_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.BackColor = System.Drawing.Color.White;
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.FillColor = System.Drawing.Color.SlateBlue;
            this.uiButton3.FillColor2 = System.Drawing.Color.SlateBlue;
            this.uiButton3.FillDisableColor = System.Drawing.Color.SlateBlue;
            this.uiButton3.FillHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.uiButton3.FillPressColor = System.Drawing.Color.DarkSlateBlue;
            this.uiButton3.FillSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.uiButton3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiButton3.ForeDisableColor = System.Drawing.Color.White;
            this.uiButton3.Location = new System.Drawing.Point(246, 145);
            this.uiButton3.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Radius = 0;
            this.uiButton3.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiButton3.RectColor = System.Drawing.Color.White;
            this.uiButton3.RectDisableColor = System.Drawing.Color.White;
            this.uiButton3.RectHoverColor = System.Drawing.Color.White;
            this.uiButton3.RectPressColor = System.Drawing.Color.White;
            this.uiButton3.RectSelectedColor = System.Drawing.Color.White;
            this.uiButton3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiButton3.Size = new System.Drawing.Size(108, 35);
            this.uiButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton3.TabIndex = 38;
            this.uiButton3.Text = "크로스핏";
            this.uiButton3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.BackColor = System.Drawing.Color.White;
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.FillColor = System.Drawing.Color.SlateBlue;
            this.uiButton2.FillColor2 = System.Drawing.Color.SlateBlue;
            this.uiButton2.FillDisableColor = System.Drawing.Color.SlateBlue;
            this.uiButton2.FillHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.uiButton2.FillPressColor = System.Drawing.Color.DarkSlateBlue;
            this.uiButton2.FillSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.uiButton2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiButton2.ForeDisableColor = System.Drawing.Color.White;
            this.uiButton2.Location = new System.Drawing.Point(128, 145);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Radius = 0;
            this.uiButton2.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiButton2.RectColor = System.Drawing.Color.White;
            this.uiButton2.RectDisableColor = System.Drawing.Color.White;
            this.uiButton2.RectHoverColor = System.Drawing.Color.White;
            this.uiButton2.RectPressColor = System.Drawing.Color.White;
            this.uiButton2.RectSelectedColor = System.Drawing.Color.White;
            this.uiButton2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiButton2.Size = new System.Drawing.Size(108, 35);
            this.uiButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton2.TabIndex = 37;
            this.uiButton2.Text = "유산소";
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.Color.White;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.SlateBlue;
            this.uiButton1.FillColor2 = System.Drawing.Color.SlateBlue;
            this.uiButton1.FillDisableColor = System.Drawing.Color.SlateBlue;
            this.uiButton1.FillHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.uiButton1.FillPressColor = System.Drawing.Color.DarkSlateBlue;
            this.uiButton1.FillSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.uiButton1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiButton1.ForeDisableColor = System.Drawing.Color.White;
            this.uiButton1.Location = new System.Drawing.Point(10, 145);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Radius = 0;
            this.uiButton1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiButton1.RectColor = System.Drawing.Color.White;
            this.uiButton1.RectDisableColor = System.Drawing.Color.White;
            this.uiButton1.RectHoverColor = System.Drawing.Color.White;
            this.uiButton1.RectPressColor = System.Drawing.Color.White;
            this.uiButton1.RectSelectedColor = System.Drawing.Color.White;
            this.uiButton1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uiButton1.Size = new System.Drawing.Size(108, 35);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 36;
            this.uiButton1.Text = "전체";
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // m_exercisePlan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiButton5);
            this.Controls.Add(this.uiButton4);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.Ex_diff_button);
            this.Controls.Add(this.Ex_mid_button);
            this.Controls.Add(this.Ex_easy_button);
            this.Controls.Add(this.ex_TextBox_Sum);
            this.Controls.Add(this.Ex_GView);
            this.Controls.Add(this.uiSymbolButton1);
            this.Name = "m_exercisePlan";
            this.Size = new System.Drawing.Size(600, 720);
            this.Load += new System.EventHandler(this.m_exercisePlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ex_GView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UIDataGridView Ex_GView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Sunny.UI.UITextBox ex_TextBox_Sum;
        private Sunny.UI.UISymbolButton Ex_diff_button;
        private Sunny.UI.UISymbolButton Ex_mid_button;
        private Sunny.UI.UISymbolButton Ex_easy_button;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton uiButton5;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
    }
}

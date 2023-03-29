namespace _3_project.ui
{
    partial class m_memberInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(m_memberInfo));
            this.m_del = new Sunny.UI.UIButton();
            this.m_searchbox = new Sunny.UI.UITextBox();
            this.m_upd = new Sunny.UI.UIButton();
            this.m_search = new Sunny.UI.UIButton();
            this.m_birth_day = new Sunny.UI.UIComboBox();
            this.m_birth_month = new Sunny.UI.UIComboBox();
            this.m_birth_year = new Sunny.UI.UIComboBox();
            this.m_gen_female = new Sunny.UI.UIRadioButton();
            this.m_gen_male = new Sunny.UI.UIRadioButton();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.m_tel = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.m_tname = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.m_bmi = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.m_bfp = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.m_tall = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.m_weight = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.m_name = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_mno = new Sunny.UI.UITextBox();
            this.listMemberInfo = new System.Windows.Forms.ListView();
            this.회원번호 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.생년월일 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.키 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.몸무게 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.체지방률 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.비만도 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.성별 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.연락처 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.코치이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_del
            // 
            this.m_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_del.FillColor = System.Drawing.Color.SlateBlue;
            this.m_del.FillColor2 = System.Drawing.Color.SlateBlue;
            this.m_del.FillHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.m_del.FillPressColor = System.Drawing.Color.DarkSlateBlue;
            this.m_del.FillSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.m_del.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_del.Location = new System.Drawing.Point(550, 302);
            this.m_del.MinimumSize = new System.Drawing.Size(1, 1);
            this.m_del.Name = "m_del";
            this.m_del.Radius = 0;
            this.m_del.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_del.RectColor = System.Drawing.Color.DarkSlateBlue;
            this.m_del.RectDisableColor = System.Drawing.Color.DarkSlateBlue;
            this.m_del.RectHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.m_del.RectPressColor = System.Drawing.Color.DarkSlateBlue;
            this.m_del.RectSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.m_del.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.m_del.Size = new System.Drawing.Size(40, 30);
            this.m_del.Style = Sunny.UI.UIStyle.Custom;
            this.m_del.TabIndex = 60;
            this.m_del.Text = "삭제";
            this.m_del.TipsFont = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_del.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.m_del.Click += new System.EventHandler(this.m_del_Click);
            // 
            // m_searchbox
            // 
            this.m_searchbox.CanEmpty = true;
            this.m_searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_searchbox.FillColor2 = System.Drawing.Color.White;
            this.m_searchbox.FillDisableColor = System.Drawing.Color.White;
            this.m_searchbox.FillReadOnlyColor = System.Drawing.Color.White;
            this.m_searchbox.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_searchbox.ForeColor = System.Drawing.Color.Black;
            this.m_searchbox.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.m_searchbox.Location = new System.Drawing.Point(10, 302);
            this.m_searchbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_searchbox.MinimumSize = new System.Drawing.Size(1, 16);
            this.m_searchbox.Name = "m_searchbox";
            this.m_searchbox.Radius = 0;
            this.m_searchbox.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_searchbox.RectColor = System.Drawing.Color.Black;
            this.m_searchbox.RectReadOnlyColor = System.Drawing.Color.White;
            this.m_searchbox.ScrollBarColor = System.Drawing.Color.MediumSlateBlue;
            this.m_searchbox.ShowText = false;
            this.m_searchbox.Size = new System.Drawing.Size(420, 30);
            this.m_searchbox.Style = Sunny.UI.UIStyle.Custom;
            this.m_searchbox.TabIndex = 36;
            this.m_searchbox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_searchbox.Watermark = "";
            this.m_searchbox.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // m_upd
            // 
            this.m_upd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_upd.FillColor = System.Drawing.Color.SlateBlue;
            this.m_upd.FillColor2 = System.Drawing.Color.SlateBlue;
            this.m_upd.FillHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.m_upd.FillPressColor = System.Drawing.Color.DarkSlateBlue;
            this.m_upd.FillSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.m_upd.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_upd.Location = new System.Drawing.Point(495, 302);
            this.m_upd.MinimumSize = new System.Drawing.Size(1, 1);
            this.m_upd.Name = "m_upd";
            this.m_upd.Radius = 0;
            this.m_upd.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_upd.RectColor = System.Drawing.Color.DarkSlateBlue;
            this.m_upd.RectDisableColor = System.Drawing.Color.DarkSlateBlue;
            this.m_upd.RectHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.m_upd.RectPressColor = System.Drawing.Color.DarkSlateBlue;
            this.m_upd.RectSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.m_upd.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.m_upd.Size = new System.Drawing.Size(40, 30);
            this.m_upd.Style = Sunny.UI.UIStyle.Custom;
            this.m_upd.TabIndex = 59;
            this.m_upd.Text = "수정";
            this.m_upd.TipsFont = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_upd.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.m_upd.Click += new System.EventHandler(this.m_upd_Click);
            // 
            // m_search
            // 
            this.m_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_search.FillColor = System.Drawing.Color.SlateBlue;
            this.m_search.FillColor2 = System.Drawing.Color.SlateBlue;
            this.m_search.FillHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.m_search.FillPressColor = System.Drawing.Color.DarkSlateBlue;
            this.m_search.FillSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.m_search.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_search.Location = new System.Drawing.Point(440, 302);
            this.m_search.MinimumSize = new System.Drawing.Size(1, 1);
            this.m_search.Name = "m_search";
            this.m_search.Radius = 0;
            this.m_search.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_search.RectColor = System.Drawing.Color.DarkSlateBlue;
            this.m_search.RectDisableColor = System.Drawing.Color.DarkSlateBlue;
            this.m_search.RectHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.m_search.RectPressColor = System.Drawing.Color.DarkSlateBlue;
            this.m_search.RectSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.m_search.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.m_search.Size = new System.Drawing.Size(40, 30);
            this.m_search.Style = Sunny.UI.UIStyle.Custom;
            this.m_search.TabIndex = 58;
            this.m_search.Text = "검색";
            this.m_search.TipsFont = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_search.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.m_search.Click += new System.EventHandler(this.m_search_Click);
            // 
            // m_birth_day
            // 
            this.m_birth_day.BackColor = System.Drawing.Color.White;
            this.m_birth_day.DataSource = null;
            this.m_birth_day.FillColor = System.Drawing.Color.White;
            this.m_birth_day.FillColor2 = System.Drawing.Color.White;
            this.m_birth_day.FillDisableColor = System.Drawing.Color.White;
            this.m_birth_day.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_birth_day.ForeColor = System.Drawing.Color.Black;
            this.m_birth_day.ItemForeColor = System.Drawing.Color.Black;
            this.m_birth_day.ItemHoverColor = System.Drawing.Color.SlateBlue;
            this.m_birth_day.ItemRectColor = System.Drawing.Color.White;
            this.m_birth_day.ItemSelectBackColor = System.Drawing.Color.White;
            this.m_birth_day.ItemSelectForeColor = System.Drawing.Color.SlateBlue;
            this.m_birth_day.Location = new System.Drawing.Point(242, 161);
            this.m_birth_day.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_birth_day.MinimumSize = new System.Drawing.Size(63, 0);
            this.m_birth_day.Name = "m_birth_day";
            this.m_birth_day.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.m_birth_day.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_birth_day.RectColor = System.Drawing.Color.Black;
            this.m_birth_day.Size = new System.Drawing.Size(63, 30);
            this.m_birth_day.Style = Sunny.UI.UIStyle.Custom;
            this.m_birth_day.TabIndex = 37;
            this.m_birth_day.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_birth_day.Watermark = "";
            this.m_birth_day.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // m_birth_month
            // 
            this.m_birth_month.BackColor = System.Drawing.Color.White;
            this.m_birth_month.DataSource = null;
            this.m_birth_month.FillColor = System.Drawing.Color.White;
            this.m_birth_month.FillColor2 = System.Drawing.Color.White;
            this.m_birth_month.FillDisableColor = System.Drawing.Color.White;
            this.m_birth_month.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_birth_month.ForeColor = System.Drawing.Color.Black;
            this.m_birth_month.ItemForeColor = System.Drawing.Color.Black;
            this.m_birth_month.ItemHoverColor = System.Drawing.Color.SlateBlue;
            this.m_birth_month.ItemRectColor = System.Drawing.Color.White;
            this.m_birth_month.Items.AddRange(new object[] {
            "01월",
            "02월",
            "03월",
            "04월",
            "05월",
            "06월",
            "07월",
            "08월",
            "09월",
            "10월",
            "11월",
            "12월"});
            this.m_birth_month.ItemSelectBackColor = System.Drawing.Color.White;
            this.m_birth_month.ItemSelectForeColor = System.Drawing.Color.SlateBlue;
            this.m_birth_month.Location = new System.Drawing.Point(171, 161);
            this.m_birth_month.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_birth_month.MinimumSize = new System.Drawing.Size(63, 0);
            this.m_birth_month.Name = "m_birth_month";
            this.m_birth_month.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.m_birth_month.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_birth_month.RectColor = System.Drawing.Color.Black;
            this.m_birth_month.Size = new System.Drawing.Size(63, 30);
            this.m_birth_month.Style = Sunny.UI.UIStyle.Custom;
            this.m_birth_month.TabIndex = 35;
            this.m_birth_month.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_birth_month.Watermark = "";
            this.m_birth_month.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // m_birth_year
            // 
            this.m_birth_year.BackColor = System.Drawing.Color.White;
            this.m_birth_year.DataSource = null;
            this.m_birth_year.FillColor = System.Drawing.Color.White;
            this.m_birth_year.FillColor2 = System.Drawing.Color.White;
            this.m_birth_year.FillDisableColor = System.Drawing.Color.White;
            this.m_birth_year.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_birth_year.ForeColor = System.Drawing.Color.Black;
            this.m_birth_year.ItemForeColor = System.Drawing.Color.Black;
            this.m_birth_year.ItemHoverColor = System.Drawing.Color.SlateBlue;
            this.m_birth_year.ItemRectColor = System.Drawing.Color.White;
            this.m_birth_year.ItemSelectBackColor = System.Drawing.Color.White;
            this.m_birth_year.ItemSelectForeColor = System.Drawing.Color.SlateBlue;
            this.m_birth_year.Location = new System.Drawing.Point(100, 161);
            this.m_birth_year.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_birth_year.MinimumSize = new System.Drawing.Size(63, 0);
            this.m_birth_year.Name = "m_birth_year";
            this.m_birth_year.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.m_birth_year.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_birth_year.RectColor = System.Drawing.Color.Black;
            this.m_birth_year.Size = new System.Drawing.Size(63, 30);
            this.m_birth_year.Style = Sunny.UI.UIStyle.Custom;
            this.m_birth_year.TabIndex = 32;
            this.m_birth_year.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_birth_year.Watermark = "";
            this.m_birth_year.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // m_gen_female
            // 
            this.m_gen_female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_gen_female.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_gen_female.ForeColor = System.Drawing.Color.Black;
            this.m_gen_female.Location = new System.Drawing.Point(520, 161);
            this.m_gen_female.MinimumSize = new System.Drawing.Size(1, 1);
            this.m_gen_female.Name = "m_gen_female";
            this.m_gen_female.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.m_gen_female.RadioButtonColor = System.Drawing.Color.Black;
            this.m_gen_female.Radius = 0;
            this.m_gen_female.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_gen_female.Size = new System.Drawing.Size(70, 30);
            this.m_gen_female.Style = Sunny.UI.UIStyle.Custom;
            this.m_gen_female.TabIndex = 57;
            this.m_gen_female.Text = "여자";
            this.m_gen_female.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // m_gen_male
            // 
            this.m_gen_male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_gen_male.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_gen_male.ForeColor = System.Drawing.Color.Black;
            this.m_gen_male.Location = new System.Drawing.Point(440, 161);
            this.m_gen_male.MinimumSize = new System.Drawing.Size(1, 1);
            this.m_gen_male.Name = "m_gen_male";
            this.m_gen_male.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.m_gen_male.RadioButtonColor = System.Drawing.Color.Black;
            this.m_gen_male.Radius = 0;
            this.m_gen_male.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_gen_male.Size = new System.Drawing.Size(60, 30);
            this.m_gen_male.Style = Sunny.UI.UIStyle.Custom;
            this.m_gen_male.TabIndex = 56;
            this.m_gen_male.Text = "남자";
            this.m_gen_male.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiLabel6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel6.ForeColor = System.Drawing.Color.Black;
            this.uiLabel6.Location = new System.Drawing.Point(350, 208);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(80, 30);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 55;
            this.uiLabel6.Text = "연락처";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.UseCompatibleTextRendering = true;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // m_tel
            // 
            this.m_tel.CanEmpty = true;
            this.m_tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_tel.FillColor2 = System.Drawing.Color.White;
            this.m_tel.FillDisableColor = System.Drawing.Color.White;
            this.m_tel.FillReadOnlyColor = System.Drawing.Color.White;
            this.m_tel.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_tel.ForeColor = System.Drawing.Color.Black;
            this.m_tel.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.m_tel.Location = new System.Drawing.Point(440, 208);
            this.m_tel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_tel.MinimumSize = new System.Drawing.Size(1, 16);
            this.m_tel.Name = "m_tel";
            this.m_tel.Radius = 0;
            this.m_tel.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_tel.RectColor = System.Drawing.Color.Black;
            this.m_tel.RectReadOnlyColor = System.Drawing.Color.White;
            this.m_tel.ScrollBarColor = System.Drawing.Color.MediumSlateBlue;
            this.m_tel.ShowText = false;
            this.m_tel.Size = new System.Drawing.Size(150, 30);
            this.m_tel.Style = Sunny.UI.UIStyle.Custom;
            this.m_tel.TabIndex = 54;
            this.m_tel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_tel.Watermark = "";
            this.m_tel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel7
            // 
            this.uiLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiLabel7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel7.ForeColor = System.Drawing.Color.Black;
            this.uiLabel7.Location = new System.Drawing.Point(350, 255);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(80, 30);
            this.uiLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel7.TabIndex = 53;
            this.uiLabel7.Text = "담당코치";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel7.UseCompatibleTextRendering = true;
            this.uiLabel7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // m_tname
            // 
            this.m_tname.CanEmpty = true;
            this.m_tname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_tname.FillColor2 = System.Drawing.Color.White;
            this.m_tname.FillDisableColor = System.Drawing.Color.White;
            this.m_tname.FillReadOnlyColor = System.Drawing.Color.White;
            this.m_tname.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_tname.ForeColor = System.Drawing.Color.Black;
            this.m_tname.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.m_tname.Location = new System.Drawing.Point(440, 255);
            this.m_tname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_tname.MinimumSize = new System.Drawing.Size(1, 16);
            this.m_tname.Name = "m_tname";
            this.m_tname.Radius = 0;
            this.m_tname.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_tname.RectColor = System.Drawing.Color.Black;
            this.m_tname.RectReadOnlyColor = System.Drawing.Color.White;
            this.m_tname.ScrollBarColor = System.Drawing.Color.MediumSlateBlue;
            this.m_tname.ShowText = false;
            this.m_tname.Size = new System.Drawing.Size(150, 30);
            this.m_tname.Style = Sunny.UI.UIStyle.Custom;
            this.m_tname.TabIndex = 52;
            this.m_tname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_tname.Watermark = "";
            this.m_tname.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel8
            // 
            this.uiLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiLabel8.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel8.ForeColor = System.Drawing.Color.Black;
            this.uiLabel8.Location = new System.Drawing.Point(350, 109);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(80, 30);
            this.uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel8.TabIndex = 51;
            this.uiLabel8.Text = "비만도";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel8.UseCompatibleTextRendering = true;
            this.uiLabel8.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // m_bmi
            // 
            this.m_bmi.CanEmpty = true;
            this.m_bmi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_bmi.FillColor2 = System.Drawing.Color.White;
            this.m_bmi.FillDisableColor = System.Drawing.Color.White;
            this.m_bmi.FillReadOnlyColor = System.Drawing.Color.White;
            this.m_bmi.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_bmi.ForeColor = System.Drawing.Color.Black;
            this.m_bmi.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.m_bmi.Location = new System.Drawing.Point(440, 109);
            this.m_bmi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_bmi.MinimumSize = new System.Drawing.Size(1, 16);
            this.m_bmi.Name = "m_bmi";
            this.m_bmi.Radius = 0;
            this.m_bmi.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_bmi.RectColor = System.Drawing.Color.Black;
            this.m_bmi.RectReadOnlyColor = System.Drawing.Color.White;
            this.m_bmi.ScrollBarColor = System.Drawing.Color.MediumSlateBlue;
            this.m_bmi.ShowText = false;
            this.m_bmi.Size = new System.Drawing.Size(150, 30);
            this.m_bmi.Style = Sunny.UI.UIStyle.Custom;
            this.m_bmi.TabIndex = 50;
            this.m_bmi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_bmi.Watermark = "";
            this.m_bmi.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel9
            // 
            this.uiLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiLabel9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel9.ForeColor = System.Drawing.Color.Black;
            this.uiLabel9.Location = new System.Drawing.Point(350, 161);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(80, 30);
            this.uiLabel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel9.TabIndex = 49;
            this.uiLabel9.Text = "성별";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel9.UseCompatibleTextRendering = true;
            this.uiLabel9.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel10
            // 
            this.uiLabel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiLabel10.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel10.ForeColor = System.Drawing.Color.Black;
            this.uiLabel10.Location = new System.Drawing.Point(350, 62);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(80, 30);
            this.uiLabel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel10.TabIndex = 48;
            this.uiLabel10.Text = "체지방률";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel10.UseCompatibleTextRendering = true;
            this.uiLabel10.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // m_bfp
            // 
            this.m_bfp.CanEmpty = true;
            this.m_bfp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_bfp.FillColor2 = System.Drawing.Color.White;
            this.m_bfp.FillDisableColor = System.Drawing.Color.White;
            this.m_bfp.FillReadOnlyColor = System.Drawing.Color.White;
            this.m_bfp.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_bfp.ForeColor = System.Drawing.Color.Black;
            this.m_bfp.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.m_bfp.Location = new System.Drawing.Point(440, 62);
            this.m_bfp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_bfp.MinimumSize = new System.Drawing.Size(1, 16);
            this.m_bfp.Name = "m_bfp";
            this.m_bfp.Radius = 0;
            this.m_bfp.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_bfp.RectColor = System.Drawing.Color.Black;
            this.m_bfp.RectReadOnlyColor = System.Drawing.Color.White;
            this.m_bfp.ScrollBarColor = System.Drawing.Color.MediumSlateBlue;
            this.m_bfp.ShowText = false;
            this.m_bfp.Size = new System.Drawing.Size(150, 30);
            this.m_bfp.Style = Sunny.UI.UIStyle.Custom;
            this.m_bfp.TabIndex = 47;
            this.m_bfp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_bfp.Watermark = "";
            this.m_bfp.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiLabel5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel5.ForeColor = System.Drawing.Color.Black;
            this.uiLabel5.Location = new System.Drawing.Point(10, 203);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(80, 30);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 46;
            this.uiLabel5.Text = "키";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.UseCompatibleTextRendering = true;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // m_tall
            // 
            this.m_tall.CanEmpty = true;
            this.m_tall.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_tall.FillColor2 = System.Drawing.Color.White;
            this.m_tall.FillDisableColor = System.Drawing.Color.White;
            this.m_tall.FillReadOnlyColor = System.Drawing.Color.White;
            this.m_tall.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_tall.ForeColor = System.Drawing.Color.Black;
            this.m_tall.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.m_tall.Location = new System.Drawing.Point(100, 208);
            this.m_tall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_tall.MinimumSize = new System.Drawing.Size(1, 16);
            this.m_tall.Name = "m_tall";
            this.m_tall.Radius = 0;
            this.m_tall.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_tall.RectColor = System.Drawing.Color.Black;
            this.m_tall.RectReadOnlyColor = System.Drawing.Color.White;
            this.m_tall.ScrollBarColor = System.Drawing.Color.MediumSlateBlue;
            this.m_tall.ShowText = false;
            this.m_tall.Size = new System.Drawing.Size(150, 30);
            this.m_tall.Style = Sunny.UI.UIStyle.Custom;
            this.m_tall.TabIndex = 45;
            this.m_tall.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_tall.Watermark = "";
            this.m_tall.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiLabel4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel4.ForeColor = System.Drawing.Color.Black;
            this.uiLabel4.Location = new System.Drawing.Point(10, 250);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(80, 30);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 44;
            this.uiLabel4.Text = "몸무게";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.UseCompatibleTextRendering = true;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // m_weight
            // 
            this.m_weight.CanEmpty = true;
            this.m_weight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_weight.FillColor2 = System.Drawing.Color.White;
            this.m_weight.FillDisableColor = System.Drawing.Color.White;
            this.m_weight.FillReadOnlyColor = System.Drawing.Color.White;
            this.m_weight.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_weight.ForeColor = System.Drawing.Color.Black;
            this.m_weight.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.m_weight.Location = new System.Drawing.Point(100, 255);
            this.m_weight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_weight.MinimumSize = new System.Drawing.Size(1, 16);
            this.m_weight.Name = "m_weight";
            this.m_weight.Radius = 0;
            this.m_weight.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_weight.RectColor = System.Drawing.Color.Black;
            this.m_weight.RectReadOnlyColor = System.Drawing.Color.White;
            this.m_weight.ScrollBarColor = System.Drawing.Color.MediumSlateBlue;
            this.m_weight.ShowText = false;
            this.m_weight.Size = new System.Drawing.Size(150, 30);
            this.m_weight.Style = Sunny.UI.UIStyle.Custom;
            this.m_weight.TabIndex = 43;
            this.m_weight.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_weight.Watermark = "";
            this.m_weight.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiLabel3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel3.ForeColor = System.Drawing.Color.Black;
            this.uiLabel3.Location = new System.Drawing.Point(10, 109);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(80, 30);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 42;
            this.uiLabel3.Text = "이름";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.UseCompatibleTextRendering = true;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // m_name
            // 
            this.m_name.CanEmpty = true;
            this.m_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_name.FillColor2 = System.Drawing.Color.White;
            this.m_name.FillDisableColor = System.Drawing.Color.White;
            this.m_name.FillReadOnlyColor = System.Drawing.Color.White;
            this.m_name.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_name.ForeColor = System.Drawing.Color.Black;
            this.m_name.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.m_name.Location = new System.Drawing.Point(100, 109);
            this.m_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_name.MinimumSize = new System.Drawing.Size(1, 16);
            this.m_name.Name = "m_name";
            this.m_name.Radius = 0;
            this.m_name.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_name.RectColor = System.Drawing.Color.Black;
            this.m_name.RectReadOnlyColor = System.Drawing.Color.White;
            this.m_name.ScrollBarColor = System.Drawing.Color.MediumSlateBlue;
            this.m_name.ShowText = false;
            this.m_name.Size = new System.Drawing.Size(150, 30);
            this.m_name.Style = Sunny.UI.UIStyle.Custom;
            this.m_name.TabIndex = 41;
            this.m_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_name.Watermark = "";
            this.m_name.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiLabel2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiLabel2.Location = new System.Drawing.Point(10, 156);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(80, 30);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 40;
            this.uiLabel2.Text = "생년월일";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.UseCompatibleTextRendering = true;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiLabel1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiLabel1.Location = new System.Drawing.Point(10, 62);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(80, 30);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 39;
            this.uiLabel1.Text = "회원번호";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.UseCompatibleTextRendering = true;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(542, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // m_mno
            // 
            this.m_mno.CanEmpty = true;
            this.m_mno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.m_mno.FillColor2 = System.Drawing.Color.White;
            this.m_mno.FillDisableColor = System.Drawing.Color.White;
            this.m_mno.FillReadOnlyColor = System.Drawing.Color.White;
            this.m_mno.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_mno.ForeColor = System.Drawing.Color.Black;
            this.m_mno.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.m_mno.Location = new System.Drawing.Point(100, 62);
            this.m_mno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_mno.MinimumSize = new System.Drawing.Size(1, 16);
            this.m_mno.Name = "m_mno";
            this.m_mno.Radius = 0;
            this.m_mno.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.m_mno.RectColor = System.Drawing.Color.Black;
            this.m_mno.RectReadOnlyColor = System.Drawing.Color.White;
            this.m_mno.ScrollBarColor = System.Drawing.Color.MediumSlateBlue;
            this.m_mno.ShowText = false;
            this.m_mno.Size = new System.Drawing.Size(150, 30);
            this.m_mno.Style = Sunny.UI.UIStyle.Custom;
            this.m_mno.TabIndex = 34;
            this.m_mno.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_mno.Watermark = "";
            this.m_mno.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // listMemberInfo
            // 
            this.listMemberInfo.BackColor = System.Drawing.Color.White;
            this.listMemberInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.회원번호,
            this.이름,
            this.생년월일,
            this.키,
            this.몸무게,
            this.체지방률,
            this.비만도,
            this.성별,
            this.연락처,
            this.코치이름});
            this.listMemberInfo.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listMemberInfo.ForeColor = System.Drawing.Color.Black;
            this.listMemberInfo.FullRowSelect = true;
            this.listMemberInfo.GridLines = true;
            this.listMemberInfo.HideSelection = false;
            this.listMemberInfo.Location = new System.Drawing.Point(10, 349);
            this.listMemberInfo.Name = "listMemberInfo";
            this.listMemberInfo.Size = new System.Drawing.Size(580, 361);
            this.listMemberInfo.TabIndex = 61;
            this.listMemberInfo.UseCompatibleStateImageBehavior = false;
            this.listMemberInfo.View = System.Windows.Forms.View.Details;
            this.listMemberInfo.SelectedIndexChanged += new System.EventHandler(this.listMemberInfo_SelectedIndexChanged);
            // 
            // 회원번호
            // 
            this.회원번호.Text = "회원번호";
            this.회원번호.Width = 58;
            // 
            // 이름
            // 
            this.이름.Text = "이름";
            this.이름.Width = 58;
            // 
            // 생년월일
            // 
            this.생년월일.Text = "생년월일";
            this.생년월일.Width = 58;
            // 
            // 키
            // 
            this.키.Text = "키";
            this.키.Width = 57;
            // 
            // 몸무게
            // 
            this.몸무게.Text = "몸무게";
            this.몸무게.Width = 58;
            // 
            // 체지방률
            // 
            this.체지방률.Text = "체지방률";
            this.체지방률.Width = 58;
            // 
            // 비만도
            // 
            this.비만도.Text = "비만도";
            this.비만도.Width = 58;
            // 
            // 성별
            // 
            this.성별.Text = "성별";
            this.성별.Width = 57;
            // 
            // 연락처
            // 
            this.연락처.Text = "연락처";
            this.연락처.Width = 58;
            // 
            // 코치이름
            // 
            this.코치이름.Text = "코치이름";
            this.코치이름.Width = 56;
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
            this.uiMarkLabel1.TabIndex = 62;
            this.uiMarkLabel1.Text = "회원 정보";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // m_memberInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.m_del);
            this.Controls.Add(this.m_searchbox);
            this.Controls.Add(this.m_upd);
            this.Controls.Add(this.m_search);
            this.Controls.Add(this.m_birth_day);
            this.Controls.Add(this.m_birth_month);
            this.Controls.Add(this.m_birth_year);
            this.Controls.Add(this.m_gen_female);
            this.Controls.Add(this.m_gen_male);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.m_tel);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.m_tname);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.m_bmi);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.m_bfp);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.m_tall);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.m_weight);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.m_name);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.m_mno);
            this.Controls.Add(this.listMemberInfo);
            this.Name = "m_memberInfo";
            this.Size = new System.Drawing.Size(600, 720);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton m_del;
        private Sunny.UI.UITextBox m_searchbox;
        private Sunny.UI.UIButton m_upd;
        private Sunny.UI.UIButton m_search;
        private Sunny.UI.UIComboBox m_birth_day;
        private Sunny.UI.UIComboBox m_birth_month;
        private Sunny.UI.UIComboBox m_birth_year;
        private Sunny.UI.UIRadioButton m_gen_female;
        private Sunny.UI.UIRadioButton m_gen_male;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox m_tel;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox m_tname;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox m_bmi;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UITextBox m_bfp;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox m_tall;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox m_weight;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox m_name;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UITextBox m_mno;
        private System.Windows.Forms.ListView listMemberInfo;
        private System.Windows.Forms.ColumnHeader 회원번호;
        private System.Windows.Forms.ColumnHeader 이름;
        private System.Windows.Forms.ColumnHeader 생년월일;
        private System.Windows.Forms.ColumnHeader 키;
        private System.Windows.Forms.ColumnHeader 몸무게;
        private System.Windows.Forms.ColumnHeader 체지방률;
        private System.Windows.Forms.ColumnHeader 비만도;
        private System.Windows.Forms.ColumnHeader 성별;
        private System.Windows.Forms.ColumnHeader 연락처;
        private System.Windows.Forms.ColumnHeader 코치이름;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
    }
}

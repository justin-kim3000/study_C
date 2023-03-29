namespace _3_project.ui
{
    partial class m_memberAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(m_memberAdd));
            this.openFileImg = new System.Windows.Forms.OpenFileDialog();
            this.picview = new System.Windows.Forms.PictureBox();
            this.day = new Sunny.UI.UIComboBox();
            this.month = new Sunny.UI.UIComboBox();
            this.year = new Sunny.UI.UIComboBox();
            this.tel = new Sunny.UI.UITextBox();
            this.women = new Sunny.UI.UIRadioButton();
            this.man = new Sunny.UI.UIRadioButton();
            this.uiLine1 = new Sunny.UI.UILine();
            this.bmi = new Sunny.UI.UITextBox();
            this.bfp = new Sunny.UI.UITextBox();
            this.weight = new Sunny.UI.UITextBox();
            this.tall = new Sunny.UI.UITextBox();
            this.tname = new Sunny.UI.UITextBox();
            this.name = new Sunny.UI.UITextBox();
            this.mno = new Sunny.UI.UITextBox();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiMarkLabel1 = new Sunny.UI.UIMarkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel10 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel11 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel7 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel8 = new Sunny.UI.UISymbolLabel();
            this.saveImg = new Sunny.UI.UIButton();
            this.memAdd = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.picview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileImg
            // 
            this.openFileImg.FileName = "openFileDialog1";
            // 
            // picview
            // 
            this.picview.BackColor = System.Drawing.Color.White;
            this.picview.Location = new System.Drawing.Point(485, 77);
            this.picview.Name = "picview";
            this.picview.Size = new System.Drawing.Size(105, 135);
            this.picview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picview.TabIndex = 102;
            this.picview.TabStop = false;
            // 
            // day
            // 
            this.day.DataSource = null;
            this.day.FillColor = System.Drawing.Color.White;
            this.day.FillColor2 = System.Drawing.Color.White;
            this.day.FillDisableColor = System.Drawing.Color.White;
            this.day.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.day.ForeColor = System.Drawing.Color.Black;
            this.day.ForeDisableColor = System.Drawing.Color.Black;
            this.day.ItemForeColor = System.Drawing.Color.Black;
            this.day.ItemHoverColor = System.Drawing.Color.SlateBlue;
            this.day.ItemRectColor = System.Drawing.Color.White;
            this.day.ItemSelectBackColor = System.Drawing.Color.White;
            this.day.ItemSelectForeColor = System.Drawing.Color.SlateBlue;
            this.day.Location = new System.Drawing.Point(399, 234);
            this.day.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.day.MinimumSize = new System.Drawing.Size(63, 0);
            this.day.Name = "day";
            this.day.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.day.Radius = 2;
            this.day.RectColor = System.Drawing.Color.Black;
            this.day.RectDisableColor = System.Drawing.Color.Black;
            this.day.Size = new System.Drawing.Size(63, 30);
            this.day.Style = Sunny.UI.UIStyle.Custom;
            this.day.TabIndex = 101;
            this.day.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.day.Watermark = "";
            this.day.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // month
            // 
            this.month.DataSource = null;
            this.month.FillColor = System.Drawing.Color.White;
            this.month.FillColor2 = System.Drawing.Color.White;
            this.month.FillDisableColor = System.Drawing.Color.White;
            this.month.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.month.ForeColor = System.Drawing.Color.Black;
            this.month.ForeDisableColor = System.Drawing.Color.Black;
            this.month.ItemForeColor = System.Drawing.Color.Black;
            this.month.ItemHoverColor = System.Drawing.Color.SlateBlue;
            this.month.ItemRectColor = System.Drawing.Color.White;
            this.month.Items.AddRange(new object[] {
            "1월",
            "2월",
            "3월",
            "4월",
            "5월",
            "6월",
            "7월",
            "8월",
            "9월",
            "10월",
            "11월",
            "12월"});
            this.month.ItemSelectBackColor = System.Drawing.Color.White;
            this.month.ItemSelectForeColor = System.Drawing.Color.SlateBlue;
            this.month.Location = new System.Drawing.Point(324, 234);
            this.month.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.month.MinimumSize = new System.Drawing.Size(63, 0);
            this.month.Name = "month";
            this.month.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.month.Radius = 2;
            this.month.RectColor = System.Drawing.Color.Black;
            this.month.RectDisableColor = System.Drawing.Color.Black;
            this.month.Size = new System.Drawing.Size(63, 30);
            this.month.Style = Sunny.UI.UIStyle.Custom;
            this.month.TabIndex = 100;
            this.month.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.month.Watermark = "";
            this.month.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // year
            // 
            this.year.DataSource = null;
            this.year.FillColor = System.Drawing.Color.White;
            this.year.FillColor2 = System.Drawing.Color.White;
            this.year.FillDisableColor = System.Drawing.Color.White;
            this.year.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.year.ForeColor = System.Drawing.Color.Black;
            this.year.ForeDisableColor = System.Drawing.Color.Black;
            this.year.ItemForeColor = System.Drawing.Color.Black;
            this.year.ItemHoverColor = System.Drawing.Color.SlateBlue;
            this.year.ItemRectColor = System.Drawing.Color.White;
            this.year.ItemSelectBackColor = System.Drawing.Color.White;
            this.year.ItemSelectForeColor = System.Drawing.Color.SlateBlue;
            this.year.Location = new System.Drawing.Point(222, 234);
            this.year.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.year.MinimumSize = new System.Drawing.Size(63, 0);
            this.year.Name = "year";
            this.year.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.year.Radius = 2;
            this.year.RectColor = System.Drawing.Color.Black;
            this.year.RectDisableColor = System.Drawing.Color.Black;
            this.year.Size = new System.Drawing.Size(90, 30);
            this.year.Style = Sunny.UI.UIStyle.Custom;
            this.year.TabIndex = 99;
            this.year.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.year.Watermark = "";
            this.year.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tel
            // 
            this.tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tel.FillColor2 = System.Drawing.Color.White;
            this.tel.FillDisableColor = System.Drawing.Color.White;
            this.tel.FillReadOnlyColor = System.Drawing.Color.White;
            this.tel.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.tel.ForeColor = System.Drawing.Color.Black;
            this.tel.ForeDisableColor = System.Drawing.Color.Black;
            this.tel.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.tel.Location = new System.Drawing.Point(222, 338);
            this.tel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tel.MinimumSize = new System.Drawing.Size(1, 16);
            this.tel.Name = "tel";
            this.tel.Radius = 0;
            this.tel.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.tel.RectColor = System.Drawing.Color.Black;
            this.tel.RectDisableColor = System.Drawing.Color.Black;
            this.tel.RectReadOnlyColor = System.Drawing.Color.Black;
            this.tel.ScrollBarColor = System.Drawing.Color.Black;
            this.tel.ShowText = false;
            this.tel.Size = new System.Drawing.Size(150, 30);
            this.tel.Style = Sunny.UI.UIStyle.Custom;
            this.tel.SymbolColor = System.Drawing.Color.Black;
            this.tel.TabIndex = 93;
            this.tel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tel.Watermark = "";
            this.tel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // women
            // 
            this.women.Cursor = System.Windows.Forms.Cursors.Hand;
            this.women.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.women.ForeColor = System.Drawing.Color.Black;
            this.women.Location = new System.Drawing.Point(295, 183);
            this.women.MinimumSize = new System.Drawing.Size(1, 1);
            this.women.Name = "women";
            this.women.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.women.RadioButtonColor = System.Drawing.Color.Black;
            this.women.Radius = 0;
            this.women.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.women.Size = new System.Drawing.Size(61, 29);
            this.women.Style = Sunny.UI.UIStyle.Custom;
            this.women.TabIndex = 98;
            this.women.Text = "여자";
            this.women.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // man
            // 
            this.man.Cursor = System.Windows.Forms.Cursors.Hand;
            this.man.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.man.ForeColor = System.Drawing.Color.Black;
            this.man.Location = new System.Drawing.Point(222, 183);
            this.man.MinimumSize = new System.Drawing.Size(1, 1);
            this.man.Name = "man";
            this.man.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.man.RadioButtonColor = System.Drawing.Color.Black;
            this.man.Radius = 0;
            this.man.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.man.Size = new System.Drawing.Size(67, 29);
            this.man.Style = Sunny.UI.UIStyle.Custom;
            this.man.TabIndex = 97;
            this.man.Text = "남자";
            this.man.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.White;
            this.uiLine1.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiLine1.ForeColor = System.Drawing.Color.Black;
            this.uiLine1.LineColor = System.Drawing.Color.Black;
            this.uiLine1.LineColor2 = System.Drawing.Color.Black;
            this.uiLine1.Location = new System.Drawing.Point(10, 630);
            this.uiLine1.Margin = new System.Windows.Forms.Padding(0);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(580, 11);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 95;
            this.uiLine1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // bmi
            // 
            this.bmi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bmi.FillColor2 = System.Drawing.Color.White;
            this.bmi.FillDisableColor = System.Drawing.Color.White;
            this.bmi.FillReadOnlyColor = System.Drawing.Color.White;
            this.bmi.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.bmi.ForeColor = System.Drawing.Color.Black;
            this.bmi.ForeDisableColor = System.Drawing.Color.Black;
            this.bmi.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.bmi.Location = new System.Drawing.Point(222, 578);
            this.bmi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bmi.MinimumSize = new System.Drawing.Size(1, 16);
            this.bmi.Name = "bmi";
            this.bmi.Radius = 0;
            this.bmi.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.bmi.RectColor = System.Drawing.Color.Black;
            this.bmi.RectDisableColor = System.Drawing.Color.Black;
            this.bmi.RectReadOnlyColor = System.Drawing.Color.Black;
            this.bmi.ScrollBarColor = System.Drawing.Color.Black;
            this.bmi.ShowText = false;
            this.bmi.Size = new System.Drawing.Size(150, 30);
            this.bmi.Style = Sunny.UI.UIStyle.Custom;
            this.bmi.SymbolColor = System.Drawing.Color.Black;
            this.bmi.TabIndex = 90;
            this.bmi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bmi.Watermark = "";
            this.bmi.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // bfp
            // 
            this.bfp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bfp.FillColor2 = System.Drawing.Color.White;
            this.bfp.FillDisableColor = System.Drawing.Color.White;
            this.bfp.FillReadOnlyColor = System.Drawing.Color.White;
            this.bfp.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.bfp.ForeColor = System.Drawing.Color.Black;
            this.bfp.ForeDisableColor = System.Drawing.Color.Black;
            this.bfp.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.bfp.Location = new System.Drawing.Point(222, 526);
            this.bfp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bfp.MinimumSize = new System.Drawing.Size(1, 16);
            this.bfp.Name = "bfp";
            this.bfp.Radius = 0;
            this.bfp.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.bfp.RectColor = System.Drawing.Color.Black;
            this.bfp.RectDisableColor = System.Drawing.Color.Black;
            this.bfp.RectReadOnlyColor = System.Drawing.Color.Black;
            this.bfp.ScrollBarColor = System.Drawing.Color.Black;
            this.bfp.ShowText = false;
            this.bfp.Size = new System.Drawing.Size(150, 30);
            this.bfp.Style = Sunny.UI.UIStyle.Custom;
            this.bfp.SymbolColor = System.Drawing.Color.Black;
            this.bfp.TabIndex = 91;
            this.bfp.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bfp.Watermark = "";
            this.bfp.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // weight
            // 
            this.weight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.weight.FillColor2 = System.Drawing.Color.White;
            this.weight.FillDisableColor = System.Drawing.Color.White;
            this.weight.FillReadOnlyColor = System.Drawing.Color.White;
            this.weight.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.weight.ForeColor = System.Drawing.Color.Black;
            this.weight.ForeDisableColor = System.Drawing.Color.Black;
            this.weight.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.weight.Location = new System.Drawing.Point(222, 474);
            this.weight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.weight.MinimumSize = new System.Drawing.Size(1, 16);
            this.weight.Name = "weight";
            this.weight.Radius = 0;
            this.weight.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.weight.RectColor = System.Drawing.Color.Black;
            this.weight.RectDisableColor = System.Drawing.Color.Black;
            this.weight.RectReadOnlyColor = System.Drawing.Color.Black;
            this.weight.ScrollBarColor = System.Drawing.Color.Black;
            this.weight.ShowText = false;
            this.weight.Size = new System.Drawing.Size(150, 30);
            this.weight.Style = Sunny.UI.UIStyle.Custom;
            this.weight.SymbolColor = System.Drawing.Color.Black;
            this.weight.TabIndex = 89;
            this.weight.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.weight.Watermark = "";
            this.weight.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tall
            // 
            this.tall.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tall.FillColor2 = System.Drawing.Color.White;
            this.tall.FillDisableColor = System.Drawing.Color.White;
            this.tall.FillReadOnlyColor = System.Drawing.Color.White;
            this.tall.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.tall.ForeColor = System.Drawing.Color.Black;
            this.tall.ForeDisableColor = System.Drawing.Color.Black;
            this.tall.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.tall.Location = new System.Drawing.Point(222, 422);
            this.tall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tall.MinimumSize = new System.Drawing.Size(1, 16);
            this.tall.Name = "tall";
            this.tall.Radius = 0;
            this.tall.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.tall.RectColor = System.Drawing.Color.Black;
            this.tall.RectDisableColor = System.Drawing.Color.Black;
            this.tall.RectReadOnlyColor = System.Drawing.Color.Black;
            this.tall.ScrollBarColor = System.Drawing.Color.Black;
            this.tall.ShowText = false;
            this.tall.Size = new System.Drawing.Size(150, 30);
            this.tall.Style = Sunny.UI.UIStyle.Custom;
            this.tall.SymbolColor = System.Drawing.Color.Black;
            this.tall.TabIndex = 88;
            this.tall.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tall.Watermark = "";
            this.tall.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tname
            // 
            this.tname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tname.FillColor2 = System.Drawing.Color.White;
            this.tname.FillDisableColor = System.Drawing.Color.White;
            this.tname.FillReadOnlyColor = System.Drawing.Color.White;
            this.tname.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.tname.ForeColor = System.Drawing.Color.Black;
            this.tname.ForeDisableColor = System.Drawing.Color.Black;
            this.tname.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.tname.Location = new System.Drawing.Point(222, 286);
            this.tname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tname.MinimumSize = new System.Drawing.Size(1, 16);
            this.tname.Name = "tname";
            this.tname.Radius = 0;
            this.tname.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.tname.RectColor = System.Drawing.Color.Black;
            this.tname.RectDisableColor = System.Drawing.Color.Black;
            this.tname.RectReadOnlyColor = System.Drawing.Color.Black;
            this.tname.ScrollBarColor = System.Drawing.Color.Black;
            this.tname.ShowText = false;
            this.tname.Size = new System.Drawing.Size(150, 30);
            this.tname.Style = Sunny.UI.UIStyle.Custom;
            this.tname.SymbolColor = System.Drawing.Color.Black;
            this.tname.TabIndex = 87;
            this.tname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tname.Watermark = "";
            this.tname.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.FillColor2 = System.Drawing.Color.White;
            this.name.FillDisableColor = System.Drawing.Color.White;
            this.name.FillReadOnlyColor = System.Drawing.Color.White;
            this.name.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.ForeDisableColor = System.Drawing.Color.Black;
            this.name.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(222, 131);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.MinimumSize = new System.Drawing.Size(1, 16);
            this.name.Name = "name";
            this.name.Radius = 0;
            this.name.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.name.RectColor = System.Drawing.Color.Black;
            this.name.RectDisableColor = System.Drawing.Color.Black;
            this.name.RectReadOnlyColor = System.Drawing.Color.Black;
            this.name.ScrollBarColor = System.Drawing.Color.Black;
            this.name.ShowText = false;
            this.name.Size = new System.Drawing.Size(150, 30);
            this.name.Style = Sunny.UI.UIStyle.Custom;
            this.name.SymbolColor = System.Drawing.Color.Black;
            this.name.TabIndex = 86;
            this.name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.name.Watermark = "";
            this.name.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // mno
            // 
            this.mno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mno.FillColor2 = System.Drawing.Color.White;
            this.mno.FillDisableColor = System.Drawing.Color.White;
            this.mno.FillReadOnlyColor = System.Drawing.Color.White;
            this.mno.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.mno.ForeColor = System.Drawing.Color.Black;
            this.mno.ForeDisableColor = System.Drawing.Color.Black;
            this.mno.ForeReadOnlyColor = System.Drawing.Color.Black;
            this.mno.Location = new System.Drawing.Point(222, 79);
            this.mno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mno.MinimumSize = new System.Drawing.Size(1, 16);
            this.mno.Name = "mno";
            this.mno.Radius = 0;
            this.mno.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.mno.RectColor = System.Drawing.Color.Black;
            this.mno.RectDisableColor = System.Drawing.Color.Black;
            this.mno.RectReadOnlyColor = System.Drawing.Color.Black;
            this.mno.ScrollBarColor = System.Drawing.Color.Black;
            this.mno.ShowText = false;
            this.mno.Size = new System.Drawing.Size(150, 30);
            this.mno.Style = Sunny.UI.UIStyle.Custom;
            this.mno.SymbolColor = System.Drawing.Color.Black;
            this.mno.TabIndex = 85;
            this.mno.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.mno.Watermark = "";
            this.mno.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLine2
            // 
            this.uiLine2.FillColor = System.Drawing.Color.White;
            this.uiLine2.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiLine2.ForeColor = System.Drawing.Color.Black;
            this.uiLine2.LineColor = System.Drawing.Color.Black;
            this.uiLine2.LineColor2 = System.Drawing.Color.Black;
            this.uiLine2.Location = new System.Drawing.Point(10, 390);
            this.uiLine2.Margin = new System.Windows.Forms.Padding(0);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(580, 10);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 81;
            this.uiLine2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiSymbolLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel2.Location = new System.Drawing.Point(80, 79);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.uiSymbolLabel2.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiSymbolLabel2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiSymbolLabel2.Size = new System.Drawing.Size(100, 30);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.Symbol = 78;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.DarkSlateBlue;
            this.uiSymbolLabel2.SymbolSize = 25;
            this.uiSymbolLabel2.TabIndex = 76;
            this.uiSymbolLabel2.Text = "회원번호";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            this.uiMarkLabel1.TabIndex = 105;
            this.uiMarkLabel1.Text = "회원 추가";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMarkLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(542, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(80, 131);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.uiSymbolLabel1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiSymbolLabel1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiSymbolLabel1.Size = new System.Drawing.Size(100, 30);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 78;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.DarkSlateBlue;
            this.uiSymbolLabel1.SymbolSize = 25;
            this.uiSymbolLabel1.TabIndex = 106;
            this.uiSymbolLabel1.Text = "이름";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiSymbolLabel3.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel3.Location = new System.Drawing.Point(80, 182);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.uiSymbolLabel3.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiSymbolLabel3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiSymbolLabel3.Size = new System.Drawing.Size(100, 30);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.Symbol = 78;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.DarkSlateBlue;
            this.uiSymbolLabel3.SymbolSize = 25;
            this.uiSymbolLabel3.TabIndex = 107;
            this.uiSymbolLabel3.Text = "성별";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel10
            // 
            this.uiSymbolLabel10.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiSymbolLabel10.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel10.Location = new System.Drawing.Point(80, 234);
            this.uiSymbolLabel10.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel10.Name = "uiSymbolLabel10";
            this.uiSymbolLabel10.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.uiSymbolLabel10.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiSymbolLabel10.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiSymbolLabel10.Size = new System.Drawing.Size(100, 30);
            this.uiSymbolLabel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel10.Symbol = 78;
            this.uiSymbolLabel10.SymbolColor = System.Drawing.Color.DarkSlateBlue;
            this.uiSymbolLabel10.SymbolSize = 25;
            this.uiSymbolLabel10.TabIndex = 108;
            this.uiSymbolLabel10.Text = "생년월일";
            this.uiSymbolLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel10.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiSymbolLabel4.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel4.Location = new System.Drawing.Point(80, 286);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.uiSymbolLabel4.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiSymbolLabel4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiSymbolLabel4.Size = new System.Drawing.Size(100, 30);
            this.uiSymbolLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel4.Symbol = 78;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.DarkSlateBlue;
            this.uiSymbolLabel4.SymbolSize = 25;
            this.uiSymbolLabel4.TabIndex = 109;
            this.uiSymbolLabel4.Text = "담당코치";
            this.uiSymbolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiSymbolLabel5.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel5.Location = new System.Drawing.Point(80, 338);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.uiSymbolLabel5.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiSymbolLabel5.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiSymbolLabel5.Size = new System.Drawing.Size(100, 30);
            this.uiSymbolLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel5.Symbol = 78;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.DarkSlateBlue;
            this.uiSymbolLabel5.SymbolSize = 25;
            this.uiSymbolLabel5.TabIndex = 110;
            this.uiSymbolLabel5.Text = "연락처";
            this.uiSymbolLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiSymbolLabel6.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel6.Location = new System.Drawing.Point(80, 422);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.uiSymbolLabel6.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiSymbolLabel6.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiSymbolLabel6.Size = new System.Drawing.Size(100, 30);
            this.uiSymbolLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel6.Symbol = 78;
            this.uiSymbolLabel6.SymbolColor = System.Drawing.Color.DarkSlateBlue;
            this.uiSymbolLabel6.SymbolSize = 25;
            this.uiSymbolLabel6.TabIndex = 111;
            this.uiSymbolLabel6.Text = "키";
            this.uiSymbolLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel11
            // 
            this.uiSymbolLabel11.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiSymbolLabel11.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel11.Location = new System.Drawing.Point(80, 474);
            this.uiSymbolLabel11.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel11.Name = "uiSymbolLabel11";
            this.uiSymbolLabel11.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.uiSymbolLabel11.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiSymbolLabel11.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiSymbolLabel11.Size = new System.Drawing.Size(100, 30);
            this.uiSymbolLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel11.Symbol = 78;
            this.uiSymbolLabel11.SymbolColor = System.Drawing.Color.DarkSlateBlue;
            this.uiSymbolLabel11.SymbolSize = 25;
            this.uiSymbolLabel11.TabIndex = 112;
            this.uiSymbolLabel11.Text = "체중";
            this.uiSymbolLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel11.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel7
            // 
            this.uiSymbolLabel7.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiSymbolLabel7.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel7.Location = new System.Drawing.Point(80, 526);
            this.uiSymbolLabel7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel7.Name = "uiSymbolLabel7";
            this.uiSymbolLabel7.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.uiSymbolLabel7.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiSymbolLabel7.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiSymbolLabel7.Size = new System.Drawing.Size(100, 30);
            this.uiSymbolLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel7.Symbol = 78;
            this.uiSymbolLabel7.SymbolColor = System.Drawing.Color.DarkSlateBlue;
            this.uiSymbolLabel7.SymbolSize = 25;
            this.uiSymbolLabel7.TabIndex = 113;
            this.uiSymbolLabel7.Text = "BFP";
            this.uiSymbolLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolLabel8
            // 
            this.uiSymbolLabel8.Font = new System.Drawing.Font("나눔고딕", 12F);
            this.uiSymbolLabel8.ForeColor = System.Drawing.Color.Black;
            this.uiSymbolLabel8.Location = new System.Drawing.Point(80, 578);
            this.uiSymbolLabel8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel8.Name = "uiSymbolLabel8";
            this.uiSymbolLabel8.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.uiSymbolLabel8.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiSymbolLabel8.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiSymbolLabel8.Size = new System.Drawing.Size(100, 30);
            this.uiSymbolLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel8.Symbol = 78;
            this.uiSymbolLabel8.SymbolColor = System.Drawing.Color.DarkSlateBlue;
            this.uiSymbolLabel8.SymbolSize = 25;
            this.uiSymbolLabel8.TabIndex = 114;
            this.uiSymbolLabel8.Text = "BMI";
            this.uiSymbolLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolLabel8.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // saveImg
            // 
            this.saveImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveImg.FillColor = System.Drawing.Color.SlateBlue;
            this.saveImg.FillColor2 = System.Drawing.Color.SlateBlue;
            this.saveImg.FillHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.saveImg.FillPressColor = System.Drawing.Color.DarkSlateBlue;
            this.saveImg.FillSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.saveImg.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saveImg.Location = new System.Drawing.Point(516, 234);
            this.saveImg.MinimumSize = new System.Drawing.Size(1, 1);
            this.saveImg.Name = "saveImg";
            this.saveImg.Radius = 0;
            this.saveImg.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.saveImg.RectColor = System.Drawing.Color.DarkSlateBlue;
            this.saveImg.RectDisableColor = System.Drawing.Color.DarkSlateBlue;
            this.saveImg.RectHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.saveImg.RectPressColor = System.Drawing.Color.DarkSlateBlue;
            this.saveImg.RectSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.saveImg.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.saveImg.Size = new System.Drawing.Size(45, 30);
            this.saveImg.Style = Sunny.UI.UIStyle.Custom;
            this.saveImg.TabIndex = 117;
            this.saveImg.Text = "사진";
            this.saveImg.TipsFont = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveImg.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.saveImg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // memAdd
            // 
            this.memAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memAdd.FillColor = System.Drawing.Color.SlateBlue;
            this.memAdd.FillColor2 = System.Drawing.Color.SlateBlue;
            this.memAdd.FillDisableColor = System.Drawing.Color.SlateBlue;
            this.memAdd.FillHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.memAdd.FillPressColor = System.Drawing.Color.DarkSlateBlue;
            this.memAdd.FillSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.memAdd.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memAdd.ForeDisableColor = System.Drawing.Color.White;
            this.memAdd.Location = new System.Drawing.Point(222, 663);
            this.memAdd.Margin = new System.Windows.Forms.Padding(0);
            this.memAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.memAdd.Name = "memAdd";
            this.memAdd.Radius = 0;
            this.memAdd.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.memAdd.RectColor = System.Drawing.Color.White;
            this.memAdd.RectDisableColor = System.Drawing.Color.White;
            this.memAdd.RectHoverColor = System.Drawing.Color.White;
            this.memAdd.RectPressColor = System.Drawing.Color.White;
            this.memAdd.RectSelectedColor = System.Drawing.Color.White;
            this.memAdd.Size = new System.Drawing.Size(150, 35);
            this.memAdd.Style = Sunny.UI.UIStyle.Custom;
            this.memAdd.Symbol = 62004;
            this.memAdd.SymbolDisableColor = System.Drawing.Color.White;
            this.memAdd.SymbolHoverColor = System.Drawing.Color.DarkSlateBlue;
            this.memAdd.SymbolOffset = new System.Drawing.Point(-5, 0);
            this.memAdd.SymbolPressColor = System.Drawing.Color.DarkSlateBlue;
            this.memAdd.SymbolSelectedColor = System.Drawing.Color.DarkSlateBlue;
            this.memAdd.TabIndex = 118;
            this.memAdd.Text = "등록";
            this.memAdd.TipsColor = System.Drawing.Color.White;
            this.memAdd.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.memAdd.Click += new System.EventHandler(this.memAdd_Click);
            // 
            // m_memberAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.saveImg);
            this.Controls.Add(this.uiSymbolLabel8);
            this.Controls.Add(this.uiSymbolLabel7);
            this.Controls.Add(this.uiSymbolLabel11);
            this.Controls.Add(this.uiSymbolLabel6);
            this.Controls.Add(this.uiSymbolLabel5);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiSymbolLabel10);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picview);
            this.Controls.Add(this.day);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.women);
            this.Controls.Add(this.man);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.bmi);
            this.Controls.Add(this.bfp);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.tall);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.mno);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.memAdd);
            this.Font = new System.Drawing.Font("나눔고딕", 9.75F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "m_memberAdd";
            this.Size = new System.Drawing.Size(600, 720);
            ((System.ComponentModel.ISupportInitialize)(this.picview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileImg;
        private System.Windows.Forms.PictureBox picview;
        private Sunny.UI.UIComboBox day;
        private Sunny.UI.UIComboBox month;
        private Sunny.UI.UIComboBox year;
        private Sunny.UI.UITextBox tel;
        private Sunny.UI.UIRadioButton women;
        private Sunny.UI.UIRadioButton man;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UITextBox bmi;
        private Sunny.UI.UITextBox bfp;
        private Sunny.UI.UITextBox weight;
        private Sunny.UI.UITextBox tall;
        private Sunny.UI.UITextBox tname;
        private Sunny.UI.UITextBox name;
        private Sunny.UI.UITextBox mno;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel10;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private Sunny.UI.UISymbolLabel uiSymbolLabel11;
        private Sunny.UI.UISymbolLabel uiSymbolLabel7;
        private Sunny.UI.UISymbolLabel uiSymbolLabel8;
        private Sunny.UI.UIButton saveImg;
        private Sunny.UI.UISymbolButton memAdd;
    }
}

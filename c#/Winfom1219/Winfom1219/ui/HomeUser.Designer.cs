namespace Winfom1219.ui
{
    partial class HomeUser
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
            this.uiBarChart1 = new Sunny.UI.UIBarChart();
            this.SuspendLayout();
            // 
            // uiBarChart1
            // 
            this.uiBarChart1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiBarChart1.LegendFont = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.uiBarChart1.Location = new System.Drawing.Point(88, 92);
            this.uiBarChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBarChart1.Name = "uiBarChart1";
            this.uiBarChart1.Size = new System.Drawing.Size(400, 300);
            this.uiBarChart1.SubFont = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.uiBarChart1.TabIndex = 0;
            this.uiBarChart1.Text = "uiBarChart1";
            this.uiBarChart1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // HomeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiBarChart1);
            this.Name = "HomeUser";
            this.Size = new System.Drawing.Size(600, 507);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIBarChart uiBarChart1;
    }
}

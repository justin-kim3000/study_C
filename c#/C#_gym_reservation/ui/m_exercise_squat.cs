using _3_project.adapter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_project.ui
{
    public partial class m_exercise_squat : UserControl
    {
        BaseAdapter ba = new BaseAdapter();
        const string UC_EXERCISEPLAN = "m_exercisePlan";
        public m_exercise_squat()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL = @"\\192.168.0.135\공유폴더\플랫폼_proj\3조\희_운동루틴\영상자료\The-Back-Squat.wmv";
            uiRichTextBox1.Text = "스쿼트(영어: squat)는 웨이트 트레이닝의 가장 대표적인 운동 중 하나이다. 데드리프트, 벤치 프레스와 함께 웨이트 트레이닝의 'Big 3'로도 불리며, 중량을 겨루는 스포츠인 파워리프팅 중 하나이다. " +
                "\r바벨 또는 덤벨을 들고 무릎 관절을 굽혔다 펴는 행동을 반복함으로써, 하반신의 대퇴사두근과 하퇴삼두근, 대둔근, 중전근 등의 근육을 성장시키는 운동으로, 하체의 근육량 증가에 커다란 효과가 있다.\r\n\r\n잘못된 자세 또는 무리한 중량으로 행할 경우 무릎 부상의 위험이 큰 운동이기도 하다. 무릎을 구부릴 때는 무릎이 앞으로 돌출되어 무게중심이 앞으로 쏠리지 않도록 주의해야 하며, 허리를 구부리지 말고 엉덩이를 뒤로 뺀 자세로 시행해야 한다.";
        }

        void controllView(UserControl uc, string viewName)
        {
            Controls.Clear();
            if (!Controls.ContainsKey(viewName))
            {
                Controls.Add(uc);
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            controllView(new m_exercisePlan(ba), UC_EXERCISEPLAN);
        }
    }
}

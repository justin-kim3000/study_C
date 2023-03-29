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
    public partial class m_exercise_benchpress : UserControl
    {

        BaseAdapter ba = new BaseAdapter();
        const string UC_EXERCISEPLAN = "m_exercisePlan";

        public m_exercise_benchpress()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL = @"\\192.168.0.135\공유폴더\플랫폼_proj\3조\희_운동루틴\영상자료\BenchPress_1080p.wmv";
            uiRichTextBox1.Text = "벤치 프레스(bench press, chest press)는 스쿼트, 데드리프트와 함께 웨이트 트레이닝의 'Big 3'로 불리는 대표적인 근력 운동 중 하나이다.\r" +
                " 벤치에 등을 대고 누워서 역기를 가슴 높이까지 내렸다가 굽힌 팔꿈치를 쭉 펴면서 들어 올리는 방식으로 실시한다.\r" +
                "웨이트 트레이닝 3대 운동 중 하나답게 운동 효과가 매우 뛰어나다. 거대한 가슴 근육 발달에는 벤치 프레스만한 운동이 없으며 가슴뿐만 아니라 어깨, 삼두 등 상체 근육 전반을 그 어떤 운동보다도 고중량으로 소화해낼 수 있는 상체 운동의 최고봉인 운동이다.\r\n" +
                "흔히 바벨과 덤벨을 사용하여 운동한다. 그 중에서도 바벨 벤치 프레스는 가장 많은 무게를 사용할 수 있는 고중량 상체 운동이기 때문에 대흉근의 매스 발달에 더 유리하다. 또한 가장 많은 무게를 사용할 수 있는 상체 운동이란 타이틀 덕분에 근비대를 목적으로 하지 않는 운동 선수들도 자신들의 훈련 프로그램에 벤치 프레스를 넣는 것이 필수로 여겨진다.";
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
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
    public partial class m_exercise_latpulldown : UserControl
    {
        BaseAdapter ba = new BaseAdapter();
        const string UC_EXERCISEPLAN = "m_exercisePlan";
        public m_exercise_latpulldown()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL = @"\\192.168.0.135\공유폴더\플랫폼_proj\3조\희_운동루틴\영상자료\LatPulldown.wmv";
            uiRichTextBox1.Text = "턱걸이를 하듯 어깨보다 좀 더 넓게 바를 잡은 다음, 상체를 뒤로 젖히고 팔이 아니라 등의 힘으로 당겨 내려오는 방식이 가장 기본적인 형태이다. 턱걸이와 가동부위는 거의 같으며, 좁게 잡을수록 광배근 안쪽이, 넓게 잡을수록 상부와 바깥쪽이 발달된다. 그밖에 등 뒤로 바를 넘기는 등 몇가지 변형이 있는데, 등에 더 많은 자극을 가할 수 있는 장점이 있지만 초보자는 자칫 몸만 상하기 쉬우므로 정석대로 하는 편이 좋다. 상단 영상의 강경원은 초보자라면 넓은 그립으로 실시할 것을 권하고 있다.\r\n\r\n따로 특별한 설명이 필요없이 초보자가 봐도 한눈에 작동법을 알수 있을만큼 직관적인 형태인데, 반드시 정식 트레이너에게 자세 교정을 받자. 전술한 바와 같이 등의 힘으로 당기는 느낌을 초보자는 제대로 파악하기 어렵기 때문이다. 초보자라면 등과 팔꿈치로 당긴다는 느낌으로 하면 좋다. 물론 트레이너가 교정해주는게 최고이다. 모든 근력운동이 그렇듯이 근신경이 부족한 초보자는 정자세를 유지하고도 자극점을 찾지 못하는 경우가 있다. 지나치게 가볍지도, 무겁지도 않은 적절한 중량과 저항을 충분히 느낄 수 있는 속도로 등 외의 여타 부위의 개입을 최대한으로 줄인다는 느낌으로 반복하며 감각을 찾도록 하자.";
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
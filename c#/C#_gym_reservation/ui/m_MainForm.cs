using _3_project.adapter;
using _3_project.ui;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_project
{
    public partial class m_MainForm : MaterialForm
    {
#pragma warning disable CS0108
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x02;
        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]

        static extern bool ReleaseCapture();
#pragma warning restore CS0108
        const string UC_EXERCISEPLAN = "m_exercisePlan";
        const string UC_HELP = "m_help";
        const string UC_HOME = "m_home";
        const string UC_MEALPLAN = "m_mealPlan";
        const string UC_MEMBERADD = "m_memberAdd";
        const string UC_MEMBERINFO = "m_memberInfo";
        const string UC_MEMBERPLAN = "m_memberPlan";
        const string UC_TODAYPLAN = "m_todayPlan";
        BaseAdapter ba = new BaseAdapter();
        int m_click = 0;
        public Stack<string> stack_viewName = new Stack<string>();

        public m_MainForm()
        {
            InitializeComponent();
            controllView(new m_home(ba), UC_HOME);

        }


        void controllView(UserControl uc, string viewName)
        {
            panelCenter.Controls.Clear();
            if (!panelCenter.Controls.ContainsKey(viewName))
            {
                panelCenter.Controls.Add(uc);
            }
        }
        
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            controllView(new m_home(ba), UC_HOME);
            stack_viewName.Push("UC_HOME");
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            controllView(new m_todayPlan(ba), UC_TODAYPLAN);
            stack_viewName.Push("UC_TODAYPLAN");
        }

        private void uiSymbolButton9_Click(object sender, EventArgs e)
        {
            controllView(new m_memberAdd(ba), UC_MEMBERADD);
            stack_viewName.Push("UC_MEMBERADD");
        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            controllView(new m_memberInfo(ba), UC_MEMBERINFO);
            stack_viewName.Push("UC_MEMBERINFO");
        }

        private void uiSymbolButton5_Click(object sender, EventArgs e)
        {
            controllView(new m_memberPlan(ba), UC_MEMBERPLAN);
            stack_viewName.Push("UC_MEMBERPLAN");
        }

        private void uiSymbolButton4_Click(object sender, EventArgs e)
        {
            controllView(new m_mealPlan(ba), UC_MEALPLAN);
            stack_viewName.Push("UC_MEALPLAN");
        }

        private void uiSymbolButton6_Click(object sender, EventArgs e)
        {
            controllView(new m_exercisePlan(ba), UC_EXERCISEPLAN);
            stack_viewName.Push("UC_EXERCISEPLAN");
        }

        private void uiSymbolButton8_Click(object sender, EventArgs e)
        {
            controllView(new m_help(), UC_HELP);
            stack_viewName.Push("UC_HELP");
        }

        private void uiSymbolButton11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiSymbolButton10_Click(object sender, EventArgs e)
        {
            string m = null;
            try
            {
                if (m_click == 0)
                {
                    panelCenter.Controls.Clear();
                    stack_viewName.Pop();
                    m = stack_viewName.Pop();
                    m_click++;
                }
                else if (m_click > 0)
                {
                    panelCenter.Controls.Clear();
                    m = stack_viewName.Pop();
                }
                else
                {
                    panelCenter.Controls.Clear();
                    m_click++;
                }
            }
            catch
            {
                panelCenter.Controls.Clear();
                controllView(new m_home(ba), UC_HOME);
                m_click = 0;
            }
            if (m == "UC_HOME")
            { controllView(new m_home(ba), UC_HOME); }
            else if (m == "UC_TODAYPLAN")
            { controllView(new m_todayPlan(ba), UC_TODAYPLAN); }
            else if (m == "UC_MEMBERADD")
            { controllView(new m_memberAdd(ba), UC_MEMBERADD); }
            else if (m == "UC_MEMBERINFO")
            { controllView(new m_memberInfo(ba), UC_MEMBERINFO); }
            else if (m == "UC_MEMBERPLAN")
            { controllView(new m_memberPlan(ba), UC_MEMBERPLAN); }
            else if (m == "UC_MEALPLAN")
            { controllView(new m_mealPlan(ba), UC_MEALPLAN); }
            else if (m == "UC_EXERCISEPLAN")
            { controllView(new m_exercisePlan(ba), UC_EXERCISEPLAN); }
            else if (m == "UC_HELP")
            { controllView(new m_help(), UC_HELP); }
        }

        private void panelTop_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN,
                    HT_CAPTION, 0);
            }
        }
    }
}

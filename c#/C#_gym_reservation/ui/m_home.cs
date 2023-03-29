using _3_project.adapter;
using _3_project.dao;
using _3_project.model;
using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace _3_project.ui
{
    partial class m_home : UserControl
    {
        BaseAdapter ba;
        const string UC_TODAYPLAN = "m_todayPlan";
        const string UC_LOGIN = "LoginAdd";
        public m_home()
        {
            InitializeComponent();

        }

        public m_home(BaseAdapter ba)
        {
            InitializeComponent();
            this.ba = ba;

        }

        void controllView(UserControl uc, string viewName)
        {
            Controls.Clear();
            if (!Controls.ContainsKey(viewName))
            {
                Controls.Add(uc);
            }
        }
        private void searchIdB_Click(object sender, EventArgs e)
        {

            controllView(new m_todayPlan(ba), UC_TODAYPLAN);
        }






        private void uiButton1_Click(object sender, EventArgs e)
        {
            controllView(new LoginAdd(ba), UC_LOGIN);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            controllView(new LoginAdd(ba), UC_LOGIN);
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.play();

        }

        private void uiSymbolButton4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.Ctlcontrols.play();

        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            axWindowsMediaPlayer2.Ctlcontrols.pause();
            axWindowsMediaPlayer3.Ctlcontrols.pause();
        }


        private void m_home_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"\\192.168.0.135\공유폴더\플랫폼_proj\3조\희_운동루틴\음원자료\macho.mp3";
            axWindowsMediaPlayer2.URL = @"\\192.168.0.135\공유폴더\플랫폼_proj\3조\희_운동루틴\음원자료\earthBreak.mp3";
            axWindowsMediaPlayer3.URL = @"\\192.168.0.135\공유폴더\플랫폼_proj\3조\희_운동루틴\음원자료\muscle.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer2.Ctlcontrols.stop();
            axWindowsMediaPlayer3.Ctlcontrols.stop();
        }

        private void next2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            back1.Visible = false;
            next2.Visible = false;
            uiSymbolButton5.Visible = false;
            pictureBox3.Visible = true;
            back2.Visible = true;
        }

        private void uiSymbolButton5_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            back1.Visible = true;
            next2.Visible = true;
        }

        private void back2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            back2.Visible = false;
            pictureBox2.Visible = true;
            uiSymbolButton5.Visible = true;
            back1.Visible = true;
            next2.Visible = true;

        }

        private void back1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            back1.Visible = false;
            next2.Visible = false;
        }

        
    }
}

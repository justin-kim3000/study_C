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
using Winfom1219.ui;
using Winfom1219.ui.admin;

namespace Winfom1219
{
    public partial class MainForm : MaterialForm
    {
        // 마우스 드래그 이동
#pragma warning disable CS0108
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x02;
        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();
#pragma warning disable CS0108

        const string UC_HOMEUSER = "HomeUser";
        const string UC_ADDUSER = "AddUser";
        const string UC_HELPUSER = "HelpUser";
        const string UC_INFOUSER = "InfoUser";
        const string UC_PAYUSER = "PayUser";
        const string UC_SETTINGUSER = "SettingUser";
        const string UC_ADMINUSER = "AdminUser";





        public MainForm()
        {
            InitializeComponent();
            controllView(new HomeUser(), UC_HOMEUSER);

        }

        private void mainMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void topLayout_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        void controllView(UserControl uc, string viewName)
        {
            if (!centerLayout.Controls.ContainsKey(viewName))
            {
                uc.Dock = DockStyle.Fill;
                centerLayout.Controls.Add(uc);
            }
           centerLayout.Controls[viewName].BringToFront();
        }

        private void mainHome_Click(object sender, EventArgs e)
        {
            controllView(new HomeUser(), UC_HOMEUSER);
        }

        private void mainAdd_Click(object sender, EventArgs e)
        {
            controllView(new AddUser(), UC_ADDUSER);
        }

        private void mainScore_Click(object sender, EventArgs e)
        {
            controllView(new PayUser(), UC_PAYUSER);

        }

        private void mainInfo_Click(object sender, EventArgs e)
        {
            controllView(new InfoUser(), UC_INFOUSER);

        }

        private void mainAdmin_Click(object sender, EventArgs e)
        {
            controllView(new AdminUser(), UC_ADMINUSER);

        }

        private void mainSetting_Click(object sender, EventArgs e)
        {
            controllView(new SettingUser(), UC_SETTINGUSER);

        }

        private void mainHelp_Click(object sender, EventArgs e)
        {
            controllView(new HelpUser(), UC_HELPUSER);

        }
    }
}

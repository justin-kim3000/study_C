using _3_project.adapter;
using _3_project.dao;
using _3_project.model;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _3_project.ui
{
    partial class LoginAdd : UserControl
    {
        const string UC_HOME = "m_home";
        int flagid = 0;
        int flagtno = 0;
        string name01;
        string pw01;
        string pw02;
        string id01;
        string tno01;
        BaseAdapter ba;
        public LoginAdd()
        {
            InitializeComponent();
        }
        public LoginAdd(BaseAdapter ba)
        {
            InitializeComponent();
            this.ba = ba;
            signingLogin.Visible= false;
            mainLogin.Visible = true;        }
        void controllView(UserControl uc, string viewName)
        {
            Controls.Clear();
            if (!Controls.ContainsKey(viewName))
            {
                Controls.Add(uc);
            }
        }
        void controllView2(UserControl uc, string viewName)
        {
            Controls.Clear();
            if (!Controls.ContainsKey(viewName))
            {
                Controls.Add(uc);
            }
        }

        private void signButton_Click(object sender, EventArgs e)
        {

            mainLogin.Visible = false;
            signingLogin.Visible = true;
            signingLogin.Enabled = true;
            
        }
        private void newId_TextChanged(object sender, EventArgs e)
        {
            id01=newId.Text.ToString();
            Console.WriteLine(id01);
            int counti = 0;
            
            bool bool01 = true;
            DaoOra ora = ba.Ora;
            List<Member> list = ora.trainerShow();
            Console.WriteLine(list.Count());
            flagid = 0;
            while (bool01)
            {
                try
                {
                    if (list[counti].Tid == id01)
                    {
                        flagid++;
                    }
                    counti++;
                }
                catch (Exception)
                {

                }
                if (counti == list.Count())
                {
                    bool01 = false;
                }
            }
            if (flagid == 0)
            {
                Console.WriteLine("사용가능한 아이디입니다.");
                reTestId.ForeColor = Color.DimGray;
                reTestId.Text = "사용가능한 아이디입니다";
            }
            else
            {
                Console.WriteLine("중복된 id입니다.");
                reTestId.ForeColor = Color.DarkRed;
                reTestId.Text = "중복된 아이디입니다";
            }

        }

        private void signedButton_Click_1(object sender, EventArgs e)
        {
            string name = name01;
            string id = id01;
            string pw = pw01;
            string tno = tno01;
            if (flagid == 0)
            {
                if (flagtno == 0)
                {
                    if (pw01 == pw02)
                    {
                        DaoOra ora = ba.Ora;
                        ora.insertData2(new Member(name,id,pw,tno));
                        MessageBox.Show("트레이너 정보가 등록되었습니다.");
                        controllView(new m_home(ba),UC_HOME);
                    }
                    else { MessageBox.Show("비밀번호 불일치!"); }
                }
                else { MessageBox.Show("트레이너 번호 중복!"); }
            }
            else { MessageBox.Show("아이디 중복!"); }
        }

        private void newPw1_TextChanged(object sender, EventArgs e)
        {
            pw01 = newPw1.Text;
        }

        private void newPw2_TextChanged(object sender, EventArgs e)
        {
            pw02=newPw2.Text;
            if (pw01 == pw02) { rePw.Text = ""; }
            else if(pw02 != pw01) { rePw.Text = "비밀번호 불일치"; }
        }

        private void newId_Click(object sender, EventArgs e)
        {
            newId.Text = "";
        }

        private void newPw1_Click(object sender, EventArgs e)
        {
            newPw1.Text = "";
            newPw1.PasswordChar= '*';
        }

        private void newTno_TextChanged(object sender, EventArgs e)
        {
            tno01 = newTno.Text.ToString();
            Console.WriteLine(newTno);
            bool bool01 = true;
            int counti = 0;
            DaoOra ora = ba.Ora;
            List<Member> list = ora.trainerShow();
            Console.WriteLine(list.Count());
            flagtno = 0;
            while (bool01)
            {
                try
                {
                    if (list[counti].Tno == tno01)
                    {
                        flagtno++;
                    }
                    counti++;
                }
                catch (Exception)
                {

                }
                if (counti == list.Count())
                {
                    bool01 = false;
                }
            }
            if (flagtno == 0)
            {
                Console.WriteLine("사용가능한 트레이너 번호입니다.");
                reTno.ForeColor = Color.DimGray;
                reTno.Text = "사용가능한 트레이너 번호입니다";
            }
            else
            {
                Console.WriteLine("중복된 트레이너 번호입니다.");
                reTno.ForeColor = Color.DarkRed;
                reTno.Text = "중복된 트레이너 번호입니다";
            }
        }

        private void newName_TextChanged(object sender, EventArgs e)
        {
            name01=newName.Text;
            Console.WriteLine(name01);
        }
        string id02;
        string pw03;
        private void idBox_TextChanged(object sender, EventArgs e)
        {
            id02= idBox.Text;
        }

        private void pwBox_TextChanged(object sender, EventArgs e)
        {
            pw03= pwBox.Text;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DaoOra ora = ba.Ora;
            List<Member> list = ora.trainerShow();
            Console.WriteLine(list.Count());
            int flag_l = 0;
            for(int i = 0; i < list.Count(); i++)
            {
                if (id02 == list[i].Tid)
                {
                    flag_l++;
                    if (pw03 == list[i].Tpw)
                    {
                        MessageBox.Show("로그인 성공 : "+ list[i].Name + " 트레이너님 환영합니다.");
                        controllView(new m_home(ba), UC_HOME);
                    }
                    else
                    {
                        MessageBox.Show("로그인 실패 : 아이디나 비밀번호를 확인하세요.");
                    }
                }              
            }
            if (flag_l == 0)
            {
                MessageBox.Show("로그인 실패 : 아이디나 비밀번호를 확인하세요.");
            }

        }

        private void idBox_Click(object sender, EventArgs e)
        {
            idBox.Text = "";
        }

        private void pwBox_Click(object sender, EventArgs e)
        {
            pwBox.Text = "";
            pwBox.PasswordChar= '*';
        }
    }
}

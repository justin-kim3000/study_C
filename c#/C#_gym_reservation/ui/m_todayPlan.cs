using _3_project.adapter;
using _3_project.dao;
using _3_project.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//adapter,dao,model,util;

namespace _3_project.ui
{   
    partial class m_todayPlan : UserControl
    {
        BaseAdapter ba;
        const string UC_MEMBERPLAN = "m_memberPlan";
        int iSpeed = 1;
        int iOffset = 10;
        string[] t_name =new string[4];
        string[] t_num=new string[4];
        int flag = 0;
        public m_todayPlan()
        {
            InitializeComponent();
        }
        public m_todayPlan(BaseAdapter ba)
        {
            InitializeComponent();
            this.ba = ba;
            Program.iLocationY = (trainerLayout.Height - trainerLayout.Location.Y) / 2;
            Point p = new Point(Program.iLocationX, Program.iLocationY);
            trainer.Location = p;
            customer();
            summary();
        }

        public void summary()
        {
            DaoOra or = ba.Ora;
            string summ;
            summ = or.reTName();
            textSummary.Text = summ+"트레이너님.";
        }
        private void customer()
        {
            cusOne.Text = "";
            cusTwo.Text = "";
            cusThree.Text = "";
            cusFour.Text = "";
            DaoOra ora = ba.Ora;
            List<Member> list = ora.planDataShow();
            Console.WriteLine(list.Count());
            for(int i=0;i<4;i++)
            {
                try
                {
                    switch (i)
                    {
                        case 0:
                            cusOne.Text = list[i].Mno+"번 회원,"+list[i].Name+"님."+list[i].Pttime+"시 운동.";
                            cusOne.RectColor = Color.DarkViolet;
                            cusOne.RectHoverColor = Color.DarkViolet;
                            cusOne.ForeHoverColor= Color.DarkViolet;
                            cusOne.FillColor= Color.SlateBlue;
                            t_name[i] = list[i].Name;
                            t_num[i] = list[i].Mno;
                            Console.WriteLine(t_name[i]);
                            break;
                        case 1:
                            cusTwo.Text = list[i].Mno + "번 회원," + list[i].Name + "님." + list[i].Time + "시 운동.";
                            cusTwo.RectColor = Color.DarkViolet;
                            cusTwo.RectHoverColor = Color.DarkViolet;
                            cusTwo.ForeHoverColor = Color.DarkViolet;
                            cusTwo.FillColor = Color.SlateBlue;
                            t_name[i] = list[i].Name;
                            t_num[i] = list[i].Mno;
                            break;
                        case 2:
                            cusThree.Text = list[i].Mno + "번 회원," + list[i].Name + "님." + list[i].Time + "시 운동.";
                            cusThree.RectColor = Color.DarkViolet;
                            cusThree.RectHoverColor = Color.DarkViolet;
                            cusThree.ForeHoverColor = Color.DarkViolet;
                            cusThree.FillColor = Color.SlateBlue;
                            t_name[i] = list[i].Name;
                            t_num[i] = list[i].Mno;
                            break;
                        case 3:
                            cusFour.Text = list[i].Mno + "번 회원," + list[i].Name + "님." + list[i].Time + "시 운동.";
                            cusFour.RectColor = Color.DarkViolet;
                            cusFour.RectHoverColor = Color.DarkViolet;
                            cusFour.ForeHoverColor = Color.DarkViolet;
                            cusFour.FillColor = Color.SlateBlue;
                            t_name[i] = list[i].Name;
                            t_num[i] = list[i].Mno;
                            break;
                        default: break;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); 
            trainerRunTime.Start();
            Program.bCheck= true;
        } 
        private void trainerRunTime_Tick(object sender, EventArgs e)
        {
            
            if (Program.bCheck)
            {
                int iMove = Program.iLocationX + trainer.Width + iOffset;
                int iEnd = trainerLayout.Width;

                if(iMove < iEnd) 
                {
                    Program.iLocationX += iSpeed;
                    Point p= new Point(Program.iLocationX, Program.iLocationY);
                    trainer.Location = p;
                }
                else
                {
                    Program.bCheck = false;
                }
            }
            else
            {
                if (Program.iLocationX < trainerLayout.Location.X)
                {
                    Program.bCheck = true;
                }
                else
                {
                    Program.iLocationX =0;
                    Point p=new Point(Program.iLocationX, Program.iLocationY);
                    trainer.Location = p;
                    trainerRunTime.Stop();
                    Program.flag_timer++;
                    if (Program.flag_timer == 1)
                    {
                        MessageBox.Show("오늘 업무가 끝났습니다.");
                    }
                    trainerRunTime.Enabled=false;
                    
                }
            }
        }
        void controllView(UserControl uc, string viewName)
        {
            Controls.Clear();
            if (!Controls.ContainsKey(viewName))
            {
                Controls.Add(uc);
            }
        }
        private void cusThree_Click(object sender, EventArgs e)
        {
            controllView(new m_memberPlan(t_name[2], t_num[2],ba), UC_MEMBERPLAN);
        }
        private void cusTwo_Click(object sender, EventArgs e)
        {
            controllView(new m_memberPlan(t_name[1], t_num[1],ba), UC_MEMBERPLAN);
        }
        private void cusFour_Click(object sender, EventArgs e)
        {
            controllView(new m_memberPlan(t_name[3], t_num[3],ba), UC_MEMBERPLAN);
        }
        private void cusOne_Click(object sender, EventArgs e)
        {
            controllView(new m_memberPlan(t_name[0], t_num[0],ba), UC_MEMBERPLAN);
        }
    }
}

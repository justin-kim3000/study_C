using _3_project.adapter;
using _3_project.dao;
using _3_project.model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _3_project.ui
{
    partial class m_exercisePlan : UserControl
    {
        const string UC_EXERCISEEASY = "m_exerciseEasy";
        const string UC_EXERCISEMID = "m_exerciseMid";
        const string UC_EXERCISEDIFF = "m_exerciseDiff";

        void controllView(UserControl uc, string viewName)
        {
            Controls.Clear();
            if (!Controls.ContainsKey(viewName))
            {
                Controls.Add(uc);
            }
        }

        BaseAdapter ba;

        public m_exercisePlan()
        {
            InitializeComponent();

        }

        public m_exercisePlan(BaseAdapter ba)
        {
            InitializeComponent();
            this.ba = ba;
        }

        private void initGridView()
        {
            DaoOra ora = ba.Ora;
            List<ExPlan> list = ora.dataShow();
            updateGridView(list);
        }

        private void initGridViewClick(string clickWord)
        {
            DaoOra ora = ba.Ora;
            List<ExPlan> list = ora.dataShow();
            clickUpdateGridView(list, clickWord);
        }

        private void m_exercisePlan_Load(object sender, EventArgs e)
        {
            initGridView();
            Ex_GView.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSlateBlue;
        } 

        private void Ex_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateGridView(List<ExPlan> list)
        {
            Ex_GView.Rows.Clear();

            int cnt = 1;
            foreach (var item in list)
            {
                Ex_GView.Rows.Add(new string[]
                {
                    
                    cnt++.ToString(),item.Ex_clf, item.Ex_type, item.Ex_cal15,
                    item.Ex_cal30, item.Ex_cal60
                });
            }
        }

        private void clickUpdateGridView(List<ExPlan> list, string word)
        {
            Ex_GView.Rows.Clear();

            int cnt = 1;
            foreach (var item in list)
            {
                if (item.Ex_clf == word || item.Ex_type == word)
                {
                    Ex_GView.Rows.Add(new string[]
                {
                    cnt++.ToString(),item.Ex_clf, item.Ex_type, item.Ex_cal15,
                    item.Ex_cal30, item.Ex_cal60
                });
                }
                
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            initGridView();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            initGridViewClick("유산소");
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            initGridViewClick("크로스핏");

        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            initGridViewClick("머신 운동");

        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            initGridViewClick("프리웨이트");

        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string text = uiTextBox1.Text;
            initGridViewClick(text);

        }

        private void uiTextBox1_DoEnter(object sender, EventArgs e)
        {
            string text = uiTextBox1.Text;
            initGridViewClick(text);
        }

        private void uiTextBox1_MouseClick(object sender, EventArgs e)
        {
            uiTextBox1.Text = "";

        }

        private void Ex_easy_button_Click(object sender, EventArgs e)
        {
            controllView(new m_exerciseEasy(), UC_EXERCISEEASY);

        }

        private void Ex_mid_button_Click(object sender, EventArgs e)
        {
            controllView(new m_exerciseMid(), UC_EXERCISEMID);
        }

        private void Ex_diff_button_Click(object sender, EventArgs e)
        {
            controllView(new m_exerciseDiff(),UC_EXERCISEDIFF);
        }

        private void Ex_GView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ex_TextBox_Sum.Text = Ex_GView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(); 
        }

        
    }
}

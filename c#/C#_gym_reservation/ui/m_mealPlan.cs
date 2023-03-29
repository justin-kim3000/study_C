using _3_project.adapter;
using _3_project.dao;
using _3_project.model;
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
    partial class m_mealPlan : UserControl
    {
        BaseAdapter ba;
        public m_mealPlan()
        {
            InitializeComponent();
        }

        public m_mealPlan(BaseAdapter ba)
        {
            InitializeComponent();
            this.ba = ba;
            initGridView();
        }

        private void initGridView()
        {
            DaoOra ora = ba.Ora;
            List<Food> list = ora.dataShowF();
            updateGridView(list);
        }

        private void initGridViewClick(string clickWord)
        {
            DaoOra ora = ba.Ora;
            List<Food> list = ora.dataShowF();
            clickUpdateGridView(list, clickWord);
        }

        private void initGridViewClick2(string clickWord)
        {
            DaoOra ora = ba.Ora;
            List<Food> list = ora.dataShow2();
            clickUpdateGridView2(list, clickWord);
        }

        private void m_mealPlan_Load(object sender, EventArgs e)
        {
            initGridView();
        }

        private void updateGridView(List<Food> list)
        {
            Ex_GView.Rows.Clear();

            int cnt = 1;
            foreach (var item in list)
            {
                Ex_GView.Rows.Add(new string[]
                {

                    cnt++.ToString(), item.Name, item.Calorie, item.Carbohydrate,
                    item.Fat, item.Protein, item.Menu, item.Eat
                });
            }
        }

        private void clickUpdateGridView(List<Food> list, string word)
        {
            Ex_GView.Rows.Clear();
            Ex_GView.Columns[0].HeaderText = "순서";
            int cnt = 1;
            foreach (var item in list)
            {
                if (item.Type == word || item.Name == word || item.Menu == word)
                {
                    Ex_GView.Rows.Add(new string[]
                {
                    cnt++.ToString(), item.Name, item.Calorie, item.Carbohydrate,
                    item.Fat, item.Protein, item.Menu, item.Eat
                });
                }

            }
        }

        private void clickUpdateGridView2(List<Food> list, string word)
        {
            Ex_GView.Rows.Clear();
            Ex_GView.Columns[0].HeaderText = "시간";
            foreach (var item in list)
            {
                if (item.Type == word || item.Name == word || item.Menu == word)
                {
                    Ex_GView.Rows.Add(new string[]
                {
                    item.Eat, item.Name, item.Calorie, item.Carbohydrate,
                    item.Fat, item.Protein, item.Menu, item.Type
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
            initGridViewClick("육류");
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            initGridViewClick("채소류");
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            initGridViewClick("견과류 및 과일");
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            initGridViewClick("생선");
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string text = uiTextBox1.Text;
            initGridViewClick(text);
        }

        private void uiTextBox1_MouseClick(object sender, EventArgs e)
        {
            uiTextBox1.Text = "";

        }

        private void uiTextBox1_DoEnter(object sender, EventArgs e)
        {
            string text = uiTextBox1.Text;
            initGridViewClick(text);
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            initGridViewClick("유제품 및 시리얼");
        }

        private void uiButton7_Click(object sender, EventArgs e)
        {
            initGridViewClick2("다이어트 식단");
        }

        private void uiButton8_Click(object sender, EventArgs e)
        {
            initGridViewClick2("고단백 식단");
        }

        private void uiButton9_Click(object sender, EventArgs e)
        {
            initGridViewClick2("건강 식단");
        }

        private void Ex_GView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiButton10_Click(object sender, EventArgs e)
        {
            initGridViewClick("밥류");
        }

        private void uiButton11_Click(object sender, EventArgs e)
        {
            initGridViewClick("국류");
        }

        
    }
}

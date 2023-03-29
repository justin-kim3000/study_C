using _3_project.adapter;
using _3_project.dao;
using _3_project.model;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _3_project.ui
{
    partial class m_memberPlan : UserControl
    {
        BaseAdapter ba;
        const string UC_MEALPLAN = "m_mealPlan";
        const string UC_EXERCISEPLAN = "m_exercisePlan";
        string[] t_name = new string[4];
        string[] t_num = new string[4];
        string originName;
        string mno;
        int flagex = 0;//운동 플래그 변수
        int flagfo = 0;
        public m_memberPlan()
        {
            InitializeComponent();
        }
        public m_memberPlan(BaseAdapter ba)
        {
            InitializeComponent();
            exPanel.Visible = false;
            exPanel.Location = new Point(650, 10);
            mealPanel.Visible = false;
            mealPanel.Location = new Point(1300, 10);
            mainPlanPanel.Visible = true;
            mainPlanPanel.Location = new Point(0, 0);
            this.ba = ba;
            DaoOra ora = ba.Ora;
            List<Present> list = null;
            list = ora.showData();
            memPlanView.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                memPlanView.Items.Add(new ListViewItem(new string[]
                {
                    list[i].Mno,
                    list[i].Name,
                    list[i].Ptdate,
                    list[i].Pttime,
                    list[i].Exercise,
                    list[i].Menu,
                    list[i].Achievement

                }));
            }
        }
        public m_memberPlan(string name, string num, BaseAdapter ba)
        {
            InitializeComponent();
            exPanel.Visible = false;
            exPanel.Location = new Point(650, 10);
            mealPanel.Visible = false;
            mealPanel.Location = new Point(1300, 10);
            mainPlanPanel.Visible = true;
            mainPlanPanel.Location = new Point(0, 0);
            this.ba = ba;
            DaoOra ora = ba.Ora;
            List<Present> list = null;
            list = ora.showData();
            memPlanView.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name == name)
                {
                    ModName.Text = list[i].Name;
                    ModNum.Text = list[i].Mno;
                    ModTime.Text = list[i].Pttime;
                    ModDate.Text = list[i].Ptdate;
                    ModExer.Text = list[i].Exercise;
                    ModMenu.Text = list[i].Menu;
                   
                }
                memPlanView.Items.Add(new ListViewItem(new string[]
                {
                    list[i].Mno,
                    list[i].Name,
                    list[i].Ptdate,
                    list[i].Pttime,
                    list[i].Exercise,
                    list[i].Menu,
                    list[i].Achievement

                }));
            }
        }
        private void memPlanView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memPlanView.SelectedItems.Count != 0)
            {
                int n = memPlanView.SelectedItems[0].Index;
                string name = memPlanView.Items[n].SubItems[1].Text;
                string ptdate = memPlanView.Items[n].SubItems[2].Text;
                string pttime = memPlanView.Items[n].SubItems[3].Text;
                string exercise = memPlanView.Items[n].SubItems[4].Text;
                string menu = memPlanView.Items[n].SubItems[5].Text;
                ModName.Text = name;
                ModDate.Text = ptdate;
                ModTime.Text = pttime;
                ModExer.Text = exercise;
                ModMenu.Text = menu;
                originName = name;
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            DaoOra ora = ba.Ora;
            List<Present> list = null;
            if (ora != null)
            {
                list = ora.updateData(originName,
                new Present(ModNum.Text,ModName.Text, ModDate.Text,
                    ModTime.Text, ModExer.Text, ModMenu.Text, ModAchievement.Text));
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DaoOra ora = ba.Ora;
            List<Present> list = null;
            if (whatCombo.Text == "이름")
            {
                list = ora.searchName(
               (textsearch.Text));
                memPlanView.Items.Clear();
                for (int i = 0; i < list.Count; i++)
                {

                    memPlanView.Items.Add(new ListViewItem(new string[]
                    {
                    (i + 1)+"",
                    list[i].Name,
                    list[i].Ptdate,
                    list[i].Pttime,
                    list[i].Exercise,
                    list[i].Menu


                    }));

                }
            }
            else if (whatCombo.Text == "번호")
            {
                list = ora.searchMno(
               (textsearch.Text));
                memPlanView.Items.Clear();
                for (int i = 0; i < list.Count; i++)
                {

                    memPlanView.Items.Add(new ListViewItem(new string[]
                    {
                    (i + 1)+"",
                    list[i].Name,
                    list[i].Ptdate,
                    list[i].Pttime,
                    list[i].Exercise,
                    list[i].Menu


                    }));

                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DaoOra ora = ba.Ora;
            ora.AddData( new Present(ModNum.Text,ModName.Text, ModDate.Text,
                ModTime.Text, ModExer.Text, ModMenu.Text, ModAchievement.Text));
            MessageBox.Show("회원 일정이 등록되었습니다.");
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (textsearch.Text == "")
            {
                try
                {
                    //memPlanView.BeginUpdate();
                    // lstView2.Items.Clear();
                    // 리스트뷰 데이터 인서트 작업 ....
                    DaoOra ora = ba.Ora;
                    List<Present> list = null;
                    list = ora.showData();
                    memPlanView.Items.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        memPlanView.Items.Add(new ListViewItem(new string[]
                        {
                    (i + 1)+"",
                    list[i].Name,
                    list[i].Ptdate,
                    list[i].Pttime,
                    list[i].Exercise,
                    list[i].Menu
                        }));
                    }
                }
                finally
                {
                    memPlanView.EndUpdate();
                }
            }
            else
            {
                DaoOra ora = ba.Ora;
                List<Present> list = null;
                list = ora.searchName(
               (textsearch.Text));
                memPlanView.Items.Clear();
                for (int i = 0; i < list.Count; i++)
                {

                    memPlanView.Items.Add(new ListViewItem(new string[]
                    {
                    (i + 1)+"",
                    list[i].Name,
                    list[i].Ptdate,
                    list[i].Pttime,
                    list[i].Exercise,
                    list[i].Menu

                    }));

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

        private void ModMenu_Click(object sender, EventArgs e)
        {

        }

        private void m_memberPlan_Load(object sender, EventArgs e)
        {
            initGridView();
            Ex_GView.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSlateBlue;
        }

        //여기서 부터는 운동 선택 패널에 관한 코드
        private void initGridView()
        {
            DaoOra ora = ba.Ora;
            List<ExPlan> list = ora.dataShow();
            updateGridView(list);
        }
        private void initGridView2()
        {
            DaoOra ora = ba.Ora;
            List<Food> list = ora.dataShowF();
            updateGridView2(list);
        }
        private void updateGridView2(List<Food> list)
        {
            Fo_GView.Rows.Clear();

            int cnt = 1;
            foreach (var item in list)
            {
                Fo_GView.Rows.Add(new string[]
                {

                    cnt++.ToString(), item.Name, item.Calorie, item.Carbohydrate,
                    item.Fat, item.Protein, item.Menu, item.Eat
                });
            }
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
        private void initGridViewClick(string clickWord)
        {
            DaoOra ora = ba.Ora;
            List<ExPlan> list = ora.dataShow();
            clickUpdateGridView(list, clickWord);
        }
        private void initGridViewClick2(string clickWord)
        {
            DaoOra ora = ba.Ora;
            List<Food> list = ora.dataShowF();
            clickUpdateGridView2(list, clickWord);
        }
        private void clickUpdateGridView2(List<Food> list, string word)
        {
            Fo_GView.Rows.Clear();
            Fo_GView.Columns[0].HeaderText = "순서";
            int cnt = 1;
            foreach (var item in list)
            {
                if (item.Type == word || item.Name == word || item.Menu == word)
                {
                    Fo_GView.Rows.Add(new string[]
                {
                    cnt++.ToString(), item.Name, item.Calorie, item.Carbohydrate,
                    item.Fat, item.Protein, item.Menu, item.Eat
                });
                }

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

        private void ModExer_Click(object sender, EventArgs e)
        {
            mainPlanPanel.Visible = false;
            mainPlanPanel.Location = new Point(650, 20);
            exPanel.Visible = true;
            exPanel.Location = new Point(0, 0);
            initGridView();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            initGridView();
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            initGridViewClick("유산소");
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            initGridViewClick("크로스핏");
        }

        private void uiButton1_Click_1(object sender, EventArgs e)
        {
            initGridViewClick("머신 운동");
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            initGridViewClick("프리웨이트");
        }

        private void exSearchBox_MouseClick(object sender, EventArgs e)
        {
            exSearchBox.Text = "";
        }
        private void exSearchButton_Click(object sender, EventArgs e)
        {
            string text = exSearchBox.Text;
            initGridViewClick(text);
        }

        private void exSearchBox_DoEnter(object sender, EventArgs e)//운동일정 검색시 바로 엔터로 검색
        {
            string text = exSearchBox.Text;
            initGridViewClick(text);
        }
        private void Ex_GView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //운동 뷰 더블클릭으로 선택
        {
            switch (flagex)
            {
                case 0:
                    firstEx.Text = Ex_GView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    flagex++;
                    break;
                case 1:
                    secondEx.Text = Ex_GView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    flagex++;
                    break;
                case 2:
                    thirdEx.Text = Ex_GView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    flagex++; break;
                case 3:
                    fourEx.Text = Ex_GView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    flagex++; break;
                default:
                    MessageBox.Show("운동을 너무 많이 선택하셨습니다.");
                    break;
            }
        }
        private void exFinish_Click(object sender, EventArgs e)//운동일정 조합끝 버튼
        {
            exPanel.Visible = false;
            exPanel.Location = new Point(1200, 0);
            mainPlanPanel.Visible = true;
            mainPlanPanel.Location = new Point(0, 0);
            flagex = 0;
            ModExer.Text = firstEx.Text + " " + secondEx.Text + " " + thirdEx.Text + " " + fourEx.Text;
            firstEx.Text = "";
            secondEx.Text = "";
            thirdEx.Text = "";
            fourEx.Text = "";
        }
        private void retry_Click(object sender, EventArgs e)//운동일정 다시하기 버튼
        {
            flagex = 0;
            firstEx.Text = "";
            secondEx.Text = "";
            thirdEx.Text = "";
            fourEx.Text = "";
        }
        //여기까지 운동일정 추가 페이지 설명.

        //회원일정 메인화면 오류로 일부 버튼기능 다시 작성. 버튼 코드 왜 날라갔냐! 
        private void searchButton_Click_1(object sender, EventArgs e)//검색버튼
        {
            DaoOra ora = ba.Ora;
            List<Present> list = null;
            if (whatCombo.Text == "이름")
            {
                list = ora.searchName(
               (textsearch.Text.ToString()));
                memPlanView.Items.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    memPlanView.Items.Add(new ListViewItem(new string[]
                    {
                    list[i].Mno,

                    list[i].Name,
                    list[i].Ptdate,
                    list[i].Pttime,
                    list[i].Exercise,
                    list[i].Menu,
                    list[i].Achievement
                    }));
                }
            }
            else if (whatCombo.Text == "번호")
            {
                list = ora.searchMno(
               (textsearch.Text));
                memPlanView.Items.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    memPlanView.Items.Add(new ListViewItem(new string[]
                    {
                    list[i].Mno,
                    list[i].Name,
                    list[i].Ptdate,
                    list[i].Pttime,
                    list[i].Exercise,
                    list[i].Menu,
                    list[i].Achievement
                    }));
                }
            }
        }
        private void refreshButton_Click_1(object sender, EventArgs e)//새로고침버튼
        {
            if (textsearch.Text == "")
            {
                try
                {
                    //memPlanView.BeginUpdate();
                    // lstView2.Items.Clear();
                    // 리스트뷰 데이터 인서트 작업 ....
                    DaoOra ora = ba.Ora;
                    List<Present> list = null;
                    list = ora.showData();
                    memPlanView.Items.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        memPlanView.Items.Add(new ListViewItem(new string[]
                        {
                    list[i].Mno,
                    list[i].Name,
                    list[i].Ptdate,
                    list[i].Pttime,
                    list[i].Exercise,
                    list[i].Menu,
                    list[i].Achievement
                        }));
                    }
                }
                finally
                {
                    memPlanView.EndUpdate();
                }
            }
            else
            {
                DaoOra ora = ba.Ora;
                List<Present> list = null;
                list = ora.searchName(
               (textsearch.Text));
                memPlanView.Items.Clear();
                for (int i = 0; i < list.Count; i++)
                {

                    memPlanView.Items.Add(new ListViewItem(new string[]
                    {
                    list[i].Mno,
                    list[i].Name,
                    list[i].Ptdate,
                    list[i].Pttime,
                    list[i].Exercise,
                    list[i].Menu,
                    list[i].Achievement
                    }));
                }
            }
        }
        private void updateButton_Click_1(object sender, EventArgs e)//수정버튼
        {
            DaoOra ora = ba.Ora;
            List<Present> list = null;
            if (ora != null)
            {
                list = ora.updateData(originName,
                new Present(ModNum.Text,ModName.Text, ModDate.Text,
                    ModTime.Text, ModExer.Text, ModMenu.Text, ModAchievement.Text));
            }
        }
        private void addButton_Click_1(object sender, EventArgs e)//추가버튼
        {
            
            DaoOra ora = ba.Ora;
            try
            {
                ora.AddData( new Present(ModNum.Text,ModName.Text, ModDate.Text,
                    ModTime.Text, ModExer.Text, ModMenu.Text, ModAchievement.Text));
                MessageBox.Show("회원 일정이 등록되었습니다.");
            }
            catch
            {
                MessageBox.Show("오류발생");
            }
        }
        private void memPlanView_SelectedIndexChanged_1(object sender, EventArgs e)//뷰 마우스 클릭 변경시
        {
            if (memPlanView.SelectedItems.Count != 0)
            {
                int n = memPlanView.SelectedItems[0].Index;
                string mno= memPlanView.Items[n].SubItems[0].Text;
                string name = memPlanView.Items[n].SubItems[1].Text;
                string ptdate = memPlanView.Items[n].SubItems[2].Text;
                string pttime = memPlanView.Items[n].SubItems[3].Text;
                string exercise = memPlanView.Items[n].SubItems[4].Text;
                string menu = memPlanView.Items[n].SubItems[5].Text;
                string achievement = memPlanView.Items[n].SubItems[6].Text;
                ModNum.Text = mno;
                ModName.Text = name;
                ModDate.Text = ptdate;
                ModTime.Text = pttime;
                ModExer.Text = exercise;
                ModMenu.Text = menu;
                ModAchievement.Text = achievement;
                originName = name;
            }
        }
        //메인 회원일정 버튼 기능은 여기까지

        //식단 클릭시 식단 조정 파트
        private void ModMenu_Click_1(object sender, EventArgs e)
        {
            mainPlanPanel.Visible = false;
            mainPlanPanel.Location = new Point(650, 10);
            exPanel.Visible = false;
            exPanel.Location = new Point(1300, 10);
            mealPanel.Visible = true;
            mealPanel.Location = new Point(0, 0);
            initGridView2();
        }


        private void uiButton13_Click(object sender, EventArgs e)
        {
            initGridView2();
        }

        private void uiButton12_Click(object sender, EventArgs e)
        {
            initGridViewClick2("육류");
        }

        private void uiButton11_Click(object sender, EventArgs e)
        {
            initGridViewClick2("채소류");
        }

        private void uiButton10_Click(object sender, EventArgs e)
        {
            initGridViewClick2("견과류 및 과일");
        }

        private void uiButton9_Click(object sender, EventArgs e)
        {
            initGridViewClick2("생선");
        }

        private void uiButton8_Click(object sender, EventArgs e)
        {
            initGridViewClick2("유제품 및 시리얼");
        }

        private void uiTextBox1_MouseClick(object sender, EventArgs e)
        {
            uiTextBox1.Text= null;
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string text = uiTextBox1.Text;
            initGridViewClick2(text);
        }

        private void Fo_GView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (flagfo)
            {
                case 0:
                    firstFo.Text = Fo_GView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    flagfo++;
                    break;
                case 1:
                    secondFo.Text = Fo_GView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    flagfo++;
                    break;
                
                default:
                    MessageBox.Show("식단을 너무 많이 선택하셨습니다.");
                    break;
            }

        }

        private void uiButton15_Click(object sender, EventArgs e)
        {
            flagfo = 0;
            firstFo.Text = "";
            secondFo.Text = "";
            
        }

        private void uiButton14_Click(object sender, EventArgs e)
        {
            exPanel.Visible = false;
            exPanel.Location = new Point(650, 10);
            mainPlanPanel.Visible = true;
            mainPlanPanel.Location = new Point(0, 0);
            mealPanel.Visible = false;
            mealPanel.Location = new Point(1300, 10);
            flagfo = 0;
            ModMenu.Text = firstFo.Text+","+secondFo.Text;
        }

        private void ModName_Click(object sender, EventArgs e)
        {
            exPanel.Visible = false;
            exPanel.Location = new Point(650, 10);
            mainPlanPanel.Visible = false;
            mainPlanPanel.Location = new Point(1300, 0);
            mealPanel.Visible = false;
            mealPanel.Location = new Point(2000, 10);
            namePanel.Visible = true;
            namePanel.Location = new Point(0, 0);
            initGridView3();
        }

        private void uiTextBox2_Click(object sender, EventArgs e)
        {
            uiTextBox2.Text= string.Empty;
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            string text = uiTextBox2.Text;
            DaoOra ora = ba.Ora;
            List<Member> list = ora.m_searchShowData2(text);
            updateListView3(list);
        }
        private void initGridView3()
        {
            DaoOra ora = ba.Ora;
            List<Member> list = ora.m_datashow();
            updateListView3(list);
        }
        private void updateListView3(List<Member> list)
        {
            listMemberInfo.BeginUpdate();
            listMemberInfo.Items.Clear();
            foreach (var item in list)
            {
                listMemberInfo.Items.Add(new ListViewItem(
                new string[] { item.Mno, item.Name, item.Birth, item.Tall, item.Weight, item.Bfp, item.Bmi, item.Tname, item.Gender, item.Tel }));
            }
            listMemberInfo.EndUpdate();
        }

        private void listMemberInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMemberInfo.SelectedItems.Count > 0)
            {
                int n = listMemberInfo.SelectedItems[0].Index;
                string name = listMemberInfo.Items[n].SubItems[1].Text;
                string num= listMemberInfo.Items[n].SubItems[0].Text;
                m_namebox.Text = name;
                m_numbox.Text= num;

            }
        }

        private void m_upd_Click(object sender, EventArgs e)
        {
            m_namebox.Text = "";
            uiTextBox2.Text = "";
            initGridView3();
        }

        private void m_del_Click(object sender, EventArgs e)
        {
            ModName.Text=m_namebox.Text;
            ModNum.Text = m_numbox.Text;
            m_namebox.Text = "";
            uiTextBox2.Text = "";
            namePanel.Visible= false;
            namePanel.Location = new Point(1300, 0);
            mainPlanPanel.Visible = true;
            mainPlanPanel.Location= new Point(0, 0);
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            initGridViewClick2("밥류");
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            initGridViewClick2("국류");
        }

        
    }
}

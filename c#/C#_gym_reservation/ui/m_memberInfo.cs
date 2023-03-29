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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_project.ui
{
    partial class m_memberInfo : UserControl
    {
        BaseAdapter ba;
        string originMno;
        public m_memberInfo()
        {
            InitializeComponent();
        }
        public m_memberInfo(BaseAdapter ba)
        {
            InitializeComponent();
            this.ba = ba;
            initGridView();
            for (int i = 1940; i <= 2022; i++)
            {
                m_birth_year.Items.Add(i.ToString() + "년");
            }
            for (int i = 1; i <= 31; i++)
            {
                if (i <= 9)
                { m_birth_day.Items.Add('0'.ToString() + i.ToString() + "일"); }
                else
                { m_birth_day.Items.Add(i.ToString() + "일"); }
            }
        }
        private void initGridView()
        {
            DaoOra ora = ba.Ora;
            List<Member> list = ora.m_datashow();
            updateListView(list);
        }

        private void m_upd_Click(object sender, EventArgs e)
        {
            List<Member> memlist = null;
            DaoOra ora = ba.Ora;
            string m_gen = string.Empty;
            if (m_gen_male.Checked) { m_gen = "남자"; }
            if (m_gen_female.Checked) { m_gen = "여자"; }
            string m_birth = m_birth_year.Text.ToString() + m_birth_month.Text.ToString() + m_birth_day.Text.ToString();
            if (ora != null)
            {
                memlist = ora.m_updateData(originMno, new Member(m_mno.Text, m_name.Text, m_birth, m_tall.Text, m_weight.Text, m_bfp.Text, m_bmi.Text, m_tname.Text, m_gen, m_tel.Text));
            }
            updateListView(memlist);
        }
        private void updateListView(List<Member> list)
        {
            listMemberInfo.BeginUpdate();
            listMemberInfo.Items.Clear();
            foreach (var item in list)
            {
                listMemberInfo.Items.Add(new ListViewItem(
                new string[] { item.Mno, item.Name, item.Birth, item.Tall, item.Weight, item.Bfp, item.Bmi, item.Tname, item.Gender, item.Tel}));
            }
            listMemberInfo.EndUpdate();
        }
        
        private void m_del_Click(object sender, EventArgs e)
        {
            DaoOra ora = ba.Ora;
            int n = listMemberInfo.SelectedItems[0].Index;
            string mno = listMemberInfo.Items[n].SubItems[0].Text;
            ora.m_deleteData(mno);
            List<Member> list = ora.m_datashow();
            updateListView(list);
        }
        private void m_search_Click(object sender, EventArgs e)
        {
            DaoOra ora = ba.Ora;
            string mno = m_searchbox.Text;
            List<Member> list = ora.m_searchShowData(mno);
            updateListView(list);

        }

        private void listMemberInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMemberInfo.SelectedItems.Count > 0)
            {
                int n = listMemberInfo.SelectedItems[0].Index;
                string mno = listMemberInfo.Items[n].SubItems[0].Text;
                string name = listMemberInfo.Items[n].SubItems[1].Text;
                string birth = listMemberInfo.Items[n].SubItems[2].Text;
                string tall = listMemberInfo.Items[n].SubItems[3].Text;
                string weight = listMemberInfo.Items[n].SubItems[4].Text;
                string bfp = listMemberInfo.Items[n].SubItems[5].Text;
                string bmi = listMemberInfo.Items[n].SubItems[6].Text;
                string gender = listMemberInfo.Items[n].SubItems[7].Text;
                string tel = listMemberInfo.Items[n].SubItems[8].Text;
                string tname = listMemberInfo.Items[n].SubItems[9].Text;
                m_mno.Text = mno;
                m_name.Text = name;
                m_birth_year.Text = birth.Substring(0, 5);
                m_birth_month.Text = birth.Substring(5, 2);
                m_birth_day.Text = birth.Substring(7, 2);
                m_tall.Text = tall;
                m_weight.Text = weight;
                m_bfp.Text = bfp;
                m_bmi.Text = bmi;
                if (gender == "남자") { m_gen_male.Checked = true; }
                if (gender == "여자") { m_gen_female.Checked = true; }
                m_tel.Text = tel;
                m_tname.Text = tname;
                originMno = mno;

            }
        }

        
    }
}

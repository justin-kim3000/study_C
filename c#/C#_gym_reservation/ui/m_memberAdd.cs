using _3_project.adapter;
using _3_project.dao;
using _3_project.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_project.ui
{
    partial class m_memberAdd : UserControl
    {
        BaseAdapter ba;
        string imgPath;
        public m_memberAdd()
        {
            InitializeComponent();
        }

        public m_memberAdd(BaseAdapter ba)
        {
            InitializeComponent();
            this.ba = ba;
            for (int i = 2023; i >= 1940; i--)
            {
                year.Items.Add(i.ToString() + "년");
            }
            for (int i = 1; i <= 31; i++)
            {
                day.Items.Add(i.ToString() + "일");
            }
        }

        
        /*
        private void saveImg_Click(object sender, EventArgs e)
        {
            openFileImg.InitialDirectory = @"C:\";
            openFileImg.Filter = "jpeg 파일(*.jpg)|*.jpg|" +
                "png 파일(*.png)|*.png|" +
                "gif 파일(*.gif)|*.gif|" +
                "모든 파일(*.*)|*.*";
            openFileImg.FilterIndex = 0;
            openFileImg.RestoreDirectory = true;
            openFileImg.ShowDialog();
            imgPath = openFileImg.FileName;

            Image img = Image.FromFile(imgPath);
            picview.SizeMode = PictureBoxSizeMode.StretchImage;
            picview.Image = img;
        }
        */

        private void memAdd_Click(object sender, EventArgs e)
        {
            DaoOra ora = ba.Ora;
            string gender = string.Empty;
            if (man.Checked) { gender = "남자"; }
            else if (women.Checked) { gender = "여자"; }
            string birth = year.SelectedItem.ToString() +
                month.SelectedItem.ToString() +
                day.SelectedItem.ToString();


            ora.insertData(new Member(mno.Text, name.Text,
                birth, tall.Text, weight.Text,
                bfp.Text, bmi.Text,  gender, tel.Text, tname.Text), imgPath);
            MessageBox.Show("회원정보가 등록되었습니다.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileImg.InitialDirectory = @"C:\";
            openFileImg.Filter = "jpeg 파일(*.jpg)|*.jpg|" +
                "png 파일(*.png)|*.png|" +
                "gif 파일(*.gif)|*.gif|" +
                "모든 파일(*.*)|*.*";
            openFileImg.FilterIndex = 0;
            openFileImg.RestoreDirectory = true;
            openFileImg.ShowDialog();
            imgPath = openFileImg.FileName;

            Image img = Image.FromFile(imgPath);
            picview.SizeMode = PictureBoxSizeMode.StretchImage;
            picview.Image = img;
        }
    }
}

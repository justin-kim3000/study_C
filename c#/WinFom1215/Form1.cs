using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFom1215
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label2.Text = checkBox2.Text;
                label2.Visible = true;

            }
            else if (checkBox1.Checked == false)
            {
                //checkBox1.Text = temp1;
                //label1.Text = string.Empty;
                label1.Visible = false;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                label3.Text = checkBox3.Text;
                label3.Visible = true;

            }
            else if (checkBox3.Checked == false)
            {
                //checkBox1.Text = temp1;
                //label1.Text = string.Empty;
                label3.Visible = false;

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                label4.Text = checkBox4.Text;
                label4.Visible = true;

            }
            else if (checkBox4.Checked == false)
            {
                //checkBox1.Text = temp1;
                //label1.Text = string.Empty;
                label4.Visible = false;

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                label5.Text = checkBox5.Text;
                label5.Visible = true;

            }
            else if (checkBox5.Checked == false)
            {
                //checkBox1.Text = temp1;
                //label1.Text = string.Empty;
                label5.Visible = false;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Text = checkBox1.Text;
                label1.Visible = true;

            }
            else if (checkBox1.Checked == false)
            {
                //checkBox1.Text = temp1;
                //label1.Text = string.Empty;
                label1.Visible = false;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // picture 박스에 이미지 넣기
            pictureBox1.Image = Properties.Resources.개;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.고양이;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.호랑이;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.돼지;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.말;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            Console.WriteLine(index);
            //var item11 = comboBox1.Items[index].ToString();
            //Console.WriteLine(item11);
            //pictureBox1.Image = Properties.Resources.item11;
            switch (index) {
                case 0:
                    pictureBox1.Image = Properties.Resources.개;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.고양이;
                    break ;
                case 2:
                    pictureBox1.Image = Properties.Resources.호랑이;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.돼지;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.말;
                    break;
            }

        }
    }
}

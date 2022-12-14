using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFom1214
{
    public partial class Form1 : Form
    {
        DateTime curDate;
        public Form1()
        {
            InitializeComponent();
            curDate = DateTime.Now;
            Console.WriteLine(getNowTime().ToString());
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // button1 컨트롤과 button1_click 이벤트핸들러 연결
            // click 이벤트 감지
            curDate = DateTime.Now;
            MessageBox.Show("C# 윈폼 앱\n"+getNowTime().ToString());
            //MessageBox.Show("현재시간: " + DateTime.Now.ToString());
            button2.Text=getNowTime().ToString();

        }

        public DateTime getNowTime()
        {
            return curDate;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBox1.Text);
            label1.Text=textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }
    }
}

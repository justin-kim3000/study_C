using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace WinFom1214
{
    public partial class Calc : Form
    {
        // 간단한 계산기
        public Calc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n2 = ((Button)sender).Text;
            if (n2 == null)
            {
                Console.WriteLine("err");
            }
            else
            {
                int result = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
                label1.Text = result.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
            label1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
            label1.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
            result = Math.Round(result,2);
            label1.Text = result.ToString();
        }
    }
}

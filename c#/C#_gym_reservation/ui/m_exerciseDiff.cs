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
    public partial class m_exerciseDiff : UserControl
    {


        const string UC_EXERCISEWALK = "m_exercise_walk";
        const string UC_EXERCISESQUAT = "m_exercise_squat";
        const string UC_EXERCISEBENCHPRESS = "m_exercise_benchpress";
        void controllView(UserControl uc, string viewName)
        {
            Controls.Clear();
            if (!Controls.ContainsKey(viewName))
            {
                Controls.Add(uc);
            }
        }

        public m_exerciseDiff()
        {
            InitializeComponent();
        }

        private void sqtButton_Click(object sender, EventArgs e)
        {
            controllView(new m_exercise_squat(), UC_EXERCISESQUAT);

        }

        private void benchPressButton_Click(object sender, EventArgs e)
        {
            controllView(new m_exercise_benchpress(), UC_EXERCISEBENCHPRESS);
        }
    }
}

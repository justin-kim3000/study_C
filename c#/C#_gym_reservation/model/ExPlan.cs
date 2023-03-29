using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_project.model
{
    internal class ExPlan
    {
        string ex_clf;
        string ex_type;
        string ex_cal15;
        string ex_cal30;
        string ex_cal60;

        public ExPlan(string ex_clf, string ex_type, string ex_cal15, string ex_cal30, string ex_cal60)
        {
            this.Ex_clf = ex_clf;
            this.Ex_type = ex_type;
            this.Ex_cal15 = ex_cal15;
            this.Ex_cal30 = ex_cal30;
            this.Ex_cal60 = ex_cal60;
        }

        public string Ex_clf { get => ex_clf; set => ex_clf = value; }
        public string Ex_type { get => ex_type; set => ex_type = value; }
        public string Ex_cal15 { get => ex_cal15; set => ex_cal15 = value; }
        public string Ex_cal30 { get => ex_cal30; set => ex_cal30 = value; }
        public string Ex_cal60 { get => ex_cal60; set => ex_cal60 = value; }
    }
}

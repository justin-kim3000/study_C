using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2_1209
{
    internal class Name
    {
        private string[] first = { "김", "박", "이","최","장"};

        public Name(string[] first)
        {
            this.first = first;
        }

        private string[] mid = {"가", "나", "다", "라", "마"};
        private string[] last = {"바", "사", "아", "자", "차"};

        private string name;
        public Name()
        {
            this.name = first[0] + mid[0] + last[0];
        }

        public string RandName()
        {
            Random r = new Random();
            int firstRand = r.Next(first.Length);
            int midRand = r.Next(mid.Length);
            int lastRand = r.Next(last.Length);
            string name = first[firstRand] + mid[midRand]+last[lastRand];
            return name;
        }
    }
}

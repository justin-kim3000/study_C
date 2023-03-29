using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_project
{
    internal class Present
    {
        string mno;
        string name;
        string ptdate;
        string pttime;
        string exercise;
        string menu;
        string achievement;


        public Present(string mno,string name, string ptdate, string pttime, string exercise, string menu, string achievement)
        {
            this.mno = mno;
            this.name = name;
            this.ptdate = ptdate;
            this.pttime = pttime;
            this.exercise = exercise;
            this.menu = menu;
            this.achievement = achievement;
        }
        public string Mno { get => mno; set=>mno=value; }
        public string Name { get => name; set => name = value; }
        public string Ptdate { get => ptdate; set => ptdate = value; }
        public string Pttime { get => pttime; set => pttime = value; }
        public string Exercise { get => exercise; set => exercise = value; }
        public string Menu { get => menu; set => menu = value; }
        public string Achievement { get => achievement; set => achievement = value; }
    }
}
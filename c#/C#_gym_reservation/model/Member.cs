using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_project.model
{
    internal class Member
    {
        string mno;
        string name;
        string birth;
        string tall;
        string weight;
        string bfp;
        string bmi;
        string tname;
        string gender;
        string tel;
        string time;
        string tno;
        string tid;
        string tpw;
        string pttime;

        public Member(string mno, string name, string birth, string tall, string weight,
            string bfp, string bmi, string tname, string gender, string tel)
        {
            this.mno = mno;
            this.name = name;
            this.birth = birth;
            this.tall = tall;
            this.weight = weight;
            this.bfp = bfp;
            this.bmi = bmi;
            this.tname = tname;
            this.gender = gender;
            this.tel = tel;
        }
        public Member(string mno, string name, string pttime)
        {
            this.mno = mno;
            this.name = name;
            this.pttime = pttime;
        }
        public Member(string tname, string tid, string tpw, string tno)
        {
            this.tname = tname;
            this.tid = tid;
            this.tpw = tpw;
            this.tno = tno;
        }
        public string Tno { get => tno; set => tno = value; }
        public string Tpw { get => tpw; set => tpw = value; }
        public string Tid { get => tid; set => tid = value; }
        public string Mno { get => mno; set => mno = value; }
        public string Name { get => name; set => name = value; }
        public string Birth { get => birth; set => birth = value; }
        public string Tall { get => tall; set => tall = value; }
        public string Weight { get => weight; set => weight = value; }
        public string Bfp { get => bfp; set => bfp = value; }
        public string Bmi { get => bmi; set => bmi = value; }
        public string Tname { get => tname; set => tname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Time { get => time; set => time = value; }
        public string Pttime {  get => pttime; set => pttime = value; } 
    }
}

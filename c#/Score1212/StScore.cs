using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score1212
{
    internal class StScore
    {
        private int kor;
        private int math;
        private int eng;
        private int hap;
        private int avg;
        private string hakjum;

        public StScore(int kor, int math, int eng)
        {
            this.kor = kor;
            this.math = math;
            this.eng = eng;
        }

        public int getHap()
        {
            hap = kor + math + eng;
            return hap;
        }

        public int getAvg()
        {
            avg = hap / 3;
            return avg;
        }

        public string getHakjum()
        {
            if (avg >= 90 && avg <= 100) hakjum = "A학점";
            else if (avg >= 80 && avg <= 89) hakjum = "B학점";
            else if (avg >= 70 && avg <= 79) hakjum = "C학점";
            else if (avg >= 60 && avg <= 69) hakjum = "D학점";
            else hakjum = "F학점";

            return hakjum;
        }
    }
}

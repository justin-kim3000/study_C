using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score1212
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                int kor = RandData.getScore();
                int eng = RandData.getScore();
                int math = RandData.getScore();
                StScore[] stArr = new StScore[5];
                stArr[i] = new StScore(kor, eng, math);
                Console.WriteLine("번호: {0}",i+1);
                Console.WriteLine("국어 : {0}, 영어: {1}, 수학: {2}", kor, eng, math);
                Console.WriteLine("총합: {0}, 평균: {1}, 학점: {2}", stArr[i].getHap(), stArr[i].getAvg(), stArr[i].getHakjum());
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                int kor = RandData.getScore();
                int eng = RandData.getScore();
                int math = RandData.getScore();
                List<StScore> stList = new List<StScore>();
                stList.Add(new StScore(kor, eng, math));
                Console.WriteLine("번호: {0}", i + 1);
                Console.WriteLine("국어 : {0}, 영어: {1}, 수학: {2}", kor, eng, math);
                Console.WriteLine("총합: {0}, 평균: {1}, 학점: {2}", stList[i].getHap(), stList[i].getAvg(), stList[i].getHakjum());
                Console.WriteLine();
            }
        }

    }
}

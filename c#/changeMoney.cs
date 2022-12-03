using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // 동전 교환 프로그램

            Console.Write("돈을 입력하시오. : ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int won500 = n2 / 500;
            int won100 = n2 % 500 / 100;
            int won50 = n2 % 500 % 100 / 50;
            int won10 = n2 % 500 % 100 % 50 / 10;
            int wonelse = n2 % 500 % 100 % 50 % 10;



            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("동전 교환 프로그램");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("오백원 갯수 : {0}", won500);
            Console.WriteLine("백원 갯수 : {0}", won100);
            Console.WriteLine("오십원 갯수 : {0}", won50);
            Console.WriteLine("십원 갯수 : {0}", won10);
            Console.WriteLine("잔돈 갯수 : {0}", wonelse);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("년도 입력하시오. : ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("년도별 윤년 구별 프로그램");
            Console.WriteLine("---------------------------------------------------------------");

            if (n2%4 == 0 & n2%100 != 0)
            {
                Console.WriteLine("{0}는 윤년입니다.",n2);
            }
            else if (n2 % 400 == 0)
            {
                Console.WriteLine("{0}는 윤년입니다.", n2);
            }
            else
            {
                Console.WriteLine("{0}는 윤년이 아닙니다.", n2);
            }
            */

            
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("담배 자판기 프로그램");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("1. 에쎄 그랜드 리프 6000원");
            Console.WriteLine("2. 에쎄 스페셜 리프 5000원");
            Console.WriteLine("3. 에쎄 골든 리프 4500원");
            Console.WriteLine("4. 에쎄 실버 리프 4500원");
            Console.WriteLine("5. 에쎄 브론즈 리프 4500원");
            Console.Write("담배를 선택하시오. : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            string ch1 = "에쎄 그랜드 리프";
            string ch2 = "에쎄 스페셜 리프";
            string ch3 = "에쎄 골든 리프";
            string ch4 = "에쎄 실버 리프";
            string ch5 = "에쎄 브론즈 리프";
            int val1 = 6000;
            int val2 = 5000;
            int val3 = 4500;
            int val4 = 4500;
            int val5 = 4500;


            switch (n1)
            {
                case 1:
                    Console.WriteLine("{0}을 선택하셨습니다.",ch1);
                    Console.Write("금액을 입력하시오=> ");
                    int won1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0}을 구매하셨습니다. 거스름돈 {1}을 받으세요.", ch1,won1-val1);
                    break;
                case 2:
                    Console.WriteLine("{0}을 선택하셨습니다.", ch2);
                    Console.Write("금액을 입력하시오=> ");
                    int won2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0}을 구매하셨습니다. 거스름돈 {1}을 받으세요.", ch2, won2 - val2);
                    break;
                case 3:
                    Console.WriteLine("{0}을 선택하셨습니다.", ch3);
                    Console.Write("금액을 입력하시오=> ");
                    int won3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0}을 구매하셨습니다. 거스름돈 {1}을 받으세요.", ch3, won3 - val3);
                    break;
                case 4:
                    Console.WriteLine("{0}을 선택하셨습니다.", ch4);
                    Console.Write("금액을 입력하시오=> ");
                    int won4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0}을 구매하셨습니다. 거스름돈 {1}을 받으세요.", ch4, won4 - val4);
                    break;
                case 5:
                    Console.WriteLine("{0}을 선택하셨습니다.", ch1);
                    Console.Write("금액을 입력하시오=> ");
                    int won5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0}을 구매하셨습니다. 거스름돈 {1}을 받으세요.", ch5, won5 - val5);
                    break;
                default:
                    Console.WriteLine("1~5 선택하시오");
                    break;
            }


        }
    }
}

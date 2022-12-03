using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 문자열 타입
            string str = "홍길동";
            bool b = false;
            //무한 루프
            //while(true)
            //for(; ; )

            foreach (var st in str)
            {
                Console.WriteLine(st);
            }

            // 이중 반복문
            int num = 1;
            for (int i = 0; i < 10; i++)         //행
            {
                for (int j = 0; j < 5; j++)     //열
                {
                    Console.Write("{0}\t",num++);
                }
                Console.WriteLine();
            }

            // 구구단
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("{0}X{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }

        }
    }
}

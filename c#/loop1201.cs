using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop1201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 반복문
            // for,while, do-while,foreach
            string[] arr1 = { "Hown", "Kim","Park"};

            int[] ints = { 10, 20, 30 };
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }

            //모든 타입 가능 - var
            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }

            foreach (var i in arr1)
            {
                Console.WriteLine(i);
            }
            */
            Console.Write("시작점을 입력하세요: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("마지막점을 입력하세요: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            for (int i = n1; i < n2+1; i++)
            {
                temp += i;
            }
            Console.WriteLine(temp);

            // 구구단
            Console.Write("구구단 시작점을 입력하세요: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",n3,i,n3*i);
            }

            int n4 = Convert.ToInt32(Console.ReadLine());

        }
    }
}

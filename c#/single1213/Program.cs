using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single1213
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("기존 객체 재사용 싱글톤 =========");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(SingleTest.getInstance().getData());
            }

            Console.WriteLine("새로운 객체 생성 =========");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(new SingleTest().getData());
            }
        }
    }
}

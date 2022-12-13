using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90,100 };
            ArraySum arrsum = new ArraySum(arr);
            Console.WriteLine("합:" + arrsum.getSum()+ "평균: " + arrsum.getAvg());
        }
    }
}

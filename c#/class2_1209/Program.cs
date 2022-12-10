using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2_1209
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.ShowInfo();
            Car car1 = new Car("porch","yellow","718","일억오천만원");
            car1.ShowInfo();

            string color = car1.Color;
            Console.WriteLine(color);

            int[] numb = { 1, 2, 3, 4, 5 };
            Sum sum = new Sum(numb);
            Sum sum2 = new Sum();

            Console.WriteLine(sum.sum_arr());
            Console.WriteLine(sum.mean_arr());
            Console.WriteLine(sum2.sum_arr());
            Console.WriteLine(sum2.mean_arr());

            RandName randName = new RandName();
            Console.WriteLine(randName.RName());

        }
    }
}

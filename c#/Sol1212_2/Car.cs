using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol1212_2
{
    internal class Car
    {

        private string model;
        private string color;
        private int year;
        private string company;


        public Car(string model, string color, int year, string company)
        {
            this.model = model;
            this.color = color;
            this.year = year;
            this.company = company;
        }

        public void printCarInfo()
        {
            Console.WriteLine("모델: "+ model);
            Console.WriteLine("색상: "+ color);
            Console.WriteLine("년식: " + year);
            Console.WriteLine("제조사: " + company);

        }
    }
}

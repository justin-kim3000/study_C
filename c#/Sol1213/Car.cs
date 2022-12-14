using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol1213
{
    internal class Car
    {
        private string model;
        private string year;
        private string company;
        private string color;

        public Car(string model, string year, string company, string color)
        {
            this.Model = model;
            this.Year = year;
            this.Company = company;
            this.Color = color;
        }

        public string Model { get => model; set => model = value; }
        public string Year { get => year; set => year = value; }
        public string Company { get => company; set => company = value; }
        public string Color { get => color; set => color = value; }

        public void printCarInfo()
        {
            Console.WriteLine("모델: " + model);
            Console.WriteLine("연식: " + year);
            Console.WriteLine("회사: " + company);
            Console.WriteLine("색상: " + color);
        }
    }
}

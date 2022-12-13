using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1212
{
    internal class Car
    {
        public static string DAERIJUM = "동대구영업소";
        private string company;
        private string price;
        private string color;
        private string model;

        public Car()
        {
            company = "기아";
            color = "검정";
            model = "K7";
            price = "4천만원";
        }

        public Car(string company, string price, string color, string model)
        {
            this.company = company;
            this.price = price;
            this.color = color;
            this.model = model;
        }

        public void showCar()
        {
            Console.WriteLine("대리점:" + DAERIJUM);
            Console.WriteLine("회사:" + company);
            Console.WriteLine("가격:" + price);
            Console.WriteLine("모델:" + model);
            Console.WriteLine("색상:" + color);
        }

        public void setModel(string model) 
        {
            this.model=model;
        }

        public string getModel() 
        {
            return model;
        }

        public void setPrice(string price)
        {
            this.price = price;
        }

        public string getPrice()
        {
            return price;
        }

    }
}

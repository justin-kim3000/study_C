using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2_1209
{
    internal class Car
    {
        public static string AGENCY = "동대구 영업소";
        private string maker;
        public string Maker
        {
            get { return maker; }
            set { maker = value; }
        }
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string price;
        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public Car()
        {
            this.maker = "기아";
            this.color = "블랙";
            this.name = "k7";
            this.price = "사천만원";
        }

        public Car(string maker, string color, string name, string price)
        {
            this.maker = maker;
            this.color = color;
            this.name = name;
            this.price = price;
        }

        


        public void ShowInfo()
        {
            Console.WriteLine("제조사: "+maker);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("이름: " + name);
            Console.WriteLine("가격: " + price);
        }
    }
}

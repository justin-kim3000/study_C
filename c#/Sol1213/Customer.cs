using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol1213
{
    internal class Customer
    {
        private string name;
        private string tel;
        private string addr;
        private Car car;

        public Customer(string name, string tel, string addr, Car car)
        {
            this.Name = name;
            this.Tel = tel;
            this.Addr = addr;
            this.Car = car;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Addr { get => addr; set => addr = value; }
        internal Car Car { get => car; set => car = value; }

        public void printCustomerInfo()
        {
            car.printCarInfo();
            Console.WriteLine("이름: " + name);
            Console.WriteLine("전화: " + tel);
            Console.WriteLine("주소: " + addr);

        }
    }
}

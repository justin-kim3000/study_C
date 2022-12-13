using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol1212_2
{
    internal class Customer
    {
        private string name;
        private string tel;
        private string address;


        public Customer(string name, string tel, string address)
        {
            this.name = name;
            this.tel = tel;
            this.address = address;
        }

        public void printCustomerInfo()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("전화번호: " + tel);
            Console.WriteLine("주소: " + address);
        }
    }
}

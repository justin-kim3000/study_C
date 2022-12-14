using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol1213
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandData rd = new RandData();
            List<Customer> cuList = new List<Customer>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + "번째");
                cuList.Add(new Customer(rd.getName(), rd.getTel(), rd.getAddr(),
                    new Car(rd.getModel(), rd.getYear(), rd.getCompany(), rd.getColor())));
                cuList[i].printCustomerInfo();
                Console.WriteLine("------------------------------");
            }
        }
    }
}

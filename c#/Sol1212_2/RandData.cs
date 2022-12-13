using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol1212_2
{
    internal class RandData
    {

        private string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
        private string[] tel = {"010-1234-5678", "010-4321-5678", "010-3478-1278",
                     "010-4523-1978", "010-7890-2134"};
        private string[] address = {"대구시 동구 신암4동", "서울시 동구 신암4동",
             "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
        private string[] model = { "SM6", "쏘나타", "싼타페", "K7", "그랜져" };
        private string[] color = { "블랙", "은색", "흰색", "회색", "빨강" };
        private int[] year = { 2016, 2017, 2016, 2017, 2016 };
        private string[] company = { "삼성르노", "현대", "현대", "기아", "현대" };

        Random random = new Random();

        Customer[] customers = new Customer[10];
        Car[] cars = new Car[10];




        public void randPick()
        {
            for (int i = 0; i < 10; i++)
            {
                int namePick = random.Next(name.Length);
                int telPick = random.Next(tel.Length);
                int addressPick = random.Next(address.Length);
                int modelPick = random.Next(model.Length);
                int colorPick = random.Next(color.Length);
                int yearPick = random.Next(year.Length);
                int companyPick = random.Next(company.Length);
\

                customers[i] = new Customer(name[namePick], tel[telPick], address[addressPick]);
                cars[i] = new Car(model[modelPick], color[colorPick], year[yearPick],company[companyPick]);

                Console.WriteLine((i + 1) + "번째 고객");
                customers[i].printCustomerInfo();
                cars[i].printCarInfo();
                Console.WriteLine();
            }
        }

    }
}

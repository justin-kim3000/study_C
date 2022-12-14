using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol1213_1
{
    internal class RandData
    {
        string[] name = { "홍길동", "김길동", "박길동", "최길동", "이길동" };
        int[] age = { 100, 200, 300, 400, 500 };
        char[] gender = { '남', '여' };
        string[] addr = { "대구 동구 11동", "서울 동구 신천11동", "대구 남구 신천4동", "북구 신림 1동" };
        Random random = new Random();
        public string getName()
        {
            return name[random.Next(name.Length)];
        }
        public int getAge()
        {
            return age[random.Next(age.Length)];
        }

        public char getGender()
        {
            return gender[random.Next(gender.Length)];
        }
        public string getAddr()
        {
            return addr[random.Next(addr.Length)];
        }
    }
}

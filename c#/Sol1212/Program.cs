using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol1212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] name = {"홍길동", "김길동", "박길동", "이길동", "최길동"};
            int[] age = { 20, 25, 30, 35, 40 };
            char[] gender = { '남', '여' };
            string[] address = {"대구시 동구 신암4동", "서울시 동구 신암4동",
                 "부산시 동구 신암4동", "인천시 동구 신암4동", "광주시 동구 신암4동"};
            Random random = new Random();
            Student[] std = new Student[10];
            for (int i = 0; i < 10; i++)
            {
                int namePick = random.Next(name.Length);
                int agePick = random.Next(age.Length);
                int genderPick = random.Next(gender.Length);
                int addressPick = random.Next(address.Length);

                if (i != 9)
                {
                    std[i] = new Student(name[namePick], age[agePick], gender[genderPick], address[addressPick]);
                    Console.WriteLine((i + 1) + "번");
                    std[i].showStudentInfo();
                    Console.WriteLine("--------------------------");
                }
                else
                {
                    std[i] = new Student("전우치",24,'남',"조선 한양인근 두메산골");
                    Console.WriteLine((i + 1) + "번");
                    std[i].showStudentInfo();
                    Console.WriteLine("--------------------------");
                }

            }
        
        }
    }
}

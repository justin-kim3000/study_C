using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol1213_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student("전우치",20,'남',"사랑시 고백구 행복동");
            RandData rd = new RandData();
            List<Student> stList = new List<Student>();
            Student[] stArr = new Student[10];

            for (int i = 0; i < stArr.Length; i++)
            {
                stArr[i] = new Student(rd.getName(),rd.getAge(),rd.getGender(),rd.getAddr());
                stList.Add(new Student(rd.getName(), rd.getAge(), rd.getGender(), rd.getAddr()));
                Console.WriteLine((i + 1) + " 번");
                stArr[i].showStudentInfo();
                Console.WriteLine("------------------------------------");

                Console.WriteLine((i + 1) + " 번");
                stList[i].showStudentInfo();
                Console.WriteLine("------------------------------------");

            }
        }
    }
}

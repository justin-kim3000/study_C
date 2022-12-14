using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol1213_1
{
    internal class Student
    {
        private string name;
        private int age;
        private char gender;
        private string addr;

        // C# 전용 getter/setter --> property
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Addr { get => addr; set => addr = value; }


        public Student(string name, int age, char gender, string addr)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.addr = addr;
        }

        public void showStudentInfo()
        {
            Console.WriteLine("이름: "+ name);
            Console.WriteLine("나이: "+ age);
            Console.WriteLine("성별: "+ gender);
            Console.WriteLine("주소: "+ addr);
        }


    }
}

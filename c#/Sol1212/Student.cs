using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sol1212
{
    internal class Student
    {
        private string name;
        private int age;
        private char gender;
        private string address;

        // 프라퍼티 brpoperty
        public string Name {  get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public char Gender { get { return gender; } set { gender = value; } }
        public string Address { get { return address; } set { address = value; } }




        public Student(string name, int age, char gender, string address)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }

        public void showStudentInfo()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("나이: " + age);
            Console.WriteLine("성별: " + gender);
            Console.WriteLine("주소: " + address);
        }
    }
}

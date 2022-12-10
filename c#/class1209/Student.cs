using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1209
{
    // 학생 클래스
    internal class Student
    {
        // 추상화: 객체의 속성을 빠르게 파악
        // 캡슐화: 정보(변수)를 은닉
        private int id;
        // 캡슐화
        private string name;
        private int age;
        private string addr;
        // 클래스 변수 - 메모리에 1개만 잡히며 공유하게된다.
        public static string SCHOOL = "경북학교";

        // 사용자가 정의한 기본 생성자
        public Student()
        {
            id = 1;
            name = "전우치";
            age = 500;
            addr = "강원도 산골";
        }

        // 생성자
        public Student(int id, string name, int age, string addr)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.addr = addr;
        }
        // setter
        public void setId(int id)
        {
            // this:
            this.id = id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setAddr(string addr)
        {
            // this:
            this.addr = addr;
        }

        // getter
        public int getId()
        {
            return this.id;
        }

        public string getName()
        {
            return this.name;
        }

        public int getAge()
        {
            return this.age;
        }

        public string getAddr()
        {
            return this.addr;
        }

        public void showInfo()
        {
            Console.WriteLine("학교 : " + SCHOOL);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("name: " + name);
            Console.WriteLine("age: " + age);
            Console.WriteLine("addr: " + addr);

        }


        public static string getSchool()
        {
            return SCHOOL;
        }

/*        // static 안에 인스턴스 변수는 사용 불가
        public static void showInfo2()
        {
            Console.WriteLine("학교 : " + SCHOOL);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("name: " + name);
            Console.WriteLine("age: " + age);
            Console.WriteLine("addr: " + addr);

        }*/
    }
}

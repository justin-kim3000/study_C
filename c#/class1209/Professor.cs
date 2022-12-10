using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1209
{
    internal class Professor
    {

        private int id;
        // 캡슐화
        private string name;
        private int age;
        private string addr;

        // 사용자가 정의한 기본 생성자
        public Professor()
        {
            id = 1;
            name = "선생님";
            age = 500;
            addr = "강원도 산골";
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
            Console.WriteLine("Id: " + id);
            Console.WriteLine("name: " + name);
            Console.WriteLine("age: " + age);
            Console.WriteLine("addr: " + addr);

        }
    }
}

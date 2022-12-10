using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1209
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 교수 클래스 생성
            // 속성 3개 이상 생성
            // setter, getter
            // 속성의 모든 정보를 출력하는 메소드


            // 학생 클래스 객체 생성
            // 괄호가 비어있는 생성자 - 기본 생성자
            Student st = new Student(); // 생성자
            Professor prof = new Professor();

            prof.setId(1);
            prof.setName("서생");
            prof.setAge(80);
            prof.setAddr("조선 한양시");


            st.setId(1);
            st.setName("홍길동");
            st.setAge(15);
            st.setAddr("조선 한양시");
            //Console.WriteLine("id: "+st.getId());
            //Console.WriteLine("name: {0}" , st.getName());


            Student st2 = new Student();
            st.showInfo();
            st2.showInfo();

            Console.WriteLine("교수 정보 ");
            prof.showInfo();

            Student st3 = new Student(333, "이순신", 300,"한산도");
            st3.showInfo();
            Console.WriteLine("학교: " + Student.getSchool());
            Console.WriteLine("학교: " + Student.SCHOOL);


        }
    }
}

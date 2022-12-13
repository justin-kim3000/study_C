using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1212
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Car 클래스를 기본생성자를 통해서 객체 생성
            Car car = new Car();
            car.showCar();
            new Car().showCar();

            Car car2 = new Car("현대", "6천만원", "파랑색", "그랜저");
            car2.showCar();
        }
    }
}

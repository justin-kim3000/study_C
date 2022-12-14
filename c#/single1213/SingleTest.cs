using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single1213
{
    internal class SingleTest
    {
        private static SingleTest inst;
        private int data;
        static Random r = new Random();
        public SingleTest()
        {
            data = r.Next(100);

        }
        public static SingleTest getInstance()
        {
            if (inst == null) inst = new SingleTest();
            return inst;
        }

        public int getData() { return data; }
    }
}

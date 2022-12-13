using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Array1212
{
    internal class ArraySum
    {
        private int sum;
        private int avg;
        private int[] arr;


        public ArraySum(int[] arr)
        {
            this.arr = arr;
            foreach (var item in arr)
            {
                sum += item;
            }
            avg = sum / arr.Length;
        }
        public int getSum()
        {
            return sum;
        }
        public int getAvg()
        {
            return avg;
        }
    }
}


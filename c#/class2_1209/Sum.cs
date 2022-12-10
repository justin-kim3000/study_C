using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2_1209
{
    internal class Sum
    {
        private int [] arr1 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        public Sum()
        {
            this.arr1 = arr1;
        }
        public Sum(int[] arr)
        {
            this.arr1 = arr;
        }

        public int sum_arr()
        {
            int sum_arr = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum_arr += arr1[i];
            }
            return sum_arr;
        }
        public int mean_arr()
        {
            int sum_arr = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum_arr += arr1[i];
            }
            return sum_arr/arr1.Length;
        }
    }
}

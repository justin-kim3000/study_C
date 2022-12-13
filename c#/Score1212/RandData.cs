using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Score1212
{
    internal class RandData
    {
        private static int[] score =
        {
            10,20,30,40,50,60,70,80,90,100
        };
        static Random random = new Random();
        public static int getScore()
        {
            return score[random.Next(score.Length)];
        }
    }
}

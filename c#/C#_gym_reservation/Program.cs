using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_project
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new m_MainForm());

        }
        public static int iLocationX = 1; //x좌표 변수
        public static int iLocationY = 0; //y좌표 변수
        public static bool bCheck = true; //플래그 변수 ->이미지나 라벨의 움직임 여부 파악용
        public static int flag_timer = 0;
    }
}

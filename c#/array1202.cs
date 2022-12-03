using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array1202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1차원 배열 초기화 1
            int[] arrInt = {10,20,30};
            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.Write(arrInt[i]+"\t");
            }
            Console.WriteLine();

            // 1차원 배열 초기화 2
            // new 는 객체를 생성함.
            char[] arrChar = new char[]
            {
                '홍','김','최'
            };
            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.Write(arrChar[i] + "\t");

            }
            Console.WriteLine();

            // 1차원 배열 초기화 3
            // 빈배열을 생성할 경우에는 반드시
            // 아래와 같은 방법 사용
            string[] arrStr = new string[5];
            // Randonm클래스 객체 생성
            Random rand = new Random();

            string[] name = new string[]
            {
                "홍길동","김길동","박길동"
            };

            for (int i = 0; arrStr.Length>i; i++)
            {
                //int n = rand.Next(3); //0~2
                //arrStr[i] = name[n];
                arrStr[i] = name[rand.Next(3)];
                Console.WriteLine(arrStr[i]);
            }
            */

            /*
            // 1. 빈 배열 크기 20을 생성한 후, 아래의 이름들을 랜덤하게 추가 하시오.
            // 2. 배열에 추가된 이름의 빈도수를 출력하시오.
            
            // 랜덤 이름 배열 생성
            string[] name2 = new string[]
            {
                "홍길동","김길동", "박길동", "이길동", "최길동"
            };
            // 랜덤 함수 호출
            Random rand = new Random();

            // 20개 빈칸 생성
            string[] arrStr = new string[20];
            // 0인 5칸짜리 배열 생성
            int[] counting = new int[5]
            {
                0,0,0,0,0
            };

            // 이름 배열 길이 만큼 반복문 실행
            for (int i = 0; arrStr.Length > i; i++)
            {
                // 잠시 저장할 공간 생성
                int temp = 0;
                // 랜덤한 값을 temp에 저장
                temp = rand.Next(5);

                // counting배열에 temp값을 대입
                for (int j = 0; j < counting.Length; j++)
                {
                    // 만약 temp가 counting배열의 index(행(i))과 같으면은 
                    if (temp == j)
                    {
                        // 해당 행의 값에 1을 더해줌
                        counting[j] += 1;
                    }
                }
                // arrStr[i](20칸 생성)에 name2에서 랜덤하게(temp) 생성된 값을 넣음
                arrStr[i] = name2[temp];
                // 해당 값을 출력함
                Console.WriteLine(arrStr[i]);
            }

            // counting함수에 입력된 숫자를 출력함.
            for (int i = 0; i < counting.Length; i++)
            {
                Console.WriteLine(name2[i] + "는 {0}번 나왔습니다.", counting[i]);
            }
            */

            /*
            //----------------------------------------------------------------
            // 로또 번호 1~45에서 6개 번호 추출
            int[] lotto = new int[6];
            Random rand = new Random();
            int count = 0;
            while (count < 6)              
            {

                for (int i = 0; i < lotto.Length; i++)
                {
                    int randnum = rand.Next(1, 46);

                    if (lotto[i] == randnum)
                    {
                        continue;
                    }
                    else
                    {
                        lotto[i] = randnum; 
                    }
                }
                count++;
            }
            Array.Sort(lotto);
            for (int i = 0; i < lotto.Length; i++)
            {
                Console.Write(lotto[i]+" ");
            }
            */

            //----------------------------------------------------------------
            // 지뢰 찾기
            // *: 지뢰, .: 빈 공간
            // 좌, 우로 지뢰 찾기
            //----------------------------------------------------------------

            string[] arrBomb =
            {
                "B",".","B","B","B",".","."
            };

            int[] matrix =
            {
                -1, 0, 1
            };


            int countBoom1 = 0;
            if (arrBomb[0] == "B")
            {
                countBoom1++;
            }
            if (arrBomb[1] == "B")
            {
                countBoom1++;
            }
            Console.Write(countBoom1 + " ");


            for (int i = 1; i < arrBomb.Length-1; i++)
            {
                int countBoom = 0;
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (arrBomb[i + matrix[j]] == "B")
                    {
                        countBoom++;
                    }
                }
                Console.Write(countBoom + " ");
            }


            int countBoom2 = 0;
            if (arrBomb[arrBomb.Length - 2] == "B")
            {
                countBoom2++;
            }
            if (arrBomb[arrBomb.Length-1] == "B")
            {
                countBoom2++;
            }
            Console.Write(countBoom2 + " ");
        }

    }
}

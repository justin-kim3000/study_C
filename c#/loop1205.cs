using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace loop1205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 2차원 배열 초기화 1
            int[,] arr2Int =
            {
                {1,2,3},{4,5,6}
            };

            for (int i = 0; i < arr2Int.GetLength(0); i++)
            {
                for (int j = 0; j < arr2Int.GetLength(1); j++)
                {
                    Console.Write(arr2Int[i, j] + "\t");
                }
                Console.WriteLine();
            }


            // 2차원 배열 초기화2
            // readonly, const
            const int SIZE_ROW = 2; // 상수변수 
            const int SIZE_COL = 3;

            int[,] arr2Int2 = new int[SIZE_ROW, SIZE_COL]
            {
                {1,2,3 },{4,5,6}
            };
            for (int i = 0; i < SIZE_ROW; i++)
            {
                for (int j = 0; j < SIZE_COL; j++)
                {
                    Console.Write(arr2Int2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // 2차원 배열 초기화3
            string[][] arrStr = new string[2][];
            arrStr[0] = new string[]
            {
                "김길동","홍길동","박길동"
            };
            arrStr[1] = new string[] { "이순신" };

            for (int i = 0; i < arrStr.Length; i++)
            {
                for (int j = 0; j < arrStr[i].Length; j++)
                {
                    Console.Write(arrStr[i][j] + "\t");
                }
                Console.WriteLine();
            }

            // 2차원 배열 초기화4
            int[][] arrInt4 = new int[3][];
            for (int i = 0; i < arrInt4.Length; i++)
            {
                arrInt4[i] = new int[4];
                for (int j = 0; j < arrInt4[i].Length; j++)
                {
                    arrInt4[i][j] = 10+j;
                    Console.Write(arrInt4[i][j] + "\t");
                }
                Console.WriteLine();
            }


            // 2차원 배열 foreach
            int[][] arr2Each =
            {
                new int[] {1,2, 3 },
                new int[] {4,5,6}
            };
            foreach (int[] n in arr2Each)
            {
                foreach (int n2 in n)
                {
                    Console.Write(n2 + "\t");
                }
                Console.WriteLine();
            }

            // 컬렉션 - 자료구조
            // 1. 리스트
            // 참고 - 제네릭
            List<string> list = new List<string>
            {
                "홍길동","김길동","박길동"
            };

            var list2 = new List<string>
            {
                "홍길동2","김길동2","박길동2"
            };
            list.Add("add1");
            list.Add("add2");
            foreach (var item in list)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            list.Remove("add2");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "\t");
            }
            Console.WriteLine();

            // 딕셔너리 - key : values
            Dictionary<int,string> dic= new Dictionary<int, string>
            {
                {111, "홍길동" },
                {222, "김길동" },
                {333, "박길동" }
            };
            dic.Add(444, "이길동");
            dic.Remove(222);

            foreach (var item in dic)
            {
                Console.WriteLine("학번: {0} 이름: {1}", item.Key, item.Value);
            }

            // 스텍(stack) - LIFO(후입선출)
            // 큐(queue) - FIFO(선입선출)
            // tree, 그래프 : 비선형 자료구조
            Stack<string> stack = new Stack<string>();
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");

            //스텍에서 실제 데이터를 빼지않고 조회만 함
            string speek = stack.Peek();
            Console.WriteLine("1. stack조회: "+speek);
            Console.WriteLine("2. stack내부: " + string.Join("-",stack.ToArray()));
            string pop = stack.Pop();
            Console.WriteLine("3. stack조회: "+pop);
            Console.WriteLine("4. stack내부: " + string.Join("-",stack.ToArray()));
            Console.WriteLine("-----------------------------------------------");

            // 큐 클래스 객체 생성
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");
            queue.Enqueue("4");

            string qpeek = queue.Peek();
            Console.WriteLine("1. 큐 조회: {0}",qpeek);
            Console.WriteLine("2. 큐 내부: " + string.Join("-", queue.ToArray()));

            // 큐 처음 데이터를 빼냄
            string dq = queue.Dequeue();
            Console.WriteLine("3. 큐 내부: " + string.Join("-", queue.ToArray()));

            */

            // 문제 1~3
            // "홍길동","김길동","박길동","최길동"
            // 랜덤으로 20개의 이름을 list에 저장
            // 1. 각각의 이름 빈도수 확인
            // 2. 특정 이름을 입력받아 삭제(중복 모두 삭제)
            // 3. 특정 이름 검색
            // ----------------------------------------------
            // DMZ 지뢰 찾기 (1차원)
            // 1. DMZ의 크기 입력 받음
            // 2. 랜덤으로 10개 폭탄 생성{"B","."}
            // 3. 랜덤으로 생성된 지뢰를 찾아서 출력
            // ----------------------------------------------
            // DMZ 지뢰 찾기 (2차원)
            // 1. 임의의 초기값으로 2차원 배열과 폭탄 안전지대 추가
            // 2. 이중루프를 통해 지뢰 찾기
            // 3. 자신을 기준으로 8방향 검색

            /*
            // 1. 랜덤 이름 배열 생성
            List<string> listName = new List<string>
            {
                "홍길동","김길동","박길동","최길동"
            };

            // 랜덤 함수 호출
            Random rand = new Random();
            const int countingNum = 20;
            // 빈칸 생성
            List<string> emName = new List<string> { };
            List<int> counting = new List<int>
            {
                0,0,0,0
            };
            // 0인 5칸짜리 배열 생성


            // 이름 배열 길이 만큼 반복문 실행
            for (int i = 0; i < countingNum; i++)
            {
                // 잠시 저장할 공간 생성
                int temp = 0;
                // 랜덤한 값을 temp에 저장
                temp = rand.Next(4);

                // counting배열에 temp값을 대입
                for (int j = 0; j < counting.Count(); j++)
                {
                    // 만약 temp가 counting배열의 index(행(i))과 같으면은 
                    if (temp == j)
                    {
                        // 해당 행의 값에 1을 더해줌
                        counting[j] += 1;
                    }
                }
                // arrStr[i](20칸 생성)에 name2에서 랜덤하게(temp) 생성된 값을 넣음
                emName.Add(listName[temp]);
                // 해당 값을 출력함
                Console.WriteLine(emName[i]);
            }

            // counting함수에 입력된 숫자를 출력함.
            for (int i = 0; i < listName.Count(); i++)
            {
                Console.WriteLine(listName[i] + "는 {0}번 나왔습니다.", counting[i]);
            }

        }
    */


            // 2. 지뢰찾기
            // 1. DMZ의 크기 입력 받음
            // 2. 랜덤으로 10개 폭탄 생성{"B","."}
            // 3. 랜덤으로 생성된 지뢰를 찾아서 출력

            /*
                        List<string> Boom = new List<string> { };
                        List<string> BoomWord = new List<string>
                        {
                            "B","."
                        };
                        Random rand = new Random();
                        for (int i = 0; i < 10; i++)
                        {
                            int rand_index = rand.Next(BoomWord.Count());
                            Boom.Add(BoomWord[rand_index]);
                        }

                        foreach (var i in Boom)
                        {
                            Console.Write(i + " ");
                        }

                        List<int> matrix = new List<int>
                        {
                            -1, 0, 1
                        };


                        Console.WriteLine();

                        int countBoom1 = 0;
                        if (Boom[0] == "B")
                        {
                            countBoom1++;
                        }
                        if (Boom[1] == "B")
                        {
                            countBoom1++;
                        }
                        Console.Write(countBoom1 + " ");


                        for (int i = 1; i < Boom.Count() - 1; i++)
                        {
                            int countBoom = 0;
                            for (int j = 0; j < matrix.Count(); j++)
                            {
                                if (Boom[i + matrix[j]] == "B")
                                {
                                    countBoom++;
                                }
                            }
                            Console.Write(countBoom + " ");
                        }


                        int countBoom2 = 0;
                        if (Boom[Boom.Count() - 2] == "B")
                        {
                            countBoom2++;
                        }
                        if (Boom[Boom.Count() - 1] == "B")
                        {
                            countBoom2++;
                        }
                        Console.Write(countBoom2 + " ");
            */


            // DMZ 지뢰 찾기 (2차원)
            // 1. 임의의 초기값으로 2차원 배열과 폭탄 안전지대 추가
            // 2. 이중루프를 통해 지뢰 찾기
            // 3. 자신을 기준으로 8방향 검색

            const int ROW_ = 5;
            const int COL_ = 5;


            string[,] BommRoom = new string[ROW_, COL_];
            int[,] Cnt = new int[ROW_, COL_];
            
            //Cnt 초기화
            for (int i = 0; i < Cnt.GetLength(0); i++)
            {
                for (int j = 0; j < Cnt.GetLength(1); j++)
                {
                    Cnt[i, j] = 0;
                }
            }


            string[] BoomWord = new string[]
            {
                "B","."
            };

            Random rand = new Random();

            int[] dx = new int[]
            {
                0,0,1,-1,1,-1,1,-1
            };
            int[] dy = new int[]
            {
                1,-1,0,0,1,1,-1,-1
            };

            for (int i = 0; i < BommRoom.GetLength(0); i++)
            {
                for (int j = 0; j < BommRoom.GetLength(1); j++)
                {

                    int rand_index = rand.Next(BoomWord.Count());
                    
                    BommRoom[i,j] = BoomWord[rand_index];
                    Console.Write(BommRoom[i, j] + "\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();


            for (int i = 0; i < BommRoom.GetLength(0); i++)
            {
                for (int j = 0; j < BommRoom.GetLength(1); j++)
                {

                    if (BommRoom[i,j]=="B")
                    {
                        Cnt[i, j]++;
                    }
                    for (int k = 0; k < dx.Length; k++)
                    {
                        int nx = i+dx[k];
                        int ny = j+dy[k];
                        
                        if(0<=nx && 0<=ny && nx<BommRoom.GetLength(0) && ny<BommRoom.GetLength(1) &&BommRoom[i + dx[k], j + dy[k]]  =="B")
                        {
                            Cnt[i, j]++;
                        }

                    }
                }
            }

            for (int i = 0; i < Cnt.GetLength(0); i++)
            {
                for (int j = 0; j < Cnt.GetLength(1); j++)
                {
                    Console.Write(Cnt[i,j] + "\t");

                }
                Console.WriteLine();

            }

        }
    }
}

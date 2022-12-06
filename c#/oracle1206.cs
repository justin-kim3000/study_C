using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oracle1206
{
    internal class Program
    {

        static string ORA_ADDR =
           "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
           "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
           "(PORT=1521)))" +
           "(CONNECT_DATA=(SERVER=DEDICATED)" +
           "(SERVICE_NAME=XE)));" +
           "User Id=test;Password=1234;";
        // 오라클 접속, sql명령어 객체 생성
        static OracleConnection conn = new OracleConnection(ORA_ADDR);
        static OracleCommand cmd = new OracleCommand();
        static Random rand = new Random();

        static void Main(string[] args)
        {
            //randpick();
            connectDB();
            mainMenu();
        }

        static void randpick()
        {
            rand = new Random();
            for (int i = 0; i > 1000; i++)
            {
                int pick = rand.Next(10000);
                Console.WriteLine(pick);
            }
        }
        static void mainMenu()
        {
            while (true)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("DBMS 관리 APP v1.0");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("1. 테이블 생성");
                Console.WriteLine("2. 테이블 삭제");
                Console.WriteLine("3. 테이블 삽입");
                Console.WriteLine("4. 테이블 보기");

                Console.WriteLine("5. 종료");

                string a = Console.ReadLine();
                int menu = Convert.ToInt32(a);
                if (menu == 1)
                {
                    createTable();
                }
                else if (menu == 2)
                {
                    deleteTable();
                }
                else if (menu == 3) insertTable();
                else if (menu == 4) selectTable();
                else if (menu == 5) Environment.Exit(0);
            }
        }

        static void connectDB() 
        {
            // try ~ catch : 각체지향 프로그래밍에서 예외처리
            try
            {
                conn.Open();    // DB 접속
                Console.WriteLine("오라클 접속 성공");
            }
            catch (OracleException e)
            {
                Console.WriteLine("접속에러: "+e.Message);
                
            }

        }
        static void disconnectDB() 
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("오라클 해제 성공!");
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine("종료 에러:" + e.Message);
            }
        }

        static void createTable() 
        {
            try
            {
                string sql = "create table stud_t(\r\n    id number not null,\r\n    name varchar2(20) not null,\r\n    age number not null,\r\n    addr varchar2(50) not null,\r\n    CONSTRAINT pk_stud_t_id primary key(id))";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 삭제: " + e.Message);
                cmd.Transaction.Rollback();

            }
        }
        static void deleteTable() 
        {
            try
            {
                string sql = "drop table stud_t";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 삭제: " + e.Message);
                cmd.Transaction.Rollback();

            }
        }

        static void insertTable()
        {
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int pick = rand.Next(10000);
                Console.WriteLine(pick);
                try
                {
                    string sql = "INSERT INTO stud_t VALUES (" + pick + ",'kun',20,'Gangnum city')";
                    cmd.Transaction = conn.BeginTransaction();
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();
                }
                catch (OracleException e)
                {
                    Console.WriteLine("테이블 입력: " + e.Message);
                    cmd.Transaction.Rollback();

                }
            }
        }

        static void selectTable()
        {
            try
            {
                string sql = "select * from stud_t\r\nORDER by ID";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("-------------------------");

                        Console.WriteLine("학번: " + reader["id"]);
                        Console.WriteLine("이름: " + reader["name"]);
                        Console.WriteLine("나이: " + reader["age"]);
                        Console.WriteLine("주소: " + reader["addr"]);

                    }
                }
                else
                {
                    Console.WriteLine("데이터 없음!");
                }

            }
            catch (OracleException e)
            {
                Console.WriteLine("테이블 입력: " + e.Message);
                cmd.Transaction.Rollback();

            }
        }
    }
}

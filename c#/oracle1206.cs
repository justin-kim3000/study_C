﻿using Oracle.ManagedDataAccess.Client;
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
            // 1. 이름 입력받아 delete
            // 2. 이름,

            // employee, department, salgrade 테이블 생성
            // 메뉴 생성

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
                Console.WriteLine("3. 랜덤 데이터 삽입");
                Console.WriteLine("4. 테이블 입력");
                Console.WriteLine("5. 테이블 보기");
                Console.WriteLine("6. 이름 검색 후 삭제");
                Console.WriteLine("7. 이름 검색 후 정보 수정");


                Console.WriteLine("8. 종료");

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
                else if (menu == 3)
                {

                    insertTable();
                }
                else if (menu == 4)
                {
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("이름: ");
                    string name = Console.ReadLine();
                    Console.Write("나이: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("주소: ");
                    string adrr = Console.ReadLine();
                    insertData(id, name, age, adrr);
                }
                else if (menu == 5) selectTable();
                else if (menu == 6)
                {
                    Console.Write("삭제할 이름 입력: ");
                    string name = Console.ReadLine();
                    delNameData(name);
                }
                else if (menu == 7)
                {
                    Console.Write("찾을 이름 입력: ");
                    string find_name = Console.ReadLine();
                    Console.Write("변경할 이름 입력: ");
                    string chan_name = Console.ReadLine();
                    Console.Write("변경할 나이 입력: ");
                    int chan_age = int.Parse(Console.ReadLine());
                    Console.Write("변경할 주소 입력: ");
                    string chan_adrr = Console.ReadLine();
                    chanNameData(find_name, chan_name, chan_age,chan_adrr);
                }
                else if (menu == 8) Environment.Exit(0);
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

            string[] first_name = { "김", "나","박", "이","최","문","권" };
            string[] sec_name = { "성", "기", "준", "구", "슬", "나", "샛" };
            string[] end_name = { "별", "용", "수", "완", "혁", "리", "람" };

            string[] city = { "대구광역시", "서울특별시", "대전광역시", "부산광역시", "경주시", "울산시", "김해시" };
            string[] dong = { "달서구", "한일구", "구구", "문화구", "구라구", "나라구", "알라구" };



            for (int i = 0; i < 100; i++)
            {
                int pick = rand.Next(1000);
                int pick_f = rand.Next(first_name.Length);
                int pick_s = rand.Next(sec_name.Length);
                int pick_e = rand.Next(end_name.Length);
                int age = rand.Next(15, 100);
                int adrr_c = rand.Next(city.Length);
                int adrr_d = rand.Next(dong.Length);


                string name = first_name[pick_f] + sec_name[pick_s] + end_name[pick_e];
                string adrr = city[adrr_c] + dong[adrr_d];
                Console.WriteLine(pick);
                try
                {
                    string sql = "INSERT INTO stud_t VALUES (" + pick + ",'" + name + "'," + age + ",'" + adrr + "')";
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

        static void insertData(int id, string name, int age, string adrr)
        {
            try
            {
                string sql = "INSERT INTO stud_t VALUES (" + id + ",'"+ name+"',"+ age+",'"+ adrr+"')";
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

        static void delNameData(string name)
        {
            try
            {
                string sql = "DELETE FROM stud_t WHERE name = '" + name +"'";
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
        static void chanNameData(string find_name, string chan_name, int chan_age, string chan_adrr)
        {
            try
            {
                string sql = "update stud_t set name = '" +
                    chan_name +
                    "', age = " +
                    chan_age +
                    ", addr = '" +
                    chan_adrr +
                    "' where name = '" +
                    find_name +
                    "'";
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
}

using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFom1215
{
    public partial class sign : Form
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

        static void createTable()
        {
            try
            {
                string sql = "create table sign_up(id VARCHAR2(20) not null,\r\npsw VARCHAR2(30) not null,\r\npaw_ch VARCHAR2(30) not null,\r\nname VARCHAR2(20) not null,\r\nname_2 VARCHAR2(20),\r\nbirth VARCHAR2(20),\r\nemail VARCHAR2(30),\r\ngender CHAR,\r\nphone VARCHAR2(30))\r\n";
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
                Console.WriteLine("접속에러: " + e.Message);

            }

        }

        static void insertData(string id,string psw,string psw_ch, string name, string name2, string birth, string email, string gender, string phone)
        {
            try
            {
                string sql = "INSERT INTO sign_up VALUES('" + id +"', '" + psw + "', '" + psw_ch +
                    "', '" + name + "', '" + name2 + "', '" + birth + "', '" + email + "', '" + gender +
                    "', '" + phone + "')";

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
        public sign()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectDB();
            string id = textBox1.Text;
            string psw = textBox2.Text;
            string psw_ch = textBox3.Text;
            string name = textBox4.Text;
            string name2 = textBox5.Text;
            string birth = textBox6.Text;
            string email = textBox7.Text;
            string gender = "";
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }else if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            string phone = textBox8.Text + "-" + textBox9.Text + "-" + textBox10.Text;

            insertData(id,psw,psw_ch,name,name2,birth,email,gender,phone);


        }

        private void sign_Load(object sender, EventArgs e)
        {
            try
            {
                createTable();

            }
            catch (Exception)
            {

                Console.WriteLine("오류");
            }
        }
    }
}

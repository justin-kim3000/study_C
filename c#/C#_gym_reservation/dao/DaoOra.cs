using _3_project.model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace _3_project.dao
{
    internal class DaoOra
    {
        string ORA_ADDR =
         "Data Source=(DESCRIPTION=(ADDRESS_LIST=" +
         "(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)" +
         "(PORT=1521)))" +
         "(CONNECT_DATA=(SERVER=DEDICATED)" +
         "(SERVICE_NAME=XE)));" +
         "User Id=team3;Password=1234;";
        OracleConnection conn;
        OracleCommand cmd;

        static DaoOra inst;

        public static DaoOra getInst()
        {
            if (inst == null)
            {
                inst = new DaoOra();
            }
            return inst;
        }
        public DaoOra()
        {
            conn = new OracleConnection(ORA_ADDR);
            cmd = new OracleCommand();
            connectDB();
        }
        ~DaoOra()
        {
            disconnectDB();
        }
        public void connectDB()
        {
            try
            {
                conn.Open();
                Console.WriteLine("오라클 접속 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("접속에러: " + e.Message);
            }
        }
        public void disconnectDB()
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

        public void insertData(string mno, string name, string birth, string tall, string weight,
            string bfp, string bmi, string tname, string gender, string tel)
        {
            try
            {
                string sql = "insert into member values " +
                    $"('{mno}', '{tall}', '{name}', '{weight}', " +
                    $"'{birth}', '{gender}', '{tel}', '{bfp}', '{bmi}', '{tname}')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터 추가 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        public void insertData(Member mem)
        {
            try
            {
                string sql = "insert into member values " +
                    $"('{mem.Mno}', '{mem.Tall}', '{mem.Name}', " +
                    $"'{mem.Weight}', '{mem.Birth}', '{mem.Gender}', " +
                    $"'{mem.Tel}', '{mem.Bfp}', '{mem.Bmi}', '{mem.Tname}', :image)";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터 추가 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }
        public void insertData2(Member mem)
        {
            try
            {
                string sql = "insert into trainer values " +
                    $"('{mem.Tname}', '{mem.Tid}', '{mem.Tpw}', " +
                    $"'{mem.Tno}')";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터 추가 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }

        public void insertData(Member mem, string path)
        {
            try
            {
                string sql = "insert into member values " +
                    $"('{mem.Mno}', '{mem.Name}', '{mem.Birth}', " +
                    $"'{mem.Tall}', '{mem.Weight}', '{mem.Bfp}', " +
                    $"'{mem.Bmi}', '{mem.Tname}', '{mem.Gender}', '{mem.Tel}', :image)";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                FileStream fs =
                    new FileStream(path, FileMode.Open,
                        FileAccess.Read);
                byte[] buffer = new byte[fs.Length - 1];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();
                OracleParameter op =
                    new OracleParameter();
                op.ParameterName = ":image";
                op.OracleDbType = OracleDbType.Blob;
                op.Direction = ParameterDirection.Input;
                op.Size = buffer.Length;
                op.Value = buffer;
                cmd.Parameters.Add(op);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터+이미지 추가 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }
        public List<ExPlan> dataShow()
        {
            string query = "select * from exercise";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<ExPlan> exList = new List<ExPlan>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("insert:{0}", dr[0]);
                    //Console.WriteLine($"ID:{dr["id"]}");
                    //Console.WriteLine($"이름:{dr["name"]}");
                    //Console.WriteLine($"별명:{dr["nick_name"]}");
                    //Console.WriteLine($"생년월일:{dr["birth"]}");
                    //Console.WriteLine($"성별:{dr["gender"]}");
                    //Console.WriteLine($"전화번호:{dr["tel"]}");
                    //Console.WriteLine($"이메일:{dr["email"]}");
                    //Console.WriteLine("-------------------");
                    exList.Add(new ExPlan(
                        dr["ex_classification"].ToString(),
                        dr["ex_type"].ToString(),
                        dr["ex_cal15"].ToString(),
                        dr["ex_cal30"].ToString(),
                        dr["ex_cal60"].ToString()));
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return exList;
        }

        public List<Member> planDataShow()
        {
            //string query= "select * from (select member.name, member.mno , present.pttime from member," +
            //    "schedule where member.mno=schedule.mno and schedule.day=28)";


            string query = "select mno,name,pttime from present where ptdate like(to_char(sysdate,'%MM\"월\"%'))";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Member> MemList = new List<Member>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine($"회원번호:{dr["mno"]}");
                    Console.WriteLine($"이름:{dr["name"]}");
                    Console.WriteLine($"시간:{dr["pttime"]}");
                    MemList.Add(new Member(
                        dr["mno"].ToString(),
                        dr["name"].ToString(),
                        dr["pttime"].ToString()));
                    Console.WriteLine("여기까진 괜찮음22");
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
            return MemList;
        }
        public List<Member> trainerShow()
        {
            string query = "select * from trainer";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Member> MemList = new List<Member>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine($"회원번호:{dr["name"]}");
                    Console.WriteLine($"이름:{dr["id"]}");
                    Console.WriteLine($"시간:{dr["passwd"]}");
                    Console.WriteLine($"시간:{dr["tno"]}");
                    MemList.Add(new Member(
                        dr["name"].ToString(),
                        dr["id"].ToString(),
                        dr["passwd"].ToString(),
                        dr["tno"].ToString()));

                    Console.WriteLine("여기까진 괜찮음2");
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
            return MemList;
        }
        public string reTName()
        {
            string tname = "";
            string query = "select name from trainer where tno = '1000'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)//애는 항상 고정임.
            {
                while (dr.Read())
                {
                    tname = dr["name"].ToString();
                    Console.WriteLine(tname + "!");
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            return tname;
        }
        public List<Member> m_datashow()
        {
            List<Member> memlist = null;
            try
            {
                string sql = "select mno, name, birth, tall, weight, bfp, bmi, gender, tel, tname from member order by mno";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                memlist = new List<Member>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        memlist.Add(new Member(dr["mno"].ToString(), dr["name"].ToString(), dr["birth"].ToString(), dr["tall"].ToString(),
                            dr["weight"].ToString(), dr["bfp"].ToString(), dr["bmi"].ToString(), dr["gender"].ToString(),
                            dr["tel"].ToString(), dr["tname"].ToString()));
                    }
                }
                else
                { MessageBox.Show("데이터가 없습니다."); }
                dr.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                cmd.Transaction.Rollback();
            }
            return memlist;
        }
        public List<Member> m_updateData(string mno, Member mem)
        {
            try
            {
                string sql = $"update member set mno='{mem.Mno}', name='{mem.Name}', birth='{mem.Birth}', " +
                    $"tall ='{mem.Tall}', weight='{mem.Weight}', bfp='{mem.Bfp}', bmi='{mem.Bmi}', gender='{mem.Gender}', " +
                    $"tel='{mem.Tel}', tname='{mem.Tname}' where mno='{mno}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터 수정 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 수정 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
            List<Member> memlist = m_datashow();
            return memlist;
        }
        public List<Member> m_deleteData(string mno)
        {
            try
            {
                string sql = $"delete from member where mno='{mno}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터 삭제 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 삭제 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
            List<Member> memlist = m_datashow();
            return memlist;
        }

        public List<Member> m_searchShowData2(string name)
        {
            List<Member> memlist = null;
            try
            {
                string sql = $"select mno, name, birth, tall, weight, bfp, bmi, gender, tel, tname from member where name='{name}'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                memlist = new List<Member>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        memlist.Add(new Member(dr["mno"].ToString(), dr["name"].ToString(), dr["birth"].ToString(), dr["tall"].ToString(),
                            dr["weight"].ToString(), dr["bfp"].ToString(), dr["bmi"].ToString(), dr["gender"].ToString(),
                            dr["tel"].ToString(), dr["tname"].ToString()));
                    }
                }
                else
                { MessageBox.Show("데이터가 없습니다."); }
                dr.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                //cmd.Transaction.Rollback();
            }
            return memlist;
        }
        public List<Member> m_searchShowData(string mno)
        {
            List<Member> memlist = null;
            try
            {
                string sql = $"select mno, name, birth, tall, weight, bfp, bmi, gender, tel, tname from member where mno='{mno}'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                memlist = new List<Member>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        memlist.Add(new Member(dr["mno"].ToString(), dr["name"].ToString(), dr["birth"].ToString(), dr["tall"].ToString(),
                            dr["weight"].ToString(), dr["bfp"].ToString(), dr["bmi"].ToString(), dr["gender"].ToString(),
                            dr["tel"].ToString(), dr["tname"].ToString()));
                    }
                }
                else
                { MessageBox.Show("데이터가 없습니다."); }
                dr.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(123456);
                cmd.Transaction.Rollback();
            }
            return memlist;
        }
        public List<Food> dataShowF()
        {
            string query = "select * from food";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Food> exList = new List<Food>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("insert:{0}", dr[0]);
                    //Console.WriteLine($"ID:{dr["id"]}");
                    //Console.WriteLine($"이름:{dr["name"]}");
                    //Console.WriteLine($"별명:{dr["nick_name"]}");
                    //Console.WriteLine($"생년월일:{dr["birth"]}");
                    //Console.WriteLine($"성별:{dr["gender"]}");
                    //Console.WriteLine($"전화번호:{dr["tel"]}");
                    //Console.WriteLine($"이메일:{dr["email"]}");
                    //Console.WriteLine("-------------------");
                    exList.Add(new Food(
                        dr["type"].ToString(),
                        dr["eat"].ToString(),
                        dr["name"].ToString(),
                        dr["calorie"].ToString(),
                        dr["carbohydrate"].ToString(),
                        dr["fat"].ToString(),
                        dr["protein"].ToString(),
                        dr["menu"].ToString()));
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return exList;
        }

        public List<Food> dataShow2()
        {
            string query = "select * from food where eat in ('아침', '점심', '저녁') " +
                "order by case " +
                "when eat = '아침' then 1 " +
                "when eat = '점심' then 2 " +
                "when eat = '저녁' then 3 " +
                "else 4 " +
                "end";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Food> exList = new List<Food>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Console.WriteLine("insert:{0}", dr[0]);
                    //Console.WriteLine($"ID:{dr["id"]}");
                    //Console.WriteLine($"이름:{dr["name"]}");
                    //Console.WriteLine($"별명:{dr["nick_name"]}");
                    //Console.WriteLine($"생년월일:{dr["birth"]}");
                    //Console.WriteLine($"성별:{dr["gender"]}");
                    //Console.WriteLine($"전화번호:{dr["tel"]}");
                    //Console.WriteLine($"이메일:{dr["email"]}");
                    //Console.WriteLine("-------------------");
                    exList.Add(new Food(
                        dr["type"].ToString(),
                        dr["eat"].ToString(),
                        dr["name"].ToString(),
                        dr["calorie"].ToString(),
                        dr["carbohydrate"].ToString(),
                        dr["fat"].ToString(),
                        dr["protein"].ToString(),
                        dr["menu"].ToString()));
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않음!");
            }
            dr.Close();
            return exList;
        }

        public List<Present> showData()
        {
            string query = "select * from present";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Present> memList = new List<Present>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    memList.Add(new Present(
                        dr["mno"].ToString(),
                        dr["name"].ToString(),
                        dr["ptdate"].ToString(),
                        dr["pttime"].ToString(),
                        dr["exercise"].ToString(),
                        dr["menu"].ToString(),
                        dr["achievement"].ToString()));


                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
            return memList;
        }
        public List<Present> updateData(string name, Present mem)
        {
            try
            {
                string sql = "update present set " +
                    $"mno='{mem.Mno}',"+
                    $"name='{mem.Name}', " +
                    $"ptdate='{mem.Ptdate}', " +
                    $"pttime='{mem.Pttime}', " +
                    $"exercise='{mem.Exercise}', " +
                    $"menu='{mem.Menu}'," +
                    $"achievement='{mem.Achievement}'" +
                    $"where name='{name}'";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터 수정 성공!");
                MessageBox.Show("데이터 수정 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 수정 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
            List<Present> list = showData();
            return list;
        }
        public List<Present> searchName(string name)
        {
            Console.WriteLine(name);
            string query = "select * from present " +
             $"where name='{name}'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Present> memList = new List<Present>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    memList.Add(new Present(dr["mno"].ToString(),
                      dr["name"].ToString(),
                      dr["ptdate"].ToString(),
                      dr["pttime"].ToString(),
                      dr["exercise"].ToString(),
                      dr["menu"].ToString(),
                      dr["achievement"].ToString()));

                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
            return memList;
        }
        public List<Present> searchMno(string mno)
        {
            string query = "select * from present " +
             $"where mno ='{mno}'";
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            List<Present> memList = new List<Present>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    memList.Add(new Present(
                      dr["mno"].ToString(),
                      dr["name"].ToString(),
                      dr["ptdate"].ToString(),
                      dr["pttime"].ToString(),
                      dr["exercise"].ToString(),
                      dr["menu"].ToString(),
                      dr["achievement"].ToString()));
                }
            }
            else
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            dr.Close();
            return memList;
        }

        public void AddData( Present mem)
        {
            try
            {
                string sql = "insert into present values " +
                    $"('{mem.Mno}', '{mem.Name}', '{mem.Ptdate}', " +
                    $"'{mem.Pttime}', '{mem.Exercise}', '{mem.Menu}','{mem.Achievement}') ";
                cmd.Transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();
                Console.WriteLine("데이터 추가 성공!");
            }
            catch (OracleException e)
            {
                Console.WriteLine("데이터 추가 Err:" + e.Message);
                cmd.Transaction.Rollback();
            }
        }

    }
}
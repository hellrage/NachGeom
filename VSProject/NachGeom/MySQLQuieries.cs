using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    static class MySQLQuieries
    {
        static MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();

        static MySQLQuieries()
        {
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Password = "aiJ2PO";
            mysqlCSB.UserID = "root";
            mysqlCSB.Server = "localhost";
            mysqlCSB.Database = "EngGraphDB";
        }

        private static DataTable ExecQuery(string q)
        {
            string query = q;
            DataTable dt = new DataTable();

            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = mysqlCSB.ConnectionString;
                MySqlCommand com = new MySqlCommand(query, con);

                try
                {
                    con.Open();

                    using (MySqlDataReader dr = com.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Load(dr);
                        }
                    }
                }

                catch (Exception ex)
                {
                }
            }

            return dt;
        }
        public static DataTable GetTestList()
        {
            return ExecQuery("SELECT * FROM TestList");
        }

        public static DataTable GetTest(string testName, int variant)
        {
            return ExecQuery("SELECT * FROM Questions WHERE test_id = 1"); //(SELECT ID FROM TestList WHERE test_name = "+testName+" AND variant = "+variant+")");
        }
    }
}

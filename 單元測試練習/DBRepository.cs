using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UnitTestLab1
{
    public class DBRepository : IDBRepository
    {
        public DataTable GetAccDT(string account)
        {
            var dt = new DataTable();
            var connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            using (var sqlConn = new SqlConnection(connString))
            {
                var sql = "select * from Member where account=@account ";
                using (var sqlCmd = new SqlCommand(sql, sqlConn))
                {
                    sqlConn.Open();

                    sqlCmd.Parameters.AddWithValue("account", account);
                    dt.Load(sqlCmd.ExecuteReader());
                }
            }

            return dt;
        }
    }
}

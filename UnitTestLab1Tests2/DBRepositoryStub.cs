using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestLab1;
using System.Data;

namespace UnitTestLab1Tests2
{
   public  class DBBRepositoryStub : IDBRepository
    {
        public DataTable GetAccDT(string account)
        {
            var dt = new DataTable();
            dt.Columns.Add("account", typeof(string));
            dt.Columns.Add("password", typeof(string));
            var dr = dt.NewRow();
            dr["account"] = "admin";
            dr["password"] = "admin123";
            dt.Rows.Add(dr);
            return dt;
        }
    }


    public class DBBRepositoryNoAccountStub : IDBRepository
    {
        public DataTable GetAccDT(string account)
        {
            var dt = new DataTable();
            dt.Columns.Add("account", typeof(string));
            dt.Columns.Add("password", typeof(string));
            return dt;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace UnitTestLab1
{
    public class ShareService
    {
        public string ValidateMember(string account, string password)
        {
            DataBaseRepository dbr = new DataBaseRepository();
            DataTable dtMember = new DataTable();
            ArrayList aryFild = new ArrayList();
            ArrayList aryValue = new ArrayList();
            string strSql = "";
            strSql = @" select * from Member where account=@account  ";
            aryFild.Add("account");
            aryValue.Add(account);

            dtMember = dbr.SelectDataTable(dbr.GetConnString(), strSql, aryFild, aryValue);

            if (dtMember.Rows.Count == 0)
            {
                return "No Account!"; 
            }
            else if (dtMember.Rows[0]["password"].ToString() != password)
            {
                return "Password Error!";
            }
            else
            {
                return "Success!";
            }

        }


    }
}

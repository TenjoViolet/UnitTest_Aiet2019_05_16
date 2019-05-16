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
            string strMsg = "";
            strMsg = ValidateMemberNoAccount(account,password);
            strMsg = ValidateMemberPasswordError(account, password);
            strMsg = ValidateMemberSuccess(account, password);
            return strMsg;

        }

        public string ValidateMemberNoAccount(string account, string password)
        {
            string strRetMsg = "";
            DataTable dtMember = new DataTable();
            DataBaseRepository dbr = new DataBaseRepository();
            dtMember = dbr.GetDtMember(account);
            if (dtMember.Rows.Count == 0)
            {
                strRetMsg= "No Account!";
            }
            return strRetMsg;

        }

        public string ValidateMemberPasswordError(string account, string password)
        {
            string strRetMsg = "";
            DataTable dtMember = new DataTable();
            DataBaseRepository dbr = new DataBaseRepository();
            dtMember = dbr.GetDtMember(account);
            if (dtMember.Rows.Count != 0 && dtMember.Rows[0]["password"].ToString() != password)
            {
                strRetMsg = "Password Error!";
            }
            return strRetMsg;

        }

        public string ValidateMemberSuccess(string account, string password)
        {
            string strRetMsg = "";
            DataTable dtMember = new DataTable();
            DataBaseRepository dbr = new DataBaseRepository();
            dtMember = dbr.GetDtMember(account);
            if (dtMember.Rows.Count != 0 && dtMember.Rows[0]["password"].ToString() == password)
            {
                strRetMsg = "Success!";
            }
            return strRetMsg;

        }



    }
}

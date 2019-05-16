using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace UnitTestLab1
{
    public class Share2Service
    {
        IDBRepository _dbRespository;

        public Share2Service(IDBRepository dbRespository)
        {
            _dbRespository = dbRespository;
        }

        public string ValidateMember(string account, string password)
        {
            DataTable dt = new DataTable();
            dt = _dbRespository.GetAccDT(account);
            if (dt.Rows.Count == 0)
            {
                return "No Account!";
            }
            else if (dt.Rows[0]["password"].ToString() != password)
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

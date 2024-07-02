using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ForgotPasswordDAO
    {
        Modify modify = new Modify();
        public bool IsEmailExist(string email)
        {
            string query = "SELECT COUNT(*) " +
                "FROM Account " +
                $"WHERE Email = '{email}'";
            object result = modify.ExecuteScalar(query);
            if ((int)result > 0)
            {
                return true;
            }
            return false;
        }
        public string GetPassword(string email)
        {
            string query = "SELECT Pwd " +
                            "FROM Account " +
                            $"WHERE Email = '{email}'";
            return modify.ExecuteScalar(query).ToString();
        }
    }
}

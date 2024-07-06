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

        public string resetAndReturnPassword(string email) {
            int currentMillisecond = DateTime.Now.Millisecond;
            int last8Digits = currentMillisecond % 100000000;
            String newPassword = PasswordUtility.EncodePassword(last8Digits.ToString());
            string query = $"UPDATE Account Set Pwd = '{newPassword}' where Email = '{email}'";

            modify.ExecuteQuery(query);

            Console.WriteLine(last8Digits);

            return last8Digits.ToString();

        }
    }
}

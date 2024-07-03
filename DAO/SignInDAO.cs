using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SignInDAO
    {
        public bool Authenticate(string username, string password)
        {
            string query = "SELECT Pwd " +
                "FROM Account " +
                $"WHERE Email = '{username}'";
            object result = new Modify().ExecuteScalar(query);

            string storedPassword = result != null ? result.ToString() : string.Empty;
            bool isCorrectPwd = PasswordUtility.ComparePasswords(password, storedPassword);
            return isCorrectPwd;
        }
        public string GetRole(string username)
        {
            string query = "SELECT UserRole " +
                "FROM Account " +
                $"WHERE Email = '{username}'";
            object result = new Modify().ExecuteScalar(query);
            return result.ToString();
        }
    }
}

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
            string query = "SELECT COUNT(*) " +
                "FROM Account " +
                $"WHERE Email = '{username}' AND Pwd = '{password}'";
            object result = new Modify().ExecuteScalar(query);
            return (int)result > 0;
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

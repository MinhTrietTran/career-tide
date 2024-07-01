using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignInDAO = DAO.SignInDAO;

namespace BUS
{
    public class SignInBUS
    {
        SignInDAO signInDAO = new SignInDAO();
        public string Authentication(string username, string password)
        {
            if (!signInDAO.Authenticate(username, password))
            {
                MessageBox.Show("Username or password is incorrect!");
            }
            else
            {
                return signInDAO.GetRole(username);
            }
            return null;
        }
    }
}

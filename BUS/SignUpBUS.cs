using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignUpDAO = DAO.SignUpDAO;

namespace BUS
{
    public class SignUpBUS
    {
        SignUpDAO signUpDAO = new SignUpDAO();
        public bool IsEmailExist(string email) =>  signUpDAO.IsEmailExist(email);


        public void InsertNewApplicant(string name, string email, string password) => signUpDAO.InsertNewApplicant(name, email, password);
    }
}

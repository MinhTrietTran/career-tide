using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployerDAO = DAO.EmployerDAO;

namespace BUS
{
    public class EmployerBUS
    {
        EmployerDAO employerDAO = new EmployerDAO();
        public DataTable GetCompanyData(string role) => employerDAO.GetCompanyData(role);
        public DataTable GetNearlyExpiredEmployerEmail() => employerDAO.GetNearlyExpiredEmployerEmail();
    }
}

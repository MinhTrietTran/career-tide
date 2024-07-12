using System;
using System.Data;
using EmployerDAO = DAO.EmployerDAO;


namespace BUS
{
    public class EmployerBUS
    {
        EmployerDAO employerDAO = new EmployerDAO();
        public DataTable GetCompanyData(string role) => employerDAO.GetCompanyData(role);
        public void InsertNewContract(string startDate, string endDate, string constractInfo, int employerID) => employerDAO.InsertNewContract(startDate, endDate, constractInfo, employerID);

        public DataTable GetCompaniesAboutToExpire(DataTable dataTable)
        {
            DataTable filteredDt = dataTable.Clone(); // Clone cấu trúc của DataTable ban đầu

            foreach (DataRow row in dataTable.Rows)
            {
                if (Convert.ToInt32(row["ContractDaysRemaining"]) < 3)
                {
                    filteredDt.ImportRow(row);
                }
            }

            return filteredDt;
        }

        public string GetEmployerEmail(int employerID) => employerDAO.GetEmployerEmail(employerID);


    }
}

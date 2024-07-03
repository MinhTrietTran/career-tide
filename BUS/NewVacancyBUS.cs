using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewVacancyDAO = DAO.NewVacancyDAO;

namespace BUS
{
    public class NewVacancyBUS
    {
        NewVacancyDAO newVacancyDAO = new NewVacancyDAO();
        public int GetEmployerID(string representativeEmail) => newVacancyDAO.GetEmployerID(representativeEmail);

        public int IsContractValid(int employerID) => newVacancyDAO.IsContracValid(employerID);

        public void AddNewVacancy(string position, int number, string openDate, string closeDate, string description, string postType, int employerID)
            => newVacancyDAO.AddNewVacancy(position, number, openDate, closeDate, description, postType, employerID);
 
    }
}

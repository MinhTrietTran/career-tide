using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class VacancyBUS
    {
        VacancyDAO vacancyDAO = new VacancyDAO();

        public void insertNewVacancy(String position, int number, DateTime openDate, DateTime closeDate, String vacancyDescription, String postType, float cost, String vacancyStatus, int employer)
        {
            vacancyDAO.insertNewVacancy( position,  number,  openDate,  closeDate,  vacancyDescription,  postType,  cost,  vacancyStatus,  employer);
        }

        public bool updateVacancy(int vacancyID, String position, int number, DateTime openDate, DateTime closeDate, String vacancyDescription, String postType, float cost, String vacancyStatus)
        {
           return vacancyDAO.updateVacancy(vacancyID, position, number, openDate, closeDate, vacancyDescription, postType, cost, vacancyStatus);
        }

        public DataTable viewAllVacancyData()
        {
            return vacancyDAO.viewAllVacancyData();
        }
        public DataTable viewOneVacancyData(int vacancyID)
        {
            return vacancyDAO.viewOneVacancyData(vacancyID);
        }

        public DataTable viewVacancyDataByStatus(string userName, string userRole, string vacancyStatus) => vacancyDAO.viewVacancyDataByStatus(userName, userRole, vacancyStatus);

        public void ApproveVacancy(int vacancyID)
        {
            try
            {
                vacancyDAO.ApproveVacancy(vacancyID);
                MessageBox.Show("Approve successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error when approve vacancy: {ex.Message}");
            }
        }
    }

}

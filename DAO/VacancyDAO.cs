using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VacancyDAO
    {
        Modify modify = new Modify();   
        public void insertNewVacancy(String position, int number, DateTime openDate, DateTime closeDate, String vacancyDescription, String postType, float cost, String vacancyStatus, int employer)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_InsertVacancyData", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Position", position);
                command.Parameters.AddWithValue("@Number", number);
                command.Parameters.AddWithValue("@OpenDate", openDate);
                command.Parameters.AddWithValue("@CloseDate", closeDate);
                command.Parameters.AddWithValue("@VacancyDescription", vacancyDescription);
                command.Parameters.AddWithValue("@PostType", postType);
                command.Parameters.AddWithValue("@Cost", cost);
                command.Parameters.AddWithValue("@VacancyStatus", vacancyStatus);
                command.Parameters.AddWithValue("@Employer", employer);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void updateVacancy(int vacancyID, String position, int number, DateTime openDate, DateTime closeDate, String vacancyDescription, String postType, float cost, String vacancyStatus)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_UpdateVacancyData", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Position", position);
                command.Parameters.AddWithValue("@Number", number);
                command.Parameters.AddWithValue("@OpenDate", openDate);
                command.Parameters.AddWithValue("@CloseDate", closeDate);
                command.Parameters.AddWithValue("@VacancyDescription", vacancyDescription);
                command.Parameters.AddWithValue("@PostType", postType);
                command.Parameters.AddWithValue("@Cost", cost);
                command.Parameters.AddWithValue("@VacancyStatus", vacancyStatus);
                command.Parameters.AddWithValue("@VacancyID", vacancyID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable viewAllVacancyData()
        {
           return modify.LoadTableSys("SELECT * FROM Vacancy");
        }

        public DataTable viewOneVacancyData(int vacancyID)
        {
            return modify.LoadTableSys($"SELECT * FROM Vacancy WHERE VacancyID={vacancyID}");
        }
    }
}

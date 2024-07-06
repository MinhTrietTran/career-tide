﻿using System;
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
        public bool updateVacancy(int vacancyID, String position, int number, DateTime openDate, DateTime closeDate, String vacancyDescription, String postType, float cost, String vacancyStatus)
        {
            bool result = false;

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
                command.Parameters.AddWithValue("@result", result);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            return result;
        }

        public DataTable viewAllVacancyData()
        {
           return modify.LoadTableSys("SELECT * FROM Vacancy");
        }

        public DataTable viewOneVacancyData(int vacancyID)
        {
            return modify.LoadTableSys($"SELECT * FROM Vacancy WHERE VacancyID={vacancyID}");
        }

        public DataTable viewVacancyDataByStatus(string userName, string userRole, string vacancyStatus)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("sp_ViewVacancyDataByStatus", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserName", userName);
                command.Parameters.AddWithValue("@UserRole", userRole);
                command.Parameters.AddWithValue("@VacancyStatus", vacancyStatus);

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    dataTable.Load(reader);
                }

                connection.Close();
            }
            return dataTable;
        }
       
        public void ApproveVacancy(int vacancyID)
        {
            string query = $"UPDATE Vacancy SET VacancyStatus = 'Open' WHERE VacancyID = {vacancyID}";
            modify.ExecuteQuery(query);
        }
    }
}

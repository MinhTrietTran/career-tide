using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace DAO
{
    public class NewVacancyDAO
    {
        public int GetEmployerID(string representativeEmail)
        {
            object result = null;
            using (SqlConnection connection = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_GetEmployerID", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào Stored Procedure
                command.Parameters.AddWithValue("@RepresentativeEmail", representativeEmail);


                connection.Open();
                result = command.ExecuteScalar();
                connection.Close();
            }
            return (int)result;
        }

        public int IsContracValid(int employerID)
        {
            object result = null;
            using (SqlConnection connection = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_CheckContractValidity", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào Stored Procedure
                command.Parameters.AddWithValue("@Employer", employerID);
                connection.Open();
                result = command.ExecuteScalar();
                connection.Close();
            }
            return (int)result;
        }

        public void AddNewVacancy(string position, int number, string openDate, string closeDate, string description, string postType, int employerID)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_InsertVacancyDataTriet", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào Stored Procedure
                command.Parameters.AddWithValue("@Position", position);
                command.Parameters.AddWithValue("@Number", number);
                command.Parameters.AddWithValue("@OpenDate", openDate);
                command.Parameters.AddWithValue("@CloseDate", closeDate);
                command.Parameters.AddWithValue("@VacancyDescription", description);
                command.Parameters.AddWithValue("@PostType", postType);
                command.Parameters.AddWithValue("@Employer", employerID);


                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}

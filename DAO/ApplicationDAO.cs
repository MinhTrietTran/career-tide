using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ApplicationDAO
    {
        Modify modify = new Modify();

        public void insertNewApplication(String coverLetter, byte[] cv, byte[] academicTranscript, String applicationStatus, String applicant, int vacancy) {
            
            using (SqlConnection connection = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_InsertApplicationData", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@CoverLetter", coverLetter);
                command.Parameters.AddWithValue("@CV", cv);
                command.Parameters.AddWithValue("@AcademicTranscript", academicTranscript);
                command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                command.Parameters.AddWithValue("@Applicant", applicant);
                command.Parameters.AddWithValue("@Vacancy", vacancy);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void updateApplication(int applicationID, String coverLetter, byte[] cv, byte[] academicTranscript, String applicationStatus)
        {

            using (SqlConnection connection = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_UpdateApplicationData", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@CoverLetter", coverLetter);
                command.Parameters.AddWithValue("@CV", cv);
                command.Parameters.AddWithValue("@AcademicTranscript", academicTranscript);
                command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                command.Parameters.AddWithValue("@ApplicationID", applicationID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable viewAllApplicationDataByStatusForAdmin(string userRole, string applicationStatus)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("sp_ViewApplicationsDataByStatusForAdmin", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserRole", userRole);
                command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    dataTable.Load(reader);
                }

                connection.Close();
            }
            return dataTable;
        }
        public DataTable viewAllApplicationDataByStatusForEmployer(int vacancyID, string userRole, string applicationStatus)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("sp_ViewApplicationsDataByStatusForEmployer", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserRole", userRole);
                command.Parameters.AddWithValue("@VacancyID", vacancyID);
                command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    dataTable.Load(reader);
                }

                connection.Close();
            }
            return dataTable;
        }
        public DataTable viewAllApplicationDataByStatusForApplicant(string applicantEmail, string userRole, string applicationStatus)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("sp_ViewApplicationsDataByStatusForApplicant", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserRole", userRole);
                command.Parameters.AddWithValue("@ApplicantEmail", applicantEmail);
                command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }

                connection.Close();
            }
            return dataTable;
        }
    }
}

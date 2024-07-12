using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DAO
{
    public class ApplicationDAO
    {
        Modify modify = new Modify();


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

        public DataTable LoadApplicationForApplicant(string applicantEmail)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("sp_ViewApplicationForApplicant", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserName", applicantEmail);

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    dataTable.Load(reader);
                }

                connection.Close();
            }
            return dataTable;
        }

        public DataTable LoadApplicationForEmployer(string employerEmail)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("sp_ViewApplicationForEmployer", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserName", employerEmail);

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    dataTable.Load(reader);
                }

                connection.Close();
            }
            return dataTable;
        }

        public DataTable LoadApplicationForAdmin()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("sp_ViewApplicationForAdmin", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    dataTable.Load(reader);
                }

                connection.Close();
            }
            return dataTable;
        }

        public byte[] GetAcademicTranscript(int applicationID)
        {
            string query = "SELECT AcademicTranscript FROM Applications WHERE ApplicationID = @applicationID";

            using (SqlConnection connection = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@applicationID", applicationID);

                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();

                if (result != null && result != DBNull.Value)
                {
                    return (byte[])result;
                }
            }

            return null;
        }

        public byte[] GetCV(int applicationID)
        {
            string query = "SELECT CV FROM Applications WHERE ApplicationID = @applicationID";

            using (SqlConnection connection = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@applicationID", applicationID);

                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();

                if (result != null && result != DBNull.Value)
                {
                    return (byte[])result;
                }
            }

            return null;
        }
    }
}

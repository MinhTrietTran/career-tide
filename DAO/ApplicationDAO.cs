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
    }
}

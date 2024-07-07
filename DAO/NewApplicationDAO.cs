using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace DAO
{
    public class NewApplicationDAO
    {
        public void InsertNewApplication(string coverLetter, byte[] cV, byte[] academicTranscript, string applicant, int vacancy)
        {
            using (SqlConnection conn = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_InsertApplicationData", conn);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào Stored Procedure
                command.Parameters.AddWithValue("@CoverLetter", coverLetter);
                command.Parameters.AddWithValue("@CV", cV);
                command.Parameters.AddWithValue("@AcademicTranscript", academicTranscript);
                command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatusEnum.Pending);
                command.Parameters.AddWithValue("@Applicant", applicant);
                command.Parameters.AddWithValue("@Vacancy", vacancy);


                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}

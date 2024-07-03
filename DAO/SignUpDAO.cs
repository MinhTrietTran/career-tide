using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SignUpDAO
    {
        Modify modify = new Modify();
        public bool IsEmailExist(string email)
        {
            string query = "SELECT COUNT(*) " +
                "FROM Account " +
                $"WHERE Email = '{email}'";
            object result = modify.ExecuteScalar(query);
            if ((int)result > 0)
            {
                return true;
            }
            return false;
        }
        public void InsertNewApplicant(string name, string email, string password)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_InsertApplicantData", connection);
                command.CommandType = CommandType.StoredProcedure;

                String encodedPassword = PasswordUtility.EncodePassword(password);
                // Thêm các tham số vào Stored Procedure
                command.Parameters.AddWithValue("@ApplicantName", name);
                command.Parameters.AddWithValue("ApplicantEmail", email);
                command.Parameters.AddWithValue("@Pwd", encodedPassword);
                

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ContactDAO
    {
        Modify modify = new Modify();
        public bool IsCompanyExist(string companyName)
        {
            string query = "SELECT COUNT(*) " +
                "FROM Employer " +
                $"WHERE CompanyName = '{companyName}'";
            object result = modify.ExecuteScalar(query);
            if ((int)result > 0)
            {
                return true;
            }
            return false;
        }
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
        public void InsertNewEmployer(string fullName, string workTittle, string workEmail, string phoneNumber, string cpnName, string cpnLocation, string taxCode)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_InsertEmployerData", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số vào Stored Procedure
                command.Parameters.AddWithValue("@FullName", fullName);
                command.Parameters.AddWithValue("@WorkTittle", workTittle);
                command.Parameters.AddWithValue("@WorkEmail", workEmail);
                command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                command.Parameters.AddWithValue("@CompanyName", cpnName);
                command.Parameters.AddWithValue("@CompanyLocation", cpnLocation);
                command.Parameters.AddWithValue("@TaxCode", taxCode);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}

using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class EmployerDAO
    {
        Modify modify = new Modify();

        // Nghe thuat vcl
        public DataTable GetCompanyData(string role)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_ViewEmployerData", conn);
                command.CommandType = CommandType.StoredProcedure;
                // Thêm tham số vào Stored Procedure
                command.Parameters.AddWithValue("@UserRole", role);
                conn.Open();
                using (command)
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        dataTable.Load(reader);
                    }
                }
                conn.Close();
            }
            return dataTable;
        }

        public void InsertNewContract(string startDate, string endDate, string constractInfo, int employerID)
        {
            string query = "INSERT INTO Constract (StartDate, EndDate, ConstractInfo, Employer) " +
                $"VALUES ('{startDate}', '{endDate}', '{constractInfo}', {employerID})";
            modify.ExecuteQuery(query);
        }

        public string GetEmployerEmail(int employerID)
        {
            string query = $"SELECT Representative FROM Employer WHERE EmployerID = {employerID}";
            return (string)modify.ExecuteScalar(query);
        }
    }
}

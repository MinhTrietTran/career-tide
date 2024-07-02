using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Collections;

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
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Modify
    {
        public DataTable LoadTableSys(string query) // Tra ve bang du lieu
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
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

        public void ExecuteQuery(string query) // Thuc thi cau lenh
        {
            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        public object ExecuteScalar(string query)
        {
            object result = null;
            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    result = command.ExecuteScalar();
                }
                conn.Close();
            }
            return result;
        } 

    }
}

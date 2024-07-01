using System.Data.SqlClient;

namespace DAO
{
    public class Connection
    {
        public static SqlConnection GetConnection()
        {
            // Thay cai nay bang cai cua ban
            string connectionString = "Server=LAPTOP-DRT7Q636;Database=CareerTide;User Id=sa;Password=heongusi22";

            //string connectionString = "Data Source=DESKTOP-1VJ4V0K;Initial Catalog=CareerTide;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

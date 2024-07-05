using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PaymentDAO
    {
        Modify modify = new Modify();   

        public bool insertNewPaymentData(float amount, string paymentType, int vacancyID)
        {
            bool result = false;

            using (SqlConnection connection = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_InsertPaymentData", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@PaymentType", paymentType);
                command.Parameters.AddWithValue("@Vacancy", vacancyID);
                command.Parameters.AddWithValue("@result", result);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            return result;
        }

        public DataTable getAllPaymentDataByVacancyID(int vacancyID)
        {
            return modify.LoadTableSys($"SELECT * FROM Payment WHERE Vacancy={vacancyID}");
        }
    }
}

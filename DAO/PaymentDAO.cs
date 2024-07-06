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
                //    SqlCommand command = new SqlCommand("sp_InsertPaymentData", connection);
                //    command.CommandType = CommandType.StoredProcedure;

                //    command.Parameters.AddWithValue("@Amount", amount);
                //    command.Parameters.AddWithValue("@PaymentType", paymentType);
                //    command.Parameters.AddWithValue("@Vacancy", vacancyID);
                //    command.Parameters.AddWithValue("@result", result);

                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();
                using (SqlCommand command = new SqlCommand("sp_InsertPaymentData", connection))
                {
                    // Set the command type to stored procedure
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the stored procedure
                    command.Parameters.Add("@Amount", SqlDbType.Float).Value = amount;
                    command.Parameters.Add("@PaymentType", SqlDbType.VarChar, 10).Value = paymentType;
                    command.Parameters.Add("@Vacancy", SqlDbType.Int).Value = vacancyID;

                    // Add output parameter for the boolean result
                    SqlParameter resultParam = new SqlParameter("@result", SqlDbType.Bit);
                    resultParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(resultParam);

                    // Open the database connection
                    connection.Open();

                    // Execute the stored procedure
                    command.ExecuteNonQuery();

                    // Get the result from the output parameter
                    result = (bool)command.Parameters["@result"].Value;
                    connection.Close();
                }
            }

            return result;
        }

        public DataTable getAllPaymentDataByVacancyID(int vacancyID)
        {
            return modify.LoadTableSys($"SELECT * FROM Payment WHERE Vacancy={vacancyID}");
        }

        public float GetRemainingCost(int vacancyID)
        {
            float remainingCost = 0.0f;

            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT [dbo].[fn_GetRemainingCost](@VacancyId)", connection))
                {
                    command.Parameters.AddWithValue("@VacancyId", vacancyID);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        remainingCost = Convert.ToSingle(result);
                    }
                }
                connection.Close();
            }

            return remainingCost;
        }

        public string GetCompanyName(int employerID)
        {
            string query = $"SELECT CompanyName FROM Employer WHERE EmployerID={employerID}";
            return modify.LoadTableSys(query).Rows[0][0].ToString();
        } 

       

    }
}

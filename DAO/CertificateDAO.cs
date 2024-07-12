using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CertificateDAO
    {
        Modify modify = new Modify();  

        public void insertNewCertificate(int applicationID, byte[] certificateFile)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_InsertCertificateData", connection);
                command.CommandType = CommandType.StoredProcedure;
               
                command.Parameters.AddWithValue("@CertificateFile", certificateFile);
                command.Parameters.AddWithValue("@Applications", applicationID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void updateCertificate(int certificateID, byte[] certificateFile)
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand("sp_UpdateCertificateData", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@CertificateFile", certificateFile);
                command.Parameters.AddWithValue("@CertificateID", certificateID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public int GetLastestApplicationID()
        {
            string query = "SELECT TOP 1 ApplicationID FROM Applications " +
                "ORDER BY ApplicationID DESC";
            return (int)modify.ExecuteScalar(query);
        }

        public List<byte[]> GetCertificatesByApplicationID(int applicationID)
        {
            List<byte[]> certificates = new List<byte[]>();
            string query = "SELECT CertificateFile FROM Certificate WHERE Applications = @ApplicationID";

            using (SqlConnection conn = Connection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageData = reader["CertificateFile"] as byte[];
                            if (imageData != null)
                            {
                                certificates.Add(imageData);
                            }
                        }
                    }
                }
            }
            return certificates;
        }
    
    }
}

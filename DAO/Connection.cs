﻿using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DAO
{
    public class Connection
    {
        public static SqlConnection GetConnection()
        {
            /* Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
             ConnectionStringSettings connectionStringSettings = config.ConnectionStrings.ConnectionStrings["CareerTide"];
             string connectionString = connectionStringSettings.ConnectionString;*/

            /*ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["CareerTide"];
            string connectionString = connectionStringSettings.ConnectionString;*/

            // Thay cai nay bang cai cua ban
            string connectionString = "Data Source=LAPTOP-I1KLF7HH;Initial Catalog=CareerTide;Integrated Security=True";

            Console.WriteLine("connectionString: " + connectionString);

            //string connectionString = "Data Source=DESKTOP-1VJ4V0K;Initial Catalog=CareerTide;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

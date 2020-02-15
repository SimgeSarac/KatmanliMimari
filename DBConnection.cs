using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Katmanli_AutoMapper.DAL
{
    public class DBConnection
    {
        public string _connectionString;

        public DBConnection()
        {
            _connectionString = "Data Source=MSI;Initial Catalog=Northwind;Integrated Security=True";
        }

        private SqlConnection GetSqlConnection()
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
            {
                connection.Open();
            }
            return connection;
        }
        public SqlCommand GetSqlCommand()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = GetSqlConnection();
            return command;
        }
    }
}

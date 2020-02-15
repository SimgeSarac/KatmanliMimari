using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Katmanli_AutoMapper.Entity;

namespace Katmanli_AutoMapper.DAL
{
    public class CustomerSqlRepository : ICustomerRepository
    {
        private DBConnection dbConnection;
        public CustomerSqlRepository()
        {
            dbConnection = new DBConnection();
        }
        public List<Customer> GetAllItems()
        {
            SqlCommand command = dbConnection.GetSqlCommand();
            command.CommandText = "Select Top 3 * From Customers";

            List<Customer> customers = new List<Customer>();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Customer customer = new Customer();

                customer.CustomerID = reader["CustomerID"].ToString();
                customer.CompanyName = reader["CompanyName"].ToString();
                customer.ContactName = reader["ContactName"].ToString();
                customer.ContactTitle = reader["ContactTitle"].ToString();
                customer.Address = reader["Address"].ToString();
                customer.City = reader["City"].ToString();
                customer.Region = reader["Region"].ToString();
                customer.PostalCode = reader["PostalCode"].ToString();
                customer.Country = reader["Country"].ToString();
                customer.Phone = reader["Phone"].ToString();
                customer.Fax = reader["Fax"].ToString();

                customers.Add(customer);
            }
            return customers;
        }

        public void AddNewItem(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers(FilterRepositoryDto filter)
        {
            SqlCommand command = dbConnection.GetSqlCommand();
            command.CommandText = $"{filter.CompanyName}";


            List<Customer> customers = new List<Customer>();
            

            Customer customer = new Customer();
            customer.CompanyName = command.CommandText.ToString();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(customer.CompanyName);
            Console.WriteLine(sb.ToString());
                                                

            customers.Add(customer);

            return customers;
        }
        
    }
}

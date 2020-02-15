using System;
using System.Collections.Generic;
using System.Text;
using Katmanli_AutoMapper.Entity;

namespace Katmanli_AutoMapper.DAL
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers(FilterRepositoryDto filter);
        List<Customer> GetAllItems();
        void AddNewItem(Customer customer);
    }
}

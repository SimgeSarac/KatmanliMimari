using System;
using System.Collections.Generic;
using System.Text;
using Katmanli_AutoMapper.Entity;

namespace Katmanli_AutoMapper.BL
{
    public interface ICustomerService
    {
        List<Customer> Filter(FilterDto filter);
        List<Customer> GetAllItems();
        void AddNewItem(Customer customer);
    }
}

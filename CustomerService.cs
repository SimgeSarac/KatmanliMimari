using System;
using System.Collections.Generic;
using System.Text;
using Katmanli_AutoMapper.Entity;
using Katmanli_AutoMapper.DAL;
using AutoMapper;

namespace Katmanli_AutoMapper.BL
{
    public class CustomerService : ICustomerService
    {
        public ICustomerRepository customerRepository;
        private readonly IMapper mapper;

        public CustomerService(ICustomerRepository _customerRepository, IMapper _mapper)
        {
            customerRepository = _customerRepository;
            mapper = _mapper;
        }
        public List<Customer> GetAllItems()
        {
            return customerRepository.GetAllItems();
        }

        public void AddNewItem(Customer customer)
        {
            customerRepository.AddNewItem(customer);
        }

        public List<Customer> Filter(FilterDto filter)
        {
            var respoFilter = mapper.Map<FilterRepositoryDto>(filter);
            var customers = customerRepository.GetCustomers(respoFilter);
            return customers;
        }
    }
}

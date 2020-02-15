using System;
using Katmanli_AutoMapper.DAL;
using Katmanli_AutoMapper.Entity;
using Katmanli_AutoMapper.BL;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

namespace Katmanli_AutoMapper.UI.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddSingleton<ICustomerService, CustomerService>();
            services.AddSingleton<ICustomerRepository, CustomerSqlRepository>();

            FilterDto filter = new FilterDto();
            var config = new MapperConfiguration(cfg =>{
                cfg.AddProfile(new MappingProfile());
            });
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            IServiceProvider provider = services.BuildServiceProvider();

            ICustomerService customerService = provider.GetService<ICustomerService>();

            var customers = customerService.GetAllItems();

            foreach (var customer in customers)
            {
                System.Console.WriteLine(customer);
            }

            var filterDto = new FilterDto()
            {
                CompanyName = "ASD"                           
            };
            customers = customerService.Filter(filterDto);
            System.Console.ReadLine();
        }
    }
}

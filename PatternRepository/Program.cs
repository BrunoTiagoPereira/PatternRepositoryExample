using System;
using System.Linq;
using Ninject;
using PatternRepository.Interfaces;
using PatternRepository.Repositories;
using PatternRepository.Services;

namespace PatternRepository
{
    internal class Program
    {
        private static ICustomerService _customerService;
        private static IKernel _container;

        public static void ResolveDependencies()
        {
            _container = new StandardKernel();

            _container.Bind<ICustomerRepository>().To<CustomerRepository>();
            _container.Bind<ICustomerService>().To<CustomerService>();
        }

        private static void Main(string[] args)
        {
            ResolveDependencies();

            _customerService = _container.Get<ICustomerService>();

            _customerService.GetCustomers();

            var customers = _customerService.GetCustomers();

            //Id inválido - Simulação validação na camada de negócio
            var customerById = _customerService.GetCustomerById(1);

            //Id válido
            var customerById2 = _customerService.GetCustomerById(2);

            var customersInfo = customers
                .Select(cli => cli.Name)
                .Aggregate((a, b) => $"{a}{Environment.NewLine}{b}");

            Console.WriteLine(customersInfo);
            Console.ReadKey();
        }
    }
}
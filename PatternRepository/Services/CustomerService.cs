using System.Collections.Generic;
using PatternRepository.Interfaces;

namespace PatternRepository.Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }

        public Customer GetCustomerById(int id)
        {
            if (id == 1) return null;

            return _customerRepository.GetCustomerById(id);
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using PatternRepository.Interfaces;

namespace PatternRepository.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private static List<Customer> _mockCustomers = new List<Customer>
        {
            new Customer(1, "Guilherme"),
            new Customer(2, "Pedro"),
            new Customer(3, "Yuske"),
            new Customer(4, "Brun"),
            new Customer(5, "Luiz"),
            new Customer(6, "Caio"),
        };

        public IEnumerable<Customer> GetCustomers()
        {
            return _mockCustomers;
        }

        public Customer GetCustomerById(int id)
        {
            return _mockCustomers.FirstOrDefault(cli => cli.Id == id);
        }
    }
}
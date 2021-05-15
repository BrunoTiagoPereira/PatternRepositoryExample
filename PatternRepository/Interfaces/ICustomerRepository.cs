using System.Collections.Generic;

namespace PatternRepository.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();

        Customer GetCustomerById(int id);
    }
}
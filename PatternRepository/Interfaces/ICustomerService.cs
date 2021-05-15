using System.Collections.Generic;

namespace PatternRepository.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();

        Customer GetCustomerById(int id);
    }
}
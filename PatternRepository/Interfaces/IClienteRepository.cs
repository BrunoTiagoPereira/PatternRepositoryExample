using System.Collections.Generic;

namespace PatternRepository.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetClientes();

        Cliente GetClienteById(int id);
    }
}
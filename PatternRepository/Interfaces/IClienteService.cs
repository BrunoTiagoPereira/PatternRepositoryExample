using System.Collections.Generic;

namespace PatternRepository.Interfaces
{
    public interface IClienteService
    {
        IEnumerable<Cliente> GetClientes();

        Cliente GetClienteById(int id);
    }
}
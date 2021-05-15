using System.Collections.Generic;
using PatternRepository.Interfaces;

namespace PatternRepository.Services
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> GetClientes()
        {
            return _clienteRepository.GetClientes();
        }

        public Cliente GetClienteById(int id)
        {
            if (id != 1) return null;

            return _clienteRepository.GetClienteById(id);
        }
    }
}
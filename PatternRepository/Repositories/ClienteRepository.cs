using System.Collections.Generic;
using System.Linq;
using PatternRepository.Interfaces;

namespace PatternRepository.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private static List<Cliente> _mockClientes = new List<Cliente>
        {
            new Cliente(1, "Guilherme", "1234567800145", 24),
            new Cliente(2, "Pedro", "15218381654", 21),
            new Cliente(3, "Yuske", "12345678454", 22),
            new Cliente(4, "Bruno", "15244381655", 19),
            new Cliente(5, "Luiz", "12121214458", 26),
            new Cliente(6, "Caio", "12121215555", 23),
        };

        public IEnumerable<Cliente> GetClientes()
        {
            return _mockClientes;
        }

        public Cliente GetClienteById(int id)
        {
            return _mockClientes.FirstOrDefault(cli => cli.Id == id);
        }
    }
}
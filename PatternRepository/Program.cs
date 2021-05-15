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
        private static IClienteService _clienteService;
        private static IKernel _container;

        public static void ResolveDependencies()
        {
            _container = new StandardKernel();

            _container.Bind<IClienteRepository>().To<ClienteRepository>();
            _container.Bind<IClienteService>().To<ClienteService>();
        }

        private static void Main(string[] args)
        {
            ResolveDependencies();

            _clienteService = _container.Get<IClienteService>();

            _clienteService.GetClientes();

            var clientes = _clienteService.GetClientes();

            //Id Existe
            var clientById = _clienteService.GetClienteById(1);

            //Id errado - Simulação validação na camada de negócio
            var clientById2 = _clienteService.GetClienteById(2);

            var clientesInfo = clientes
                .Select(cli => cli.Nome)
                .Aggregate((a, b) => $"{a}{Environment.NewLine}{b}");

            Console.WriteLine(clientesInfo);
            Console.ReadKey();
        }
    }
}
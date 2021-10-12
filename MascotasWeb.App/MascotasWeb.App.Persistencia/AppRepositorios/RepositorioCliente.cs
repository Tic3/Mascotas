


using System.Collections.Generic;
using MascotasWeb.App.Dominio;

namespace MascotasWeb.App.Persistencia
{
    public class RepositorioClienteaIRepositorioCliente
    {
        private readonly AppContext _appContext;

     
        public Cliente addCliente(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Cliente> GetAllClientes()
        {
            throw new System.NotImplementedException();
        }

        public Cliente UpdateCliente(Cliente cliente);
        void DeleteCliente(int idCliente);

        void IRepositorioCliente.DeleteCliente(int idCliente)
        {
            throw new System.NotImplementedException();
        }

        Cliente GetCliente(int idCliente);

        Cliente IRepositorioCliente.GetCliente(int idCliente)
        {
            throw new System.NotImplementedException();
        }
    }
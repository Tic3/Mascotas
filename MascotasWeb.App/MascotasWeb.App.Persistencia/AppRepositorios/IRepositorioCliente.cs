using System.Collections.Generic;
using MascotasWeb.App.Dominio;

namespace MascotasWeb.App.Persistencia
{
    public interface IRepositorioCliente
    {
    //firma de los METODOS
        IEnumerable<Cliente> GetAllClientes();
        //firma de los METODOS
        Cliente addCliente(Cliente cliente);
        Cliente UpdateCliente(Cliente cliente);
        void DeleteCliente(int idCliente);
        Cliente GetCliente(int idCliente);

    }
}

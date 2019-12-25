using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.Models
{
    public interface IClienteDAL
    {
        IEnumerable<Cliente> GetAllClientes();
        void AddCliente(Cliente cliente);
        void UpdateCliente(Cliente cliente);
        Cliente GetCliente(string id);
        void DeleteCliente(string id);
    }
}

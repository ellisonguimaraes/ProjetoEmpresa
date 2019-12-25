using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.Models
{
    public interface IPedidoDAL
    {
        IEnumerable<Pedido> GetAllPedidos();
        void AddPedido(Pedido pedido);
        void UpdatePedido(Pedido pedido);
        Pedido GetPedido(int? id);
        void DeletePedido(int? id);
    }
}

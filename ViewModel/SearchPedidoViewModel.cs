using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.ViewModel
{
    public class SearchPedidoViewModel
    {
        public string Search { get; set; }

        public IEnumerable<PedidoViewModel> Pedidos { get; set; }
    }
}

using BDApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.ViewModel
{
    public class DetalhesPedViewModel
    {
        public int NumPed { get; set; }
        public int CodProd { get; set; }
        public string Prod { get; set; }
        public double Preco { get; set; }
        public int Qtde { get; set; }
        public double Desconto { get; set; }

        public List<Pedido> Pedidos { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}

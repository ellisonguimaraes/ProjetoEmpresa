using BDApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.ViewModel
{
    public class ProdutoViewModel
    {
        public int CodProd { get; set; }
        public string Descr { get; set; }
        public double Preco { get; set; }
        public int Unidades { get; set; }
        public int Descontinuado { get; set; }
        public int CodFor { get; set; }
        public string For { get; set; }
        public int CodCategoria { get; set; }
        public string Categoria { get; set; }

        public List<Fornecedor> FornecedoresList { get; set; }
        public List<Categoria> CategoriasList { get; set; }
    }
}

using BDApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.ViewModel
{
    public class SearchProdutoViewModel
    {
        public string Search { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }

    }
}

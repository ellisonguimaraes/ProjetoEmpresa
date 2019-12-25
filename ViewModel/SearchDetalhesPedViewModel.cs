using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.ViewModel
{
    public class SearchDetalhesPedViewModel
    {
        public string Search { get; set; }
        public IEnumerable<DetalhesPedViewModel> DetalhesPed { get; set; }
    }
}

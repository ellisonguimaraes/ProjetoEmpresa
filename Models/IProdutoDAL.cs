using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.Models
{
    public interface IProdutoDAL
    {
        IEnumerable<Produto> GetAllProdutos();
        void AddProduto(Produto produto);
        void UpdateProduto(Produto produto);
        Produto GetProduto(int? id);
        void DeleteProduto(int? id);
    }
}

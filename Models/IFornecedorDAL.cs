using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.Models
{
    public interface IFornecedorDAL
    {
        IEnumerable<Fornecedor> GetAllFornecedores();
        void AddFornecedor(Fornecedor fornecedor);
        void UpdateFornecedor(Fornecedor fornecedor);
        Fornecedor GetFornecedor(int? id);
        void DeleteFornecedor(int? id);
    }
}

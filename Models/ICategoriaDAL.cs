using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.Models
{
    public interface ICategoriaDAL
    {
        IEnumerable<Categoria> GetAllCategorias();
        void AddCategoria(Categoria categoria);
        void UpdateCategoria(Categoria categoria);
        Categoria GetCategoria(int? id);
        void DeleteCategoria(int? id);
    }
}

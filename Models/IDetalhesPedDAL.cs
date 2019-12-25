using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.Models
{
    public interface IDetalhesPedDAL
    {
        IEnumerable<DetalhesPed> GetAllDetalhesPed();
        void AddDetalhesPed(DetalhesPed detalhesped);
        void UpdateDetalhesPed(DetalhesPed detalhesped);
        DetalhesPed GetDetalhesPed(int? NumPed, int? CodProd);
        void DeleteDetalhesPed(int? NumPed, int? CodProd);
    }
}

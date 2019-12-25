using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.Models
{
    [Table("DetalhesPed")]
    public class DetalhesPed
    {
        public int NumPed { get; set; }
        public int CodProd { get; set; }
        public double Preco { get; set; }
        public int Qtde { get; set; }
        public double Desconto { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int CodProd { get; set; }
        public string Descr { get; set; }
        public double Preco { get; set; }
        public int Unidades { get; set; }
        public int Descontinuado { get; set; }
        public int CodFor { get; set; }
        public int CodCategoria { get; set; }
    }
}

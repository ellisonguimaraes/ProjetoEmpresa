using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int NumPed { get; set; }
        public string CodCli { get; set; }
        public int CodFun { get; set; }
        public DateTime DataPed { get; set; }
        public DateTime DataEntrega { get; set; }
        public double Frete { get; set; }
    }
}

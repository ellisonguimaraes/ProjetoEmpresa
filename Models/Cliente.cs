using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public string CodCli { get; set; }
        public string Nome { get; set; }
        public string Contato { get; set; }
        public string Cargo { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Regiao { get; set; }
        public string CEP { get; set; }
        public string Pais { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }

    }
}

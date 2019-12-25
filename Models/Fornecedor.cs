using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.Models
{
    [Table("Fornecedores")]
    public class Fornecedor
    {
        [Key]
        public int CodFor { get; set; }

        public string Empresa { get; set; }

        public string Contato { get; set; }

        public string Cargo { get; set; }

        public string Endereco { get; set; }

        public string Cidade { get; set; }

        public string Cep { get; set; }

        public string Pais { get; set; }
    }
}

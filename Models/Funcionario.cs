using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.Models
{
    [Table("Funcionarios")]
    public class Funcionario
    {
        [Key]
        public int CodFun { get; set; }
        public string Sobrenome { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public DateTime DataNasc { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Pais { get; set; }
        public string Fone { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public Decimal Salario { get; set; }

    }
}

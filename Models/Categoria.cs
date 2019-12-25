using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.Models
{
    [Table("Categorias")]
    public class Categoria
    {   
        [Key]
        public int CodCategoria { get; set; }

        [Required]
        public string Descr { get; set; }
    }
}

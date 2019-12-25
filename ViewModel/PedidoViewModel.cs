using BDApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BDApplication.ViewModel
{
    public class PedidoViewModel
    {
        public int NumPed { get; set; }
        public string CodCli { get; set; }
        public string Cli { get; set; }
        public int CodFun { get; set; }
        public string Fun { get; set; }
        public DateTime DataPed { get; set; }
        public DateTime DataEntrega { get; set; }
        public double Frete { get; set; }

        public List<Cliente> ClientesList { get; set; }
        public List<Funcionario> FuncionariosList { get; set; }
    }
}

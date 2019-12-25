using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BDApplication.Models;

namespace BDApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoDAL _produtos;
        private readonly ICategoriaDAL _categorias;
        private readonly IFornecedorDAL _fornecedores;
        private readonly IFuncionarioDAL _funcionarios;
        private readonly IClienteDAL _clientes;
        private readonly IPedidoDAL _pedidos;
        private readonly IDetalhesPedDAL _detalhesped;

        public HomeController(IProdutoDAL produtos, ICategoriaDAL categorias, IFornecedorDAL fornecedores, 
                                IFuncionarioDAL funcionarios, IClienteDAL clientes, IPedidoDAL pedidos, IDetalhesPedDAL detalhesped)
        {
            _produtos = produtos;
            _categorias = categorias;
            _fornecedores = fornecedores;
            _funcionarios = funcionarios;
            _clientes = clientes;
            _pedidos = pedidos;
            _detalhesped = detalhesped;
        }

        public IActionResult Index()
        {
            ViewData["qtd_produtos"] = _produtos.GetAllProdutos().ToList().Count;
            ViewData["qtd_categorias"] = _categorias.GetAllCategorias().ToList().Count;
            ViewData["qtd_fornecedores"] = _fornecedores.GetAllFornecedores().ToList().Count;
            ViewData["qtd_funcionarios"] = _funcionarios.GetAllFuncionarios().ToList().Count;
            ViewData["qtd_clientes"] = _clientes.GetAllClientes().ToList().Count;
            ViewData["qtd_pedidos"] = _pedidos.GetAllPedidos().ToList().Count;
            ViewData["qtd_detalhesped"] = _detalhesped.GetAllDetalhesPed().ToList().Count;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

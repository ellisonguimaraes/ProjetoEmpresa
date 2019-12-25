using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDApplication.Models;
using BDApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BDApplication.Controllers
{
    public class PedidosController : Controller
    {
        private readonly IPedidoDAL _pedidos;
        private readonly IFuncionarioDAL _funcionarios;
        private readonly IClienteDAL _clientes;

        public PedidosController(IPedidoDAL pedidos, IFuncionarioDAL funcionarios, IClienteDAL clientes)
        {
            _pedidos = pedidos;
            _funcionarios = funcionarios;
            _clientes = clientes;
        }

        public List<PedidoViewModel> ToPedidoViewModel()
        {
            List<PedidoViewModel> pedidoViewModel = new List<PedidoViewModel>();

            List<Pedido> pedidos = new List<Pedido>();
            pedidos = _pedidos.GetAllPedidos().ToList();

            foreach(var item in pedidos)
            {
                pedidoViewModel.Add(new PedidoViewModel()
                {
                    NumPed = item.NumPed,
                    CodCli = item.CodCli,
                    CodFun = item.CodFun,
                    DataEntrega = item.DataEntrega,
                    DataPed = item.DataPed,
                    Frete = item.Frete,
                    Cli = _clientes.GetCliente(item.CodCli).Nome,
                    Fun = _funcionarios.GetFuncionario(item.CodFun).Nome
                });
            }

            return pedidoViewModel;
        }

        [HttpGet]
        public IActionResult Index()
        {
            SearchPedidoViewModel searchPedidoViewModel = new SearchPedidoViewModel() {
                Pedidos = ToPedidoViewModel()
            };

            return View(searchPedidoViewModel);
        }

        [HttpPost]
        public IActionResult Index([Bind]SearchPedidoViewModel searchPedidoViewModel)
        {
            if (ModelState.IsValid && !string.IsNullOrEmpty(searchPedidoViewModel.Search))
            {
                searchPedidoViewModel.Pedidos = ToPedidoViewModel().Where(p => p.NumPed.ToString().ToLower().Contains(searchPedidoViewModel.Search.ToLower()));

            }
            else
            {
                searchPedidoViewModel.Pedidos = ToPedidoViewModel();
            }

            return View(searchPedidoViewModel);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pedido pedido = _pedidos.GetPedido(id);

            if (pedido == null)
            {
                return NotFound();
            }

            PedidoViewModel pedidoViewModel = new PedidoViewModel()
            {
                CodCli = pedido.CodCli,
                CodFun = pedido.CodFun,
                NumPed = pedido.NumPed,
                DataEntrega = pedido.DataEntrega,
                DataPed = pedido.DataPed,
                Frete = pedido.Frete,
                Fun = _funcionarios.GetFuncionario(pedido.CodFun).Nome,
                Cli = _clientes.GetCliente(pedido.CodCli).Nome
            };

            return View(pedidoViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            PedidoViewModel pedidoViewModel = new PedidoViewModel() {
                DataPed = DateTime.Now,
                DataEntrega = DateTime.Now,
                FuncionariosList = _funcionarios.GetAllFuncionarios().ToList(),
                ClientesList = _clientes.GetAllClientes().ToList()
            };

            return View(pedidoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] PedidoViewModel pedidoViewModel)
        {
            if (ModelState.IsValid)
            {
                _pedidos.AddPedido(new Pedido()
                {
                    CodCli = pedidoViewModel.CodCli,
                    CodFun = pedidoViewModel.CodFun,
                    NumPed = pedidoViewModel.NumPed,
                    DataEntrega = pedidoViewModel.DataEntrega,
                    DataPed = pedidoViewModel.DataPed,
                    Frete = pedidoViewModel.Frete
                });
                return RedirectToAction("Index");
            }

            return View(pedidoViewModel);
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pedido pedido = _pedidos.GetPedido(id);

            if (pedido == null)
            {
                return NotFound();
            }

            PedidoViewModel pedidoViewModel = new PedidoViewModel()
            {
                CodCli = pedido.CodCli,
                CodFun = pedido.CodFun,
                NumPed = pedido.NumPed,
                DataEntrega = pedido.DataEntrega,
                DataPed = pedido.DataPed,
                Frete = pedido.Frete,
                FuncionariosList = _funcionarios.GetAllFuncionarios().ToList(),
                ClientesList = _clientes.GetAllClientes().ToList()
            };

            return View(pedidoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, [Bind] PedidoViewModel pedidoViewModel)
        {

            if (id != pedidoViewModel.NumPed)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _pedidos.UpdatePedido(new Pedido() {
                    CodCli = pedidoViewModel.CodCli,
                    CodFun = pedidoViewModel.CodFun,
                    NumPed = pedidoViewModel.NumPed,
                    DataEntrega = pedidoViewModel.DataEntrega,
                    DataPed = pedidoViewModel.DataPed,
                    Frete = pedidoViewModel.Frete
                });
                return RedirectToAction("Index");
            }

            return View(pedidoViewModel);
        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pedido pedido = _pedidos.GetPedido(id);

            if (pedido == null)
            {
                return NotFound();
            }

            PedidoViewModel pedidoViewModel = new PedidoViewModel()
            {
                CodCli = pedido.CodCli,
                CodFun = pedido.CodFun,
                NumPed = pedido.NumPed,
                DataEntrega = pedido.DataEntrega,
                DataPed = pedido.DataPed,
                Frete = pedido.Frete,
                Fun = _funcionarios.GetFuncionario(pedido.CodFun).Nome,
                Cli = _clientes.GetCliente(pedido.CodCli).Nome
            };

            return View(pedidoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            _pedidos.DeletePedido(id);
            return RedirectToAction("Index");
        }
    }
}
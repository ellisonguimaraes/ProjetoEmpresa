using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDApplication.Models;
using BDApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BDApplication.Controllers
{
    public class DetalhespedController : Controller
    {
        private readonly IDetalhesPedDAL _detalhesped;
        private readonly IPedidoDAL _pedidos;
        private readonly IProdutoDAL _produtos;
        public DetalhespedController(IDetalhesPedDAL detalhesped, IPedidoDAL pedidos, IProdutoDAL produtos)
        {
            _detalhesped = detalhesped;
            _pedidos = pedidos;
            _produtos = produtos;
        }

        public List<DetalhesPedViewModel> ToDetalhesPedViewModel()
        {
            List<DetalhesPedViewModel> detalhespedViewModel = new List<DetalhesPedViewModel>();

            List<DetalhesPed> detalhesped = new List<DetalhesPed>();
            detalhesped = _detalhesped.GetAllDetalhesPed().ToList();

            foreach (var item in detalhesped)
            {
                detalhespedViewModel.Add(new DetalhesPedViewModel()
                {
                    NumPed = item.NumPed,
                    CodProd = item.CodProd,
                    Prod = _produtos.GetProduto(item.CodProd).Descr,
                    Preco = item.Preco,
                    Qtde = item.Qtde,
                    Desconto = item.Desconto
                });
            }

            return detalhespedViewModel;
        }

        [HttpGet]
        public IActionResult Index(int? NumPed)
        {
            SearchDetalhesPedViewModel searchDetalhesPedViewModel = new SearchDetalhesPedViewModel();

            if (NumPed == null)
            {
                searchDetalhesPedViewModel.DetalhesPed = ToDetalhesPedViewModel();
            }
            else
            {
                searchDetalhesPedViewModel.DetalhesPed = ToDetalhesPedViewModel().Where(p => p.NumPed.ToString().ToLower().Contains(NumPed.ToString().ToLower()));
            }
            
            return View(searchDetalhesPedViewModel);
        }

        [HttpPost]
        public IActionResult Index([Bind] SearchDetalhesPedViewModel searchDetalhesPedViewModel)
        {
            if (ModelState.IsValid && !string.IsNullOrEmpty(searchDetalhesPedViewModel.Search))
            {
                searchDetalhesPedViewModel.DetalhesPed = ToDetalhesPedViewModel().Where(p => p.NumPed.ToString().ToLower().Contains(searchDetalhesPedViewModel.Search.ToLower()));

            }
            else
            {
                searchDetalhesPedViewModel.DetalhesPed = ToDetalhesPedViewModel();
            }

            return View(searchDetalhesPedViewModel);
        }

        [HttpGet]
        public IActionResult Details(int? NumPed, int? CodProd)
        {
            if (NumPed == null || CodProd == null)
            {
                return NotFound();
            }

            DetalhesPed dp = _detalhesped.GetDetalhesPed(NumPed, CodProd);

            if (dp == null)
            {
                return NotFound();
            }

            DetalhesPedViewModel dpvm = new DetalhesPedViewModel() {
                CodProd = dp.CodProd,
                NumPed = dp.NumPed,
                Desconto = dp.Desconto,
                Preco = dp.Preco,
                Qtde = dp.Qtde,
                Prod = _produtos.GetProduto(dp.CodProd).Descr
            };

            return View(dpvm);
        }

        [HttpGet]
        public IActionResult Create()
        {
            DetalhesPedViewModel dpvm = new DetalhesPedViewModel()
            {
                Pedidos = _pedidos.GetAllPedidos().ToList(),
                Produtos = _produtos.GetAllProdutos().ToList()
            };

            return View(dpvm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] DetalhesPedViewModel dpvm)
        {
            if (ModelState.IsValid)
            {
                _detalhesped.AddDetalhesPed(new DetalhesPed()
                {
                    CodProd = dpvm.CodProd,
                    NumPed = dpvm.NumPed,
                    Desconto = dpvm.Desconto,
                    Preco = dpvm.Preco,
                    Qtde = dpvm.Qtde
                });
                return RedirectToAction("Index");
            }

            return View(dpvm);
        }


        [HttpGet]
        public IActionResult Edit(int? NumPed, int? CodProd)
        {
            if (NumPed == null || CodProd == null)
            {
                return NotFound();
            }

            DetalhesPed pd = _detalhesped.GetDetalhesPed(NumPed, CodProd);

            if (pd == null)
            {
                return NotFound();
            }

            return View(pd);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? NumPed, int? CodProd, [Bind] DetalhesPed dp)
        {

            if (NumPed == null || CodProd == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _detalhesped.UpdateDetalhesPed(dp);
                return RedirectToAction("Index");
            }

            return View(dp);
        }


        [HttpGet]
        public IActionResult Delete(int? NumPed, int? CodProd)
        {
            if (NumPed == null || CodProd == null)
            {
                return NotFound();
            }

            DetalhesPed dp = _detalhesped.GetDetalhesPed(NumPed, CodProd);

            if (dp == null)
            {
                return NotFound();
            }

            DetalhesPedViewModel dpvm = new DetalhesPedViewModel()
            {
                CodProd = dp.CodProd,
                NumPed = dp.NumPed,
                Desconto = dp.Desconto,
                Preco = dp.Preco,
                Qtde = dp.Qtde,
                Prod = _produtos.GetProduto(dp.CodProd).Descr
            };

            return View(dpvm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? NumPed, int? CodProd)
        {
            _detalhesped.DeleteDetalhesPed(NumPed, CodProd);
            return RedirectToAction("Index");
        }

    }
}
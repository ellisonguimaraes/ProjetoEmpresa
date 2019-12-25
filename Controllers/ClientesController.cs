using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDApplication.Models;
using BDApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BDApplication.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteDAL _clientes;

        public ClientesController(IClienteDAL clientes)
        {
            _clientes = clientes;
        }

        [HttpGet]
        public IActionResult Index()
        {
            SearchClienteViewModel searchClienteViewModel = new SearchClienteViewModel()
            {
                Clientes = _clientes.GetAllClientes().ToList()
            };

            return View(searchClienteViewModel);
        }

        [HttpPost]
        public IActionResult Index([Bind] SearchClienteViewModel searchClienteViewModel)
        {
            if (ModelState.IsValid && !string.IsNullOrEmpty(searchClienteViewModel.Search))
            {
                searchClienteViewModel.Clientes = _clientes.GetAllClientes().ToList().Where(p => p.Nome.ToLower().Contains(searchClienteViewModel.Search.ToLower()));

            }
            else
            {
                searchClienteViewModel.Clientes = _clientes.GetAllClientes().ToList();
            }

            return View(searchClienteViewModel);
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cliente cliente = _clientes.GetCliente(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _clientes.AddCliente(cliente);
                return RedirectToAction("Index");
            }

            return View(cliente);
        }


        [HttpGet]
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cliente cliente = _clientes.GetCliente(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, [Bind] Cliente cliente)
        {

            if (id != cliente.CodCli)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _clientes.UpdateCliente(cliente);
                return RedirectToAction("Index");
            }

            return View(cliente);
        }


        [HttpGet]
        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cliente cliente = _clientes.GetCliente(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            _clientes.DeleteCliente(id);
            return RedirectToAction("Index");
        }
    }
}
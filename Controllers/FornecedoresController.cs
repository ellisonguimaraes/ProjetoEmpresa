using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace BDApplication.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly IFornecedorDAL _fornecedores;

        public FornecedoresController(IFornecedorDAL fornecedores)
        {
            _fornecedores = fornecedores;
        }

        public IActionResult Index()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            fornecedores = _fornecedores.GetAllFornecedores().ToList();

            return View(fornecedores);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Fornecedor fornecedor = _fornecedores.GetFornecedor(id);

            if(fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                _fornecedores.AddFornecedor(fornecedor);
                return RedirectToAction("Index");
            }

            return View(fornecedor);
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Fornecedor fornecedor = _fornecedores.GetFornecedor(id);

            if(fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind] Fornecedor fornecedor)
        {

            if (id != fornecedor.CodFor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _fornecedores.UpdateFornecedor(fornecedor);
                return RedirectToAction("Index");
            }

            return View(fornecedor);
        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            Fornecedor fornecedor = _fornecedores.GetFornecedor(id);

            if(fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            _fornecedores.DeleteFornecedor(id);
            return RedirectToAction("Index");
        }
    }
}
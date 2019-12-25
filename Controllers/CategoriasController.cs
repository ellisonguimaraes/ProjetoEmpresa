using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace BDApplication.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly ICategoriaDAL _categorias;

        public CategoriasController(ICategoriaDAL categorias)
        {
            _categorias = categorias;
        }

        public IActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();

            categorias = _categorias.GetAllCategorias().ToList();

            return View(categorias);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _categorias.AddCategoria(categoria);
                return RedirectToAction("Index");
            }

            return View(categoria);
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Categoria categoria = _categorias.GetCategoria(id);

            if(categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind] Categoria categoria)
        {

            if (id != categoria.CodCategoria)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _categorias.UpdateCategoria(categoria);
                return RedirectToAction("Index");
            }

            return View(categoria);
        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            Categoria categoria = _categorias.GetCategoria(id);

            if(categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            _categorias.DeleteCategoria(id);
            return RedirectToAction("Index");
        }
    }
}
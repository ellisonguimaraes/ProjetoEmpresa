using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace BDApplication.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly IFuncionarioDAL _funcionarios;

        public FuncionariosController(IFuncionarioDAL funcionarios)
        {
            _funcionarios = funcionarios;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            funcionarios = _funcionarios.GetAllFuncionarios().ToList();

            return View(funcionarios);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Funcionario funcionario = _funcionarios.GetFuncionario(id);

            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                _funcionarios.AddFuncionario(funcionario);
                return RedirectToAction("Index");
            }

            return View(funcionario);
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Funcionario funcionario = _funcionarios.GetFuncionario(id);

            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind] Funcionario funcionario)
        {

            if (id != funcionario.CodFun)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _funcionarios.UpdateFuncionario(funcionario);
                return RedirectToAction("Index");
            }

            return View(funcionario);
        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Funcionario funcionario = _funcionarios.GetFuncionario(id);

            if (funcionario == null)
            {
                return NotFound();
            }

            return View(funcionario);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            _funcionarios.DeleteFuncionario(id);
            return RedirectToAction("Index");
        }
    }
}
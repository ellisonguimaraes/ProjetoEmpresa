using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDApplication.Models;
using BDApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BDApplication.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoDAL _produtos;
        private readonly ICategoriaDAL _categorias;
        private readonly IFornecedorDAL _fornecedores;

        public ProdutosController(IProdutoDAL produtos, ICategoriaDAL categorias, IFornecedorDAL fornecedores)
        {
            _produtos = produtos;
            _categorias = categorias;
            _fornecedores = fornecedores;
        }

        public List<ProdutoViewModel> ToProdutoViewModel()
        {
            List<ProdutoViewModel> produtosViewModel = new List<ProdutoViewModel>();

            List<Produto> produtos = new List<Produto>();
            produtos = _produtos.GetAllProdutos().ToList();

            foreach (var item in produtos)
            {
                produtosViewModel.Add(new ProdutoViewModel()
                {
                    CodProd = item.CodProd,
                    Descr = item.Descr,
                    Preco = item.Preco,
                    Unidades = item.Unidades,
                    Descontinuado = item.Descontinuado,
                    CodFor = item.CodFor,
                    CodCategoria = item.CodCategoria,
                    Categoria = _categorias.GetCategoria(item.CodCategoria).Descr,
                    For = _fornecedores.GetFornecedor(item.CodFor).Empresa
                });
            }

            return produtosViewModel;
        }

        [HttpGet]
        public IActionResult Index()
        {
            SearchProdutoViewModel produtoViewModel = new SearchProdutoViewModel() { 
                Produtos = ToProdutoViewModel()
            };

            return View(produtoViewModel);
        }

        [HttpPost]
        public IActionResult Index([Bind]SearchProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid && !string.IsNullOrEmpty(produtoViewModel.Search)){
                produtoViewModel.Produtos = ToProdutoViewModel().Where(p => p.Descr.ToLower().Contains(produtoViewModel.Search.ToLower()));
 
            }else{
                produtoViewModel.Produtos = ToProdutoViewModel();
            }

            return View(produtoViewModel);
        }


        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Produto produto = _produtos.GetProduto(id);

            if (produto == null)
            {
                return NotFound();
            }

            ProdutoViewModel produtoViewModel = new ProdutoViewModel()
            {
                CodProd = produto.CodProd,
                Descr = produto.Descr,
                Preco = produto.Preco,
                Unidades = produto.Unidades,
                Descontinuado = produto.Descontinuado,
                CodFor = produto.CodFor,
                CodCategoria = produto.CodCategoria,
                Categoria = _categorias.GetCategoria(produto.CodCategoria).Descr,
                For = _fornecedores.GetFornecedor(produto.CodFor).Empresa
            };

            return View(produtoViewModel);
        }


        [HttpGet]
        public IActionResult Create()
        {
            ProdutoViewModel produtoViewModel = new ProdutoViewModel()
            {
                FornecedoresList = _fornecedores.GetAllFornecedores().ToList(),
                CategoriasList = _categorias.GetAllCategorias().ToList()
            };
            return View(produtoViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind]ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                _produtos.AddProduto(new Produto()
                {
                    CodProd = produtoViewModel.CodProd,
                    Descr = produtoViewModel.Descr,
                    Unidades = produtoViewModel.Unidades,
                    Descontinuado = produtoViewModel.Descontinuado,
                    Preco = produtoViewModel.Preco,
                    CodCategoria = produtoViewModel.CodCategoria,
                    CodFor = produtoViewModel.CodFor
                });
                return RedirectToAction("Index");
            }

            return View(produtoViewModel);
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            
            if (id == null)
            {
                return NotFound();
            }

            Produto produto = _produtos.GetProduto(id);

            if(produto == null)
            {
                return NotFound();
            }

            ProdutoViewModel produtoViewModel = new ProdutoViewModel()
            {
                CodProd = produto.CodProd,
                Descr = produto.Descr,
                Preco = produto.Preco,
                Unidades = produto.Unidades,
                Descontinuado = produto.Descontinuado,
                CodFor = produto.CodFor,
                CodCategoria = produto.CodCategoria,
                FornecedoresList = _fornecedores.GetAllFornecedores().ToList(),
                CategoriasList = _categorias.GetAllCategorias().ToList()
            };

            return View(produtoViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind]ProdutoViewModel produtoViewModel)
        {
            
            if (id != produtoViewModel.CodProd)
            {
                return NotFound();
            }
            
            if (ModelState.IsValid)
            {
                _produtos.UpdateProduto(new Produto() {
                    CodProd = produtoViewModel.CodProd,
                    Descr = produtoViewModel.Descr,
                    Preco = produtoViewModel.Preco,
                    Unidades = produtoViewModel.Unidades,
                    Descontinuado = produtoViewModel.Descontinuado,
                    CodFor = produtoViewModel.CodFor,
                    CodCategoria = produtoViewModel.CodCategoria
                });
                return RedirectToAction("Index");
            }

            return View(produtoViewModel);
        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            Produto produto = _produtos.GetProduto(id);

            if(produto == null)
            {
                return NotFound();
            }

            ProdutoViewModel produtoViewModel = new ProdutoViewModel()
            {
                CodProd = produto.CodProd,
                Descr = produto.Descr,
                Preco = produto.Preco,
                Unidades = produto.Unidades,
                Descontinuado = produto.Descontinuado,
                CodFor = produto.CodFor,
                CodCategoria = produto.CodCategoria,
                Categoria = _categorias.GetCategoria(produto.CodCategoria).Descr,
                For = _fornecedores.GetFornecedor(produto.CodFor).Empresa
            };

            return View(produtoViewModel);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            _produtos.DeleteProduto(id);
            return RedirectToAction("Index");
        }

    }
}
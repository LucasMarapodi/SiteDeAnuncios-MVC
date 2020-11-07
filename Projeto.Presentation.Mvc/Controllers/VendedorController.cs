using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Projeto.Infra.Data.Entities;
using Projeto.Infra.Data.Repositories;
using Projeto.Presentation.Mvc.Models.ProdutoModels;
using Projeto.Presentation.Mvc.Models.VendedorModels;

namespace Projeto.Presentation.Mvc.Controllers
{
    [Authorize]
    public class VendedorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Cadastro
        public IActionResult CadastroProduto()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastroProduto([FromServices]ProdutoRepository produtoRepository, ProdutoCadastroModel model,[FromServices]VendedorRepository vendedorRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var vendedor = vendedorRepository.GetByEmail(User.Identity.Name);

                    var produto = new Produto();
                    produto.Nome = model.Nome;
                    produto.Descricao = model.Descricao;
                    produto.Categoria = model.Categoria;
                    produto.Preco = double.Parse(model.Preco);
                    produto.IdVendedor = vendedor.IdVendedor;

                    produtoRepository.Insert(produto);

                    TempData["MensagemSucesso"] = "Produto Cadastrado Com Sucesso.";
                    ModelState.Clear();
                }
                catch (Exception e )
                {
                    TempData["MensagemErro"] = "Erro " + e.Message;
                }
            }

            return View();
        }

        #endregion

        #region Edicao

        public IActionResult EdicaoProduto(int id,[FromServices] ProdutoRepository produtoRepository)
        {
            var model = new ProdutoEdicaoModel();
            
            try
            {

                var produto = produtoRepository.GetById(id);

                model.Nome = produto.Nome;
                model.Descricao = produto.Descricao.ToString();
                model.IdProduto = produto.IdProduto.ToString();
                model.Preco = produto.Preco.ToString();
                model.Categoria = produto.Categoria;
            }
            catch(Exception e)
            {
                TempData["MensagemErro"] = "Erro " + e.Message;
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult EdicaoProduto([FromServices]ProdutoRepository produtoRepository, ProdutoEdicaoModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var produto = new Produto();
                    produto.IdProduto = int.Parse(model.IdProduto);
                    produto.Nome = model.Nome;
                    produto.Descricao = model.Descricao;
                    produto.Categoria = model.Categoria;
                    produto.Preco = double.Parse(model.Preco);

                    produtoRepository.Update(produto);
                    TempData["MensagemSucesso"] = "Produto Atualizado com Sucesso";
                }
                catch(Exception e)
                {
                    TempData["MensagemErro"] = "Erro " + e.Message;
                }
            }
            return View();
        }

        #endregion

        

        #region Consulta
        public IActionResult ConsultaVendedorProdutos([FromServices]ProdutoRepository produtoRepository, [FromServices]VendedorRepository vendedorRepository)
        {
            var produtos = new List<Produto>();

            try
            {
                var vendedor = vendedorRepository.GetByEmail(User.Identity.Name);

                produtos = produtoRepository.GetByVendedor(vendedor.IdVendedor);
            }
            catch(Exception e)
            {
                TempData["MensagemErro"] = "Erro " + e.Message;
            }

            return View(produtos);
        }

        #endregion


        public IActionResult Exclusao(int id, [FromServices]ProdutoRepository produtoRepository)
        {
            try
            {
                var produto = produtoRepository.GetById(id);

                if (produto != null)
                {
                    produtoRepository.Delete(produto);

                    TempData["MensagemSucesso"] = "Produto Excluido com Sucesso.";
                }
                else
                {
                    throw new Exception("Produto Não Encontrado");
                }

            }
            catch(Exception e)
            {
                TempData["MensagemErro"] = "Erro " + e.Message;
            }

            return RedirectToAction("ConsultaVendedorProdutos");
        }

        #region Logout

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Projeto.Infra.Data.Entities;
using Projeto.Infra.Data.Repositories;
using Projeto.Presentation.Mvc.Models.ProdutoModels;
using Projeto.Presentation.Mvc.Models.VendedorModels;

namespace Projeto.Presentation.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        

        #region Acesso_O_Sistema
        public IActionResult LoguinVendedor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoguinVendedor([FromServices]VendedorRepository vendedorRepository, VendedorLoguinModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var vendedor = vendedorRepository.GetByEmailAndSenha(model.Email, model.Senha);

                    if (vendedor != null)
                    {
                        var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, vendedor.Email) },
                        CookieAuthenticationDefaults.AuthenticationScheme);


                        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(identity));

                        return RedirectToAction("Index", "Vendedor");
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Email ou Senha Incorretos.";
                    }
                }
                catch(Exception e)
                {
                    TempData["MensagemErro"] = "Erro " + e.Message;
                }
            }
            return View();
        }

        public IActionResult CadastroVendedor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastroVendedor([FromServices]VendedorRepository vendedorRepository, VendedorCadastroModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (vendedorRepository.GetByEmail(model.Email) != null)
                    {
                        throw new Exception("Email já Cadastrado.");
                    }

                    var vendedor = new Vendedor();

                    vendedor.Nome = model.Nome;
                    vendedor.Email = model.Email;
                    vendedor.Senha = model.Senha;
                    vendedor.Telefone = model.Telefone;

                    vendedorRepository.Insert(vendedor);

                    TempData["MensagemSucesso"] = "Vendedor Cadastrado Com Sucesso";
                    ModelState.Clear();
                }
                catch(Exception e)
                {
                    TempData["MensagemErro"] = "Erro " + e.Message;
                } 
            }
            return View();
        }
        #endregion



        #region ConsultaProdutos
        public IActionResult ConsultaProdutos([FromServices]ProdutoRepository produtoRepository)
        {
            var produtos = new List<Produto>();

            try
            {
                produtos = produtoRepository.GetAll();
            }
            catch(Exception e)
            {
                TempData["MensagemErro"] = "Erro " + e.Message;
            }

            return View(produtos);
        }

        #endregion



        #region Compra

        // Actions que simulam a compra, apesar de não serem computados no banco de dados

        public IActionResult Compra(int id,[FromServices]ProdutoRepository produtoRepository)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Compra([FromServices]ProdutoRepository produtoRepository, ProdutoCompraModel model)
        {
            if (ModelState.IsValid) 
            { 
            var comprador = new ProdutoCompraModel();

            try

            {
                    comprador.Nome = model.Nome;
                    comprador.Cartao = model.Cartao;
                    comprador.Local = model.Local;

                    TempData["MensagemSucesso"] = "Produto Comprado Com Sucesso, obrigado por usar a plataforma";
                
            }
            catch(Exception e)
            {
                TempData["MensagemErro"] = "Erro " + e.Message;
            }
                }
                return View();
        }


        #endregion


    }

}

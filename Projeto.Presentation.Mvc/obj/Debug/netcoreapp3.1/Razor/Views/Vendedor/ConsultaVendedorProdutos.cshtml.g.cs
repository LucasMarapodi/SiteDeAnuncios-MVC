#pragma checksum "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45bd429c6e3235fe6bec38b22211053e737e4409"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendedor_ConsultaVendedorProdutos), @"mvc.1.0.view", @"/Views/Vendedor/ConsultaVendedorProdutos.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45bd429c6e3235fe6bec38b22211053e737e4409", @"/Views/Vendedor/ConsultaVendedorProdutos.cshtml")]
    public class Views_Vendedor_ConsultaVendedorProdutos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projeto.Infra.Data.Entities.Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml"
  
    ViewData["Title"] = "ConsultaVendedorProdutos";
    Layout = "~/Views/Shared/LayoutVendedor.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n    <div class=\"container mt-3\">\n        <h2>Consulta dos seus Produtos :</h2>\n\n\n");
#nullable restore
#line 16 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml"
         if (TempData["MensagemSucesso"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\n                <strong>");
#nullable restore
#line 19 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml"
                   Write(TempData["MensagemSucesso"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\n                    <span aria-hidden=\"true\">&times;</span>\n                </button>\n            </div>\n");
#nullable restore
#line 24 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 26 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml"
         if (TempData["MensagemErro"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">\n                <strong>");
#nullable restore
#line 29 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml"
                   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\n                    <span aria-hidden=\"true\">&times;</span>\n                </button>\n            </div>\n");
#nullable restore
#line 34 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-hover table-striped border border-dark"">
            <thead>
                <tr>
                    <th>Nome</th>
                    <th>Preço</th>
                    <th>Descrição</th>
                    <th>Categoria</th>
                    <th>Operação</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 46 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 49 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml"
                       Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>R$ ");
#nullable restore
#line 50 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml"
                          Write(item.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td> ");
#nullable restore
#line 51 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml"
                        Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 52 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml"
                       Write(item.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1776, "\"", 1825, 2);
            WriteAttributeValue("", 1783, "/Vendedor/EdicaoProduto?id=", 1783, 27, true);
#nullable restore
#line 54 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml"
WriteAttributeValue("", 1810, item.IdProduto, 1810, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\">\n                                Atualizar\n                            </a>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1964, "\"", 2008, 2);
            WriteAttributeValue("", 1971, "/Vendedor/Exclusao?id=", 1971, 22, true);
#nullable restore
#line 57 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml"
WriteAttributeValue("", 1993, item.IdProduto, 1993, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Deseja Realmente Excluir do Registro ?\');\" class=\"btn btn-danger btn-sm\">\n                                Excluir\n                            </a>\n                        </td>\n                    </tr>\n");
#nullable restore
#line 62 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Vendedor\ConsultaVendedorProdutos.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n\n    </div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Projeto.Infra.Data.Entities.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591

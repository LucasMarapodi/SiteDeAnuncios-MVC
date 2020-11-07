#pragma checksum "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Home\LoguinVendedor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bf6161000659154cbb3080268b9e75afb5183dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LoguinVendedor), @"mvc.1.0.view", @"/Views/Home/LoguinVendedor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bf6161000659154cbb3080268b9e75afb5183dc", @"/Views/Home/LoguinVendedor.cshtml")]
    public class Views_Home_LoguinVendedor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projeto.Presentation.Mvc.Models.VendedorModels.VendedorCadastroModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Home\LoguinVendedor.cshtml"
  
    ViewData["Title"] = "LoguinVendedor";
    Layout = "~/Views/Shared/LayoutBase.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
#nullable restore
#line 10 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Home\LoguinVendedor.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container mt-3\">\n        <h2>Preencha os Campos para entrar como Vendedor</h2>\n\n");
#nullable restore
#line 15 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Home\LoguinVendedor.cshtml"
         if (TempData["MensagemSucesso"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\n                <strong>");
#nullable restore
#line 18 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Home\LoguinVendedor.cshtml"
                   Write(TempData["MensagemSucesso"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\n                    <span aria-hidden=\"true\">&times;</span>\n                </button>\n            </div>\n");
#nullable restore
#line 23 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Home\LoguinVendedor.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 25 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Home\LoguinVendedor.cshtml"
         if (TempData["MensagemErro"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">\n                <strong>");
#nullable restore
#line 28 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Home\LoguinVendedor.cshtml"
                   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\n                    <span aria-hidden=\"true\">&times;</span>\n                </button>\n            </div>\n");
#nullable restore
#line 33 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Home\LoguinVendedor.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <label>Informe o Email:</label>\n        ");
#nullable restore
#line 36 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Home\LoguinVendedor.cshtml"
   Write(Html.TextBoxFor(model => model.Email, new
    {
       @class = "form-control col-md-4",
       @placeholder = "Digite Aqui"
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <span class=\"text-danger\">\n            ");
#nullable restore
#line 42 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Home\LoguinVendedor.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </span>\n        <br />\n        <label>Senha:</label>\n        ");
#nullable restore
#line 46 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Home\LoguinVendedor.cshtml"
   Write(Html.PasswordFor(model => model.Senha, new
    {
       @class = "form-control col-md-4",
       @placeholder = "Digite Aqui"
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <span class=\"text-danger\">\n            ");
#nullable restore
#line 52 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Home\LoguinVendedor.cshtml"
       Write(Html.ValidationMessageFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </span>\n        <br />\n\n        <br />\n        <input type=\"submit\" value=\"Entrar\"\n               class=\"btn btn-success btn-sm\" />\n    </div>\n");
#nullable restore
#line 60 "C:\Users\lucas\Desktop\ToGit\LojaMvc\LojaDeAnuncios-MVC-master\Projeto.Presentation.Mvc\Views\Home\LoguinVendedor.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projeto.Presentation.Mvc.Models.VendedorModels.VendedorCadastroModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
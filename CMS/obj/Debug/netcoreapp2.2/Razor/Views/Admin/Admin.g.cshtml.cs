#pragma checksum "C:\Users\leandro\rede-social\CMS\Views\Admin\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e453887cf064fcd479fb474361352035401c439b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Admin), @"mvc.1.0.view", @"/Views/Admin/Admin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Admin.cshtml", typeof(AspNetCore.Views_Admin_Admin))]
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
#line 1 "C:\Users\leandro\rede-social\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Users\leandro\rede-social\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e453887cf064fcd479fb474361352035401c439b", @"/Views/Admin/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\leandro\rede-social\CMS\Views\Admin\Admin.cshtml"
  
    ViewData["Title"] = "Admin";

    List<business.business.DadoFormulario> dados = ViewBag.dados;

#line default
#line hidden
            BeginContext(112, 528, true);
            WriteLiteral(@"
<h1>Administrador</h1>

<a href=""#"" id=""btn-Formulario"" class=""btn btn-success"">Informoções de formulário</a>
<a href=""#"" id=""btn-Venda"" class=""btn btn-primary"">Informoções de venda</a>

<div id=""Venda"" class=""dados"" style=""display: none;"">
    <h2>Dados de venda</h2>
</div>

<div id=""Formulario"" class=""dados"" style=""display: none;"">
    <h2>Dados de formulário</h2>

    <table border=""1"">
        <tr>
            <td>Formulario</td>
            <td>Campo</td>
            <td>Valor</td>
        </tr>

");
            EndContext();
#line 27 "C:\Users\leandro\rede-social\CMS\Views\Admin\Admin.cshtml"
         foreach (var dado in dados)
        {

#line default
#line hidden
            BeginContext(689, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(728, 15, false);
#line 30 "C:\Users\leandro\rede-social\CMS\Views\Admin\Admin.cshtml"
               Write(dado.Formulario);

#line default
#line hidden
            EndContext();
            BeginContext(743, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(771, 10, false);
#line 31 "C:\Users\leandro\rede-social\CMS\Views\Admin\Admin.cshtml"
               Write(dado.Campo);

#line default
#line hidden
            EndContext();
            BeginContext(781, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(809, 10, false);
#line 32 "C:\Users\leandro\rede-social\CMS\Views\Admin\Admin.cshtml"
               Write(dado.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(819, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 34 "C:\Users\leandro\rede-social\CMS\Views\Admin\Admin.cshtml"
        }

#line default
#line hidden
            BeginContext(856, 30, true);
            WriteLiteral("\r\n\r\n    </table>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(909, 438, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {

            $(""#btn-Formulario"").click(function () {
                $("".dados"").fadeOut(""slow"");
                $(""#Formulario"").fadeIn(""slow"");
            });

            $(""#btn-Venda"").click(function () {
                $("".dados"").fadeOut(""slow"");
                $(""#Venda"").fadeIn(""slow"");
            });

        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(1350, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

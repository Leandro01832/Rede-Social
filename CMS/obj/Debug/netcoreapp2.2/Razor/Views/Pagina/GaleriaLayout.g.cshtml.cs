#pragma checksum "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\GaleriaLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "568c229aec94299545e20cd20f7e4d2b1d061931"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagina_GaleriaLayout), @"mvc.1.0.view", @"/Views/Pagina/GaleriaLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pagina/GaleriaLayout.cshtml", typeof(AspNetCore.Views_Pagina_GaleriaLayout))]
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
#line 1 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"568c229aec94299545e20cd20f7e4d2b1d061931", @"/Views/Pagina/GaleriaLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagina_GaleriaLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<business.business.Pagina>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\GaleriaLayout.cshtml"
  
    ViewBag.Title = "Galeria";
    Layout = "~/Views/Shared/_Render.cshtml";
    var proximo = ViewBag.pagina + 1;
    var anterior = ViewBag.pagina - 1;

#line default
#line hidden
            BeginContext(211, 30, true);
            WriteLiteral("\r\n<h2>Galeria</h2>\r\n<h4>Lista ");
            EndContext();
            BeginContext(242, 14, false);
#line 10 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\GaleriaLayout.cshtml"
     Write(ViewBag.pagina);

#line default
#line hidden
            EndContext();
            BeginContext(256, 70, true);
            WriteLiteral("</h4>\r\n\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(327, 42, false);
#line 16 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\GaleriaLayout.cshtml"
       Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(369, 43, true);
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
            EndContext();
            BeginContext(413, 36, false);
#line 19 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\GaleriaLayout.cshtml"
       Write(Html.DisplayName("Preview dinâmico"));

#line default
#line hidden
            EndContext();
            BeginContext(449, 34, true);
            WriteLiteral("\r\n        </th>\r\n\r\n\r\n    </tr>\r\n\r\n");
            EndContext();
#line 25 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\GaleriaLayout.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(524, 50, true);
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(575, 41, false);
#line 30 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\GaleriaLayout.cshtml"
           Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(616, 61, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 677, "\"", 700, 2);
            WriteAttributeValue("", 684, "/Editar/", 684, 8, true);
#line 35 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\GaleriaLayout.cshtml"
WriteAttributeValue("", 692, item.Id, 692, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(701, 99, true);
            WriteLiteral(" target=\"_blank\" class=\"btn btn-warning\">Mostrar layout</a>\r\n            </td>\r\n\r\n\r\n        </tr>\r\n");
            EndContext();
#line 40 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\GaleriaLayout.cshtml"
    }

#line default
#line hidden
            BeginContext(807, 35, true);
            WriteLiteral("\r\n</table>\r\n<label>Lista:</label>\r\n");
            EndContext();
            BeginContext(843, 14, false);
#line 44 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\GaleriaLayout.cshtml"
Write(ViewBag.pagina);

#line default
#line hidden
            EndContext();
            BeginContext(857, 6, true);
            WriteLiteral("\r\n\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 863, "\"", 901, 2);
            WriteAttributeValue("", 870, "/Pagina/GaleriaLayout/", 870, 22, true);
#line 46 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\GaleriaLayout.cshtml"
WriteAttributeValue("", 892, anterior, 892, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(902, 37, true);
            WriteLiteral("  class=\"btn btn-primary\" ><<</a>\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 939, "\"", 976, 2);
            WriteAttributeValue("", 946, "/Pagina/GaleriaLayout/", 946, 22, true);
#line 47 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\GaleriaLayout.cshtml"
WriteAttributeValue("", 968, proximo, 968, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(977, 37, true);
            WriteLiteral("  class=\"btn btn-primary\" >>></a>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1031, 402, true);
                WriteLiteral(@"


    <script type=""text/javascript"">
        $(document).ready(function () {

            $(""#numeroAcesso"").change(function () {
                var numero = $("".bloco"")[0].baseURI.replace(/[^0-9]/g, '');
                numero = numero.replace('44311', '');
                window.location.href = ""/Pagina/GaleriaLayout/"" + $(this).val();
            });

        });
    </script>

");
                EndContext();
            }
            );
            BeginContext(1436, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<business.business.Pagina>> Html { get; private set; }
    }
}
#pragma warning restore 1591

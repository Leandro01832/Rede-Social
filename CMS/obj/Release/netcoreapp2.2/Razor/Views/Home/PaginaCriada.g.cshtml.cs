#pragma checksum "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Home\PaginaCriada.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de44811613d092a87c3e02d791eacc78b38c10a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PaginaCriada), @"mvc.1.0.view", @"/Views/Home/PaginaCriada.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/PaginaCriada.cshtml", typeof(AspNetCore.Views_Home_PaginaCriada))]
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
#line 1 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de44811613d092a87c3e02d791eacc78b38c10a0", @"/Views/Home/PaginaCriada.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"600f5e98c0b7ea1830bf7c16785f85b547fc669d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PaginaCriada : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 3 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Home\PaginaCriada.cshtml"
  
    ViewData["Title"] = "PaginaCriada";
    string user = ViewBag.user;
    int versiculo = ViewBag.versiculo;
    int capitulo = ViewBag.capitulo;

#line default
#line hidden
            BeginContext(155, 179, true);
            WriteLiteral("\n<h2>Pagina Criada!!!</h2>\n\n<div>\n    <h4>Compartilhar <span class=\"glyphicon glyphicon-send\"></span></h4>\n    \n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(335, 33, false);
#line 18 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Home\PaginaCriada.cshtml"
       Write(Html.DisplayName("Nome do livro"));

#line default
#line hidden
            EndContext();
            BeginContext(368, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(409, 4, false);
#line 21 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Home\PaginaCriada.cshtml"
       Write(user);

#line default
#line hidden
            EndContext();
            BeginContext(413, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(454, 28, false);
#line 24 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Home\PaginaCriada.cshtml"
       Write(Html.DisplayName("Capitulo"));

#line default
#line hidden
            EndContext();
            BeginContext(482, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(523, 8, false);
#line 27 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Home\PaginaCriada.cshtml"
       Write(capitulo);

#line default
#line hidden
            EndContext();
            BeginContext(531, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(572, 29, false);
#line 30 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Home\PaginaCriada.cshtml"
       Write(Html.DisplayName("Versiculo"));

#line default
#line hidden
            EndContext();
            BeginContext(601, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(642, 9, false);
#line 33 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Home\PaginaCriada.cshtml"
       Write(versiculo);

#line default
#line hidden
            EndContext();
            BeginContext(651, 33, true);
            WriteLiteral("\n        </dd>\n\n    </dl>\n</div>\n");
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

#pragma checksum "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\PaginasCriadas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c27f6542d7a5b09cf413583a97a7e2e7b37aac39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PaginasCriadas), @"mvc.1.0.view", @"/Views/Home/PaginasCriadas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/PaginasCriadas.cshtml", typeof(AspNetCore.Views_Home_PaginasCriadas))]
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
#line 1 "C:\Users\leand\Downloads\teste\cms\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Users\leand\Downloads\teste\cms\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c27f6542d7a5b09cf413583a97a7e2e7b37aac39", @"/Views/Home/PaginasCriadas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PaginasCriadas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\PaginasCriadas.cshtml"
  
    ViewData["Title"] = "Paginas Criadas";
    string user = ViewBag.user;
    int capitulo = ViewBag.capitulo;

#line default
#line hidden
            BeginContext(126, 190, true);
            WriteLiteral("\r\n<h2>Paginas Criadas!!!</h2>\r\n\r\n<div>\r\n    <h4>Compartilhar <span class=\"glyphicon glyphicon-send\"></span></h4>\r\n    \r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(317, 33, false);
#line 17 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\PaginasCriadas.cshtml"
       Write(Html.DisplayName("Nome do livro"));

#line default
#line hidden
            EndContext();
            BeginContext(350, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(394, 4, false);
#line 20 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\PaginasCriadas.cshtml"
       Write(user);

#line default
#line hidden
            EndContext();
            BeginContext(398, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(442, 28, false);
#line 23 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\PaginasCriadas.cshtml"
       Write(Html.DisplayName("Capitulo"));

#line default
#line hidden
            EndContext();
            BeginContext(470, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(514, 8, false);
#line 26 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Home\PaginasCriadas.cshtml"
       Write(capitulo);

#line default
#line hidden
            EndContext();
            BeginContext(522, 36, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
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

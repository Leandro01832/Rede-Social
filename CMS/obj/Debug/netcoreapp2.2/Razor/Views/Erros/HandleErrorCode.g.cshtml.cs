#pragma checksum "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Erros\HandleErrorCode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3228ae6e25d2a599a066739273158231be3744e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Erros_HandleErrorCode), @"mvc.1.0.view", @"/Views/Erros/HandleErrorCode.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Erros/HandleErrorCode.cshtml", typeof(AspNetCore.Views_Erros_HandleErrorCode))]
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
#line 1 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3228ae6e25d2a599a066739273158231be3744e6", @"/Views/Erros/HandleErrorCode.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"600f5e98c0b7ea1830bf7c16785f85b547fc669d", @"/Views/_ViewImports.cshtml")]
    public class Views_Erros_HandleErrorCode : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Erros\HandleErrorCode.cshtml"
  
    ViewData["Title"] = "HandleErrorCode";

#line default
#line hidden
            BeginContext(49, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(55, 20, false);
#line 6 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Erros\HandleErrorCode.cshtml"
Write(ViewBag.ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(75, 17, true);
            WriteLiteral("</h2>\n<hr />\n<h2>");
            EndContext();
            BeginContext(93, 24, false);
#line 8 "C:\Rede-Social-master\clone\Rede-Social\CMS\Views\Erros\HandleErrorCode.cshtml"
Write(ViewBag.RouteOfException);

#line default
#line hidden
            EndContext();
            BeginContext(117, 7, true);
            WriteLiteral(" </h2>\n");
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

#pragma checksum "C:\rede-social\CMS\Views\Erros\HandleErrorCode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25b7800a687e1490aec8e0475138b99dce62e198"
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
#line 1 "C:\rede-social\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\rede-social\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25b7800a687e1490aec8e0475138b99dce62e198", @"/Views/Erros/HandleErrorCode.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Erros_HandleErrorCode : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\rede-social\CMS\Views\Erros\HandleErrorCode.cshtml"
  
    ViewData["Title"] = "HandleErrorCode";

#line default
#line hidden
            BeginContext(53, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(60, 20, false);
#line 6 "C:\rede-social\CMS\Views\Erros\HandleErrorCode.cshtml"
Write(ViewBag.ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(80, 19, true);
            WriteLiteral("</h2>\r\n<hr />\r\n<h2>");
            EndContext();
            BeginContext(100, 24, false);
#line 8 "C:\rede-social\CMS\Views\Erros\HandleErrorCode.cshtml"
Write(ViewBag.RouteOfException);

#line default
#line hidden
            EndContext();
            BeginContext(124, 8, true);
            WriteLiteral(" </h2>\r\n");
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

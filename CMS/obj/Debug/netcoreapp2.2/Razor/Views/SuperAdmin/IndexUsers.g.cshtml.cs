#pragma checksum "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\SuperAdmin\IndexUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14fc3cd74ac7e90ad6762f15e46bac08887d2051"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperAdmin_IndexUsers), @"mvc.1.0.view", @"/Views/SuperAdmin/IndexUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SuperAdmin/IndexUsers.cshtml", typeof(AspNetCore.Views_SuperAdmin_IndexUsers))]
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
#line 1 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\SuperAdmin\IndexUsers.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14fc3cd74ac7e90ad6762f15e46bac08887d2051", @"/Views/SuperAdmin/IndexUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperAdmin_IndexUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\SuperAdmin\IndexUsers.cshtml"
  
    ViewData["Title"] = "IndexUsers";

#line default
#line hidden
            BeginContext(121, 92, true);
            WriteLiteral("\r\n<h2>Usuarios</h2>\r\n\r\n<table border=\"1\">\r\n    <tr>\r\n        <td>Email</td>\r\n    </tr>\r\n\r\n\r\n");
            EndContext();
#line 16 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\SuperAdmin\IndexUsers.cshtml"
     foreach(var user in Model)
    {

#line default
#line hidden
            BeginContext(253, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(276, 13, false);
#line 19 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\SuperAdmin\IndexUsers.cshtml"
       Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(289, 20, true);
            WriteLiteral("</td>  \r\n    </tr>\r\n");
            EndContext();
#line 21 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\SuperAdmin\IndexUsers.cshtml"
    }

#line default
#line hidden
            BeginContext(316, 18, true);
            WriteLiteral("\r\n</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591

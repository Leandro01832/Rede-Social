#pragma checksum "C:\rede-social\CMS\Views\Container\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0516c1f141136f5bf37ea697c958220f3de58f29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Container_Index), @"mvc.1.0.view", @"/Views/Container/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Container/Index.cshtml", typeof(AspNetCore.Views_Container_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0516c1f141136f5bf37ea697c958220f3de58f29", @"/Views/Container/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Container_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<business.business.Pagina>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 78, true);
            WriteLiteral("\r\n<style>\r\n    .FecharGaleria {\r\n        margin-left: 50px;\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(112, 22, false);
#line 8 "C:\rede-social\CMS\Views\Container\Index.cshtml"
Write(Html.Raw(ViewBag.Html));

#line default
#line hidden
            EndContext();
            BeginContext(134, 431, true);
            WriteLiteral(@"

<button class=""FecharGaleria btn btn-primary"">Fechar</button>


<div>
    <script type=""text/javascript"">
        $(document).ready(function () {

            $("".FecharGaleria"").click(function () {
                $(""#FormTexto, #estrutura, #Permissao, #Galeria, #GaleriaBlocos, #GaleriaConteiners"").fadeOut(""slow"");
                $(""#estrutura"").fadeIn(""slow"");
            });
        });
    </script>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<business.business.Pagina> Html { get; private set; }
    }
}
#pragma warning restore 1591

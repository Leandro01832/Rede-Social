#pragma checksum "C:\Users\leandro\rede-social\CMS\Views\Elemento\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85edc1c3e76bbf5f3a72bff757932982e55d2e13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Elemento_Lista), @"mvc.1.0.view", @"/Views/Elemento/Lista.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Elemento/Lista.cshtml", typeof(AspNetCore.Views_Elemento_Lista))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85edc1c3e76bbf5f3a72bff757932982e55d2e13", @"/Views/Elemento/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Elemento_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<business.business.Pagina>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 80, true);
            WriteLiteral("\r\n\r\n<style>\r\n    .FecharGaleria {\r\n        margin-left: 50px;\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(114, 22, false);
#line 9 "C:\Users\leandro\rede-social\CMS\Views\Elemento\Lista.cshtml"
Write(Html.Raw(ViewBag.Html));

#line default
#line hidden
            EndContext();
            BeginContext(136, 411, true);
            WriteLiteral(@"

<button class=""FecharGaleria btn btn-primary"">Fechar</button>


<div>
    <script type=""text/javascript"">
        $(document).ready(function () {

            $("".FecharGaleria"").click(function () {
                $(""#FormTexto, #estrutura, #Permissao, #Galeria, #GaleriaBlocos"").fadeOut(""slow"");
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

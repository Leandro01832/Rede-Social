#pragma checksum "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Background\ListaCores.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20999108a6358520b90894f3a00c813108a248c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Background_ListaCores), @"mvc.1.0.view", @"/Views/Background/ListaCores.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Background/ListaCores.cshtml", typeof(AspNetCore.Views_Background_ListaCores))]
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
#line 1 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20999108a6358520b90894f3a00c813108a248c9", @"/Views/Background/ListaCores.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Background_ListaCores : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<business.Back.Cor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(128, 49, false);
#line 7 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Background\ListaCores.cshtml"
           Write(Html.DisplayNameFor(model => model.CorBackground));

#line default
#line hidden
            EndContext();
            BeginContext(177, 68, true);
            WriteLiteral("\r\n            </th>             \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(246, 30, false);
#line 10 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Background\ListaCores.cshtml"
           Write(Html.DisplayName("Background"));

#line default
#line hidden
            EndContext();
            BeginContext(276, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 16 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Background\ListaCores.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(394, 67, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <input type=\"color\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 461, "\"", 488, 1);
#line 19 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Background\ListaCores.cshtml"
WriteAttributeValue("", 469, item.CorBackground, 469, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(489, 71, true);
            WriteLiteral(" />\r\n            </td>             \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(561, 48, false);
#line 22 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Background\ListaCores.cshtml"
           Write(Html.DisplayFor(modelItem => item.Background.Id));

#line default
#line hidden
            EndContext();
            BeginContext(609, 88, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a class=\"EditarCor\" data-value=\"");
            EndContext();
            BeginContext(698, 7, false);
#line 25 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Background\ListaCores.cshtml"
                                            Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(705, 65, true);
            WriteLiteral("\">Editar</a> |\r\n                <a class=\"ApagarCor\" data-value=\"");
            EndContext();
            BeginContext(771, 7, false);
#line 26 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Background\ListaCores.cshtml"
                                            Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(778, 48, true);
            WriteLiteral("\">Apagar</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 29 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Background\ListaCores.cshtml"
}

#line default
#line hidden
            BeginContext(829, 530, true);
            WriteLiteral(@"    </tbody>
</table>

<div>
    <script type=""text/javascript"">
        $(document).ready(function () {

            $("".EditarCor"").click(function () {
                var id = $(this).data(""value""); 
                $(""#conteudomodal"").load(""/Ferramenta/EditCor/"" + id);
            });

            $("".ApagarCor"").click(function () {
                var id = $(this).data(""value"");
                $(""#conteudomodal"").load(""/Ferramenta/DeleteCor/"" + id);
            });

        });
    </script>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<business.Back.Cor>> Html { get; private set; }
    }
}
#pragma warning restore 1591

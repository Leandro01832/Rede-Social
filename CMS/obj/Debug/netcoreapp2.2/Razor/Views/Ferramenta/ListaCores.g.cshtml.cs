#pragma checksum "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Ferramenta\ListaCores.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55e273ac5811f03bb260bec3f10064320d82a589"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ferramenta_ListaCores), @"mvc.1.0.view", @"/Views/Ferramenta/ListaCores.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ferramenta/ListaCores.cshtml", typeof(AspNetCore.Views_Ferramenta_ListaCores))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55e273ac5811f03bb260bec3f10064320d82a589", @"/Views/Ferramenta/ListaCores.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Ferramenta_ListaCores : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<business.Back.Cor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(128, 22, false);
#line 7 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Ferramenta\ListaCores.cshtml"
           Write(Html.DisplayName("Id"));

#line default
#line hidden
            EndContext();
            BeginContext(150, 42, true);
            WriteLiteral("\r\n            </th> <th>\r\n                ");
            EndContext();
            BeginContext(193, 49, false);
#line 9 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Ferramenta\ListaCores.cshtml"
           Write(Html.DisplayNameFor(model => model.CorBackground));

#line default
#line hidden
            EndContext();
            BeginContext(242, 113, true);
            WriteLiteral("\r\n            </th>             \r\n            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 16 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Ferramenta\ListaCores.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(387, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(436, 48, false);
#line 19 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Ferramenta\ListaCores.cshtml"
           Write(Html.DisplayFor(modelItem => item.Background.Id));

#line default
#line hidden
            EndContext();
            BeginContext(484, 75, true);
            WriteLiteral("\r\n            </td> \r\n            <td>\r\n                <input type=\"color\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 559, "\"", 586, 1);
#line 22 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Ferramenta\ListaCores.cshtml"
WriteAttributeValue("", 567, item.CorBackground, 567, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(587, 118, true);
            WriteLiteral(" />\r\n            </td>             \r\n            \r\n            <td>\r\n                <a class=\"EditarCor\" data-value=\"");
            EndContext();
            BeginContext(706, 7, false);
#line 26 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Ferramenta\ListaCores.cshtml"
                                            Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(713, 65, true);
            WriteLiteral("\">Editar</a> |\r\n                <a class=\"ApagarCor\" data-value=\"");
            EndContext();
            BeginContext(779, 7, false);
#line 27 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Ferramenta\ListaCores.cshtml"
                                            Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(786, 48, true);
            WriteLiteral("\">Apagar</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 30 "C:\Users\leand\Downloads\rede-social-box\CMS\Views\Ferramenta\ListaCores.cshtml"
}

#line default
#line hidden
            BeginContext(837, 530, true);
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

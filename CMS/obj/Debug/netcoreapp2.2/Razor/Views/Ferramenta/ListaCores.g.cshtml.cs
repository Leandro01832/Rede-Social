#pragma checksum "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7beaeedc01a7e8f26e1dc8db5bb78baf4681b101"
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
#line 1 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7beaeedc01a7e8f26e1dc8db5bb78baf4681b101", @"/Views/Ferramenta/ListaCores.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"600f5e98c0b7ea1830bf7c16785f85b547fc669d", @"/Views/_ViewImports.cshtml")]
    public class Views_Ferramenta_ListaCores : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<business.Back.Cor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 81, true);
            WriteLiteral("\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(122, 24, false);
#line 7 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
           Write(Html.DisplayName("Tipo"));

#line default
#line hidden
            EndContext();
            BeginContext(146, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(199, 22, false);
#line 10 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
           Write(Html.DisplayName("Id"));

#line default
#line hidden
            EndContext();
            BeginContext(221, 53, true);
            WriteLiteral("\n            </th>\n             <th>\n                ");
            EndContext();
            BeginContext(275, 49, false);
#line 13 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
           Write(Html.DisplayNameFor(model => model.CorBackground));

#line default
#line hidden
            EndContext();
            BeginContext(324, 106, true);
            WriteLiteral("\n            </th>             \n            \n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 20 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
 foreach (var item in Model.Where(c => c.BackgroundDivId != null)) {

#line default
#line hidden
            BeginContext(499, 128, true);
            WriteLiteral("        <tr>\n            <td>\n                <label>Cor para bloco</label>\n            </td> \n            <td>\n                ");
            EndContext();
            BeginContext(628, 51, false);
#line 26 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
           Write(Html.DisplayFor(modelItem => item.BackgroundDiv.Id));

#line default
#line hidden
            EndContext();
            BeginContext(679, 72, true);
            WriteLiteral("\n            </td> \n            <td>\n                <input type=\"color\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 751, "\"", 778, 1);
#line 29 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
WriteAttributeValue("", 759, item.CorBackground, 759, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(779, 114, true);
            WriteLiteral(" />\n            </td>             \n            \n            <td>\n                <a class=\"EditarCor\" data-value=\"");
            EndContext();
            BeginContext(894, 7, false);
#line 33 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
                                            Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(901, 64, true);
            WriteLiteral("\">Editar</a> |\n                <a class=\"ApagarCor\" data-value=\"");
            EndContext();
            BeginContext(966, 7, false);
#line 34 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
                                            Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(973, 45, true);
            WriteLiteral("\">Apagar</a>\n            </td>\n        </tr>\n");
            EndContext();
#line 37 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
}

#line default
#line hidden
#line 38 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
 foreach (var item in Model.Where(c => c.BackgroundContainerId != null)) {

#line default
#line hidden
            BeginContext(1095, 132, true);
            WriteLiteral("        <tr>\n            <td>\n                <label>Cor para container</label>\n            </td> \n            <td>\n                ");
            EndContext();
            BeginContext(1228, 51, false);
#line 44 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
           Write(Html.DisplayFor(modelItem => item.BackgroundDiv.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 72, true);
            WriteLiteral("\n            </td> \n            <td>\n                <input type=\"color\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1351, "\"", 1378, 1);
#line 47 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
WriteAttributeValue("", 1359, item.CorBackground, 1359, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1379, 123, true);
            WriteLiteral(" />\n            </td>             \n            \n            <td>\n                <a class=\"EditarCorContainer\" data-value=\"");
            EndContext();
            BeginContext(1503, 7, false);
#line 51 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
                                                     Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1510, 64, true);
            WriteLiteral("\">Editar</a> |\n                <a class=\"ApagarCor\" data-value=\"");
            EndContext();
            BeginContext(1575, 7, false);
#line 52 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
                                            Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1582, 45, true);
            WriteLiteral("\">Apagar</a>\n            </td>\n        </tr>\n");
            EndContext();
#line 55 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
}

#line default
#line hidden
#line 56 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
 foreach (var item in Model.Where(c => c.BackgroundElementoId != null)) {

#line default
#line hidden
            BeginContext(1703, 131, true);
            WriteLiteral("        <tr>\n            <td>\n                <label>Cor para elemento</label>\n            </td> \n            <td>\n                ");
            EndContext();
            BeginContext(1835, 51, false);
#line 62 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
           Write(Html.DisplayFor(modelItem => item.BackgroundDiv.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1886, 72, true);
            WriteLiteral("\n            </td> \n            <td>\n                <input type=\"color\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1958, "\"", 1985, 1);
#line 65 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
WriteAttributeValue("", 1966, item.CorBackground, 1966, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1986, 121, true);
            WriteLiteral(" />\n            </td>             \n           \n            <td>\n                <a class=\"EditarCorElemento\" data-value=\"");
            EndContext();
            BeginContext(2108, 7, false);
#line 69 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
                                                    Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2115, 64, true);
            WriteLiteral("\">Editar</a> |\n                <a class=\"ApagarCor\" data-value=\"");
            EndContext();
            BeginContext(2180, 7, false);
#line 70 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
                                            Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2187, 45, true);
            WriteLiteral("\">Apagar</a>\n            </td>\n        </tr>\n");
            EndContext();
#line 73 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Ferramenta\ListaCores.cshtml"
}

#line default
#line hidden
            BeginContext(2234, 926, true);
            WriteLiteral(@"    </tbody>
</table>

<div>
    <script type=""text/javascript"">
        $(document).ready(function () {

            $("".EditarCor"").click(function () {
                var id = $(this).data(""value""); 
                $(""#conteudomodal"").load(""/Ferramenta/EditCor/"" + id);
            });

            $("".EditarCorContainer"").click(function () {
                var id = $(this).data(""value""); 
                $(""#conteudomodal"").load(""/Ferramenta/EditCorContainer/"" + id);
            });
            
            $("".EditarCorElemento"").click(function () {
                var id = $(this).data(""value""); 
                $(""#conteudomodal"").load(""/Ferramenta/EditCorElemento/"" + id);
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

#pragma checksum "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a32ff3cd428c9d7185f1d60d66132582b65ecc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagina_Editar), @"mvc.1.0.view", @"/Views/Pagina/Editar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pagina/Editar.cshtml", typeof(AspNetCore.Views_Pagina_Editar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a32ff3cd428c9d7185f1d60d66132582b65ecc0", @"/Views/Pagina/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagina_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<business.business.Pagina>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/RenderizarDinamico.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "BlocoFerramenta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagem/loader.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FullScreen.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/aspnet-signalr/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/loader.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Variaveis.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/AlterarPosicaoBloco.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/funcaoClickRenderizarDinamico.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ContentUmDoisClick.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\Editar.cshtml"
  
    Layout = "~/Views/Shared/_Render2.cshtml";
    var proximo = ViewBag.proximo;
    var anterior = proximo - 2;
    var atual = proximo - 1;

#line default
#line hidden
            BeginContext(189, 54, true);
            WriteLiteral("\r\n<script src=\"/lib/jquery/dist/jquery.js\"></script>\r\n");
            EndContext();
            BeginContext(243, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a32ff3cd428c9d7185f1d60d66132582b65ecc08740", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(288, 761, true);
            WriteLiteral(@"

<style>
    .glyphicon {
        font-size: 22px;
    }

    #sites {
        margin-left: 50px;
    }

    #paginas {
        margin-left: 50px;
    }

    #acesso {
        margin-left: 50px;
    }

    #loading {
        display: none;
        background-color: lightgray;
        position: absolute;
        left: 0;
        top: 0;
        width: 100%;
        height: 100%;
        text-align: center;
        padding-top: 300px;
        filter: alpha(opacity=75);
        opacity: 0.75;
    }

    .blocoLoader {
        z-index: 40;
    }

    .minhaClasse {
        z-index: 0 !important;
    }

    .minhaClasse2 {
        z-index: 40 !important;
    }
</style>

<br />  <br />    <br /><br /><br />

");
            EndContext();
#line 59 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\Editar.cshtml"
 if (Model == null)
{

#line default
#line hidden
            BeginContext(1073, 85, true);
            WriteLiteral("    <label class=\"control-label\" style=\"margin-left:50px;\">Escolha um site:</label>\r\n");
            EndContext();
            BeginContext(1163, 86, false);
#line 62 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\Editar.cshtml"
Write(Html.DropDownList("sites", null, htmlAttributes: new { @class = "form-control site" }));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 90, false);
#line 64 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\Editar.cshtml"
Write(Html.DropDownList("paginas", null, htmlAttributes: new { @class = "form-control pagina" }));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 65, true);
            WriteLiteral("    <a href=\"#\" id=\"acesso\" class=\"btn btn-primary\">Acessar</a>\r\n");
            EndContext();
#line 67 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\Editar.cshtml"
}
else
{

    ViewBag.Title = Model.Titulo;
    string valor = ViewBag.html;


#line default
#line hidden
            BeginContext(1502, 122, true);
            WriteLiteral("    <style media=\"screen and (max-width: 450px)\">\r\n        .content {\r\n            width: 100%;\r\n        }\r\n    </style>\r\n");
            EndContext();
            BeginContext(1626, 24, true);
            WriteLiteral("    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1650, "\"", 1673, 1);
#line 80 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\Editar.cshtml"
WriteAttributeValue("", 1658, ViewBag.IdSite, 1658, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1674, 49, true);
            WriteLiteral(" id=\"IdentificaSite\" />\r\n    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1723, "\"", 1748, 1);
#line 81 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\Editar.cshtml"
WriteAttributeValue("", 1731, ViewBag.IdPagina, 1731, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1749, 27, true);
            WriteLiteral(" id=\"IdentificaPagina\" />\r\n");
            EndContext();
            BeginContext(1778, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1782, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a32ff3cd428c9d7185f1d60d66132582b65ecc013302", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1843, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1849, 191, true);
            WriteLiteral("    <div id=\"estrutura\">\r\n\r\n        <div class=\"row\" id=\"LinhaImaginaria\">\r\n\r\n            <div style=\"position: fixed;  margin-left:20px;\" class=\"blocoLoader\">\r\n                <a id=\"voltar\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2040, "\"", 2064, 2);
            WriteAttributeValue("", 2047, "/Editar/", 2047, 8, true);
#line 91 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\Editar.cshtml"
WriteAttributeValue("", 2055, anterior, 2055, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2065, 306, true);
            WriteLiteral(@"
                   class=""btn btn-primary loader glyphicon glyphicon-chevron-left"">
                </a>
            </div>
            <div style=""position: fixed;  margin-left:70px; top:80px;"" class=""blocoLoader"">
                <input type=""number"" placeholder=""N° pagina"" id=""NumeroPaginaAcesso""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2371, "\"", 2385, 1);
#line 96 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\Editar.cshtml"
WriteAttributeValue("", 2379, atual, 2379, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2386, 78, true);
            WriteLiteral(" min=\"2\" style=\"width: 80px;\" />\r\n                <a id=\"acessoPaginaComInput\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2464, "\"", 2485, 2);
            WriteAttributeValue("", 2471, "/Editar/", 2471, 8, true);
#line 97 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\Editar.cshtml"
WriteAttributeValue("", 2479, atual, 2479, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2486, 211, true);
            WriteLiteral(" class=\"glyphicon glyphicon-search loader\">\r\n                </a>\r\n            </div>\r\n            <div style=\"position: fixed;  margin-left:20px; top:50px;\" class=\"blocoLoader\">\r\n                <a id=\"avancar\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2697, "\"", 2720, 2);
            WriteAttributeValue("", 2704, "/Editar/", 2704, 8, true);
#line 101 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\Editar.cshtml"
WriteAttributeValue("", 2712, proximo, 2712, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2721, 255, true);
            WriteLiteral("\r\n                   class=\"btn btn-primary loader glyphicon glyphicon-chevron-right\">\r\n                </a>\r\n            </div>\r\n            \r\n\r\n            <div id=\"Chat\" class=\"col-md-4\" style=\"background-color: white; display:none;\">\r\n                ");
            EndContext();
            BeginContext(2976, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a32ff3cd428c9d7185f1d60d66132582b65ecc017533", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3010, 116, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"content col-md-12\" id=\"ConteudoPagina\" data-id=\"\">\r\n                ");
            EndContext();
            BeginContext(3127, 22, false);
#line 112 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\Editar.cshtml"
           Write(Html.Raw(ViewBag.Html));

#line default
#line hidden
            EndContext();
            BeginContext(3149, 921, true);
            WriteLiteral(@"
            </div>

            <script type=""text/javascript"">
                $('.linha').sortable({
                    connectWith: '.linha'
                });

                $('.ClassDiv').sortable();

                var axis = $('.linha').sortable('option', 'connectWith');
                let condicaoBloco = false;
                let condicaoElemento = false;

                // Setter
                $('.linha').sortable('option', 'connectWith', '.linha');

                $('.linha').sortable({
                    update: function (event, ui) {
                        condicaoBloco = true;
                    }
                });

                $('.ClassDiv').sortable({
                    update: function (event, ui) {
                        condicaoElemento = true;
                    }
                });
            </script>

        </div>

    </div>
");
            EndContext();
            BeginContext(4072, 81, true);
            WriteLiteral("    <div id=\"FormTexto\" style=\"display:none;  margin-left:50px;\">\r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(4155, 62, true);
            WriteLiteral("    <div id=\"Permissao\" style=\"display:none;\">\r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(4219, 60, true);
            WriteLiteral("    <div id=\"Galeria\" style=\"display:none;\">\r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(4281, 66, true);
            WriteLiteral("    <div id=\"GaleriaBlocos\" style=\"display:none;\">\r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(4349, 56, true);
            WriteLiteral("    <div id=\"loading\" style=\"display:none; z-index:50;\">");
            EndContext();
            BeginContext(4405, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a32ff3cd428c9d7185f1d60d66132582b65ecc021050", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4439, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 163 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pagina\Editar.cshtml"

}

#line default
#line hidden
            BeginContext(4452, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4475, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(4483, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a32ff3cd428c9d7185f1d60d66132582b65ecc022645", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4525, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4531, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a32ff3cd428c9d7185f1d60d66132582b65ecc023901", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4590, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4596, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a32ff3cd428c9d7185f1d60d66132582b65ecc025157", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4632, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4638, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a32ff3cd428c9d7185f1d60d66132582b65ecc026413", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4676, 2108, true);
                WriteLiteral(@"

    <script>
        $(document).ready(function () {

            $(""#NumeroPaginaAcesso"").change(function () {
                document.getElementById('acessoPaginaComInput').href = '/Editar/';
                document.getElementById(""acessoPaginaComInput"").href +=  $(this).val();
            });
            

            $(""button"").click(function () {

                if ($("".collapse"")[0].ariaExpanded == ""true"") {
                    $("".blocoLoader"").removeClass('minhaClasse');
                    $("".blocoLoader"").addClass('minhaClasse2');
                }
                else
                {
                    $("".blocoLoader"").removeClass('minhaClasse2');
                    $("".blocoLoader"").addClass('minhaClasse');
                }


            }).before(function () { });

            $("".site"").click(function () {

                $("".pagina"").empty();
                $("".pagina"").append('<option value=""0"">[Selecione  uma pagina..]</option>');

               ");
                WriteLiteral(@" $.ajax({
                    type: 'POST',
                    url: '/AjaxGet/GetPaginas',
                    dataType: 'json',
                    data: { PedidoId: $(this).val() },
                    success: function (data) {
                        $.each(data, function (i, data) {
                            $("".pagina"").append('<option value=""'
                                + data.idPagina + '"">'
                                + data.titulo + '</option>');
                        });
                    },
                    error: function (ex) {
                        alert('Falha ao buscar paginas.' + ex);
                    }
                });
                return false;
            });
            $(""#paginas"").change(function () {
                document.getElementById(""acesso"").href = ""/pagina/"" + $(this).val();
            });

            $(""#NumeroElementoEditar"").focusout(function () {
                $(""#conteudomodal"").load(""/Elemento/Edit/"" + $(this).va");
                WriteLiteral("l());\r\n            });\r\n\r\n        });\r\n    </script>\r\n\r\n    ");
                EndContext();
                BeginContext(6784, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a32ff3cd428c9d7185f1d60d66132582b65ecc029898", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6848, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(6856, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a32ff3cd428c9d7185f1d60d66132582b65ecc031246", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6907, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(6915, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a32ff3cd428c9d7185f1d60d66132582b65ecc032507", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6999, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(7007, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a32ff3cd428c9d7185f1d60d66132582b65ecc033855", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7080, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(7087, 4, true);
            WriteLiteral("\r\n\r\n");
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

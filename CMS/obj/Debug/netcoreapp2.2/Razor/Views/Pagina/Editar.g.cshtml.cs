#pragma checksum "C:\Users\leand\Downloads\teste\cms\CMS\Views\Pagina\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f2bdca4b63ee52d3fe0ca853ed60b123337cedc"
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
#line 1 "C:\Users\leand\Downloads\teste\cms\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Users\leand\Downloads\teste\cms\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f2bdca4b63ee52d3fe0ca853ed60b123337cedc", @"/Views/Pagina/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagina_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<business.business.Pagina>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Editar.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/RenderizarDinamico2.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "BlocoFerramenta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagem/loader.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FullScreen.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/aspnet-signalr/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/loader.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Variaveis.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/funcaoClickRenderizarDinamico.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ContentUmDoisClick.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Pagina\Editar.cshtml"
  
    Layout = "~/Views/Shared/_Render2.cshtml";
    var proximo = ViewBag.proximo;
    var anterior = proximo - 2;
    var atual = proximo - 1;

#line default
#line hidden
            BeginContext(189, 828, true);
            WriteLiteral(@"
<script src=""/lib/jquery/dist/jquery.js""></script>


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

<br />  <br />   <br /> 
<br />  <br />  
 

");
            EndContext();
#line 62 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Pagina\Editar.cshtml"
 if (Model == null)
{

#line default
#line hidden
            BeginContext(1041, 85, true);
            WriteLiteral("    <label class=\"control-label\" style=\"margin-left:50px;\">Escolha um site:</label>\r\n");
            EndContext();
            BeginContext(1131, 86, false);
#line 65 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Pagina\Editar.cshtml"
Write(Html.DropDownList("sites", null, htmlAttributes: new { @class = "form-control site" }));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 90, false);
#line 67 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Pagina\Editar.cshtml"
Write(Html.DropDownList("paginas", null, htmlAttributes: new { @class = "form-control pagina" }));

#line default
#line hidden
            EndContext();
            BeginContext(1320, 65, true);
            WriteLiteral("    <a href=\"#\" id=\"acesso\" class=\"btn btn-primary\">Acessar</a>\r\n");
            EndContext();
#line 70 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Pagina\Editar.cshtml"
}
else
{
    ViewBag.Title = Model.Titulo;
    string valor = ViewBag.html;


#line default
#line hidden
            BeginContext(1468, 122, true);
            WriteLiteral("    <style media=\"screen and (max-width: 450px)\">\r\n        .content {\r\n            width: 100%;\r\n        }\r\n    </style>\r\n");
            EndContext();
            BeginContext(1592, 24, true);
            WriteLiteral("    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1616, "\"", 1650, 1);
#line 82 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Pagina\Editar.cshtml"
WriteAttributeValue("", 1624, ViewBag.IdentificacaoUser, 1624, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1651, 50, true);
            WriteLiteral(" id=\"IdentificacaoUser\">\r\n    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1701, "\"", 1724, 1);
#line 83 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Pagina\Editar.cshtml"
WriteAttributeValue("", 1709, ViewBag.IdSite, 1709, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1725, 49, true);
            WriteLiteral(" id=\"IdentificaSite\" />\r\n    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1774, "\"", 1799, 1);
#line 84 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Pagina\Editar.cshtml"
WriteAttributeValue("", 1782, ViewBag.IdPagina, 1782, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1800, 27, true);
            WriteLiteral(" id=\"IdentificaPagina\" />\r\n");
            EndContext();
            BeginContext(1829, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1833, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f2bdca4b63ee52d3fe0ca853ed60b123337cedc12139", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1882, 7, true);
            WriteLiteral("\r\n     ");
            EndContext();
            BeginContext(1889, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f2bdca4b63ee52d3fe0ca853ed60b123337cedc13399", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1951, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1957, 207, true);
            WriteLiteral("    <div id=\"estrutura\">\r\n       \r\n\r\n        <div class=\"row\" id=\"LinhaImaginaria\">           \r\n\r\n            <div id=\"Chat\" class=\"col-md-4\" style=\"background-color: white; display:none;\">\r\n                ");
            EndContext();
            BeginContext(2164, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f2bdca4b63ee52d3fe0ca853ed60b123337cedc14987", async() => {
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
            BeginContext(2198, 439, true);
            WriteLiteral(@"
            </div>
                       
            <center>
                <input id=""modo"" type=""checkbox"" />  
                <label>Desktop || Mobile</label>
                <input id=""margem"" type=""checkbox"" style=""margin-left:50px;"" />  
                <label style=""margin-left:10px;"">Margem</label>
            </center>

            <div class=""content col-md-12"" id=""ConteudoPagina"" data-id="""">
                ");
            EndContext();
            BeginContext(2638, 22, false);
#line 107 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Pagina\Editar.cshtml"
           Write(Html.Raw(ViewBag.Html));

#line default
#line hidden
            EndContext();
            BeginContext(2660, 65, true);
            WriteLiteral("\r\n            </div>           \r\n\r\n        </div>\r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(2727, 81, true);
            WriteLiteral("    <div id=\"FormTexto\" style=\"display:none;  margin-left:50px;\">\r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(2810, 62, true);
            WriteLiteral("    <div id=\"Permissao\" style=\"display:none;\">\r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(2874, 60, true);
            WriteLiteral("    <div id=\"Galeria\" style=\"display:none;\">\r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(2936, 66, true);
            WriteLiteral("    <div id=\"GaleriaBlocos\" style=\"display:none;\">\r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(3012, 56, true);
            WriteLiteral("    <div id=\"loading\" style=\"display:none; z-index:50;\">");
            EndContext();
            BeginContext(3068, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f2bdca4b63ee52d3fe0ca853ed60b123337cedc17976", async() => {
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
            BeginContext(3102, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 133 "C:\Users\leand\Downloads\teste\cms\CMS\Views\Pagina\Editar.cshtml"

}

#line default
#line hidden
            BeginContext(3115, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3138, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(3146, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2bdca4b63ee52d3fe0ca853ed60b123337cedc19563", async() => {
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
                BeginContext(3188, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3194, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2bdca4b63ee52d3fe0ca853ed60b123337cedc20819", async() => {
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
                BeginContext(3253, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3259, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2bdca4b63ee52d3fe0ca853ed60b123337cedc22075", async() => {
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
                BeginContext(3295, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3301, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2bdca4b63ee52d3fe0ca853ed60b123337cedc23331", async() => {
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
                BeginContext(3339, 2306, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {          

              

            $(""#margem"").change(function () {

                if ($(this).is(':checked'))
                {
                    $("".Elemento"").css(""border"", ""ridge"");
                    $("".Elemento"").css(""border-width"", ""3px"");
                    $("".ClassDiv"").css(""border"", ""ridge"");
                    $("".ClassDiv"").css(""border-width"", ""8px"");
                    $("".ContainerDiv"").css(""border"", ""ridge"");
                    $("".ContainerDiv"").css(""border-width"", ""15px""); 
                }
                else
                {
                    $("".Elemento"").css(""border"", ""none"");
                    $("".ClassDiv"").css(""border"", ""none"");
                    $("".ContainerDiv"").css(""border"", ""none"");
                }

            });

            $("".site"").click(function () {

                $("".pagina"").empty();
                $("".pagina"").append('<option value=");
                WriteLiteral(@"""0"">[Selecione  uma pagina..]</option>');

                $.ajax({
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
           ");
                WriteLiteral(@"     $(""#conteudomodal"").load(""/Elemento/Edit/"" + $(this).val());
            });

            var numero = $(""#IdentificaPagina"").val();
                        $("".content"").load(""/Pagina/getview"", { id: numero });

        });
    </script>

    ");
                EndContext();
                BeginContext(5645, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2bdca4b63ee52d3fe0ca853ed60b123337cedc27049", async() => {
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
                BeginContext(5709, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(5717, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2bdca4b63ee52d3fe0ca853ed60b123337cedc28397", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5801, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(5809, 73, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f2bdca4b63ee52d3fe0ca853ed60b123337cedc29745", async() => {
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
                BeginContext(5882, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(5889, 4, true);
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
#pragma checksum "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38b6c46766c57e73496e557cd91afd721cced2b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagina_Renderizar), @"mvc.1.0.view", @"/Views/Pagina/Renderizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pagina/Renderizar.cshtml", typeof(AspNetCore.Views_Pagina_Renderizar))]
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
#line 1 "C:\Users\leandro\Documents\rede-social\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Users\leandro\Documents\rede-social\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b6c46766c57e73496e557cd91afd721cced2b1", @"/Views/Pagina/Renderizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagina_Renderizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<business.business.Pagina>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/RenderizarDinamico.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagem/loader.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.cookie.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/loader.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Navegacao.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
  
    Layout = "~/Views/Shared/_Render.cshtml";
    var proximo = ViewBag.proximo;
    var anterior = proximo - 2;
    var atual = proximo - 1;
    var quant = ViewBag.quantidadePaginas;

#line default
#line hidden
            BeginContext(232, 1454, true);
            WriteLiteral(@"
<script src=""/lib/jquery/dist/jquery.js""></script>

<style media=""screen and (max-width: 550px)"">
    .carousel-control {
        display: block !important;
        z-index: 40 !important;
    }

    #voltar {
        display: none !important;
    }

    #avancar {
        display: none !important;
    }
</style>

<style>

    input[type=checkbox] {
        /* Double-sized Checkboxes */
        -ms-transform: scale(2); /* IE */
        -moz-transform: scale(2); /* FF */
        -webkit-transform: scale(2); /* Safari and Chrome */
        -o-transform: scale(2); /* Opera */
        transform: scale(2);
        padding: 10px;
    }

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

    .blocoLoader {
        z-index: 40;
    }

    .blocoLoader2 {
        z-index: 0;
        bottom: 30%;
    }

    .DivPagina {
   ");
            WriteLiteral(@"     z-index: 120;
    }

    .minhaClasse3 {
        color: red;
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
</style>


    <input type=""hidden""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1686, "\"", 1703, 1);
#line 89 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 1694, Model.Id, 1694, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1704, 54, true);
            WriteLiteral(" id=\"IdentificacaoPagina\" />\r\n    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1758, "\"", 1779, 1);
#line 90 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 1766, ViewBag.user, 1766, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1780, 44, true);
            WriteLiteral(" id=\"ValorUser\" />\r\n    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1824, "\"", 1838, 1);
#line 91 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 1832, atual, 1832, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1839, 45, true);
            WriteLiteral(" id=\"ValorAtual\" />\r\n    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1884, "\"", 1898, 1);
#line 92 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 1892, quant, 1892, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1899, 45, true);
            WriteLiteral(" id=\"ValorQuant\" />\r\n    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1944, "\"", 1960, 1);
#line 93 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 1952, proximo, 1952, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1961, 47, true);
            WriteLiteral(" id=\"ValorProximo\" />\r\n    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2008, "\"", 2025, 1);
#line 94 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 2016, anterior, 2016, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2026, 48, true);
            WriteLiteral(" id=\"ValorAnterior\" />\r\n    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2074, "\"", 2111, 1);
#line 95 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 2082, Model.Story.PaginaPadraoLink, 2082, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2112, 56, true);
            WriteLiteral(" id=\"ValorPaginaPadraoLink\" />\r\n    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2168, "\"", 2193, 1);
#line 96 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 2176, Model.Story.Nome, 2176, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2194, 27, true);
            WriteLiteral(" id=\"ValorStoryNome\" />\r\n\r\n");
            EndContext();
#line 98 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
  


    ViewData["Title"] = Model.Titulo;
    ViewBag.Title = Model.Titulo;
    string valor = ViewBag.html;

    


#line default
#line hidden
            BeginContext(2347, 122, true);
            WriteLiteral("    <style media=\"screen and (max-width: 450px)\">\r\n        .content {\r\n            width: 100%;\r\n        }\r\n    </style>\r\n");
            EndContext();
            BeginContext(2471, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(2475, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "38b6c46766c57e73496e557cd91afd721cced2b111820", async() => {
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
            BeginContext(2536, 51, true);
            WriteLiteral("\r\n    <a class=\"left carousel-control blocoLoader2\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2587, "\"", 2663, 6);
            WriteAttributeValue("", 2594, "/Renderizar/", 2594, 12, true);
#line 114 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 2606, ViewBag.user, 2606, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2619, "/", 2619, 1, true);
#line 114 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 2620, Model.Story.PaginaPadraoLink, 2620, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 2651, "/", 2651, 1, true);
#line 114 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 2652, anterior, 2652, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2664, 146, true);
            WriteLiteral(" style=\"display:none;\">\r\n        <span class=\"glyphicon glyphicon-chevron-left\"></span>\r\n        <span class=\"sr-only\">Previous</span>\r\n    </a>\r\n");
            EndContext();
            BeginContext(2814, 50, true);
            WriteLiteral("    <a class=\"right carousel-control blocoLoader2\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2864, "\"", 2939, 6);
            WriteAttributeValue("", 2871, "/Renderizar/", 2871, 12, true);
#line 120 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 2883, ViewBag.user, 2883, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2896, "/", 2896, 1, true);
#line 120 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 2897, Model.Story.PaginaPadraoLink, 2897, 31, false);

#line default
#line hidden
            WriteAttributeValue("", 2928, "/", 2928, 1, true);
#line 120 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 2929, proximo, 2929, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2940, 143, true);
            WriteLiteral(" style=\"display:none;\">\r\n        <span class=\"glyphicon glyphicon-chevron-right\"></span>\r\n        <span class=\"sr-only\">Next</span>\r\n    </a>\r\n");
            EndContext();
            BeginContext(3085, 100, true);
            WriteLiteral("    <div style=\"position:fixed; top:5px;\" class=\"blocoLoader row\">\r\n        <div class=\"col-xs-4\">\r\n");
            EndContext();
#line 127 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
              

                if (Model.Story.PaginaPadraoLink != 0)
                {

#line default
#line hidden
            BeginContext(3278, 65, true);
            WriteLiteral("                    <span style=\"background-color:white;\">Story: ");
            EndContext();
            BeginContext(3344, 16, false);
#line 131 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                                                            Write(Model.Story.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3360, 141, true);
            WriteLiteral("</span>\r\n                    <br />\r\n                    <span style=\"font-size: 12px; background-color: white;\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3501, "\"", 3565, 4);
            WriteAttributeValue("", 3508, "/Renderizar/", 3508, 12, true);
#line 134 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 3520, ViewBag.user, 3520, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3533, "/0/", 3533, 3, true);
#line 134 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 3536, Model.Story.PaginaPadraoLink, 3536, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3566, 64, true);
            WriteLiteral(" class=\"btn btn-primary\">\r\n                            Capítulo ");
            EndContext();
            BeginContext(3631, 28, false);
#line 135 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                                Write(Model.Story.PaginaPadraoLink);

#line default
#line hidden
            EndContext();
            BeginContext(3659, 61, true);
            WriteLiteral("\r\n                        </a>\r\n                    </span>\r\n");
            EndContext();
#line 138 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3780, 76, true);
            WriteLiteral("                    <span style=\"background-color:white;\">Capítulos</span>\r\n");
            EndContext();
#line 142 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                }
            

#line default
#line hidden
            BeginContext(3890, 70, true);
            WriteLiteral("        </div>\r\n\r\n        <div class=\"right col-xs-8\" id=\"Pesquisa\">\r\n");
            EndContext();
#line 147 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
              
                if (Model.Story.PaginaPadraoLink == 0)
                {

#line default
#line hidden
            BeginContext(4051, 71, true);
            WriteLiteral("                    <span style=\"background-color:white;\">Cap.</span>\r\n");
            EndContext();
#line 151 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(4182, 72, true);
            WriteLiteral("                    <span style=\"background-color:white;\">Vers.</span>\r\n");
            EndContext();
#line 155 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                }
            

#line default
#line hidden
            BeginContext(4288, 101, true);
            WriteLiteral("            <input type=\"number\" placeholder=\"N° pagina\"\r\n                   id=\"NumeroPaginaAcesso2\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4389, "\"", 4403, 1);
#line 158 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 4397, atual, 4397, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4404, 576, true);
            WriteLiteral(@" style=""width: 80px;"" />
            <a id=""acessoPaginaComInput2"" href=""#""
               class=""btn btn-primary glyphicon glyphicon-search loader"">
            </a>
            <a href=""/"" class=""glyphicon glyphicon-home"" style=""left: 3%;""></a>
            <br />
            <a id=""voltar"" href=""#""
               class=""btn btn-primary loader glyphicon glyphicon-chevron-left"">
            </a>
            <a id=""avancar"" href=""#""
               class=""btn btn-primary loader glyphicon glyphicon-chevron-right"">
            </a>
        </div>

    </div>
");
            EndContext();
            BeginContext(4987, 22, false);
#line 174 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
Write(Html.Raw(ViewBag.Html));

#line default
#line hidden
            EndContext();
            BeginContext(5013, 138, true);
            WriteLiteral("    <div style=\"position:fixed; bottom:4%; left: 1%; width: 100%; overflow-x:auto;\" class=\"DivPagina\">\r\n\r\n        <center>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5151, "\"", 5179, 2);
            WriteAttributeValue("", 5158, "/Perfil/", 5158, 8, true);
#line 179 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 5166, ViewBag.user, 5166, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5180, 119, true);
            WriteLiteral("  style=\"font-size:1.5rem; background-color:white; opacity: 0.80;\">\r\n               <span class=\"text-primary\" >Livro: ");
            EndContext();
            BeginContext(5300, 12, false);
#line 180 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                                             Write(ViewBag.user);

#line default
#line hidden
            EndContext();
            BeginContext(5312, 94, true);
            WriteLiteral("</span> \r\n            </a>\r\n            <h3 style=\"background-color:darkgray; opacity: 0.80;\">");
            EndContext();
            BeginContext(5407, 27, false);
#line 182 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                                                             Write(Html.CheckBox("automatico"));

#line default
#line hidden
            EndContext();
            BeginContext(5434, 42, true);
            WriteLiteral(" Automático </h3>\r\n\r\n            <div>\r\n\r\n");
            EndContext();
#line 186 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                  
                    if (quant <= 60)
                    {

                        for (var indice = 1; indice <= quant; indice++)
                        {

#line default
#line hidden
            BeginContext(5659, 143, true);
            WriteLiteral("                            <div style=\"width:14px; display:inline-grid; margin: 0px, 4px, 0px, 4px; background-color:darkgray; opacity: 0.80;\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5802, "\"", 5825, 2);
            WriteAttributeValue("", 5807, "DivPagina", 5807, 9, true);
#line 192 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
WriteAttributeValue("", 5816, indice, 5816, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5826, 71, true);
            WriteLiteral(">\r\n\r\n                                <span style=\"font-size: 1rem;\"><b>");
            EndContext();
            BeginContext(5898, 6, false);
#line 194 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                                                             Write(indice);

#line default
#line hidden
            EndContext();
            BeginContext(5904, 190, true);
            WriteLiteral("</b> </span>\r\n                                <span class=\"glyphicon glyphicon-record\"\r\n                              style=\"font-size: 1rem;\"></span>\r\n\r\n                            </div>\r\n");
            EndContext();
#line 199 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                        }
                    }
                    else
                    {
                        if (Model.Story.Nome == "Padrao")
                        {

#line default
#line hidden
            BeginContext(6279, 90, true);
            WriteLiteral("                            <p style=\"background-color:darkgray; opacity: 0.80;\">Capitulo ");
            EndContext();
            BeginContext(6370, 5, false);
#line 205 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                                                                                     Write(atual);

#line default
#line hidden
            EndContext();
            BeginContext(6375, 4, true);
            WriteLiteral(" de ");
            EndContext();
            BeginContext(6380, 5, false);
#line 205 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                                                                                               Write(quant);

#line default
#line hidden
            EndContext();
            BeginContext(6385, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 206 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(6475, 91, true);
            WriteLiteral("                            <p style=\"background-color:darkgray; opacity: 0.80;\">Versiculo ");
            EndContext();
            BeginContext(6567, 5, false);
#line 209 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                                                                                      Write(atual);

#line default
#line hidden
            EndContext();
            BeginContext(6572, 4, true);
            WriteLiteral(" de ");
            EndContext();
            BeginContext(6577, 5, false);
#line 209 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                                                                                                Write(quant);

#line default
#line hidden
            EndContext();
            BeginContext(6582, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 210 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\Renderizar.cshtml"
                        }
                    }
                

#line default
#line hidden
            BeginContext(6657, 55, true);
            WriteLiteral("\r\n            </div>\r\n        </center>\r\n\r\n    </div>\r\n");
            EndContext();
            BeginContext(6716, 56, true);
            WriteLiteral("    <div id=\"loading\" style=\"display:none; z-index:50;\">");
            EndContext();
            BeginContext(6772, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "38b6c46766c57e73496e557cd91afd721cced2b127265", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6805, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
            BeginContext(6818, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(6841, 10, true);
                WriteLiteral("\r\n  \r\n    ");
                EndContext();
                BeginContext(6851, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38b6c46766c57e73496e557cd91afd721cced2b128740", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6909, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6915, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38b6c46766c57e73496e557cd91afd721cced2b129996", async() => {
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
                BeginContext(6953, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6959, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38b6c46766c57e73496e557cd91afd721cced2b131252", async() => {
                    BeginContext(7014, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7024, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(7031, 4, true);
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

#pragma checksum "C:\rede-social\CMS\Views\Produto\paginacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "807c180af1cebcb9898566c9bd6a622cbdfc3df2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_paginacao), @"mvc.1.0.view", @"/Views/Produto/paginacao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/paginacao.cshtml", typeof(AspNetCore.Views_Produto_paginacao))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807c180af1cebcb9898566c9bd6a622cbdfc3df2", @"/Views/Produto/paginacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_paginacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<business.business.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/paginacao.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
  
    Layout = null;
    int atual = ViewBag.pagina;
    int proximo = atual + 1;
    int anterior = atual - 1;
    var quant = Model.ToList().Count;

#line default
#line hidden
            BeginContext(207, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(236, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "807c180af1cebcb9898566c9bd6a622cbdfc3df24425", async() => {
                BeginContext(242, 91, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n    ");
                EndContext();
                BeginContext(333, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "807c180af1cebcb9898566c9bd6a622cbdfc3df24904", async() => {
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
                BeginContext(385, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(396, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(400, 8314, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "807c180af1cebcb9898566c9bd6a622cbdfc3df27041", async() => {
                BeginContext(406, 279, true);
                WriteLiteral(@"
   
    <div id=""configuracao"">
    <p id=""livro""><strong>Livro: Leandro</strong></p>
    <p id=""config"">
        <strong>
        <a  href=""#"" id=""configurar"" onclick=""clicou()"" >Info e Config</a>
        </strong>
    </p>
    <p id=""automatico"" >
        <strong>
");
                EndContext();
#line 31 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
              
                if(ViewBag.automatico == 1)
                {

#line default
#line hidden
                BeginContext(765, 22, true);
                WriteLiteral("                    <a");
                EndContext();
                BeginWriteAttribute("href", "  href=\"", 787, "\"", 863, 8);
                WriteAttributeValue("", 795, "/paginacao/", 795, 11, true);
#line 34 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 806, atual, 806, 6, false);

#line default
#line hidden
                WriteAttributeValue("", 812, "/", 812, 1, true);
#line 34 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 813, ViewBag.ordenar, 813, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 829, "/0/", 829, 3, true);
#line 34 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 832, ViewBag.tempo, 832, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 846, "/", 846, 1, true);
#line 34 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 847, ViewBag.tamanho, 847, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(864, 74, true);
                WriteLiteral(" >\r\n                    Desabilitar automático\r\n                    </a>\r\n");
                EndContext();
#line 37 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(998, 22, true);
                WriteLiteral("                    <a");
                EndContext();
                BeginWriteAttribute("href", "  href=\"", 1020, "\"", 1096, 8);
                WriteAttributeValue("", 1028, "/paginacao/", 1028, 11, true);
#line 40 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1039, atual, 1039, 6, false);

#line default
#line hidden
                WriteAttributeValue("", 1045, "/", 1045, 1, true);
#line 40 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1046, ViewBag.ordenar, 1046, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 1062, "/1/", 1062, 3, true);
#line 40 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1065, ViewBag.tempo, 1065, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 1079, "/", 1079, 1, true);
#line 40 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1080, ViewBag.tamanho, 1080, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1097, 72, true);
                WriteLiteral(" >\r\n                    Habilitar automático\r\n                    </a>\r\n");
                EndContext();
#line 43 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                }
            

#line default
#line hidden
                BeginContext(1203, 79, true);
                WriteLiteral("        \r\n        </strong>\r\n    </p>\r\n\r\n    <p id=\"lista\">\r\n        <strong>\r\n");
                EndContext();
#line 51 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
              
                if(atual > 1)
                {

#line default
#line hidden
                BeginContext(1348, 22, true);
                WriteLiteral("                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1370, "\"", 1466, 10);
                WriteAttributeValue("", 1377, "/paginacao/", 1377, 11, true);
#line 54 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1388, anterior, 1388, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 1397, "/", 1397, 1, true);
#line 54 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1398, ViewBag.ordenar, 1398, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 1414, "/", 1414, 1, true);
#line 54 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1415, ViewBag.automatico, 1415, 19, false);

#line default
#line hidden
                WriteAttributeValue("", 1434, "/", 1434, 1, true);
#line 54 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1435, ViewBag.tempo, 1435, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 1449, "/", 1449, 1, true);
#line 54 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1450, ViewBag.tamanho, 1450, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1467, 71, true);
                WriteLiteral(">\r\n                     Lista Anterior ||\r\n                     </a> \r\n");
                EndContext();
#line 57 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                }

            

#line default
#line hidden
                BeginContext(1574, 46, true);
                WriteLiteral("                          \r\n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1620, "\"", 1715, 10);
                WriteAttributeValue("", 1627, "/paginacao/", 1627, 11, true);
#line 61 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1638, proximo, 1638, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1646, "/", 1646, 1, true);
#line 61 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1647, ViewBag.ordenar, 1647, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 1663, "/", 1663, 1, true);
#line 61 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1664, ViewBag.automatico, 1664, 19, false);

#line default
#line hidden
                WriteAttributeValue("", 1683, "/", 1683, 1, true);
#line 61 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1684, ViewBag.tempo, 1684, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 1698, "/", 1698, 1, true);
#line 61 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1699, ViewBag.tamanho, 1699, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1716, 294, true);
                WriteLiteral(@">
                 Proxima lista >>>
                 </a>

        </strong>
            </p>
    </div>

     <div id=""cabecalho"">
        <div>
            <h4>Logo</h4>

        </div>
        <div id=""ordenacao"">
            <h4>Ordenar</h4>
            <input type=""hidden""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2010, "\"", 2024, 1);
#line 76 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2018, quant, 2018, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2025, 71, true);
                WriteLiteral(" id=\"quantidade\" name=\"quantidade\" > \r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2096, "\"", 2123, 1);
#line 77 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2104, ViewBag.automatico, 2104, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2124, 41, true);
                WriteLiteral(" id=\"auto\" name=\"auto\" > \r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2165, "\"", 2223, 4);
                WriteAttributeValue("", 2172, "/paginacao/1/nome/1/", 2172, 20, true);
#line 78 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2192, ViewBag.tempo, 2192, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2206, "/", 2206, 1, true);
#line 78 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2207, ViewBag.tamanho, 2207, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2224, 38, true);
                WriteLiteral(" >Ordenar por nome</a>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2262, "\"", 2321, 4);
                WriteAttributeValue("", 2269, "/paginacao/1/preco/1/", 2269, 21, true);
#line 79 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2290, ViewBag.tempo, 2290, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2304, "/", 2304, 1, true);
#line 79 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2305, ViewBag.tamanho, 2305, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2322, 39, true);
                WriteLiteral(" >Ordenar por preço</a>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2361, "\"", 2423, 4);
                WriteAttributeValue("", 2368, "/paginacao/1/capitulo/1/", 2368, 24, true);
#line 80 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2392, ViewBag.tempo, 2392, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2406, "/", 2406, 1, true);
#line 80 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2407, ViewBag.tamanho, 2407, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2424, 153, true);
                WriteLiteral(" >Ordenar por capitulo</a>\r\n        </div>\r\n        <div id=\"proxima-lista\">\r\n            <h3>Tamanho da lista</h3>\r\n            <strong>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2577, "\"", 2621, 3);
                WriteAttributeValue("", 2584, "/paginacao/1/nome/1/", 2584, 20, true);
#line 85 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2604, ViewBag.tempo, 2604, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2618, "/11", 2618, 3, true);
                EndWriteAttribute();
                BeginContext(2622, 77, true);
                WriteLiteral(" >10 itens</a>\r\n\r\n            </strong>\r\n            <strong>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2699, "\"", 2744, 3);
                WriteAttributeValue("", 2706, "/paginacao/1/preco/1/", 2706, 21, true);
#line 89 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2727, ViewBag.tempo, 2727, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2741, "/41", 2741, 3, true);
                EndWriteAttribute();
                BeginContext(2745, 77, true);
                WriteLiteral(" >40 itens</a>\r\n\r\n            </strong>\r\n            <strong>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2822, "\"", 2870, 3);
                WriteAttributeValue("", 2829, "/paginacao/1/capitulo/1/", 2829, 24, true);
#line 93 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2853, ViewBag.tempo, 2853, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2867, "/81", 2867, 3, true);
                EndWriteAttribute();
                BeginContext(2871, 73, true);
                WriteLiteral(" >80 itens</a>\r\n\r\n            </strong>\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2944, "\"", 2968, 1);
#line 96 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2952, ViewBag.tamanho, 2952, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2969, 177, true);
                WriteLiteral(" id=\"tamanho\" name=\"tamanho\" >\r\n        </div>\r\n        <div>\r\n            <label for=\"tempo\" > <strong>Time em segundos (s):</strong> </label>\r\n            <input type=\"number\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3146, "\"", 3168, 1);
#line 100 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 3154, ViewBag.tempo, 3154, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3169, 178, true);
                WriteLiteral(" id=\"tempo\" name=\"tempo\" max=\"600\" min=\"15\" >\r\n            <a href=\"#\" onclick=\"alterou()\">Alterar time</a>\r\n        </div>\r\n\r\n    </div>\r\n    \r\n\r\n    <div class=\"container\">\r\n\r\n");
                EndContext();
#line 109 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
         foreach (var item in Model.ToList())
        {

            if (Model.ToList().IndexOf(item) != 0)
            {
            var path = item.Imagem.First().ArquivoImagem;
            var largura = item.Imagem.First().WidthImagem;
            var identifica = item.Pagina.Id;
            List<business.business.Pagina> lista = item.Pagina.Story.Pagina;
            var Capitulo = item.Pagina.Story.PaginaPadraoLink;

            var Versiculo = lista.IndexOf(lista.First(l => l.Id == identifica)) + 1;


#line default
#line hidden
                BeginContext(3871, 125, true);
                WriteLiteral("                    <div class=\"produto\">\r\n                        <div class=\"info\">\r\n                            <p> Nome: ");
                EndContext();
                BeginContext(3997, 9, false);
#line 124 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                 Write(item.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(4006, 50, true);
                WriteLiteral(" </p>\r\n                            <p> Descrição: ");
                EndContext();
                BeginContext(4057, 14, false);
#line 125 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                      Write(item.Descricao);

#line default
#line hidden
                EndContext();
                BeginContext(4071, 46, true);
                WriteLiteral(" </p>\r\n                            <p> Preço: ");
                EndContext();
                BeginContext(4118, 10, false);
#line 126 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                  Write(item.Preco);

#line default
#line hidden
                EndContext();
                BeginContext(4128, 48, true);
                WriteLiteral(" </p>\r\n                            <p> Estoque: ");
                EndContext();
                BeginContext(4177, 17, false);
#line 127 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                    Write(item.QuantEstoque);

#line default
#line hidden
                EndContext();
                BeginContext(4194, 155, true);
                WriteLiteral(" </p>\r\n                        </div>\r\n                        <div class=\"caps\">\r\n                            <strong>\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4349, "\"", 4422, 6);
                WriteAttributeValue("", 4356, "/Renderizar/leandro/", 4356, 20, true);
#line 131 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4376, Capitulo, 4376, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 4385, "/", 4385, 1, true);
#line 131 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4386, Versiculo, 4386, 10, false);

#line default
#line hidden
                WriteAttributeValue("", 4396, "/1/#redireciona-", 4396, 16, true);
#line 131 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4412, Versiculo, 4412, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4423, 45, true);
                WriteLiteral(" >\r\n                                Capitulo ");
                EndContext();
                BeginContext(4469, 8, false);
#line 132 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                    Write(Capitulo);

#line default
#line hidden
                EndContext();
                BeginContext(4477, 103, true);
                WriteLiteral("                        \r\n                                </a> <br>\r\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4580, "\"", 4653, 6);
                WriteAttributeValue("", 4587, "/Renderizar/leandro/", 4587, 20, true);
#line 134 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4607, Capitulo, 4607, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 4616, "/", 4616, 1, true);
#line 134 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4617, Versiculo, 4617, 10, false);

#line default
#line hidden
                WriteAttributeValue("", 4627, "/1/#redireciona-", 4627, 16, true);
#line 134 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4643, Versiculo, 4643, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4654, 70, true);
                WriteLiteral(" >                        \r\n                                Versiculo ");
                EndContext();
                BeginContext(4725, 9, false);
#line 135 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                     Write(Versiculo);

#line default
#line hidden
                EndContext();
                BeginContext(4734, 137, true);
                WriteLiteral("\r\n                                </a>\r\n                            </strong>\r\n                        </div>\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4871, "\"", 4944, 6);
                WriteAttributeValue("", 4878, "/Renderizar/leandro/", 4878, 20, true);
#line 139 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4898, Capitulo, 4898, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 4907, "/", 4907, 1, true);
#line 139 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4908, Versiculo, 4908, 10, false);

#line default
#line hidden
                WriteAttributeValue("", 4918, "/1/#redireciona-", 4918, 16, true);
#line 139 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4934, Versiculo, 4934, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4945, 32, true);
                WriteLiteral(" >\r\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4977, "\"", 4988, 1);
#line 140 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4983, path, 4983, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4989, 92, true);
                WriteLiteral(" alt=\"Imagem do produto\"  />\r\n\r\n                        </a>\r\n\r\n                    </div>\r\n");
                EndContext();
#line 145 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
            }
        }

#line default
#line hidden
                BeginContext(5107, 2963, true);
                WriteLiteral(@"    </div>

    <div class=""progressbar"" style=""position: fixed; bottom: 1%;"" >
                <div></div>
            </div>
    

   <script type=""text/javascript"">

        var elements1 = document.getElementsByClassName(""info"");
        var elements2 = document.getElementsByClassName(""produto"");
        var elements3 = document.getElementsByClassName(""caps"");
        var element = document.getElementById(""cabecalho"");
        var element2 = document.getElementById(""auto"");
        var element3 = document.getElementById(""tamanho"");
        var time = parseInt(document.getElementById(""tempo"").value) * 1000;
        var ss = 0;
        var porcentagem = 0;
    const progresso = document.querySelector("".progressbar div"")

    if (parseInt(element2.value) == 1) 
    {
        setInterval(function()
         {    
            ss += 1000;
            porcentagem = parseInt((ss / time) * 100); 
            progresso.setAttribute(""style"", ""width: "" +porcentagem+ ""%"");               
   ");
                WriteLiteral(@"      }, 1000);    
    }

        for(var i = 0; i < elements2.length; i++){
                if(parseInt(element3.value) == 81)
                {
                    elements2[i].style.width = ""90px"";
                    elements2[i].style.minHeight = ""108px"";
                    elements2[i].style.height = ""auto"";
                }
                else
                if(parseInt(element3.value) == 41)
                {
                    elements2[i].style.width = ""172px"";
                    elements2[i].style.minHeight = ""210px"";
                    elements2[i].style.height = ""auto"";
                }
                else
                if(parseInt(element3.value) == 11)
                {
                    elements2[i].style.width = ""344px"";
                    elements2[i].style.minHeight = ""430px"";
                    elements2[i].style.height = ""auto"";
                }
            }

            if(parseInt(element3.value) == 81)
                {
                    ");
                WriteLiteral(@"for(var i = 0; i < elements3.length; i++)
                    elements3[i].style.fontSize = ""0.8em"";
                }
                else
                if(parseInt(element3.value) == 41)
                {
                    for(var i = 0; i < elements3.length; i++)
                    elements3[i].style.fontSize = ""1.2em"";
                }
                else
                if(parseInt(element3.value) == 11)
                {
                     for(var i = 0; i < elements3.length; i++)
                    elements3[i].style.fontSize = ""1.8em"";
                }

        function clicou()
        {
                for(var i = 0; i < elements1.length; i++){
                elements1[i].style.display = ""block"";
            }
            element.style.display = ""flex"";
        }
        
        function alterou()
        {
            window.location.href = ""/paginacao/");
                EndContext();
                BeginContext(8071, 5, false);
#line 228 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                          Write(atual);

#line default
#line hidden
                EndContext();
                BeginContext(8076, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(8078, 15, false);
#line 228 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                                 Write(ViewBag.ordenar);

#line default
#line hidden
                EndContext();
                BeginContext(8093, 63, true);
                WriteLiteral("/1/\" +\r\n            document.getElementById(\"tempo\").value + \"/");
                EndContext();
                BeginContext(8157, 15, false);
#line 229 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                                  Write(ViewBag.tamanho);

#line default
#line hidden
                EndContext();
                BeginContext(8172, 265, true);
                WriteLiteral(@""";
        }
       
        if(parseInt(element2.value) == 1)
        {
            setTimeout(function() {
            if(parseInt(document.getElementById(""quantidade"").value) == parseInt(element3.value))
            window.location.href = ""/paginacao/"" + ");
                EndContext();
                BeginContext(8438, 7, false);
#line 236 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                              Write(proximo);

#line default
#line hidden
                EndContext();
                BeginContext(8445, 10, true);
                WriteLiteral(" + \"/\" + \"");
                EndContext();
                BeginContext(8456, 15, false);
#line 236 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                                                Write(ViewBag.ordenar);

#line default
#line hidden
                EndContext();
                BeginContext(8471, 3, true);
                WriteLiteral("/1/");
                EndContext();
                BeginContext(8475, 13, false);
#line 236 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                                                                   Write(ViewBag.tempo);

#line default
#line hidden
                EndContext();
                BeginContext(8488, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(8490, 15, false);
#line 236 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                                                                                  Write(ViewBag.tamanho);

#line default
#line hidden
                EndContext();
                BeginContext(8505, 76, true);
                WriteLiteral("\";\r\n            else\r\n            window.location.href = \"/paginacao/1/\" + \"");
                EndContext();
                BeginContext(8582, 15, false);
#line 238 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                                 Write(ViewBag.ordenar);

#line default
#line hidden
                EndContext();
                BeginContext(8597, 3, true);
                WriteLiteral("/1/");
                EndContext();
                BeginContext(8601, 13, false);
#line 238 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                                                    Write(ViewBag.tempo);

#line default
#line hidden
                EndContext();
                BeginContext(8614, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(8616, 15, false);
#line 238 "C:\rede-social\CMS\Views\Produto\paginacao.cshtml"
                                                                                   Write(ViewBag.tamanho);

#line default
#line hidden
                EndContext();
                BeginContext(8631, 76, true);
                WriteLiteral("\";\r\n\r\n            }, time);  \r\n\r\n        }\r\n\r\n\r\n          \r\n    </script> \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8714, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<business.business.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591

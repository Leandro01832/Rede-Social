#pragma checksum "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d526685a299deebe24799d5ec29dc3cfe18bf155"
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
#line 1 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d526685a299deebe24799d5ec29dc3cfe18bf155", @"/Views/Produto/paginacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"600f5e98c0b7ea1830bf7c16785f85b547fc669d", @"/Views/_ViewImports.cshtml")]
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
#line 2 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
  
    Layout = null;
    int atual = ViewBag.pagina;
    int proximo = atual + 1;
    int anterior = atual - 1;
    var quant = Model.ToList().Count;

#line default
#line hidden
            BeginContext(199, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n\n");
            EndContext();
            BeginContext(224, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d526685a299deebe24799d5ec29dc3cfe18bf1554575", async() => {
                BeginContext(230, 88, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Index</title>\n    ");
                EndContext();
                BeginContext(318, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d526685a299deebe24799d5ec29dc3cfe18bf1555048", async() => {
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
                BeginContext(370, 2, true);
                WriteLiteral("\n\n");
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
            BeginContext(379, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(381, 8081, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d526685a299deebe24799d5ec29dc3cfe18bf1557177", async() => {
                BeginContext(387, 268, true);
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
#line 31 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
              
                if(ViewBag.automatico == 1)
                {

#line default
#line hidden
                BeginContext(732, 22, true);
                WriteLiteral("                    <a");
                EndContext();
                BeginWriteAttribute("href", "  href=\"", 754, "\"", 830, 8);
                WriteAttributeValue("", 762, "/paginacao/", 762, 11, true);
#line 34 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 773, atual, 773, 6, false);

#line default
#line hidden
                WriteAttributeValue("", 779, "/", 779, 1, true);
#line 34 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 780, ViewBag.ordenar, 780, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 796, "/0/", 796, 3, true);
#line 34 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 799, ViewBag.tempo, 799, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 813, "/", 813, 1, true);
#line 34 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 814, ViewBag.tamanho, 814, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(831, 71, true);
                WriteLiteral(" >\n                    Desabilitar automático\n                    </a>\n");
                EndContext();
#line 37 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(959, 22, true);
                WriteLiteral("                    <a");
                EndContext();
                BeginWriteAttribute("href", "  href=\"", 981, "\"", 1057, 8);
                WriteAttributeValue("", 989, "/paginacao/", 989, 11, true);
#line 40 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1000, atual, 1000, 6, false);

#line default
#line hidden
                WriteAttributeValue("", 1006, "/", 1006, 1, true);
#line 40 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1007, ViewBag.ordenar, 1007, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 1023, "/1/", 1023, 3, true);
#line 40 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1026, ViewBag.tempo, 1026, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 1040, "/", 1040, 1, true);
#line 40 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1041, ViewBag.tamanho, 1041, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1058, 69, true);
                WriteLiteral(" >\n                    Habilitar automático\n                    </a>\n");
                EndContext();
#line 43 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                }
            

#line default
#line hidden
                BeginContext(1159, 73, true);
                WriteLiteral("        \n        </strong>\n    </p>\n\n    <p id=\"lista\">\n        <strong>\n");
                EndContext();
#line 51 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
              
                if(atual > 1)
                {

#line default
#line hidden
                BeginContext(1295, 22, true);
                WriteLiteral("                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1317, "\"", 1413, 10);
                WriteAttributeValue("", 1324, "/paginacao/", 1324, 11, true);
#line 54 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1335, anterior, 1335, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 1344, "/", 1344, 1, true);
#line 54 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1345, ViewBag.ordenar, 1345, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 1361, "/", 1361, 1, true);
#line 54 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1362, ViewBag.automatico, 1362, 19, false);

#line default
#line hidden
                WriteAttributeValue("", 1381, "/", 1381, 1, true);
#line 54 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1382, ViewBag.tempo, 1382, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 1396, "/", 1396, 1, true);
#line 54 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1397, ViewBag.tamanho, 1397, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1414, 68, true);
                WriteLiteral(">\n                     Lista Anterior ||\n                     </a> \n");
                EndContext();
#line 57 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                }

            

#line default
#line hidden
                BeginContext(1515, 45, true);
                WriteLiteral("                          \n                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1560, "\"", 1655, 10);
                WriteAttributeValue("", 1567, "/paginacao/", 1567, 11, true);
#line 61 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1578, proximo, 1578, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1586, "/", 1586, 1, true);
#line 61 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1587, ViewBag.ordenar, 1587, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 1603, "/", 1603, 1, true);
#line 61 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1604, ViewBag.automatico, 1604, 19, false);

#line default
#line hidden
                WriteAttributeValue("", 1623, "/", 1623, 1, true);
#line 61 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1624, ViewBag.tempo, 1624, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 1638, "/", 1638, 1, true);
#line 61 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1639, ViewBag.tamanho, 1639, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1656, 279, true);
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
                BeginWriteAttribute("value", " value=\"", 1935, "\"", 1949, 1);
#line 76 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 1943, quant, 1943, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1950, 70, true);
                WriteLiteral(" id=\"quantidade\" name=\"quantidade\" > \n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2020, "\"", 2047, 1);
#line 77 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2028, ViewBag.automatico, 2028, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2048, 40, true);
                WriteLiteral(" id=\"auto\" name=\"auto\" > \n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2088, "\"", 2146, 4);
                WriteAttributeValue("", 2095, "/paginacao/1/nome/1/", 2095, 20, true);
#line 78 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2115, ViewBag.tempo, 2115, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2129, "/", 2129, 1, true);
#line 78 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2130, ViewBag.tamanho, 2130, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2147, 37, true);
                WriteLiteral(" >Ordenar por nome</a>\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2184, "\"", 2243, 4);
                WriteAttributeValue("", 2191, "/paginacao/1/preco/1/", 2191, 21, true);
#line 79 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2212, ViewBag.tempo, 2212, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2226, "/", 2226, 1, true);
#line 79 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2227, ViewBag.tamanho, 2227, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2244, 38, true);
                WriteLiteral(" >Ordenar por preço</a>\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2282, "\"", 2344, 4);
                WriteAttributeValue("", 2289, "/paginacao/1/capitulo/1/", 2289, 24, true);
#line 80 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2313, ViewBag.tempo, 2313, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2327, "/", 2327, 1, true);
#line 80 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2328, ViewBag.tamanho, 2328, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2345, 148, true);
                WriteLiteral(" >Ordenar por capitulo</a>\n        </div>\n        <div id=\"proxima-lista\">\n            <h3>Tamanho da lista</h3>\n            <strong>\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2493, "\"", 2537, 3);
                WriteAttributeValue("", 2500, "/paginacao/1/nome/1/", 2500, 20, true);
#line 85 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2520, ViewBag.tempo, 2520, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2534, "/11", 2534, 3, true);
                EndWriteAttribute();
                BeginContext(2538, 73, true);
                WriteLiteral(" >10 itens</a>\n\n            </strong>\n            <strong>\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2611, "\"", 2656, 3);
                WriteAttributeValue("", 2618, "/paginacao/1/preco/1/", 2618, 21, true);
#line 89 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2639, ViewBag.tempo, 2639, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2653, "/41", 2653, 3, true);
                EndWriteAttribute();
                BeginContext(2657, 73, true);
                WriteLiteral(" >40 itens</a>\n\n            </strong>\n            <strong>\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2730, "\"", 2778, 3);
                WriteAttributeValue("", 2737, "/paginacao/1/capitulo/1/", 2737, 24, true);
#line 93 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2761, ViewBag.tempo, 2761, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2775, "/81", 2775, 3, true);
                EndWriteAttribute();
                BeginContext(2779, 70, true);
                WriteLiteral(" >80 itens</a>\n\n            </strong>\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2849, "\"", 2873, 1);
#line 96 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 2857, ViewBag.tamanho, 2857, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2874, 173, true);
                WriteLiteral(" id=\"tamanho\" name=\"tamanho\" >\n        </div>\n        <div>\n            <label for=\"tempo\" > <strong>Time em segundos (s):</strong> </label>\n            <input type=\"number\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3047, "\"", 3069, 1);
#line 100 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 3055, ViewBag.tempo, 3055, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3070, 169, true);
                WriteLiteral(" id=\"tempo\" name=\"tempo\" max=\"600\" min=\"15\" >\n            <a href=\"#\" onclick=\"alterou()\">Alterar time</a>\n        </div>\n\n    </div>\n    \n\n    <div class=\"container\">\n\n");
                EndContext();
#line 109 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
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
                BeginContext(3750, 123, true);
                WriteLiteral("                    <div class=\"produto\">\n                        <div class=\"info\">\n                            <p> Nome: ");
                EndContext();
                BeginContext(3874, 9, false);
#line 124 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                 Write(item.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(3883, 49, true);
                WriteLiteral(" </p>\n                            <p> Descrição: ");
                EndContext();
                BeginContext(3933, 14, false);
#line 125 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                      Write(item.Descricao);

#line default
#line hidden
                EndContext();
                BeginContext(3947, 45, true);
                WriteLiteral(" </p>\n                            <p> Preço: ");
                EndContext();
                BeginContext(3993, 10, false);
#line 126 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                  Write(item.Preco);

#line default
#line hidden
                EndContext();
                BeginContext(4003, 47, true);
                WriteLiteral(" </p>\n                            <p> Estoque: ");
                EndContext();
                BeginContext(4051, 17, false);
#line 127 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                    Write(item.QuantEstoque);

#line default
#line hidden
                EndContext();
                BeginContext(4068, 151, true);
                WriteLiteral(" </p>\n                        </div>\n                        <div class=\"caps\">\n                            <strong>\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4219, "\"", 4290, 6);
                WriteAttributeValue("", 4226, "/Renderizar/leandro/", 4226, 20, true);
#line 131 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4246, Capitulo, 4246, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 4255, "/", 4255, 1, true);
#line 131 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4256, Versiculo, 4256, 10, false);

#line default
#line hidden
                WriteAttributeValue("", 4266, "/#redireciona-", 4266, 14, true);
#line 131 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4280, Versiculo, 4280, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4291, 44, true);
                WriteLiteral(" >\n                                Capitulo ");
                EndContext();
                BeginContext(4336, 8, false);
#line 132 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                    Write(Capitulo);

#line default
#line hidden
                EndContext();
                BeginContext(4344, 101, true);
                WriteLiteral("                        \n                                </a> <br>\n                                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4445, "\"", 4516, 6);
                WriteAttributeValue("", 4452, "/Renderizar/leandro/", 4452, 20, true);
#line 134 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4472, Capitulo, 4472, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 4481, "/", 4481, 1, true);
#line 134 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4482, Versiculo, 4482, 10, false);

#line default
#line hidden
                WriteAttributeValue("", 4492, "/#redireciona-", 4492, 14, true);
#line 134 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4506, Versiculo, 4506, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4517, 69, true);
                WriteLiteral(" >                        \n                                Versiculo ");
                EndContext();
                BeginContext(4587, 9, false);
#line 135 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                     Write(Versiculo);

#line default
#line hidden
                EndContext();
                BeginContext(4596, 133, true);
                WriteLiteral("\n                                </a>\n                            </strong>\n                        </div>\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4729, "\"", 4800, 6);
                WriteAttributeValue("", 4736, "/Renderizar/leandro/", 4736, 20, true);
#line 139 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4756, Capitulo, 4756, 9, false);

#line default
#line hidden
                WriteAttributeValue("", 4765, "/", 4765, 1, true);
#line 139 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4766, Versiculo, 4766, 10, false);

#line default
#line hidden
                WriteAttributeValue("", 4776, "/#redireciona-", 4776, 14, true);
#line 139 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4790, Versiculo, 4790, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4801, 31, true);
                WriteLiteral(" >\n                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4832, "\"", 4843, 1);
#line 140 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
WriteAttributeValue("", 4838, path, 4838, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4844, 87, true);
                WriteLiteral(" alt=\"Imagem do produto\"  />\n\n                        </a>\n\n                    </div>\n");
                EndContext();
#line 145 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
            }
        }

#line default
#line hidden
                BeginContext(4955, 2882, true);
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
         }, 1000);    
    }

");
                WriteLiteral(@"        for(var i = 0; i < elements2.length; i++){
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
                    for(var i = 0; i < elements3.length; i++)
             ");
                WriteLiteral(@"       elements3[i].style.fontSize = ""0.8em"";
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
                BeginContext(7838, 5, false);
#line 228 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                          Write(atual);

#line default
#line hidden
                EndContext();
                BeginContext(7843, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(7845, 15, false);
#line 228 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                                 Write(ViewBag.ordenar);

#line default
#line hidden
                EndContext();
                BeginContext(7860, 62, true);
                WriteLiteral("/1/\" +\n            document.getElementById(\"tempo\").value + \"/");
                EndContext();
                BeginContext(7923, 15, false);
#line 229 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                                  Write(ViewBag.tamanho);

#line default
#line hidden
                EndContext();
                BeginContext(7938, 258, true);
                WriteLiteral(@""";
        }
       
        if(parseInt(element2.value) == 1)
        {
            setTimeout(function() {
            if(parseInt(document.getElementById(""quantidade"").value) == parseInt(element3.value))
            window.location.href = ""/paginacao/"" + ");
                EndContext();
                BeginContext(8197, 7, false);
#line 236 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                              Write(proximo);

#line default
#line hidden
                EndContext();
                BeginContext(8204, 10, true);
                WriteLiteral(" + \"/\" + \"");
                EndContext();
                BeginContext(8215, 15, false);
#line 236 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                                                Write(ViewBag.ordenar);

#line default
#line hidden
                EndContext();
                BeginContext(8230, 3, true);
                WriteLiteral("/1/");
                EndContext();
                BeginContext(8234, 13, false);
#line 236 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                                                                   Write(ViewBag.tempo);

#line default
#line hidden
                EndContext();
                BeginContext(8247, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(8249, 15, false);
#line 236 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                                                                                  Write(ViewBag.tamanho);

#line default
#line hidden
                EndContext();
                BeginContext(8264, 74, true);
                WriteLiteral("\";\n            else\n            window.location.href = \"/paginacao/1/\" + \"");
                EndContext();
                BeginContext(8339, 15, false);
#line 238 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                                 Write(ViewBag.ordenar);

#line default
#line hidden
                EndContext();
                BeginContext(8354, 3, true);
                WriteLiteral("/1/");
                EndContext();
                BeginContext(8358, 13, false);
#line 238 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                                                    Write(ViewBag.tempo);

#line default
#line hidden
                EndContext();
                BeginContext(8371, 1, true);
                WriteLiteral("/");
                EndContext();
                BeginContext(8373, 15, false);
#line 238 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Produto\paginacao.cshtml"
                                                                                   Write(ViewBag.tamanho);

#line default
#line hidden
                EndContext();
                BeginContext(8388, 67, true);
                WriteLiteral("\";\n\n            }, time);  \n\n        }\n\n\n          \n    </script> \n");
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
            BeginContext(8462, 10, true);
            WriteLiteral("\n\n</html>\n");
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

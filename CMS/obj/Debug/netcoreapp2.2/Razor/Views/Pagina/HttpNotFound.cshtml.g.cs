#pragma checksum "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\HttpNotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0741827a9bd2f1e364c0dad9db383b2cce2ef7ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagina_HttpNotFound), @"mvc.1.0.view", @"/Views/Pagina/HttpNotFound.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pagina/HttpNotFound.cshtml", typeof(AspNetCore.Views_Pagina_HttpNotFound))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0741827a9bd2f1e364c0dad9db383b2cce2ef7ae", @"/Views/Pagina/HttpNotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagina_HttpNotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<business.business.Pagina>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagem/loader.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/loader.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\HttpNotFound.cshtml"
  
    ViewData["Title"] = "HttpNotFound";
    Layout = "~/Views/Shared/_Render.cshtml";

#line default
#line hidden
            BeginContext(128, 170, true);
            WriteLiteral("\r\n<script src=\"/lib/jquery/dist/jquery.js\"></script>\r\n<br />\r\n<div style=\"position: fixed; z-index: 2; display:none;\" id=\"navegacao\">\r\n    <input type=\"hidden\" id=\"livro\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 298, "\"", 320, 1);
#line 10 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\HttpNotFound.cshtml"
WriteAttributeValue("", 306, ViewBag.livro, 306, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(321, 50, true);
            WriteLiteral(" />\r\n           <input type=\"hidden\" id=\"capitulo\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 371, "\"", 396, 1);
#line 11 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\HttpNotFound.cshtml"
WriteAttributeValue("", 379, ViewBag.capitulo, 379, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(397, 136, true);
            WriteLiteral(" />\r\n    <input type=\"number\" id=\"NumeroPaginaAcesso\" style=\"width:80%; margin-left: 60px;\" placeholder=\"N?? do Capitulo. Ex: 2, 3, 4, 5\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 533, "\"", 560, 1);
#line 12 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\HttpNotFound.cshtml"
WriteAttributeValue("", 541, ViewBag.numeroErro, 541, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(561, 436, true);
            WriteLiteral(@" />
    <center>
        <a id=""acessoPaginaComInput"" href=""/Pagina/"" class=""btn btn-primary glyphicon glyphicon-search loader"">
            Acessar
        </a>
    </center>

    <h1>Pagina n??o encontrada</h1>
</div>

<div style=""position: fixed; z-index: 2; display:none;"" id=""aguarde"">
   <h1>Aguarde o processamento...</h1> 
</div>


<br />
<br />
<br />



<div id=""loading"" style=""display:none; z-index:50;"">");
            EndContext();
            BeginContext(997, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0741827a9bd2f1e364c0dad9db383b2cce2ef7ae6241", async() => {
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
            BeginContext(1030, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1059, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1067, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0741827a9bd2f1e364c0dad9db383b2cce2ef7ae7609", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1105, 486, true);
                WriteLiteral(@"
    <script type=""text/javascript"">


            if($(""#livro"").val() == """") 
            {
                    $(""#navegacao"").css(""display"", ""block"");
                    $(""#aguarde"").css(""display"", ""none"");
            }       
            else
            {
                    $(""#navegacao"").css(""display"", ""none"");
                    $(""#aguarde"").css(""display"", ""block"");

                     setTimeout(function() {   window.location.href = ""/Renderizar/""+ """);
                EndContext();
                BeginContext(1592, 13, false);
#line 52 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\HttpNotFound.cshtml"
                                                                                  Write(ViewBag.livro);

#line default
#line hidden
                EndContext();
                BeginContext(1605, 10, true);
                WriteLiteral("\" +\"/\" + \"");
                EndContext();
                BeginContext(1616, 16, false);
#line 52 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\HttpNotFound.cshtml"
                                                                                                          Write(ViewBag.capitulo);

#line default
#line hidden
                EndContext();
                BeginContext(1632, 11, true);
                WriteLiteral("\" + \"/\" + \"");
                EndContext();
                BeginContext(1644, 18, false);
#line 52 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\HttpNotFound.cshtml"
                                                                                                                                      Write(ViewBag.numeroErro);

#line default
#line hidden
                EndContext();
                BeginContext(1662, 176, true);
                WriteLiteral("\";  }, 30000);\r\n            }\r\n\r\n\r\n      \r\n\r\n        $(\"#NumeroPaginaAcesso\").change(function () {\r\n\r\n                document.getElementById(\"acessoPaginaComInput2\").href = \"/");
                EndContext();
                BeginContext(1839, 12, false);
#line 60 "C:\Users\leandro\Documents\rede-social\CMS\Views\Pagina\HttpNotFound.cshtml"
                                                                     Write(ViewBag.user);

#line default
#line hidden
                EndContext();
                BeginContext(1851, 152, true);
                WriteLiteral("/Story-Padrao-Pagina/\";\r\n                document.getElementById(\"acessoPaginaComInput2\").href += $(this).val();\r\n            });\r\n\r\n    </script>\r\n\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(2006, 2, true);
            WriteLiteral("\r\n");
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

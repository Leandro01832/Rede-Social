#pragma checksum "C:\rede-social\CMS\Views\Visualizar\Comentar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "460eb2378fb0991b27c2420b509607c403f45838"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Visualizar_Comentar), @"mvc.1.0.view", @"/Views/Visualizar/Comentar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Visualizar/Comentar.cshtml", typeof(AspNetCore.Views_Visualizar_Comentar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"460eb2378fb0991b27c2420b509607c403f45838", @"/Views/Visualizar/Comentar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Visualizar_Comentar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Tynymce.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/AjaxGetGroup.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FullScreen.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "C:\rede-social\CMS\Views\Visualizar\Comentar.cshtml"
  
    ViewBag.Title = "Create";
    List<string> lista = ViewBag.comentarios;

#line default
#line hidden
            BeginContext(89, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\rede-social\CMS\Views\Visualizar\Comentar.cshtml"
     using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(130, 23, false);
#line 10 "C:\rede-social\CMS\Views\Visualizar\Comentar.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(157, 132, true);
            WriteLiteral("    <script src=\"https://cloud.tinymce.com/5/tinymce.min.js?apiKey=m8nq39l31dv5y829ehcjsd0rciwei8crem0yubndhdgs72fd\"></script>\r\n    ");
            EndContext();
            BeginContext(289, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "460eb2378fb0991b27c2420b509607c403f458385484", async() => {
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
            BeginContext(328, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(332, 162, true);
            WriteLiteral("    <a href=\'#\' id=\'Fechar\' class=\'btn btn-primary\' style=\"display:none;\">Fechar Preview</a>\r\n    <div class=\"form-horizontal\" id=\"Formulario\">\r\n       \r\n        ");
            EndContext();
            BeginContext(495, 64, false);
#line 18 "C:\rede-social\CMS\Views\Visualizar\Comentar.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(559, 56, true);
            WriteLiteral("\r\n        \r\n        <input name=\"idPagina\" id=\"idPagina\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 615, "\"", 640, 1);
#line 20 "C:\rede-social\CMS\Views\Visualizar\Comentar.cshtml"
WriteAttributeValue("", 623, ViewBag.idPagina, 623, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(641, 547, true);
            WriteLiteral(@" type=""hidden"" />        

        <div class=""form-group"">
            <label id=""PalavrasTexto"" name=""PalavrasTexto"" class=""control-label"">Conteudo:</label>
            <script type=""text/javascript"">Editar();</script>
            <textarea id=""textarea"" name=""Conteudo"" class=""form-control""></textarea>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Comentar"" class=""btn btn-default"" />
            </div>
        </div>
    </div>
");
            EndContext();
#line 34 "C:\rede-social\CMS\Views\Visualizar\Comentar.cshtml"

}

#line default
#line hidden
            BeginContext(1193, 156, true);
            WriteLiteral("\r\n<a href=\"#\" class=\"btn btn-primary fechar\" >Fechar</a>\r\n\r\n<div class=\"comentarios\" style=\"height:350px; overflow: hidden; bottom: 1% position: fixed;\" >\r\n");
            EndContext();
#line 40 "C:\rede-social\CMS\Views\Visualizar\Comentar.cshtml"
          foreach(var item in lista)
            {
                

#line default
#line hidden
            BeginContext(1419, 14, false);
#line 42 "C:\rede-social\CMS\Views\Visualizar\Comentar.cshtml"
           Write(Html.Raw(item));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 48, true);
            WriteLiteral("                <br />\r\n                <hr />\r\n");
            EndContext();
#line 45 "C:\rede-social\CMS\Views\Visualizar\Comentar.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1509, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1538, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1546, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "460eb2378fb0991b27c2420b509607c403f458389611", async() => {
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
                BeginContext(1613, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1619, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "460eb2378fb0991b27c2420b509607c403f4583810953", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1684, 311, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            $("".fechar"").click(function () {
                $("".ProdutoContent"").css(""display"", ""block"");
                $(""#comentario"").css(""display"", ""none"");
            });           

        });
    </script>

");
                EndContext();
            }
            );
            BeginContext(1998, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

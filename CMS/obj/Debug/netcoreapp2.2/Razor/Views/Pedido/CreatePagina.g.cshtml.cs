#pragma checksum "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6515247c58f93884b8624a84245387c69acf149a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_CreatePagina), @"mvc.1.0.view", @"/Views/Pedido/CreatePagina.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/CreatePagina.cshtml", typeof(AspNetCore.Views_Pedido_CreatePagina))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6515247c58f93884b8624a84245387c69acf149a", @"/Views/Pedido/CreatePagina.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_CreatePagina : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<business.business.Pagina>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
            BeginContext(73, 22, true);
            WriteLiteral("\r\n<h2>Criar</h2>\r\n\r\n\r\n");
            EndContext();
#line 10 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(130, 23, false);
#line 12 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(157, 68, true);
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h4>Pagina</h4>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(226, 64, false);
#line 17 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(290, 42, true);
            WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(333, 95, false);
#line 20 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
   Write(Html.LabelFor(model => model.Titulo, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(428, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(476, 95, false);
#line 22 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
       Write(Html.EditorFor(model => model.Titulo, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(571, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(586, 84, false);
#line 23 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
       Write(Html.ValidationMessageFor(model => model.Titulo, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(670, 70, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(740, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6515247c58f93884b8624a84245387c69acf149a6120", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 28 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
                                         WriteLiteral(ViewBag.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(804, 54, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(859, 96, false);
#line 32 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
   Write(Html.LabelFor(model => model.StoryId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(955, 47, true);
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
            EndContext();
            BeginContext(1003, 83, false);
#line 34 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
       Write(Html.DropDownList("StoryId", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1086, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1101, 85, false);
#line 35 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
       Write(Html.ValidationMessageFor(model => model.StoryId, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 131, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"checkbox\">\r\n            <label>\r\n                ");
            EndContext();
            BeginContext(1317, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6515247c58f93884b8624a84245387c69acf149a9967", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 42 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Layout);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1343, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1345, 42, false);
#line 42 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
                                      Write(Html.DisplayNameFor(model => model.Layout));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 244, true);
            WriteLiteral("\r\n            </label>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Criar\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 53 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
}

#line default
#line hidden
            BeginContext(1634, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1648, 47, false);
#line 56 "C:\Users\simon\source\repos\C#\rede-social\CMS\Views\Pedido\CreatePagina.cshtml"
Write(Html.ActionLink("Voltar para a lista", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1695, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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

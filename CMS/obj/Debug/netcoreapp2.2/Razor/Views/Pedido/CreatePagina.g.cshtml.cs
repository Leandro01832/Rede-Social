#pragma checksum "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b679c16115a6df7bb8de94ac8feba79249519aef"
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
#line 1 "C:\Rede-Social-master\Rede-Social\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Rede-Social-master\Rede-Social\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b679c16115a6df7bb8de94ac8feba79249519aef", @"/Views/Pedido/CreatePagina.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"600f5e98c0b7ea1830bf7c16785f85b547fc669d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_CreatePagina : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<business.business.Pagina>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/AjaxGetGroup.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
            BeginContext(68, 18, true);
            WriteLiteral("\n<h2>Criar</h2>\n\n\n");
            EndContext();
#line 10 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(119, 23, false);
#line 12 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(144, 65, true);
            WriteLiteral("<div class=\"form-horizontal\">\n    <h4>Pagina</h4>\n    <hr />\n    ");
            EndContext();
            BeginContext(210, 64, false);
#line 17 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(274, 40, true);
            WriteLiteral("\n\n\n    <div class=\"form-group\">\n        ");
            EndContext();
            BeginContext(315, 95, false);
#line 21 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
   Write(Html.LabelFor(model => model.Titulo, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(410, 45, true);
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
            EndContext();
            BeginContext(456, 95, false);
#line 23 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
       Write(Html.EditorFor(model => model.Titulo, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(551, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(565, 84, false);
#line 24 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
       Write(Html.ValidationMessageFor(model => model.Titulo, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(649, 85, true);
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 734, "\"", 757, 1);
#line 29 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
WriteAttributeValue("", 742, ViewBag.UserId, 742, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(758, 33, true);
            WriteLiteral(" id=\"IdentificacaoUser\">\n        ");
            EndContext();
            BeginContext(791, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b679c16115a6df7bb8de94ac8feba79249519aef8776", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 30 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 30 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
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
            BeginContext(855, 50, true);
            WriteLiteral("\n    </div>\n\n    <div class=\"form-group\">\n        ");
            EndContext();
            BeginContext(906, 96, false);
#line 34 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
   Write(Html.LabelFor(model => model.StoryId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 45, true);
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
            EndContext();
            BeginContext(1048, 83, false);
#line 36 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
       Write(Html.DropDownList("StoryId", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(1145, 85, false);
#line 37 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
       Write(Html.ValidationMessageFor(model => model.StoryId, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 73, true);
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n                ");
            EndContext();
            BeginContext(1303, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b679c16115a6df7bb8de94ac8feba79249519aef12495", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 42 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SubStoryId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1361, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1378, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b679c16115a6df7bb8de94ac8feba79249519aef14126", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 43 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SubStoryId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1437, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1454, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b679c16115a6df7bb8de94ac8feba79249519aef15763", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 44 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SubStoryId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1519, 74, true);
            WriteLiteral("\n            </div>\n\n            <div class=\"form-group\">\n                ");
            EndContext();
            BeginContext(1593, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b679c16115a6df7bb8de94ac8feba79249519aef17526", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 48 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GrupoId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1648, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1665, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b679c16115a6df7bb8de94ac8feba79249519aef19154", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 49 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GrupoId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1722, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1739, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b679c16115a6df7bb8de94ac8feba79249519aef20788", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 50 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GrupoId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1801, 74, true);
            WriteLiteral("\n            </div>\n\n            <div class=\"form-group\">\n                ");
            EndContext();
            BeginContext(1875, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b679c16115a6df7bb8de94ac8feba79249519aef22548", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 54 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SubGrupoId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1933, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1950, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b679c16115a6df7bb8de94ac8feba79249519aef24179", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 55 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SubGrupoId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2010, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(2027, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b679c16115a6df7bb8de94ac8feba79249519aef25816", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 56 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SubGrupoId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2092, 74, true);
            WriteLiteral("\n            </div>\n\n            <div class=\"form-group\">\n                ");
            EndContext();
            BeginContext(2166, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b679c16115a6df7bb8de94ac8feba79249519aef27579", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 60 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SubSubGrupoId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2227, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(2244, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b679c16115a6df7bb8de94ac8feba79249519aef29213", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 61 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SubSubGrupoId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2307, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(2324, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b679c16115a6df7bb8de94ac8feba79249519aef30853", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 62 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SubSubGrupoId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2392, 617, true);
            WriteLiteral(@"
            </div>

            <div class=""form-group"">
                <label  class=""control-label"">Quantidades de blocos no container</label>
                <input id=""QuantidadeDiv"" name=""QuantidadeDiv"" type=""number"" min=""1"" class=""form-control"">
            </div>
            <div class=""form-group"">
                <label  class=""control-label"">Quantidades de containers</label>
                <input id=""QuantContainers"" name=""QuantContainers"" type=""number"" min=""0"" class=""form-control"">
            </div>

    <div class=""form-group"">
        <div class=""checkbox"">
            <label>
                ");
            EndContext();
            BeginContext(3009, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b679c16115a6df7bb8de94ac8feba79249519aef33190", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 77 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
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
            BeginContext(3035, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3037, 42, false);
#line 77 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
                                      Write(Html.DisplayNameFor(model => model.Layout));

#line default
#line hidden
            EndContext();
            BeginContext(3079, 233, true);
            WriteLiteral("\n            </label>\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        <div class=\"col-md-offset-2 col-md-10\">\n            <input type=\"submit\" value=\"Criar\" class=\"btn btn-default\" />\n        </div>\n    </div>\n</div>\n");
            EndContext();
#line 88 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
}

#line default
#line hidden
            BeginContext(3314, 11, true);
            WriteLiteral("\n<div>\n    ");
            EndContext();
            BeginContext(3326, 47, false);
#line 91 "C:\Rede-Social-master\Rede-Social\CMS\Views\Pedido\CreatePagina.cshtml"
Write(Html.ActionLink("Voltar para a lista", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(3373, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3399, 8, true);
                WriteLiteral("\n  \n    ");
                EndContext();
                BeginContext(3407, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b679c16115a6df7bb8de94ac8feba79249519aef36106", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3474, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
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

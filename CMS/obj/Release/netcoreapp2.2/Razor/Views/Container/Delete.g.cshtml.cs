#pragma checksum "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e938cf42439876aa6e6f8176b578162f49d67c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Container_Delete), @"mvc.1.0.view", @"/Views/Container/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Container/Delete.cshtml", typeof(AspNetCore.Views_Container_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e938cf42439876aa6e6f8176b578162f49d67c7", @"/Views/Container/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"600f5e98c0b7ea1830bf7c16785f85b547fc669d", @"/Views/_ViewImports.cshtml")]
    public class Views_Container_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<business.business.Container>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(60, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(85, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e938cf42439876aa6e6f8176b578162f49d67c75100", async() => {
                BeginContext(91, 85, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Delete</title>\n");
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
            BeginContext(183, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(184, 2416, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e938cf42439876aa6e6f8176b578162f49d67c76368", async() => {
                BeginContext(190, 154, true);
                WriteLiteral("\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Container</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
                EndContext();
                BeginContext(345, 41, false);
#line 22 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ordem));

#line default
#line hidden
                EndContext();
                BeginContext(386, 60, true);
                WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
                EndContext();
                BeginContext(447, 37, false);
#line 25 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ordem));

#line default
#line hidden
                EndContext();
                BeginContext(484, 59, true);
                WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
                EndContext();
                BeginContext(544, 48, false);
#line 28 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BorderRadius));

#line default
#line hidden
                EndContext();
                BeginContext(592, 60, true);
                WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
                EndContext();
                BeginContext(653, 44, false);
#line 31 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BorderRadius));

#line default
#line hidden
                EndContext();
                BeginContext(697, 59, true);
                WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
                EndContext();
                BeginContext(757, 42, false);
#line 34 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Height));

#line default
#line hidden
                EndContext();
                BeginContext(799, 60, true);
                WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
                EndContext();
                BeginContext(860, 38, false);
#line 37 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Height));

#line default
#line hidden
                EndContext();
                BeginContext(898, 59, true);
                WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
                EndContext();
                BeginContext(958, 41, false);
#line 40 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Width));

#line default
#line hidden
                EndContext();
                BeginContext(999, 60, true);
                WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
                EndContext();
                BeginContext(1060, 37, false);
#line 43 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Width));

#line default
#line hidden
                EndContext();
                BeginContext(1097, 59, true);
                WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
                EndContext();
                BeginContext(1157, 44, false);
#line 46 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FlexWrap));

#line default
#line hidden
                EndContext();
                BeginContext(1201, 60, true);
                WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
                EndContext();
                BeginContext(1262, 40, false);
#line 49 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FlexWrap));

#line default
#line hidden
                EndContext();
                BeginContext(1302, 59, true);
                WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
                EndContext();
                BeginContext(1362, 50, false);
#line 52 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JustifyContent));

#line default
#line hidden
                EndContext();
                BeginContext(1412, 60, true);
                WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
                EndContext();
                BeginContext(1473, 46, false);
#line 55 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JustifyContent));

#line default
#line hidden
                EndContext();
                BeginContext(1519, 59, true);
                WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
                EndContext();
                BeginContext(1579, 49, false);
#line 58 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FlexDirection));

#line default
#line hidden
                EndContext();
                BeginContext(1628, 60, true);
                WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
                EndContext();
                BeginContext(1689, 45, false);
#line 61 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FlexDirection));

#line default
#line hidden
                EndContext();
                BeginContext(1734, 59, true);
                WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
                EndContext();
                BeginContext(1794, 46, false);
#line 64 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AlignItems));

#line default
#line hidden
                EndContext();
                BeginContext(1840, 60, true);
                WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
                EndContext();
                BeginContext(1901, 42, false);
#line 67 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AlignItems));

#line default
#line hidden
                EndContext();
                BeginContext(1943, 59, true);
                WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
                EndContext();
                BeginContext(2003, 43, false);
#line 70 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Padding));

#line default
#line hidden
                EndContext();
                BeginContext(2046, 60, true);
                WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
                EndContext();
                BeginContext(2107, 39, false);
#line 73 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Padding));

#line default
#line hidden
                EndContext();
                BeginContext(2146, 59, true);
                WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
                EndContext();
                BeginContext(2206, 43, false);
#line 76 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
                EndContext();
                BeginContext(2249, 60, true);
                WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
                EndContext();
                BeginContext(2310, 39, false);
#line 79 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
                EndContext();
                BeginContext(2349, 34, true);
                WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
                EndContext();
                BeginContext(2383, 202, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e938cf42439876aa6e6f8176b578162f49d67c715859", async() => {
                    BeginContext(2409, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(2418, 36, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e938cf42439876aa6e6f8176b578162f49d67c716269", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 84 "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Container\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

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
                    BeginContext(2454, 81, true);
                    WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                    EndContext();
                    BeginContext(2535, 38, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e938cf42439876aa6e6f8176b578162f49d67c718261", async() => {
                        BeginContext(2557, 12, true);
                        WriteLiteral("Back to List");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2573, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2585, 8, true);
                WriteLiteral("\n</div>\n");
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
            BeginContext(2600, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<business.business.Container> Html { get; private set; }
    }
}
#pragma warning restore 1591

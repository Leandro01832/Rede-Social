#pragma checksum "C:\Users\leand\Downloads\Rede-Social-master\Rede-Social\CMS\Views\Pagina\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a305f6b17dbe7fc2d10e84fb5537311ba80ffea9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagina_Chat), @"mvc.1.0.view", @"/Views/Pagina/Chat.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pagina/Chat.cshtml", typeof(AspNetCore.Views_Pagina_Chat))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a305f6b17dbe7fc2d10e84fb5537311ba80ffea9", @"/Views/Pagina/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"600f5e98c0b7ea1830bf7c16785f85b547fc669d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagina_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 476, true);
            WriteLiteral(@"
 <style>
     .container1{
         width:255px;
         margin-left: 0px;
     }
 </style>

<style>
    #discussion {
        background-color: lightblue;
        width: 255px;
        height: 255px;
        overflow: scroll;
    }
</style>

<h2>Chat</h2>
<div class=""container1"">
    <input type=""text"" id=""message"" />
    <input type=""button"" id=""sendmessage"" value=""Enviar mensagem"" />
    <input type=""hidden"" id=""displayname"" />
    <ul id=""discussion""></ul>
</div>


");
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

#pragma checksum "C:\Users\simon\source\repos\C#\rede-social\CMS\wwwroot\Arquivotxt\DocBackgroundGradiente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "727a6f42fc9d2a85bf85c88d2432ae1f0a49540d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.wwwroot_Arquivotxt_DocBackgroundGradiente), @"mvc.1.0.view", @"/wwwroot/Arquivotxt/DocBackgroundGradiente.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/wwwroot/Arquivotxt/DocBackgroundGradiente.cshtml", typeof(AspNetCore.wwwroot_Arquivotxt_DocBackgroundGradiente))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"727a6f42fc9d2a85bf85c88d2432ae1f0a49540d", @"/wwwroot/Arquivotxt/DocBackgroundGradiente.cshtml")]
    public class wwwroot_Arquivotxt_DocBackgroundGradiente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 805, true);
            WriteLiteral(@"<style>




    body {
        background: rgb(9,231,24);
        background: -moz-linear-gradient(49deg, rgba(rgb(9,231,24),0.7456116235556722) 21%, rgba(28,142,165,0.4711018196341037) 77%);
        background: -webkit-linear-gradient(49deg, rgba(9,231,24,0.7456116235556722) 21%, rgba(28,142,165,0.4711018196341037) 77%);
        background: linear-gradient(49deg, rgba(9,231,24,0.7456116235556722) 21%, rgba(28,142,165,0.4711018196341037) 77%);
        filter: progid:DXImageTransform.Microsoft.gradient(startColorstr=""#09e718"",endColorstr=""#1c8ea5"",GradientType=1);
    }
</style>



#else

<style>
    .content {
        background-color: $model.background.Cor;
    }

    #pagina$model.Pagina.Id {
        background-color: $model.background.Cor;
    }
</style>

#end

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

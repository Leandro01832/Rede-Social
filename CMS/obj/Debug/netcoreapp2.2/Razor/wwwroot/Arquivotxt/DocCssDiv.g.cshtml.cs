#pragma checksum "C:\Rede-Social-master\Rede-Social\CMS\wwwroot\Arquivotxt\DocCssDiv.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f65fecdf0f131641bb8a6c22546a8f78bef83006"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.wwwroot_Arquivotxt_DocCssDiv), @"mvc.1.0.view", @"/wwwroot/Arquivotxt/DocCssDiv.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/wwwroot/Arquivotxt/DocCssDiv.cshtml", typeof(AspNetCore.wwwroot_Arquivotxt_DocCssDiv))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f65fecdf0f131641bb8a6c22546a8f78bef83006", @"/wwwroot/Arquivotxt/DocCssDiv.cshtml")]
    public class wwwroot_Arquivotxt_DocCssDiv : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3478, true);
            WriteLiteral(@"#set($site = '')

<style>
    .bloco 
    {
        display: flex;    
        flex-direction: ${model.Pagina.FlexDirection};    
        align-items: ${model.Pagina.AlignItems};
        width: 100%;
        min-height: 950px;
        height: auto;
        background-size: contain;
    } 

</style>

#foreach($container in $divs)

<style>

#Container${container.Container.Id}Pagina${model.Pagina.Id}
    {
        width: ${container.Container.Width}%;
        min-height: ${container.Container.Height}px;
        height: auto;
        border-radius: ${container.Container.BorderRadius}px;
        padding: ${container.Container.Padding}%;
        order: ${container.Container.Ordem};
        flex-wrap: ${container.Container.FlexWrap};
        justify-content: ${container.Container.JustifyContent};
        flex-direction: ${container.Container.FlexDirection};    
        align-items: ${container.Container.AlignItems};          
        align-self: ${container.Container.AlignSelf};
        
    }
</style>

#foreach($bl");
            WriteLiteral(@" in $container.Container.Div)

<style>
    #DIV${bl.Div.Id}Pagina${model.Pagina.Id} 
    {
        order: ${bl.Div.Ordem};
        width: ${bl.Div.Width}%;
        min-height: ${bl.Div.Height}px;
        height: auto;
        border-radius: ${bl.Container.BorderRadius}px;
        flex-wrap: ${bl.Div.FlexWrap};
        justify-content: ${bl.Div.JustifyContent};
        flex-direction: ${bl.Div.FlexDirection};    
        align-items: ${bl.Div.AlignItems};        
        align-self: ${bl.Div.AlignSelf};
        
    }
</style>

#foreach($elemento in $bl.Div.Elemento)

    <style>
    #elemento${elemento.Elemento.Id}Pagina${model.Pagina.Id}
    {
        order: ${elemento.Elemento.Ordem};        
        align-self: ${elemento.Elemento.AlignSelf};
        flex-grow: ${elemento.Elemento.Width};
        
    }
</style>

#end
#end
#end


               #if($model.Pagina.MostrarDados == 1)
    <script type=""text/javascript"">
        $(document).ready(function () {
            $("".Elemento"").css(""border"", ""ridge"");
");
            WriteLiteral(@"            $("".Elemento"").css(""border-width"", ""3px"");
            $("".ClassDiv"").css(""border"", ""ridge"");
            $("".ClassDiv"").css(""border-width"", ""8px"");
            $("".ContainerDiv"").css(""border"", ""ridge"");
            $("".ContainerDiv"").css(""border-width"", ""15px"");
        });
    </script>
            #else
    <script type=""text/javascript"">
        $(document).ready(function () {
            $("".Elemento"").css(""border"", ""none"");
            $("".ClassDiv"").css(""border"", ""none"");
            $("".ContainerDiv"").css(""border"", ""none"");
            });
    </script>
            #end

            <script type=""text/javascript"">
        $(document).ready(function () {      
            
                if ($(""#margem"").is(':checked'))
                {
                    $("".Elemento"").css(""border"", ""ridge"");
                    $("".Elemento"").css(""border-width"", ""3px"");
                    $("".ClassDiv"").css(""border"", ""ridge"");
                    $("".ClassDiv"").css(""border-width"", ""8px"");
            ");
            WriteLiteral(@"        $("".ContainerDiv"").css(""border"", ""ridge"");
                    $("".ContainerDiv"").css(""border-width"", ""15px""); 
                }
                else
                {
                    $("".Elemento"").css(""border"", ""none"");
                    $("".ClassDiv"").css(""border"", ""none"");
                    $("".ContainerDiv"").css(""border"", ""none"");
                }      

        });
    </script>
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

#pragma checksum "C:\Users\leandro\Documents\rede-social\CMS\wwwroot\Arquivotxt\html\DocLink.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2497d8d48c56c31915844f1dd9ccae397e02b518"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.wwwroot_Arquivotxt_html_DocLink), @"mvc.1.0.view", @"/wwwroot/Arquivotxt/html/DocLink.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/wwwroot/Arquivotxt/html/DocLink.cshtml", typeof(AspNetCore.wwwroot_Arquivotxt_html_DocLink))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2497d8d48c56c31915844f1dd9ccae397e02b518", @"/wwwroot/Arquivotxt/html/DocLink.cshtml")]
    public class wwwroot_Arquivotxt_html_DocLink : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1625, true);
            WriteLiteral(@"#if($element.Elemento.tipo == 'Link' && $element.Elemento.Menu == false)

#if($element.Elemento.UrlLink == false)

<div id='Link${element.Elemento.IdElemento}Pagina${model.Pagina.Id}' class='Elemento$element.Elemento.IdElemento grid-item' data-value='$element.Elemento.IdElemento' data-id='$element.Elemento.IdElemento'>
    <a href='/site/$element.Elemento.Destino.Pedido.DominioTemporario/$element.Elemento.Destino.Titulo.Replace(' ', '')'>

        #set($linkIndice = 0)
        #foreach($el in $element.Elemento.Despendentes)

        #if($linkIndice == 0)
        $el.ElementoDependente.Dependente.PalavrasTexto
        #end

        #if($linkIndice == 1)
        <img class='img-responsive' src='$el.ElementoDependente.Dependente.ArquivoImagem' alt='imagem' style='width:100%;' />
        #end

        #set($linkIndice = $linkIndice + 1)

        #end


    </a>
</div>

#else

<div id='Link${element.Elemento.IdElemento}Pagina${model.Pagina.Id}' class='Elemento$element.Elemento.IdElement");
            WriteLiteral(@"o grid-item' data-value='$element.Elemento.IdElemento' data-id='$element.Elemento.IdElemento'>
    <a href='$element.Elemento.TextoLink'>

        #set($linkIndice = 0)
        #foreach($el in $element.Elemento.Despendentes)

        #if($linkIndice == 0)
        $el.ElementoDependente.Dependente.PalavrasTexto
        #end

        #if($linkIndice == 1)
        <img class='img-responsive' src='$el.ElementoDependente.Dependente.ArquivoImagem' alt='imagem' style='width:100%;' />
        #end

        #set($linkIndice = $linkIndice + 1)

        #end
    </a>
</div>

#end
#end");
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

#pragma checksum "C:\rede-social\CMS\wwwroot\Arquivotxt\DocBloco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d141cc00f23c46e33c8e9b6ce011596937b60ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.wwwroot_Arquivotxt_DocBloco), @"mvc.1.0.view", @"/wwwroot/Arquivotxt/DocBloco.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/wwwroot/Arquivotxt/DocBloco.cshtml", typeof(AspNetCore.wwwroot_Arquivotxt_DocBloco))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d141cc00f23c46e33c8e9b6ce011596937b60ef", @"/wwwroot/Arquivotxt/DocBloco.cshtml")]
    public class wwwroot_Arquivotxt_DocBloco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 9868, true);
            WriteLiteral(@"
#foreach($container in $divs)

#foreach($bloco in $container.Container.Div)

#if($bloco.Div.Tipo == ""DivFixo"" && $bloco.Div.EscolherPosicao == false)

<style>
    #DIV${bloco.Div.Id}Pagina${model.Pagina.Id} 
    {
        display: none;
        position: fixed; 
        right: ${bloco.Div.EixoXBlocoFixado}%;
        top: ${bloco.Div.EixoYBlocoFixado}%;
    }
</style>

#elseif($bloco.Div.Tipo == ""DivFixo"")

<style>
    #DIV${bloco.Div.Id}Pagina${model.Pagina.Id} 
    {
        display: none;
    }
</style>

#end

#if($bloco.Div.Background.Tipo == ""BackgroundImagem"")
<style>
    #DIV${bloco.Div.Id}Pagina${model.Pagina.Id} {

      background-repeat: ${bloco.Div.Background.Background_Repeat};       

    background-image: url($bloco.Div.Background.Imagem.ArquivoImagem);
       
    }
</style>

#elseif($bloco.Div.Background.Tipo == ""BackgroundGradiente"")

  <style>
    #DIV${bloco.Div.Id}Pagina${model.Pagina.Id} {

        #set($um = 1)
         #foreach($Cores in $bl");
            WriteLiteral(@"oco.Div.Background.Cores)
         #if($um == 1)
        #set($back = $Cores.HexToColor($Cores.CorBackground))
        background: rgb($back); 
        #end
        #set($um = $um + 1)        
         #end


         #set($quantidade = $bloco.Div.Background.Cores.Count())
        background: -moz-linear-gradient(${bloco.Div.Background.Grau}deg,
        #foreach($Cor in $bloco.Div.Background.Cores)
         #set($Transparencia = $Cor.Transparencia / 10)
        rgba($Cor.HexToColor($Cor.CorBackground),$Transparencia.toString().replace(',','.')) ${Cor.Position}%

            #if($velocityCount == $quantidade)
             );
        #else
            ,
            #end

        #end  

        background: -webkit-linear-gradient(${bloco.Div.Background.Grau}deg,
        #foreach($Cor in $bloco.Div.Background.Cores)
        #set($Transparencia = $Cor.Transparencia / 10)
        rgba($Cor.HexToColor($Cor.CorBackground),$Transparencia.toString().replace(',','.')) ${Cor.Position}%

     ");
            WriteLiteral(@"   #if($velocityCount == $quantidade)
             );
        #else
            ,
            #end

        #end  

        background: linear-gradient(${bloco.Div.Background.Grau}deg,
        #foreach($Cor in $bloco.Div.Background.Cores)
        #set($Transparencia = $Cor.Transparencia / 10)
        rgba($Cor.HexToColor($Cor.CorBackground),$Transparencia.toString().replace(',','.')) ${Cor.Position}%

            #if($velocityCount == $quantidade)
             );
        #else
             ,
            #end

        #end  

        filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#09e718',endColorstr='#1c8ea5',GradientType=1);
    
    }
</style>

#else

<style>
    #DIV${bloco.Div.Id}Pagina${model.Pagina.Id} {       

    background-color: $bloco.Div.Background.Cor;    
    
    }
</style>
#end

#foreach($elemento in $bloco.Div.Elemento)

    #if($elemento.Elemento.Background.Tipo == ""BackgroundImagemElemento"")
<style>
    #elemento${elemento.Element");
            WriteLiteral(@"o.Id}Pagina${model.Pagina.Id} {

      background-repeat: ${elemento.Elemento.Background.Background_RepeatElemento};       

    background-image: url($elemento.Elemento.Background.Imagem.ArquivoImagem);
       
    }
</style>

#elseif($elemento.Elemento.Background.Tipo == ""BackgroundGradienteElemento"")

  <style>
    #elemento${elemento.Elemento.Id}Pagina${model.Pagina.Id} {

        #set($um = 1)
         #foreach($Cores in $elemento.Elemento.Background.Cores)
         #if($um == 1)
        #set($back = $Cores.HexToColor($Cores.CorBackground))
        background: rgb($back); 
        #end
        #set($um = $um + 1)        
         #end


         #set($quantidade = $elemento.Elemento.Background.Cores.Count())
        background: -moz-linear-gradient(${elemento.Elemento.Background.GrauElemento}deg,
        #foreach($Cor in $elemento.Elemento.Background.Cores)
         #set($Transparencia = $Cor.Transparencia / 10)
        rgba($Cor.HexToColor($Cor.CorBackground),$Transparencia.t");
            WriteLiteral(@"oString().replace(',','.')) ${Cor.Position}%

            #if($velocityCount == $quantidade)
             );
        #else
            ,
            #end

        #end  

        background: -webkit-linear-gradient(${elemento.Elemento.Background.GrauElemento}deg,
        #foreach($Cor in $elemento.Elemento.Background.Cores)
        #set($Transparencia = $Cor.Transparencia / 10)
        rgba($Cor.HexToColor($Cor.CorBackground),$Transparencia.toString().replace(',','.')) ${Cor.Position}%

        #if($velocityCount == $quantidade)
             );
        #else
            ,
            #end

        #end  

        background: linear-gradient(${elemento.Elemento.Background.GrauElemento}deg,
        #foreach($Cor in $elemento.Elemento.Background.Cores)
        #set($Transparencia = $Cor.Transparencia / 10)
        rgba($Cor.HexToColor($Cor.CorBackground),$Transparencia.toString().replace(',','.')) ${Cor.Position}%

            #if($velocityCount == $quantidade)
             );
     ");
            WriteLiteral(@"   #else
             ,
            #end

        #end  

        filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#09e718',endColorstr='#1c8ea5',GradientType=1);
    
    }
</style>

#else

<style>
    #elemento${elemento.Elemento.Id}Pagina${model.Pagina.Id} {       

    background-color: $elemento.Elemento.Background.CorElemento;    
    
    }
</style>
#end

#end

#end

#end

<div>
    <script type='text/javascript'>
        jQuery(function () {

                $('#Ocultar').click(function () {

                    #foreach($bloco in $divs)
                    $('#DIV${bloco.Div.Id}Pagina${model.Pagina.Id}').css('display', 'block');
                    #end

                });

            $('.Ferramenta').click(function () {

                    #foreach($bloco in $divs)
                    #if($bloco.Div.Fixado)
                        $('#DIV${bloco.Div.Id}Pagina${model.Pagina.Id}').css('display', 'none');
                    #end
       ");
            WriteLiteral(@"             #end

            });


                    #foreach($bloco in $divs) 
                    #if ($bloco.Div.Fixado && $bloco.Div.EscolherPosicao)

                        var header = $('#DIV${bloco.Div.Id}Pagina${model.Pagina.Id}');
                    var sticky = header[0].offsetTop;

                        window.onscroll = function () {
                            if (window.pageYOffset + ${bloco.Div.InicioFixacao} > sticky) {

                        header.addClass('stickyDIV${bloco.Div.Id}Pagina${model.Pagina.Id}');
                    } else
                    {
                        header.removeClass('stickyDIV${bloco.Div.Id}Pagina${model.Pagina.Id}');
                    }
                }
        #end
        #end

        });
    </script>
</div>


#foreach($bloco in $divs)
#foreach($bl in $bloco.Container.Div)

#if($bl.Div.Tipo == 'DivFixo' && $bl.Div.Fixado && $bloco.Div.EscolherPosicao)

<style>
    .stickyDIV${bl.Div.Id}Pagina${model.Pagina.");
            WriteLiteral(@"Id} {
        position: fixed;
        top: ${bloco.Div.PosicaoFixacao}%;
        
    }
</style>
#end
#end
#end


#foreach($bloco in $divs)

#if($bloco.Container.Background.Tipo == ""BackgroundImagemContainer"")
<style>
    #Container${bloco.Container.Id}Pagina${model.Pagina.Id} {

      background-repeat: ${bloco.Container.Background.Background_RepeatContainer};       

    background-image: url($bloco.Container.Background.Imagem.ArquivoImagem);

    }
</style>

#elseif($bloco.Container.Background.Tipo == ""BackgroundGradienteContainer"")

  <style>
    #Container${bloco.Container.Id}Pagina${model.Pagina.Id} {

        #set($um = 1)
         #foreach($Cores in $bloco.Container.Background.Cores)
         #if($um == 1)
        #set($back = $Cores.HexToColor($Cores.CorBackground))
        background: rgb($back); 
        #end
        #set($um = $um + 1)        
         #end


         #set($quantidade = $bloco.Container.Background.Cores.Count())
        background: -moz-lin");
            WriteLiteral(@"ear-gradient(${bloco.Container.Background.GrauContainer}deg,
        #foreach($Cor in $bloco.Container.Background.Cores)
         #set($Transparencia = $Cor.Transparencia / 10)
        rgba($Cor.HexToColor($Cor.CorBackground),$Transparencia.toString().replace(',','.')) ${Cor.Position}%

            #if($velocityCount == $quantidade)
             );
        #else
            ,
            #end

        #end  

        background: -webkit-linear-gradient(${bloco.Container.Background.GrauContainer}deg,
        #foreach($Cor in $bloco.Container.Background.Cores)
        #set($Transparencia = $Cor.Transparencia / 10)
        rgba($Cor.HexToColor($Cor.CorBackground),$Transparencia.toString().replace(',','.')) ${Cor.Position}%

        #if($velocityCount == $quantidade)
             );
        #else
            ,
            #end

        #end  

        background: linear-gradient(${bloco.Container.Background.GrauContainer}deg,
        #foreach($Cor in $bloco.Container.Background.Cores)
");
            WriteLiteral(@"        #set($Transparencia = $Cor.Transparencia / 10)
        rgba($Cor.HexToColor($Cor.CorBackground),$Transparencia.toString().replace(',','.')) ${Cor.Position}%

            #if($velocityCount == $quantidade)
             );
        #else
             ,
            #end

        #end  

        filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#09e718',endColorstr='#1c8ea5',GradientType=1);
           
    }
</style>

#else

<style>
    #Container${bloco.Container.Id}Pagina${model.Pagina.Id} {     
    
    background-color: $bloco.Container.Background.CorContainer;
    
    }
</style>
#end

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

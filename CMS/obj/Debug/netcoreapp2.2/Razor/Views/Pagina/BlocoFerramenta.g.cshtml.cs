#pragma checksum "C:\Users\leand\Downloads\teste\cms\CMS\Views\Pagina\BlocoFerramenta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89f9afe2ee50dc10cee272cf01c09d2319a865d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagina_BlocoFerramenta), @"mvc.1.0.view", @"/Views/Pagina/BlocoFerramenta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pagina/BlocoFerramenta.cshtml", typeof(AspNetCore.Views_Pagina_BlocoFerramenta))]
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
#line 1 "C:\Users\leand\Downloads\teste\cms\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#line 2 "C:\Users\leand\Downloads\teste\cms\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89f9afe2ee50dc10cee272cf01c09d2319a865d3", @"/Views/Pagina/BlocoFerramenta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagina_BlocoFerramenta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2228, true);
            WriteLiteral(@"
<style>
    .container1 {
        width: 255px;
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

<ul class=""nav navbar-nav navbar-left"" style=""width:100px;"">
    <li class=""dropdown"">
        <a href=""#"" class=""dropdown-toggle glyphicon glyphicon-list"" data-toggle=""dropdown"">Criar |</a>
        <ul class=""dropdown-menu"">
            <li>
                <a href=""#"" id=""BlocoCriarFormulario"" class=""btn-warning glyphicon glyphicon-align-left""> Formulários</a>
            </li>

            <li>
                <a href=""#"" id=""BlocoCriarCampo"" class=""btn-warning glyphicon glyphicon-align-left"">Campos para formul");
            WriteLiteral(@"ários</a>
            </li>

            <li>
                <a href=""#"" id=""BlocoCriarTexto"" class=""btn-warning glyphicon glyphicon-text-width"">Textos</a>
            </li>

            <li>
                <a href=""#"" id=""BlocoCriarVideo"" class=""btn btn-warning glyphicon glyphicon-facetime-video"">Videos</a>
            </li>

            <li>
                <a href=""#"" id=""BlocoCriarCarouselImg"" class=""btn btn-warning glyphicon glyphicon-sound-dolby"">Carrosseis</a>
            </li>

            <li>
                <a href=""#"" id=""BlocoCriarCarouselPagina"" class=""btn btn-warning glyphicon glyphicon-file"">Carrosseis de pagina</a>
            </li>
        </ul>
    </li>
    
    <li class=""dropdown"">
        <a href=""#"" class=""dropdown-toggle glyphicon glyphicon-list"" data-toggle=""dropdown"">Criar ||</a>
        <ul class=""dropdown-menu"">

            <li class=""BlocoCriar"">
                <a href=""#"" id=""BlocoCriarImagem"" class=""btn btn-warning glyphicon glyphicon-picture"">Imag");
            WriteLiteral("ens</a>\r\n            </li>\r\n\r\n            <li>\r\n                <a href=\"#\" id=\"BlocoCriarLink\" class=\"btn btn-warning glyphicon glyphicon-hand-up\">Links</a>\r\n            </li>\r\n\r\n");
            EndContext();
            BeginContext(2410, 2241, true);
            WriteLiteral(@"
            <li>
                <a href=""#"" id=""EscolherMusica"" class=""btn btn-warning glyphicon glyphicon-music"">Musica</a>
            </li>

            <li>
                <a href=""#"" id=""CreatePath"" class=""btn btn-warning glyphicon glyphicon-folder-open"">Pasta de imagens</a>
            </li>
            
            
        </ul>
    </li>

    <li class=""dropdown"">
        <a href=""#"" class=""dropdown-toggle glyphicon glyphicon-list"" data-toggle=""dropdown"">Criar |||</a>
        <ul class=""dropdown-menu"">

            <li>
                <a href=""#"" id=""BlocoCriarCor"" class=""btn btn-warning CoresBack glyphicon glyphicon-tint"">Cores para bloco</a>
            </li>
            <li>
                <a href=""#"" id=""BlocoCriarCorContainer"" class=""btn btn-warning glyphicon glyphicon-tint"">Cores para container</a>
            </li>
            <li>
                <a href=""#"" id=""BlocoCriarCorElemento"" class=""btn btn-warning glyphicon glyphicon-tint"">Cores para elemento</a>
      ");
            WriteLiteral(@"      </li>  


            <li>
                <a href=""#"" id=""BlocoCriarPaginaComLayout"" class=""btn btn-warning glyphicon glyphicon-file"">Novas paginas com Layout</a>
            </li>

            <li>
                <a href=""/Criar-Pagina/"" id=""BlocoCriarPagina"" class=""btn btn-warning glyphicon glyphicon-file"">Nova pagina</a>
            </li>

            <li>
                <a href=""/Criar-Site/"" id=""BlocoCriarSite"" class=""btn btn-warning glyphicon glyphicon-globe"">Novo site</a>
            </li>
        </ul>
    </li>

    
</ul>

<br /><br /><br />



<label>Informe id do elemento:</label>
<input type=""number"" id=""NumeroElementoEditar"" />
<a href=""#"" id=""BotaoEditarElemento"" class=""glyphicon glyphicon-edit""></a>

<div id=""conteudomodal"" style=""background-color: white; min-height:200px;"">
    <h4>Formulário</h4>
</div>

<div id=""conteudoImagem"" style=""background-color: greenyellow; min-height:200px;"">
    <h4>Imagem</h4>
</div>

<div id=""conteudoMusica"" style=""ba");
            WriteLiteral("ckground-color: yellow; min-height:200px;\">\r\n    <h4>Música</h4>\r\n</div>\r\n\r\n<div id=\"conteudoVideo\" style=\"background-color: cadetblue; min-height:200px;\">\r\n    <h4>Vídeo</h4>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
#pragma checksum "C:\rede-social\CMS\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "171d44e68e365a58b89894069272cbccde3dd844"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\rede-social\CMS\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"171d44e68e365a58b89894069272cbccde3dd844", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0389c18537be78d994187c367b0e0aa311ab30d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<business.business.Pagina>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagem/story.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 75%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(130, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(165, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\rede-social\CMS\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
     List<business.business.Group.Story> stories = ViewBag.stories;

#line default
#line hidden
            BeginContext(324, 647, true);
            WriteLiteral(@"
<style>
    #esquerda {
        left: 1%;
    }
    #direita {
        right: 1%;
    }
    
    #partilha {
        font-size: 18px;
        color: rgb(95, 56, 23);
        font-family: fantasy;
    }
    
    #inscrito {
        font-size: 14px;
        color: rgb(212, 150, 65);
        font-family: fantasy;
    }
    
    #compartilhamentos {
        font-size: 14px;
        color: rgb(212, 150, 65);
        font-family: fantasy;
    }

   .topo{
       display:flex;
       flex-direction: row-reverse;
       flex-wrap: wrap;
       justify-content: space-between;
   }

</style>

<input type=""hidden""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 971, "\"", 1002, 1);
#line 48 "C:\rede-social\CMS\Views\Home\Index.cshtml"
WriteAttributeValue("", 979, ViewBag.compartilhante, 979, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1003, 204, true);
            WriteLiteral(" id=\"compartilhante\" />\r\n\r\n<script type=\"text/javascript\">\r\n\r\n            function acessarStory(url)\r\n            {\r\n                window.location.href =  url;\r\n            }           \r\n\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(1208, 15, false);
#line 59 "C:\rede-social\CMS\Views\Home\Index.cshtml"
Write(ViewBag.message);

#line default
#line hidden
            EndContext();
            BeginContext(1223, 573, true);
            WriteLiteral(@"

<center>
    <div class=""form-group"">
                
            <input id=""livro"" name=""livro"" class=""form-control"" type=""url"" placeholder=""Domínio ou o livro"">
            <a href=""#"" id=""compartilhamentos"" >Compartilhamentos</a>
            </div>
            <div id=""listaUrls"" style=""position:absolute; display:none; z-index:2000;"" class=""jumbotron"">

            </div>
</center>

<div class=""topo"" style=""z-index: 2;"">
<button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
  Sumário
</button>
    
    ");
            EndContext();
            BeginContext(1797, 107, false);
#line 77 "C:\rede-social\CMS\Views\Home\Index.cshtml"
Write(Html.ActionLink("Compartilhe seu comentário", "Comentar", "Home", new {texto="..."}, new {id = "partilha"}));

#line default
#line hidden
            EndContext();
            BeginContext(1904, 35, true);
            WriteLiteral("\r\n    <h4 id=\"inscrito\">Inscritos: ");
            EndContext();
            BeginContext(1940, 13, false);
#line 78 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                            Write(ViewBag.users);

#line default
#line hidden
            EndContext();
            BeginContext(1953, 559, true);
            WriteLiteral(@"</h4>

        <center>            
        <input type=""text"" id=""NumeroPaginaAcesso"" style=""width:80%; margin-left: 60px;""
               placeholder=""N° do capítulo ou o nome""  />
            <a id=""acessoPaginaComInput""  class=""btn btn-primary glyphicon glyphicon-search"">
                Acessar
            </a>
            <div id=""listaUrlGrupo"" style=""position:absolute; display:none; z-index:2000;"" class=""jumbotron"">
            </div>
        </center>
        <center>            

            <label class=""form-control"" > capitulo ");
            EndContext();
            BeginContext(2513, 16, false);
#line 91 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                                              Write(ViewBag.capitulo);

#line default
#line hidden
            EndContext();
            BeginContext(2529, 467, true);
            WriteLiteral(@"</label>
        <input type=""number"" id=""NumeroVersoAcesso"" style=""width:80%; margin-left: 60px;""
               placeholder=""N° do verso"" min=""1""  />
            <a id=""acessoPaginaComVerso""  class=""btn btn-primary glyphicon glyphicon-search"">
                Acessar
            </a>
        </center>
    </div>
    <center>



    </center>

        <div class=""row"">
            <div class=""col-md-12"">
                <center>
                ");
            EndContext();
            BeginContext(2996, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "171d44e68e365a58b89894069272cbccde3dd8449059", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(3073, 741, true);
            WriteLiteral(@"

                </center>
            </div>        
        </div>


        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Sumário</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
         <table>
                    <thead>
                        <tr>
                            <th>
                                ");
            EndContext();
            BeginContext(3815, 27, false);
#line 129 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                           Write(Html.DisplayName("Stories"));

#line default
#line hidden
            EndContext();
            BeginContext(3842, 176, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n");
            EndContext();
#line 135 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                      

                        foreach (var item in stories)
                        {

#line default
#line hidden
            BeginContext(4126, 114, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    Story ");
            EndContext();
            BeginContext(4241, 9, false);
#line 141 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                                     Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(4250, 271, true);
            WriteLiteral(@"
                                </td>
                                <td>
                                    .......................................
                                </td>
                                <td>
                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4521, "\"", 4564, 3);
            WriteAttributeValue("", 4528, "/Renderizar/", 4528, 12, true);
#line 147 "C:\rede-social\CMS\Views\Home\Index.cshtml"
WriteAttributeValue("", 4540, item.PaginaPadraoLink, 4540, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 4562, "/1", 4562, 2, true);
            EndWriteAttribute();
            BeginContext(4565, 6, true);
            WriteLiteral(">Cap. ");
            EndContext();
            BeginContext(4572, 21, false);
#line 147 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                                                                                   Write(item.PaginaPadraoLink);

#line default
#line hidden
            EndContext();
            BeginContext(4593, 80, true);
            WriteLiteral("</a>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 150 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(4723, 167, true);
            WriteLiteral("                </table>\r\n      </div>\r\n      <div class=\"modal-footer\">\r\n        <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n");
            EndContext();
            BeginContext(4973, 62, true);
            WriteLiteral("      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n\r\n\r\n    \r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5053, 3097, true);
                WriteLiteral(@"

     <script type=""text/javascript"">

             function buscarLivro(url)
            {
                document.getElementById(""livro"").value = url;
                 $(""#listaUrls"").css(""display"", ""none"");
            }         

</script>
    
<script type=""text/javascript"">
        $(document).ready(function () {

            
            
            $(""#livro"").keyup(function(){   
         

                 $.ajax({
                    type: 'POST',
                    url: '/AjaxGet/BuscarLivros',
                    dataType: 'json',
                    data: { valor: $(this).val() },
                    success: function (data) {

                        if (data == null)
                            $(""#listaUrls"").css(""display"", ""none"");
                        else
                            $(""#listaUrls"").css(""display"", ""block"");
                        $(""#listaUrls"").empty();
                        $.each(data, function (i) {
                            ");
                WriteLiteral(@"
                            $(""#listaUrls"").append(""<p>"" +
                             ""<a href='#' onclick="" + ""\""buscarLivro('""+data[i].url+""');\"" >"" +
                                data[i].url +
                                ""</a></p> <br>"");
                                              
                        });
                    },
                    error: function (ex) {
                        alert('Falha ao buscar urls.' + ex);
                    }
                });

            });

             

        });
</script>
    
<script type=""text/javascript"">
        $(document).ready(function () {

            var compartilhante = $(""#compartilhante"").val();


            function BuscarStory(valorPaginaPadraoLink) {
        $.ajax({
            type: 'POST',
            url: '/AjaxGet/GetStory',
            dataType: 'json',
            data: { Indice: valorPaginaPadraoLink }
        })
            .done(function(response) {                

         ");
                WriteLiteral(@"       if(response[0] == ""Story"")
                window.location.href = ""/Renderizar/""   +  response[1] +  ""/1/1/"" + compartilhante;
                else if(response[0] == ""SubStory"")
                window.location.href = ""/SubStory/""     +  response[1] +  ""/1/1/1/"" + compartilhante;
                else if(response[0] == ""Grupo"")
                window.location.href = ""/Grupo/""        +  response[1] +  ""/1/1/1/1/"" + compartilhante;
                else if(response[0] == ""SubGrupo"")
                window.location.href = ""/SubGrupo/""     +  response[1] +  ""/1/1/1/1/1/"" + compartilhante;
                else if(response[0] == ""SubSubGrupo"")
                window.location.href = ""/SubSubGrupo/""  +  response[1] +  ""/1/1/1/1/1/1/"" + compartilhante;
            });
            return false;
    }
           
            function VerificarCompartilhamento(verso) {
        $.ajax({
            type: 'POST',
            url: '/AjaxGet/verificarCompartilhamento',
            dataType: 'json',
   ");
                WriteLiteral("         data: { Livro: \"");
                EndContext();
                BeginContext(8151, 13, false);
#line 255 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                       Write(ViewBag.livro);

#line default
#line hidden
                EndContext();
                BeginContext(8164, 13, true);
                WriteLiteral("\", Capitulo: ");
                EndContext();
                BeginContext(8178, 16, false);
#line 255 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                                                  Write(ViewBag.capitulo);

#line default
#line hidden
                EndContext();
                BeginContext(8194, 7264, true);
                WriteLiteral(@", Verso: verso   }
        })
            .done(function(response) {                

                if(response != """")
                window.location.href = response;
                else
                alert(""Esta pagina não existe"");

            });
            return false;
    }
             

            $(""#acessoPaginaComInput"").click(function(){                

                if($(""#NumeroPaginaAcesso"").val() != """")
                {
                    var num =  parseInt($(""#NumeroPaginaAcesso"").val());
                    BuscarStory(num - 1);
                }
                else
                alert(""Informe o numero do capitulo!!!"");

            });

            $(""#acessoPaginaComVerso"").click(function(){                

                if($(""#NumeroVersoAcesso"").val() != """")
                {
                    var num =  parseInt($(""#NumeroVersoAcesso"").val());
                    VerificarCompartilhamento(num);
                }
                el");
                WriteLiteral(@"se
                alert(""Informe o numero do verso!!!"");

            });

           

            $(""#NumeroPaginaAcesso"").keyup(function(){   
         

                var valor = parseInt( $(this).val());

               if (isNaN(valor))
                {

                      $.ajax({
                    type: 'POST',
                    url: '/AjaxGet/BuscarStories',
                    dataType: 'json',
                    data: { valor: $(this).val() },
                    success: function (data) {

                        if (data == null)
                            $(""#listaUrlGrupo"").css(""display"", ""none"");
                        else
                            $(""#listaUrlGrupo"").css(""display"", ""block"");
                        $(""#listaUrlGrupo"").empty();
                        $.each(data.story, function (i) {
                            var url = ""/Renderizar/""+data.story[i].paginaPadraoLink+""/1/1/""+compartilhante;
                            $(""#listaUrlG");
                WriteLiteral(@"rupo"").append(""<p>"" +
                             ""<a href='#' onclick="" + ""\""acessarStory('""+url+""');\"" >"" +
                                "" Capitulo "" +data.story[i].paginaPadraoLink+ "" - ""  + data.story[i].nome +
                                ""</a></p> <br>"");
                        });

                        $.each(data.substory, function (i) {
                            var url = data.substory[i].url+""/1/""+compartilhante;
                            $(""#listaUrlGrupo"").append(""<p>"" +
                             ""<a href='#' onclick="" + ""\""acessarStory('""+url+""');\"" >"" +
                                "" Capitulo "" +data.substory[i].capitulo+ "" - Sub-Story ""  + data.substory[i].nome +
                                ""</a></p> <br>"");
                        });

                        $.each(data.grupo, function (i) {
                            var url = data.grupo[i].url+""/1/""+compartilhante;
                            $(""#listaUrlGrupo"").append(""<p>"" +
                     ");
                WriteLiteral(@"        ""<a href='#' onclick="" + ""\""acessarStory('""+url+""');\"" >"" +
                                "" Capitulo "" +data.grupo[i].capitulo+ "" - Grupo ""  + data.grupo[i].nome +
                                ""</a></p> <br>"");
                        });
                        
                        $.each(data.subgrupo, function (i) {
                            var url = data.subgrupo[i].url+""/1/""+compartilhante;
                            $(""#listaUrlGrupo"").append(""<p>"" +
                             ""<a href='#' onclick="" + ""\""acessarStory('""+url+""');\"" >"" +
                                "" Capitulo "" +data.subgrupo[i].capitulo+ "" - Sub-Grupo ""  + data.subgrupo[i].nome +
                                ""</a></p> <br>"");
                        });

                        $.each(data.subsubgrupo, function (i) {
                             var url = data.subsubgrupo[i].url+""/1/""+compartilhante;
                            $(""#listaUrlGrupo"").append(""<p>"" +
                            ""<");
                WriteLiteral(@"a href='#' onclick="" + ""\""acessarStory('""+url+""');\"" >"" +
                                "" Capitulo "" +data.subsubgrupo[i].capitulo+ "" - Sub-Sub-Grupo ""  + data.subsubgrupo[i].nome +
                                ""</a></p> <br>"");
                        });
                        
                        $.each(data.camadaseis, function (i) {
                             var url = data.camadaseis[i].url+""/1/""+compartilhante;
                            $(""#listaUrlGrupo"").append(""<p>"" +
                            ""<a href='#' onclick="" + ""\""acessarStory('""+url+""');\"" >"" +
                                "" Capitulo "" +data.camadaseis[i].capitulo+ "" - Sub-Sub-Grupo ""  + data.camadaseis[i].nome +
                                ""</a></p> <br>"");
                        });
                      
                        $.each(data.camadasete, function (i) {
                             var url = data.camadasete[i].url+""/1/""+compartilhante;
                            $(""#listaUrlGrupo"").appe");
                WriteLiteral(@"nd(""<p>"" +
                            ""<a href='#' onclick="" + ""\""acessarStory('""+url+""');\"" >"" +
                                "" Capitulo "" +data.camadasete[i].capitulo+ "" - Sub-Sub-Grupo ""  + data.camadasete[i].nome +
                                ""</a></p> <br>"");
                        });
                       
                        $.each(data.camadaoito, function (i) {
                             var url = data.camadaoito[i].url+""/1/""+compartilhante;
                            $(""#listaUrlGrupo"").append(""<p>"" +
                            ""<a href='#' onclick="" + ""\""acessarStory('""+url+""');\"" >"" +
                                "" Capitulo "" +data.camadaoito[i].capitulo+ "" - Sub-Sub-Grupo ""  + data.camadaoito[i].nome +
                                ""</a></p> <br>"");
                        });
                        
                        $.each(data.camadanove, function (i) {
                             var url = data.camadanove[i].url+""/1/""+compartilhante;
           ");
                WriteLiteral(@"                 $(""#listaUrlGrupo"").append(""<p>"" +
                            ""<a href='#' onclick="" + ""\""acessarStory('""+url+""');\"" >"" +
                                "" Capitulo "" +data.camadanove[i].capitulo+ "" - Sub-Sub-Grupo ""  + data.camadanove[i].nome +
                                ""</a></p> <br>"");
                        });
                        
                        $.each(data.camadadez, function (i) {
                             var url = data.camadadez[i].url+""/1/""+compartilhante;
                            $(""#listaUrlGrupo"").append(""<p>"" +
                            ""<a href='#' onclick="" + ""\""acessarStory('""+url+""');\"" >"" +
                                "" Capitulo "" +data.camadadez[i].capitulo+ "" - Sub-Sub-Grupo ""  + data.camadadez[i].nome +
                                ""</a></p> <br>"");
                        });
                    },
                    error: function (ex) {
                        alert('Falha ao buscar urls.' + ex);
                  ");
                WriteLiteral("  }\r\n                });\r\n\r\n                }\r\n\r\n            });\r\n\r\n\r\n\r\n        });\r\n</script>\r\n");
                EndContext();
            }
            );
            BeginContext(15461, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<UserModel> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<UserModel> SignInManager { get; private set; }
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

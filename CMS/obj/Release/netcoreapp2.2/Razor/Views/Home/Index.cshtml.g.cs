#pragma checksum "C:\rede-social\CMS\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85a9a3e4bfdd3fec41828fae12222bc7d7d3f88a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85a9a3e4bfdd3fec41828fae12222bc7d7d3f88a", @"/Views/Home/Index.cshtml")]
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
            BeginContext(1003, 253, true);
            WriteLiteral(" id=\"compartilhante\" />\r\n<input type=\"hidden\" value=\"0\" id=\"inverter\" />\r\n\r\n<script type=\"text/javascript\">\r\n\r\n            function acessarStory(url)\r\n            {\r\n                window.location.href =  url;\r\n            }           \r\n\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(1257, 15, false);
#line 60 "C:\rede-social\CMS\Views\Home\Index.cshtml"
Write(ViewBag.message);

#line default
#line hidden
            EndContext();
            BeginContext(1272, 203, true);
            WriteLiteral("\r\n\r\n<center>\r\n    <div class=\"form-group\">\r\n                \r\n            <input id=\"livro\" name=\"livro\" class=\"form-control\" type=\"url\" placeholder=\"digite domínio ou o livro\">            \r\n            ");
            EndContext();
            BeginContext(1476, 102, false);
#line 66 "C:\rede-social\CMS\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Compartilhamentos", "Compartilhamento", "Home", null, new {id = "compartilhamentos"}));

#line default
#line hidden
            EndContext();
            BeginContext(1578, 332, true);
            WriteLiteral(@"
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
            BeginContext(1911, 107, false);
#line 78 "C:\rede-social\CMS\Views\Home\Index.cshtml"
Write(Html.ActionLink("Compartilhe seu comentário", "Comentar", "Home", new {texto="..."}, new {id = "partilha"}));

#line default
#line hidden
            EndContext();
            BeginContext(2018, 35, true);
            WriteLiteral("\r\n    <h4 id=\"inscrito\">Inscritos: ");
            EndContext();
            BeginContext(2054, 13, false);
#line 79 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                            Write(ViewBag.users);

#line default
#line hidden
            EndContext();
            BeginContext(2067, 590, true);
            WriteLiteral(@"</h4>

        <center>            
        <input type=""text"" id=""NumeroPaginaAcesso"" style=""width:80%; margin-left: 60px;""
               placeholder=""N° do capítulo ou o nome""  />
            <a id=""acessoPaginaComInput""  class=""btn btn-primary glyphicon glyphicon-search"">
                Acessar
            </a>
            <div id=""listaUrlGrupo"" style=""position:absolute; display:none; z-index:2000; height: 500px; overflow: auto;"" class=""jumbotron"">
            </div>
        </center>
        <center>            

            <label class=""form-control"" > capitulo ");
            EndContext();
            BeginContext(2658, 16, false);
#line 92 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                                              Write(ViewBag.capitulo);

#line default
#line hidden
            EndContext();
            BeginContext(2674, 467, true);
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
            BeginContext(3141, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "85a9a3e4bfdd3fec41828fae12222bc7d7d3f88a9496", async() => {
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
            BeginContext(3218, 741, true);
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
            BeginContext(3960, 27, false);
#line 130 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                           Write(Html.DisplayName("Stories"));

#line default
#line hidden
            EndContext();
            BeginContext(3987, 176, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n");
            EndContext();
#line 136 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                      

                        foreach (var item in stories)
                        {

#line default
#line hidden
            BeginContext(4271, 114, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    Story ");
            EndContext();
            BeginContext(4386, 9, false);
#line 142 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                                     Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(4395, 271, true);
            WriteLiteral(@"
                                </td>
                                <td>
                                    .......................................
                                </td>
                                <td>
                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4666, "\"", 4709, 3);
            WriteAttributeValue("", 4673, "/Renderizar/", 4673, 12, true);
#line 148 "C:\rede-social\CMS\Views\Home\Index.cshtml"
WriteAttributeValue("", 4685, item.PaginaPadraoLink, 4685, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 4707, "/1", 4707, 2, true);
            EndWriteAttribute();
            BeginContext(4710, 6, true);
            WriteLiteral(">Cap. ");
            EndContext();
            BeginContext(4717, 21, false);
#line 148 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                                                                                   Write(item.PaginaPadraoLink);

#line default
#line hidden
            EndContext();
            BeginContext(4738, 80, true);
            WriteLiteral("</a>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 151 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(4868, 167, true);
            WriteLiteral("                </table>\r\n      </div>\r\n      <div class=\"modal-footer\">\r\n        <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n");
            EndContext();
            BeginContext(5118, 62, true);
            WriteLiteral("      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n\r\n\r\n\r\n    \r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5198, 6382, true);
                WriteLiteral(@"

     <script type=""text/javascript"">

            function buscarGrupos(texto, inversao)
                {
                        $.ajax({
                        type: 'POST',
                        url: '/AjaxGet/BuscarStories',
                        dataType: 'json',
                        data: { valor: texto, valorOrdem : inversao },
                        success: function (data) {

                            if (data == null)
                                $(""#listaUrlGrupo"").css(""display"", ""none"");
                            else
                                $(""#listaUrlGrupo"").css(""display"", ""block"");
                            $(""#listaUrlGrupo"").empty();      

                            $(""#listaUrlGrupo"").append("" <p>"" +
                                ""<a href='#' onclick="" + ""\""buscarInverso();\"" class='glyphicon glyphicon-refresh' >""  +
                                    ""</a></p> <br>"");                                        

                         ");
                WriteLiteral(@"   $.each(data, function (i) {
                                var url = data[i].url+""/1/""+compartilhante;
                                var myArray = url.split(""/"");
                                var name = """";
                                if(myArray.length == 6) name = ""Story"";
                                if(myArray.length == 7) name = ""Sub-Story"";
                                if(myArray.length == 8) name = ""Grupo"";
                                if(myArray.length == 9) name = ""Sub-Grupo"";
                                if(myArray.length == 10) name = ""Sub-Sub-Grupo"";
                                if(myArray.length == 11) name = ""Camada nº 6"";
                                if(myArray.length == 12) name = ""Camada nº 7"";
                                if(myArray.length == 13) name = ""Camada nº 8"";
                                if(myArray.length == 14) name = ""Camada nº 9"";
                                if(myArray.length == 15) name = ""Camada nº 10"";
                     ");
                WriteLiteral(@"           
                                $(""#listaUrlGrupo"").append("" <p>"" +
                                ""<a href='#' onclick="" + ""\""acessarStory('""+url+""');\"" >"" +
                                    "" Capitulo "" +data[i].capitulo+ "" - "" + name + "" "" + data[i].nome +
                                    ""</a></p> <br>"");
                            });                        
                        
                        },
                        error: function (ex) {
                            alert('Falha ao buscar urls.' + ex);
                        }
                    });
                }

             function buscarLivro(url)
            {
                document.getElementById(""livro"").value = url;
                 $(""#listaUrls"").css(""display"", ""none"");
            }         
             
             function buscarInverso()
            {
                debugger;
                var texto =  $(""#NumeroPaginaAcesso"").val();
                var ordenar = par");
                WriteLiteral(@"seInt( $(""#inverter"").val());
                if(ordenar == 0)
                {
                    ordenar = 1;
                    $(""#inverter"").val(ordenar);
                    buscarGrupos(texto, ordenar);
                }
                else
                {
                    ordenar = 0;
                    $(""#inverter"").val(ordenar);
                    buscarGrupos(texto, ordenar);
                }
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
                  ");
                WriteLiteral(@"      else
                            $(""#listaUrls"").css(""display"", ""block"");
                        $(""#listaUrls"").empty();
                        $.each(data, function (i) {
                            
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
            type");
                WriteLiteral(@": 'POST',
            url: '/AjaxGet/GetStory',
            dataType: 'json',
            data: { Indice: valorPaginaPadraoLink }
        })
            .done(function(response) {                

                if(response[0] == ""Story"")
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
            return false;");
                WriteLiteral("\n    }\r\n           \r\n            function VerificarCompartilhamento(verso) {\r\n        $.ajax({\r\n            type: \'POST\',\r\n            url: \'/AjaxGet/verificarCompartilhamento\',\r\n            dataType: \'json\',\r\n            data: { Livro: \"");
                EndContext();
                BeginContext(11581, 13, false);
#line 322 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                       Write(ViewBag.livro);

#line default
#line hidden
                EndContext();
                BeginContext(11594, 13, true);
                WriteLiteral("\", Capitulo: ");
                EndContext();
                BeginContext(11608, 16, false);
#line 322 "C:\rede-social\CMS\Views\Home\Index.cshtml"
                                                  Write(ViewBag.capitulo);

#line default
#line hidden
                EndContext();
                BeginContext(11624, 1507, true);
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
  ");
                WriteLiteral(@"              else
                alert(""Informe o numero do verso!!!"");

            });
            
            $(""#NumeroPaginaAcesso"").keyup(function(){   
         

                var valor = parseInt( $(this).val());
                var ordenar = parseInt( $(""#inverter"").val());

               if (isNaN(valor))
                {
                     buscarGrupos($(this).val(), ordenar);
                }

            });



        });
</script>
");
                EndContext();
            }
            );
            BeginContext(13134, 6, true);
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

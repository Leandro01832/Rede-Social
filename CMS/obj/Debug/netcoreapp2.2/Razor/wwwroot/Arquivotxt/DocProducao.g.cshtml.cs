#pragma checksum "C:\Rede-Social-master\Rede-Social\CMS\wwwroot\Arquivotxt\DocProducao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c41018c2dce452b87a916b1d83d6c36d7dfb828"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.wwwroot_Arquivotxt_DocProducao), @"mvc.1.0.view", @"/wwwroot/Arquivotxt/DocProducao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/wwwroot/Arquivotxt/DocProducao.cshtml", typeof(AspNetCore.wwwroot_Arquivotxt_DocProducao))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c41018c2dce452b87a916b1d83d6c36d7dfb828", @"/wwwroot/Arquivotxt/DocProducao.cshtml")]
    public class wwwroot_Arquivotxt_DocProducao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 26749, true);
            WriteLiteral(@"#set($site = '')

<meta charset='UTF-8'>

 

    <div id='blocos$model.Div1.Container.Id' class='bloco' data-value='$model.Div1.Container.Id'>

        
            #foreach($bloco in $divs)

           <div id='Container${bloco.Container.Id}Pagina${model.Pagina.Id}' class='${bloco.Container.ClassesModificadoras}ContainerDiv' data-value='$bloco.Container.Id' >                
                #if ($model.Pagina.Id == 0 && $bloco.Container.Id != 0 && $model.Pagina.MostrarDados == 1)
                <center><p>Identificação do Container: $bloco.Container.Id</p></center> 
                #end


              #foreach($bl in $bloco.Container.Div)
            <div id='DIV${bl.Div.Id}Pagina${model.Pagina.Id}' class='${bl.Div.ClassesModificadoras}ClassDiv' data-value='$bl.Div.Id'>
                #if ($model.Pagina.Id == 0 && $bl.Div.Id != 0 && $model.Pagina.MostrarDados == 1)
                <center><p>Identificação do bloco: $bl.Div.Id</p></center> 
                #end

               
                #foreach($el");
            WriteLiteral(@"ement in $bl.Div.Elemento)

                #if ($element.Elemento.VerificarPagina == 0)
                             
                <div id='elemento${element.Elemento.Id}Pagina${model.Pagina.Id}' class='${element.Elemento.ClassesModificadoras}Elemento' data-value='$element.Elemento.Id'>
                        #if($model.Pagina.MostrarDados == 1)
                       <center><p>Identificação do elemento: $element.Elemento.Id</p></center> 
                        #end
                   


                        #if ($element.Elemento.Tipo == 'CarouselImg')
                            <div id='carouselsite$element.Elemento.Id' class='carousel' data-ride='carousel'>
                                <div class='carousel-inner' role='listbox'>
                                    #foreach($dependente in $element.Elemento.Dependentes)
                                    <div class='item'>
                                        <img class='img-responsive minhaimg' src='$site$dependente.ElementoDependente.Arqu");
            WriteLiteral(@"ivoImagem' alt='imagem' style='width:${dependente.ElementoDependente.Dependente.Width}%;' />
                                        <!-- <div class='carousel-caption'>
                                        </div>   -->
                                    </div>
                                    #end
                                </div>
                            </div>
                        #end

                        #if($element.Elemento.Tipo == 'CarouselPagina')
                            <div id='carouselsiteCarouselPagina$element.Elemento.Id' class='carousel' data-ride='carousel'>
                                <div class='carousel-inner' role='listbox'>
                                    #foreach($Page in $element.Elemento.Paginas)
                                    <div id='Page$Page.Pagina.Id' class='item'>
                                        #foreach($bl in $Page.Pagina.Div)
                                        <div id='BlocoCarouselPagina$bl.Div.Id' class='BlocoCarouselPagina ");
            WriteLiteral(@"$bl.Div.Divisao'>

                                            #foreach($el in $bl.Div.Elemento)

                                            <div id='ElementoCarouselPagina$el.Elemento.Id'>

                                                #if ($el.Elemento.Tipo == 'Video')

                                                <div id='VideoCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class=''>

                                                    <video style='width:100%; height:100%' controls>
                                                        <source src='$site$el.Elemento.ArquivoVideo' type='video/mp4' />
                                                    </video>

                                                </div>

                                                #end

                                                #if ($el.Elemento.Tipo == 'Texto')

                                                <div id='textoCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class=''>

          ");
            WriteLiteral(@"                                          <p>$el.Elemento.PalavrasTexto</p>
                                                </div>

                                                #end

                                                #if($el.Elemento.Tipo == 'Link')

                                                #if($element.Elemento.TextoLink != '#LinkPadrao')

                                                <a href='$element.Elemento.TextoLink'>

                                                 ${element.Elemento.Texto.PalavrasTexto}
                                
                                                <img class='img-responsive' src='$site$element.Elemento.Imagem.ArquivoImagem' alt='imagem' style='width:100%;' />
                               

                                                </a>  

                                                #else

                                                <a id='LinkPadrao' href='#'> ${element.Elemento.Texto.PalavrasTexto} </a>

                  ");
            WriteLiteral(@"                              #end

                                                #end

                                                #if ($el.Elemento.Tipo == 'Imagem')

                                                <div id='ImagemCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class=''>
                                                    <img class='img-responsive' src='$site$el.Elemento.ArquivoImagem' alt='imagem' style='width:${el.Elemento.Width}%;' />
                                                </div>

                                                #end

                                                #if($el.Elemento.Tipo == 'Formulario')

                                                <div id='FormCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class=''>

                                                    <form>
                                                        #foreach($el in $el.Elemento.Dependentes)

                                                        <label>");
            WriteLiteral(@"$el.ElementoDependente.Dependente.Nome</label>
                                                        <input class='CampoFormulario$el.Elemento.Id' id='Campo$el.ElementoDependente.Dependente.Id' name='Campo$el.ElementoDependente.Dependente.Id' type='$el.ElementoDependente.Dependente.TipoCampo' placeholder='$el.ElementoDependente.Dependente.Placeholder' value='$el.ElementoDependente.Dependente.ValorCampo' />
                                                        <br />

                                                        #end
                                                        <a href='#' id='SalvarDadosFormulario'>Salvar</a>
                                                    </form>

                                                </div>

                                                <script type='text/javascript'>

                                                    $(document).ready(function () {

                                                        $('#SalvarDadosFormulario').click(function");
            WriteLiteral(@" () {

                                                            var Arquivos = $('.CampoFormulario');
                                                            var formData = new FormData();

                                                            let token = $('[name=__RequestVerificationToken]').val();
                                                            let headers = {};
                                                            headers['RequestVerificationToken'] = token;

                                                            for (var i = 0; i !== Arquivos.length; i++) {
                                                                formData.append('valores', document.getElementsByClassName('CampoFormulario$el.Elemento.Id')[i].value);
                                                                formData.append('Formulario', $el.Elemento.Id);
                                                            }

                                                            jQuery.ajax({
  ");
            WriteLiteral(@"                                                              url: '/Formulario/SalvarDados',
                                                                data: formData,
                                                                processData: !1,
                                                                contentType: !1,
                                                                type: 'POST',
                                                                headers: headers,
                                                                success: function (data) {
                                                                    alert('dados salvos com sucesso!' + data);
                                                                }
                                                            });


                                                        });
                                                    });
                                                </script>
                    ");
            WriteLiteral(@"                            #end
                                            </div>
                                            #end
                                        </div>
                                        #end
                                    </div>
                                    #end
                                </div>
                            </div>
                        #end

                        #if($element.Elemento.Tipo == 'Formulario')
                            <form>
                                #foreach($el in $element.Elemento.Dependentes)

                                <label>$el.ElementoDependente.Dependente.Nome</label>
                                <input class='CampoFormulario$element.Elemento.Id' id='Campo$el.ElementoDependente.Dependente.Id' name='Campo$el.ElementoDependente.Dependente.Id' type='$el.ElementoDependente.Dependente.TipoCampo' placeholder='$el.ElementoDependente.Dependente.Placeholder' />
                                <br />

         ");
            WriteLiteral(@"                       #end
                                <a href='#' id='SalvarDadosFormulario'>Salvar</a>
                            </form>

                        <script type='text/javascript'>

                            $(document).ready(function () {

                                $('#SalvarDadosFormulario').click(function () {

                                    var Arquivos = $('.CampoFormulario');
                                    var formData = new FormData();

                                    let token = $('[name=__RequestVerificationToken]').val();
                                    let headers = {};
                                    headers['RequestVerificationToken'] = token;

                                    for (var i = 0; i !== Arquivos.length; i++) {
                                        formData.append('valores', document.getElementsByClassName('CampoFormulario$element.Elemento.Id')[i].value);
                                        formData.append('Formulario', $elem");
            WriteLiteral(@"ent.Elemento.Id);
                                    }

                                    jQuery.ajax({
                                        url: '/Formulario/SalvarDados',
                                        data: formData,
                                        processData: !1,
                                        contentType: !1,
                                        type: 'POST',
                                        headers: headers,
                                        success: function (data) {
                                            alert('dados salvos com sucesso!' + data);
                                        }
                                    });


                                });

                            });

                        </script>

                        #end

                        #if ($element.Elemento.Tipo == 'Imagem')
                        <img class='img-responsive' src='$site$element.Elemento.ArquivoImagem' alt='imagem' style='width:${el");
            WriteLiteral(@"ement.Elemento.WidthImagem}%;' />
                        #end

                        #if($element.Elemento.Tipo == 'LinkBody')

                            #if($element.Elemento.TextoLink != '#LinkPadrao')
                            <a href='$element.Elemento.TextoLink'>

                                ${element.Elemento.Texto.PalavrasTexto}
                                #if($element.Elemento.VerificarNuloImagem == 1)
                                <img class='img-responsive' src='$site$element.Elemento.Imagem.ArquivoImagem' alt='imagem' style='width:100%;' />
                               #end

                            </a>
                            #else

                            <a href='#' id='LinkPadrao'  > ${element.Elemento.Texto.PalavrasTexto} </a>
                            #end
                        
                        #end                        

                        #if ($element.Elemento.Tipo == 'Texto')
                            <p>$element.Elemento.PalavrasTexto</");
            WriteLiteral(@"p>
                        #end

                        #if ($element.Elemento.Tipo == 'Video')
                            <video style='width:100%; height:100%' controls>
                                <source src='$site$element.Elemento.ArquivoVideo' type='video/mp4' />
                            </video>
                        #end

                    

                </div>
                   
                #elseif($element.Elemento.PaginaEscolhida == $model.Pagina.Id)

                <div id='elemento${element.Elemento.Id}Pagina${model.Pagina.Id}' class='${element.Elemento.ClassesModificadoras}Elemento' data-value='$element.Elemento.Id'>
                        #if($model.Pagina.MostrarDados == 1)
                      <center><p>Identificação do elemento: $element.Elemento.Id</p></center> 
                        #end
                   


                        #if ($element.Elemento.Tipo == 'CarouselImg')
                            <div id='carouselsite$element.Elemento.Id' class='carousel");
            WriteLiteral(@"' data-ride='carousel'>
                                <div class='carousel-inner' role='listbox'>
                                    #foreach($dependente in $element.Elemento.Dependentes)
                                    <div class='item'>
                                        <img class='img-responsive minhaimg' src='$site$dependente.ElementoDependente.ArquivoImagem' alt='imagem' style='width:${dependente.ElementoDependente.Dependente.Width}%;' />
                                        <!-- <div class='carousel-caption'>
                                        </div>   -->
                                    </div>
                                    #end
                                </div>
                            </div>
                        #end

                        #if($element.Elemento.Tipo == 'CarouselPagina')
                            <div id='carouselsiteCarouselPagina$element.Elemento.Id' class='carousel' data-ride='carousel'>
                                <div class='carous");
            WriteLiteral(@"el-inner' role='listbox'>
                                    #foreach($Page in $element.Elemento.Paginas)
                                    <div id='Page$Page.Pagina.Id' class='item'>
                                        #foreach($bl in $Page.Pagina.Div)
                                        <div id='BlocoCarouselPagina$bl.Div.Id' class='BlocoCarouselPagina $bl.Div.Divisao'>

                                            #foreach($el in $bl.Div.Elemento)

                                            <div id='ElementoCarouselPagina$el.Elemento.Id'>

                                                #if ($el.Elemento.Tipo == 'Video')

                                                <div id='VideoCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class=''>

                                                    <video style='width:100%; height:100%' controls>
                                                        <source src='$site$el.Elemento.ArquivoVideo' type='video/mp4' />
                            ");
            WriteLiteral(@"                        </video>

                                                </div>

                                                #end

                                                #if ($el.Elemento.Tipo == 'Texto')

                                                <div id='textoCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class=''>

                                                    <p>$el.Elemento.PalavrasTexto</p>
                                                </div>

                                                #end

                                                #if($el.Elemento.Tipo == 'Link')

                                                #if($element.Elemento.TextoLink != '#LinkPadrao')
                                                <a href='$element.Elemento.TextoLink'>

                                                 ${element.Elemento.Texto.PalavrasTexto}
                                
                                                <img class='img-responsive' src=");
            WriteLiteral(@"'$site$element.Elemento.Imagem.ArquivoImagem' alt='imagem' style='width:100%;' />
                               

                                                </a>      
                                                #else
                                                <a href='#' id='LinkPadrao'> ${element.Elemento.Texto.PalavrasTexto} </a>
                                                #end                                       

                                                #end

                                                #if ($el.Elemento.Tipo == 'Imagem')

                                                <div id='ImagemCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class=''>
                                                    <img class='img-responsive' src='$site$el.Elemento.ArquivoImagem' alt='imagem' style='width:${el.Elemento.Width}%;' />
                                                </div>

                                                #end

                               ");
            WriteLiteral(@"                 #if($el.Elemento.Tipo == 'Formulario')

                                                <div id='FormCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class=''>

                                                    <form>
                                                        #foreach($el in $el.Elemento.Dependentes)

                                                        <label>$el.ElementoDependente.Dependente.Nome</label>
                                                        <input class='CampoFormulario$el.Elemento.Id' id='Campo$el.ElementoDependente.Dependente.Id' name='Campo$el.ElementoDependente.Dependente.Id' type='$el.ElementoDependente.Dependente.TipoCampo' placeholder='$el.ElementoDependente.Dependente.Placeholder' value='$el.ElementoDependente.Dependente.ValorCampo' />
                                                        <br />

                                                        #end
                                                        <a href='#' id='SalvarDa");
            WriteLiteral(@"dosFormulario'>Salvar</a>
                                                    </form>

                                                </div>

                                                <script type='text/javascript'>

                                                    $(document).ready(function () {

                                                        $('#SalvarDadosFormulario').click(function () {

                                                            var Arquivos = $('.CampoFormulario');
                                                            var formData = new FormData();

                                                            let token = $('[name=__RequestVerificationToken]').val();
                                                            let headers = {};
                                                            headers['RequestVerificationToken'] = token;

                                                            for (var i = 0; i !== Arquivos.length; i++) {
            ");
            WriteLiteral(@"                                                    formData.append('valores', document.getElementsByClassName('CampoFormulario$el.Elemento.Id')[i].value);
                                                                formData.append('Formulario', $el.Elemento.Id);
                                                            }

                                                            jQuery.ajax({
                                                                url: '/Formulario/SalvarDados',
                                                                data: formData,
                                                                processData: !1,
                                                                contentType: !1,
                                                                type: 'POST',
                                                                headers: headers,
                                                                success: function (data) {
                              ");
            WriteLiteral(@"                                      alert('dados salvos com sucesso!' + data);
                                                                }
                                                            });


                                                        });
                                                    });
                                                </script>
                                                #end
                                            </div>
                                            #end
                                        </div>
                                        #end
                                    </div>
                                    #end
                                </div>
                            </div>
                        #end

                        #if($element.Elemento.Tipo == 'Formulario')
                            <form>
                                #foreach($el in $element.Elemento.Dependentes)

                     ");
            WriteLiteral(@"           <label>$el.ElementoDependente.Dependente.Nome</label>
                                <input class='CampoFormulario$element.Elemento.Id' id='Campo$el.ElementoDependente.Dependente.Id' name='Campo$el.ElementoDependente.Dependente.Id' type='$el.ElementoDependente.Dependente.TipoCampo' placeholder='$el.ElementoDependente.Dependente.Placeholder' />
                                <br />

                                #end
                                <a href='#' id='SalvarDadosFormulario'>Salvar</a>
                            </form>

                        <script type='text/javascript'>

                            $(document).ready(function () {

                                $('#SalvarDadosFormulario').click(function () {

                                    var Arquivos = $('.CampoFormulario');
                                    var formData = new FormData();

                                    let token = $('[name=__RequestVerificationToken]').val();
                                   ");
            WriteLiteral(@" let headers = {};
                                    headers['RequestVerificationToken'] = token;

                                    for (var i = 0; i !== Arquivos.length; i++) {
                                        formData.append('valores', document.getElementsByClassName('CampoFormulario$element.Elemento.Id')[i].value);
                                        formData.append('Formulario', $element.Elemento.Id);
                                    }

                                    jQuery.ajax({
                                        url: '/Formulario/SalvarDados',
                                        data: formData,
                                        processData: !1,
                                        contentType: !1,
                                        type: 'POST',
                                        headers: headers,
                                        success: function (data) {
                                            alert('dados salvos com sucesso!' + data);
  ");
            WriteLiteral(@"                                      }
                                    });


                                });

                            });

                        </script>

                        #end

                        #if ($element.Elemento.Tipo == 'Imagem')
                        <img class='img-responsive' src='$site$element.Elemento.ArquivoImagem' alt='imagem' style='width:${element.Elemento.WidthImagem}%;' />
                        #end

                        #if($element.Elemento.Tipo == 'LinkBody')

                            #if($element.Elemento.TextoLink != '#LinkPadrao')
                            <a href='$element.Elemento.TextoLink'>

                                ${element.Elemento.Texto.PalavrasTexto}
                                #if($element.Elemento.VerificarNuloImagem == 1)
                                <img class='img-responsive' src='$site$element.Elemento.Imagem.ArquivoImagem' alt='imagem' style='width:100%;' />
                               #end

     ");
            WriteLiteral(@"                       </a>
                            #else
                            <a href='#' id='LinkPadrao'> ${element.Elemento.Texto.PalavrasTexto}</a>
                            #end
                        
                        #end                        

                        #if ($element.Elemento.Tipo == 'Texto')
                            <p>$element.Elemento.PalavrasTexto</p>
                        #end

                        #if ($element.Elemento.Tipo == 'Video')
                            <video style='width:100%; height:100%' controls>
                                <source src='$site$element.Elemento.ArquivoVideo' type='video/mp4' />
                            </video>
                        #end

                    

                </div>

                #end


                #end
            </div>
            #end

           </div>


            #end        
    
</div>    

<script type='text/javascript'>

        $(document).ready(function () {

            jQu");
            WriteLiteral("ery(function () {\n\n                $(\'.item:first-child\').addClass(\'active\').show();\n            });\n\n        });\n\n</script>\n");
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

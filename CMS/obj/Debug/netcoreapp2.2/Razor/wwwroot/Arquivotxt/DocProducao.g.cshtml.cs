#pragma checksum "C:\Users\simon\source\repos\C#\rede-social\CMS\wwwroot\Arquivotxt\DocProducao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0de567e43457e01b150eaf6c02399bf398499a17"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0de567e43457e01b150eaf6c02399bf398499a17", @"/wwwroot/Arquivotxt/DocProducao.cshtml")]
    public class wwwroot_Arquivotxt_DocProducao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 34500, true);
            WriteLiteral(@"#set($site = '')

<div id='conteudo$model.Pagina.Id' class='Conteudo'>

    <div id='blocos$model.Div4.Div.Id' class='bloco' data-value='$model.Div4.Div.Id'>

        #foreach($nunber in $model.Rows)



        #set ($condicao = 0)
        #set ($espacamento = 0)
        <div class='row linha' id='line$nunber'>


            #foreach($bloco in $divs)

            #if ($bloco.Div.Divisao == 'col-md-12' && $bloco.Div.Desenhado == 0 || $bloco.Div.Divisao == 'col-sm-12' && $bloco.Div.Desenhado == 0)
            #set($espacamento = $espacamento + 12)
            #end

            #if ($bloco.Div.Divisao == 'col-md-6' && $bloco.Div.Desenhado == 0 || $bloco.Div.Divisao == 'col-sm-6' && $bloco.Div.Desenhado == 0)
            #set($espacamento = $espacamento + 6)
            #end

            #if ($bloco.Div.Divisao == 'col-md-4' && $bloco.Div.Desenhado == 0 || $bloco.Div.Divisao == 'col-sm-4' && $bloco.Div.Desenhado == 0)
            #set($espacamento = $espacamento + 4)
            #end
");
            WriteLiteral(@"
            #if ($bloco.Div.Divisao == 'col-md-3' && $bloco.Div.Desenhado == 0 || $bloco.Div.Divisao == 'col-sm-3' && $bloco.Div.Desenhado == 0)
            #set($espacamento = $espacamento + 3)
            #end

            #if ($bloco.Div.Divisao == 'col-md-2' && $bloco.Div.Desenhado == 0 || $bloco.Div.Divisao == 'col-sm-2' && $bloco.Div.Desenhado == 0)
            #set($espacamento = $espacamento + 2)
            #end

            #if ($espacamento > 12)
            #set($condicao = 1)

            #end

            #if ($condicao == 0 && $bloco.Div.Desenhado == 0)

                #if ($model.Pagina.Id == 0 && $bloco.Div.Id != 0 && $model.Pagina.MostrarDados == 1)
                <p>Identificação do bloco: $bloco.Div.Id </p>
                #end
            <div id='DIV${bloco.Div.Id}Pagina${model.Pagina.Id}' class='ClassDiv $bloco.Div.Divisao grid-container' data-value='$bloco.Div.Id'>



                #foreach($element in $bloco.Div.Elemento)

                #if ($element.Ele");
            WriteLiteral(@"mento.VerificarPagina == 0)
                             
                <div id='elemento${element.Elemento.Id}Pagina${model.Pagina.Id}' class='Elemento grid-item' data-value='$element.Elemento.Id'>
                    <div id='element${element.Elemento.Id}Pagina${model.Pagina.Id}' class='Elemento$element.Elemento.Id grid-item' data-value='$element.Elemento.Id' data-id='$element.Elemento.Id'>

                        #if($model.Pagina.MostrarDados == 1)
                        <p>Identificação do elemento: $element.Elemento.Id</p>
                        #end

                        #if ($element.Elemento.Tipo == 'CarouselImg')
                            <div id='carouselsite$element.Elemento.Id' class='carousel' data-ride='carousel'>
                                <div class='carousel-inner' role='listbox'>
                                    #foreach($dependente in $element.Elemento.Dependentes)
                                    <div class='item'>
                                       ");
            WriteLiteral(@" <img class='img-responsive minhaimg' src='$site$dependente.ElementoDependente.ArquivoImagem' alt='imagem' style='width:${dependente.ElementoDependente.Dependente.Width}%;' />
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
         ");
            WriteLiteral(@"                               <div id='BlocoCarouselPagina$bl.Div.Id' class='BlocoCarouselPagina $bl.Div.Divisao'>

                                            #foreach($el in $bl.Div.Elemento)

                                            <div id='ElementoCarouselPagina$el.Elemento.Id'>

                                                #if ($el.Elemento.Tipo == 'Video')

                                                <div id='VideoCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class='grid-item'>

                                                    <video style='width:100%; height:100%' controls>
                                                        <source src='$site$el.Elemento.ArquivoVideo' type='video/mp4' />
                                                    </video>

                                                </div>

                                                #end

                                                #if ($el.Elemento.Tipo == 'Texto')

             ");
            WriteLiteral(@"                                   <div id='textoCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class='grid-item'>

                                                    <p>$el.Elemento.PalavrasTexto</p>
                                                </div>

                                                #end

                                                #if($el.Elemento.Tipo == 'Link')

                                                <a href='$element.Elemento.TextoLink'>

                                                 ${element.Elemento.Texto.PalavrasTexto}
                                
                                                <img class='img-responsive' src='$site$element.Elemento.Imagem.ArquivoImagem' alt='imagem' style='width:100%;' />
                               

                                                </a>                                             

                                                #end

                                          ");
            WriteLiteral(@"      #if ($el.Elemento.Tipo == 'Imagem')

                                                <div id='ImagemCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class='grid-item'>
                                                    <img class='img-responsive' src='$site$el.Elemento.ArquivoImagem' alt='imagem' style='width:${el.Elemento.Width}%;' />
                                                </div>

                                                #end

                                                #if($el.Elemento.Tipo == 'Formulario')

                                                <div id='FormCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class='grid-item'>

                                                    <form>
                                                        #foreach($el in $el.Elemento.Dependentes)

                                                        <label>$el.ElementoDependente.Dependente.Nome</label>
                                                   ");
            WriteLiteral(@"     <input class='CampoFormulario$el.Elemento.Id' id='Campo$el.ElementoDependente.Dependente.Id' name='Campo$el.ElementoDependente.Dependente.Id' type='$el.ElementoDependente.Dependente.TipoCampo' placeholder='$el.ElementoDependente.Dependente.Placeholder' value='$el.ElementoDependente.Dependente.ValorCampo' />
                                                        <br />

                                                        #end
                                                        <a href='#' id='SalvarDadosFormulario'>Salvar</a>
                                                    </form>

                                                </div>

                                                <script type='text/javascript'>

                                                    $(document).ready(function () {

                                                        $('#SalvarDadosFormulario').click(function () {

                                                            var Arquivos = $");
            WriteLiteral(@"('.CampoFormulario');
                                                            var formData = new FormData();

                                                            let token = $('[name=__RequestVerificationToken]').val();
                                                            let headers = {};
                                                            headers['RequestVerificationToken'] = token;

                                                            for (var i = 0; i !== Arquivos.length; i++) {
                                                                formData.append('valores', document.getElementsByClassName('CampoFormulario$el.Elemento.Id')[i].value);
                                                                formData.append('Formulario', $el.Elemento.Id);
                                                            }

                                                            jQuery.ajax({
                                                                url: '/F");
            WriteLiteral(@"ormulario/SalvarDados',
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
                     ");
            WriteLiteral(@"                       </div>
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

                                #end
       ");
            WriteLiteral(@"                         <a href='#' id='SalvarDadosFormulario'>Salvar</a>
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
                                        formData.append('Formulario', $element.Elemento.Id);");
            WriteLiteral(@"
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
                        <img class='img-responsive' src='$site$element.Elemento.ArquivoImagem' alt='imagem' style='wi");
            WriteLiteral(@"dth:${element.Elemento.Width}%;' />
                        #end

                        #if($element.Elemento.Tipo == 'LinkBody')

                        
                            <a href='$element.Elemento.TextoLink'>

                                ${element.Elemento.Texto.PalavrasTexto}
                                #if($element.Elemento.VerificarNuloImagem == 1)
                                <img class='img-responsive' src='$site$element.Elemento.Imagem.ArquivoImagem' alt='imagem' style='width:100%;' />
                               #end

                            </a>
                        
                        #end

                        #if($element.Elemento.Tipo == 'Table')
                            <table class='$element.Elemento.EstiloTabela'>

                                <tr>
                                    <th>
                                        <label>Nome</label>
                                    </th>
                                ");
            WriteLiteral(@"    <th>
                                        <label>Imagem</label>
                                    </th>
                                    <th></th>

                                </tr>

                                #foreach($prod in $element.Elemento.Dependentes)
                                <tr class='linhaProduto' id='Produto$prod.ElementoDependente.Dependente.Id' data-value='$prod.ElementoDependente.Dependente.Id'>
                                    <th>
                                        <label>$prod.ElementoDependente.Dependente.Nome</label>
                                    </th>
                                    <th>
                                        #set($imgIndice = 0)
                                        #foreach($img in $prod.ElementoDependente.Dependente.Dependentes)


                                        #if($imgIndice == 0)
                                        <img src='$site$img.ElementoDependente.Dependente.ArquivoImagem' width='100");
            WriteLiteral(@"' />
                                        #end

                                        #set($imgIndice = $imgIndice + 1)

                                        #end
                                    </th>


                                    <th>
                                        <div id='LinksTabela'>
                                            <a href='#' data-value='$prod.ElementoDependente.Dependente.Id' class='btn btn-danger botaoDetalhesProduto'>  Detalhes </a>
                                        </div>

                                        <div>
                                            <script type='text/javascript'>

                                                jQuery(function () {

                                                    if ($('.bloco')[0].baseURI.includes('https')) {
                                                        document.getElementById('LinksTabela').innerHTML += '<button href=# ' +
                                               ");
            WriteLiteral(@"             'data-value=$prod.ElementoDependente.Dependente.Id class=botaoAdicionarCarrinho ' +
                                                            '> Adicionar ao carrinho </button> ';
                                                    }

                                                });

                                            </script>

                                        </div>
                                    </th>
                                </tr>
                                #end
                            </table>
                        #end

                        #if ($element.Elemento.Tipo == 'Texto')
                            <p>$element.Elemento.PalavrasTexto</p>
                        #end

                        #if ($element.Elemento.Tipo == 'Video')
                            <video style='width:100%; height:100%' controls>
                                <source src='$site$element.Elemento.ArquivoVideo' type='video/mp4' />
         ");
            WriteLiteral(@"                   </video>
                        #end

                    </div>

                </div>
                   
                #elseif($element.Elemento.PaginaEscolhida == $model.Pagina.Id)

                <div id='elemento${element.Elemento.Id}Pagina${model.Pagina.Id}' class='Elemento grid-item' data-value='$element.Elemento.Id'>
                    <div id='element${element.Elemento.Id}Pagina${model.Pagina.Id}' class='Elemento$element.Elemento.Id grid-item' data-value='$element.Elemento.Id' data-id='$element.Elemento.Id'>

                        #if($model.Pagina.MostrarDados == 1)
                        <p>Identificação do elemento: $element.Elemento.Id</p>
                        #end

                        #if ($element.Elemento.Tipo == 'CarouselImg')
                            <div id='carouselsite$element.Elemento.Id' class='carousel' data-ride='carousel'>
                                <div class='carousel-inner' role='listbox'>
                             ");
            WriteLiteral(@"       #foreach($dependente in $element.Elemento.Dependentes)
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
                                <div class='carousel-inner' role='listbox'>
                                    #foreach($Page in $element.Elemento.Paginas)
       ");
            WriteLiteral(@"                             <div id='Page$Page.Pagina.Id' class='item'>
                                        #foreach($bl in $Page.Pagina.Div)
                                        <div id='BlocoCarouselPagina$bl.Div.Id' class='BlocoCarouselPagina $bl.Div.Divisao'>

                                            #foreach($el in $bl.Div.Elemento)

                                            <div id='ElementoCarouselPagina$el.Elemento.Id'>

                                                #if ($el.Elemento.Tipo == 'Video')

                                                <div id='VideoCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class='grid-item'>

                                                    <video style='width:100%; height:100%' controls>
                                                        <source src='$site$el.Elemento.ArquivoVideo' type='video/mp4' />
                                                    </video>

                                                </div>");
            WriteLiteral(@"

                                                #end

                                                #if ($el.Elemento.Tipo == 'Texto')

                                                <div id='textoCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class='grid-item'>

                                                    <p>$el.Elemento.PalavrasTexto</p>
                                                </div>

                                                #end

                                                #if($el.Elemento.Tipo == 'Link')

                                                <a href='$element.Elemento.TextoLink'>

                                                 ${element.Elemento.Texto.PalavrasTexto}
                                
                                                <img class='img-responsive' src='$site$element.Elemento.Imagem.ArquivoImagem' alt='imagem' style='width:100%;' />
                               

                                         ");
            WriteLiteral(@"       </a>                                             

                                                #end

                                                #if ($el.Elemento.Tipo == 'Imagem')

                                                <div id='ImagemCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class='grid-item'>
                                                    <img class='img-responsive' src='$site$el.Elemento.ArquivoImagem' alt='imagem' style='width:${el.Elemento.Width}%;' />
                                                </div>

                                                #end

                                                #if($el.Elemento.Tipo == 'Formulario')

                                                <div id='FormCarouselPagina${el.Elemento.Id}Pagina${model.Pagina.Id}' class='grid-item'>

                                                    <form>
                                                        #foreach($el in $el.Elemento.Dependentes)

    ");
            WriteLiteral(@"                                                    <label>$el.ElementoDependente.Dependente.Nome</label>
                                                        <input class='CampoFormulario$el.Elemento.Id' id='Campo$el.ElementoDependente.Dependente.Id' name='Campo$el.ElementoDependente.Dependente.Id' type='$el.ElementoDependente.Dependente.TipoCampo' placeholder='$el.ElementoDependente.Dependente.Placeholder' value='$el.ElementoDependente.Dependente.ValorCampo' />
                                                        <br />

                                                        #end
                                                        <a href='#' id='SalvarDadosFormulario'>Salvar</a>
                                                    </form>

                                                </div>

                                                <script type='text/javascript'>

                                                    $(document).ready(function () {

                         ");
            WriteLiteral(@"                               $('#SalvarDadosFormulario').click(function () {

                                                            var Arquivos = $('.CampoFormulario');
                                                            var formData = new FormData();

                                                            let token = $('[name=__RequestVerificationToken]').val();
                                                            let headers = {};
                                                            headers['RequestVerificationToken'] = token;

                                                            for (var i = 0; i !== Arquivos.length; i++) {
                                                                formData.append('valores', document.getElementsByClassName('CampoFormulario$el.Elemento.Id')[i].value);
                                                                formData.append('Formulario', $el.Elemento.Id);
                                                      ");
            WriteLiteral(@"      }

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
                                 ");
            WriteLiteral(@"                   });
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

                                <label>$el.ElementoDependente.Dependente.Nome</label>
                                <input class='CampoFormulario$element.Elemento.Id' id='Campo$el.ElementoDependente.Dependente.Id' name='Campo$el.ElementoDependente.Dependente.Id' type='$el.ElementoDependente.Dependente.Tipo");
            WriteLiteral(@"Campo' placeholder='$el.ElementoDependente.Dependente.Placeholder' />
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
                                    let headers = {};
                                    headers['RequestVerificationToken'] = token;

                                    for (var i = 0; i !== Arquivos.length; i++) {
                                        formData.append('valores', document.getEleme");
            WriteLiteral(@"ntsByClassName('CampoFormulario$element.Elemento.Id')[i].value);
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
                                        }
                                    });


                                });

                            });

                        </script>

                        #end

                        #");
            WriteLiteral(@"if ($element.Elemento.Tipo == 'Imagem')
                        <img class='img-responsive' src='$site$element.Elemento.ArquivoImagem' alt='imagem' style='width:${element.Elemento.Width}%;' />
                        #end

                        #if($element.Elemento.Tipo == 'LinkBody')

                        
                            <a href='$element.Elemento.TextoLink'>

                                ${element.Elemento.Texto.PalavrasTexto}
                                #if($element.Elemento.VerificarNuloImagem == 1)
                                <img class='img-responsive' src='$site$element.Elemento.Imagem.ArquivoImagem' alt='imagem' style='width:100%;' />
                               #end

                            </a>
                        
                        #end

                        #if($element.Elemento.Tipo == 'Table')
                            <table class='$element.Elemento.EstiloTabela'>

                                <tr>
                    ");
            WriteLiteral(@"                <th>
                                        <label>Nome</label>
                                    </th>
                                    <th>
                                        <label>Imagem</label>
                                    </th>
                                    <th></th>

                                </tr>

                                #foreach($prod in $element.Elemento.Dependentes)
                                <tr class='linhaProduto' id='Produto$prod.ElementoDependente.Dependente.Id' data-value='$prod.ElementoDependente.Dependente.Id'>
                                    <th>
                                        <label>$prod.ElementoDependente.Dependente.Nome</label>
                                    </th>
                                    <th>
                                        #set($imgIndice = 0)
                                        #foreach($img in $prod.ElementoDependente.Dependente.Dependentes)


                   ");
            WriteLiteral(@"                     #if($imgIndice == 0)
                                        <img src='$site$img.ElementoDependente.Dependente.ArquivoImagem' width='100' />
                                        #end

                                        #set($imgIndice = $imgIndice + 1)

                                        #end
                                    </th>


                                    <th>
                                        <div id='LinksTabela'>
                                            <a href='#' data-value='$prod.ElementoDependente.Dependente.Id' class='btn btn-danger botaoDetalhesProduto'>  Detalhes </a>
                                        </div>

                                        <div>
                                            <script type='text/javascript'>

                                                jQuery(function () {

                                                    if ($('.bloco')[0].baseURI.includes('https')) {
                  ");
            WriteLiteral(@"                                      document.getElementById('LinksTabela').innerHTML += '<button href=# ' +
                                                            'data-value=$prod.ElementoDependente.Dependente.Id class=botaoAdicionarCarrinho ' +
                                                            '> Adicionar ao carrinho </button> ';
                                                    }

                                                });

                                            </script>

                                        </div>
                                    </th>
                                </tr>
                                #end
                            </table>
                        #end

                        #if ($element.Elemento.Tipo == 'Texto')
                            <p>$element.Elemento.PalavrasTexto</p>
                        #end

                        #if ($element.Elemento.Tipo == 'Video')
                            <vid");
            WriteLiteral(@"eo style='width:100%; height:100%' controls>
                                <source src='$site$element.Elemento.ArquivoVideo' type='video/mp4' />
                            </video>
                        #end

                    </div>

                </div>

                #end

                #end
            </div>
            <!--<br />-->
            #set ($bloco.Div.Desenhado = 1)
            #end
            #end
        </div>
        #end
        <br />
        <br />
    
</div>

    </div>

<script type='text/javascript'>

        $(document).ready(function () {

            jQuery(function () {

                $('.item:first-child').addClass('active').show();
            });

        });

</script>

#if($model.Pagina.Margem)



<style>

    #bordaDireita$model.Div6.Div.Id {
        display: block;
    }

    #bordaEsquerda$model.Div5.Div.Id {
        display: block;
    }

    #conteudo$model.Pagina.Id {
        width: 60%;
        mi");
            WriteLiteral(@"n-height: 1000px;
        height: auto;
        position: relative;
        margin: auto;
        margin-top: 0px;
        background-size: contain;
    }
</style>

#else

<style type='text/css'>


    h1 {
        text-align: center;
    }



    #menu a {
        display: inline-block;
    }

    #conteudo$model.Pagina.Id {
        width: 100%;
        min-height: 1000px;
        height: auto;
        position: relative;
        margin: auto;
        margin-top: 0px;
        background-size: contain;
    }

    #bordaDireita$model.Div6.Div.Id {
        display: none;
    }

    #bordaEsquerda$model.Div5.Div.Id {
        display: none;
    }
</style>

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

$(document).ready(function() {

    var id = $("#IdentificacaoPagina").val();
    var compartilhante = $("#compartilhante").val();
    var auto = parseInt( $("#auto").val());
    var valorAtual = parseInt( $("#ValorAtual").val());
    var valorQuant = parseInt($("#ValorQuant").val()) ;
    var valorProximo = parseInt($("#ValorProximo").val());
    var valorAnterior = parseInt($("#ValorAnterior").val());
    var valorPaginaPadraoLink = parseInt($("#ValorPaginaPadraoLink").val());
    var tempo = parseInt($("#Tempo").val());
    var valorStoryNome = $("#ValorStoryNome").val();
    var redirecionamento = "";
    var proximoCapitulo = valorPaginaPadraoLink + 1;

    setInterval(function() {           
        if(duracaoVideo != 0)
        {
            tempo = duracaoVideo * 1000;
        }              
        }, 1000);
    

    function redirecionar(pagina)
    {
        if(pagina >= 20){
            redirecionamento =  "/#redireciona-" + pagina;
        }
        else{
            redirecionamento =  "/#redireciona-1";        
        }

    }



    if (valorStoryNome != "Padrao")
        $("#NumeroPaginaAcesso2").attr('placeholder', 'Nº versiculo');




    $("#DivPagina" + valorAtual).addClass('minhaClasse3');



    $("#voltar").click(function() {
        redirecionar(valorAnterior);
        window.location.href = "/Renderizar/" + valorPaginaPadraoLink + "/" + valorAnterior + "/" + auto + "/" + compartilhante + redirecionamento;
    });

    $("#avancar").click(function() {
        redirecionar(valorProximo);
        window.location.href = "/Renderizar/" + valorPaginaPadraoLink + "/" + valorProximo + "/" + auto + "/" + compartilhante + redirecionamento;
    });

    var checkbox = document.querySelector("#automatico");
    function ativarCheckbox(el) {
        el.checked = true;
    }
    function desativarCheckbox(el) {
        el.checked = false;
    }

    if (valorAtual == 1) {
        ativarCheckbox(checkbox);
    }

    $("#automatico").change(function() {

        if (auto == 0) {          
            auto = 1;
            alert("As paginas serão mostradas automaticamente.");
            setTimeout(function() {
                $("#loading").show();
                
                if (valorAtual < valorQuant){
                    redirecionar(valorProximo);
                    window.location.href = "/Renderizar/" + valorPaginaPadraoLink + "/" + valorProximo + "/" + auto + "/" + compartilhante + redirecionamento;
                }
                else
                    window.location.href = "/Renderizar/" + valorPaginaPadraoLink + "/1" + "/" + auto + "/" + compartilhante;
            }, tempo);
        }
        else
           window.location.href = "/Renderizar/" + valorPaginaPadraoLink + "/" + valorAtual + "/" + 0 + "/" + compartilhante;
           
    });

       

    if (auto == 1) {
        
        ativarCheckbox(checkbox);
        setTimeout(function() {

            setTimeout(function() {
               
    
                if (auto == 1)
                    $("#loading").show();
                if (valorAtual < valorQuant && auto == 1)   {
                    redirecionar(valorProximo);
                    window.location.href = "/Renderizar/" + valorPaginaPadraoLink + "/" + valorProximo + "/" + auto + "/" + compartilhante + redirecionamento;            
                }           
                else if (auto == 1) {
    
                    if (valorStoryNome != "Padrao")
                    window.location.href = "/Renderizar/" + proximoCapitulo + "/1/" + auto + "/" + compartilhante;
                        //BuscarStory();
                    else
                        window.location.href = "/Renderizar/0/1/" + auto + "/" + compartilhante;
                }
            }, tempo);

        }, 3000);

    }
    else
        desativarCheckbox(checkbox);

    $(".carousel-control").click(function() { $("#loading").show(); });

    $("#NumeroPaginaAcesso2").change(function() {
        redirecionar(parseInt($(this).val()));
        document.getElementById("acessoPaginaComInput2").href = "/Renderizar/" + valorPaginaPadraoLink + "/";
        document.getElementById("acessoPaginaComInput2").href += $(this).val() + "/" + auto + "/" + compartilhante + redirecionamento;
    });

    $("#LinkPadrao").click(function() {  
        
        window.location.href = "/Renderizar/" + valorAtual + "/1/" + auto + "/" + compartilhante;
    });

    

    $(".agrupamento").click(function () {

        $(".group").css("display", "block");
        $(".container1").css("display", "none");
        $(".DivPagina").css("display", "none");
    
    });

    $(".abrir").click(function () {
        
      if($("#PalavrasTexto").length)
      {
        $(".ProdutoContent").css("display", "block");
        $("#comentario")[0].innerHTML = "";
        $("#comentario").css("display", "none");
        $(".abrir").removeClass("btn-primary");
        $(".abrir").addClass("btn-warning");
      } 
      else
      {
          $(".ProdutoContent").css("display", "none");
          $("#comentario").css("display", "block");
          $("#comentario").load("/Comentar/" + id);
          $(".abrir").removeClass("btn-warning");
        $(".abrir").addClass("btn-primary");
      } 
    }); 
    
    
    

    
});

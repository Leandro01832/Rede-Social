$(document).ready(function() {

    var valorUser = $("#ValorUser").val();
    var valorAtual = parseInt( $("#ValorAtual").val());
    var valorQuant = parseInt($("#ValorQuant").val()) ;
    var valorProximo = parseInt($("#ValorProximo").val());
    var valorAnterior = parseInt($("#ValorAnterior").val());
    var valorPaginaPadraoLink = parseInt($("#ValorPaginaPadraoLink").val());
    var tempo = parseInt($("#Tempo").val());
    var valorStoryNome = $("#ValorStoryNome").val();

    var redirecionamento = "";

    function redirecionar(pagina)
    {
        if(pagina >= 20){
            redirecionamento =  "/#redireciona-" + pagina;
        }
        else{
            redirecionamento =  "/#redireciona-1";        
        }

    }


    var links = $(".LinksPagina");

    if (valorStoryNome != "Padrao")
        $("#NumeroPaginaAcesso2").attr('placeholder', 'Nº versiculo');




    $("#DivPagina" + valorAtual).addClass('minhaClasse3');



    $("#voltar").click(function() {
        redirecionar(valorAnterior);
        window.location.href = "/Renderizar/"+ valorUser +"/" + valorPaginaPadraoLink + "/" + valorAnterior + redirecionamento;
    });

    $("#avancar").click(function() {
        redirecionar(valorProximo);
        window.location.href = "/Renderizar/"+ valorUser +"/" + valorPaginaPadraoLink + "/" + valorProximo + redirecionamento;
    });

    var checkbox = document.querySelector("#automatico");
    function ativarCheckbox(el) {
        el.checked = true;
    }
    function desativarCheckbox(el) {
        el.checked = false;
    }

    if (valorAtual == 1) {

        $.cookie('automatico', '1');
        ativarCheckbox(checkbox);
    }

    $("#automatico").change(function() {

        if ($("#automatico").is(':checked') == true) {
            $.cookie('automatico', '1');
            alert("As paginas serão mostradas automaticamente.");
            setTimeout(function() {
                $("#loading").show();
                
                if (valorAtual < valorQuant){
                    redirecionar(valorProximo);
                    window.location.href = "/Renderizar/"+ valorUser +"/" + valorPaginaPadraoLink + "/" + valorProximo + redirecionamento;
                }
                else
                    window.location.href = "/Renderizar/"+ valorUser +"/" + valorPaginaPadraoLink + "/1";
            }, tempo);
        }
        else
            $.cookie('automatico', '0');
    });

    function BuscarStory() {
        $.ajax({
            type: 'POST',
            url: '/AjaxGet/GetStory',
            dataType: 'json',
            data: { Indice: valorPaginaPadraoLink, User: valorUser }
        })
            .done(function(response) {
                $.cookie('automatico', '1');

                if(response[0] == "Story")
                window.location.href = "/Renderizar/"+ valorUser +"/" + response[1] +  "/1";
                else if(response[0] == "SubStory")
                window.location.href = "/SubStory/"+ valorUser +"/" + response[1] +    "/1/1";
                else if(response[0] == "Grupo")
                window.location.href = "/Grupo/"+ valorUser +"/" + response[1] +       "/1/1/1";
                else if(response[0] == "SubGrupo")
                window.location.href = "/SubGrupo/"+ valorUser +"/" + response[1] +    "/1/1/1/1";
                else if(response[0] == "SubSubGrupo")
                window.location.href = "/SubSubGrupo/"+ valorUser +"/" + response[1] + "/1/1/1/1/1";
            });
    }

    function refreshData() 
             {
                $.ajax({
                    type: 'POST',
                    url: '/AjaxGet/refresh',
                    dataType: 'json',
                    data: { }
                    })
                    .done(function(response) {
                       
                    });
             }

    if ($.cookie('automatico') == '1') {
        ativarCheckbox(checkbox);
        setTimeout(function() {


            if ($.cookie('automatico') == '1')
                $("#loading").show();
            if (valorAtual < valorQuant && $.cookie('automatico') == '1')   {
                redirecionar(valorProximo);
                window.location.href = "/Renderizar/"+ valorUser +"/" + valorPaginaPadraoLink + "/" + valorProximo + redirecionamento;            
            }           
            else if ($.cookie('automatico') == '1') {

                if (valorStoryNome != "Padrao")
                    BuscarStory();
                else
                    window.location.href = "/Renderizar/"+ valorUser +"/0/1";
            }
        }, tempo);
    }
    else
        desativarCheckbox(checkbox);

    $(".carousel-control").click(function() { $("#loading").show(); });

    $("#NumeroPaginaAcesso2").change(function() {
        redirecionar(parseInt($(this).val()));
        document.getElementById("acessoPaginaComInput2").href = "/Renderizar/"+ valorUser +"/" + valorPaginaPadraoLink + "/";
        document.getElementById("acessoPaginaComInput2").href += $(this).val() + redirecionamento;
    });

    $("#LinkPadrao").click(function() {  
        window.location.href = "/Renderizar/"+ valorUser +"/" + valorAtual + "/1";
    });

    setTimeout(function () { refreshData(); }, 300000);

    $(".agrupamento").click(function () {

        $(".group").css("display", "block");
        $(".container1").css("display", "none");
        $(".DivPagina").css("display", "none");
    
    });

});
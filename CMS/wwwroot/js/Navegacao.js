$(document).ready(function() {

    var valorUser = $("#ValorUser").val();
    var valorAtual = parseInt( $("#ValorAtual").val());
    var valorQuant = parseInt($("#ValorQuant").val()) ;
    var valorProximo = parseInt($("#ValorProximo").val());
    var valorAnterior = parseInt($("#ValorAnterior").val());
    var valorPaginaPadraoLink = parseInt($("#ValorPaginaPadraoLink").val());
    var valorStoryNome = $("#ValorStoryNome").val();

    

    var links = $(".LinksPagina");

    if (valorStoryNome != "Padrao")
        $("#NumeroPaginaAcesso2").attr('placeholder', 'Nº versiculo');




    $("#DivPagina" + valorAtual).addClass('minhaClasse3');



    $("#voltar").click(function() {
        window.location.href = "/Renderizar/"+ valorUser +"/" + valorPaginaPadraoLink + "/" + valorAnterior;
    });

    $("#avancar").click(function() {
        window.location.href = "/Renderizar/"+ valorUser +"/" + valorPaginaPadraoLink + "/" + valorProximo;
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

    $("input").change(function() {

        if ($("#automatico").is(':checked') == true) {
            $.cookie('automatico', '1');
            alert("As paginas serão mostradas automaticamente.");
            setTimeout(function() {
                $("#loading").show();

                if (valorAtual < valorQuant)
                    window.location.href = "/Renderizar/"+ valorUser +"/" + valorPaginaPadraoLink + "/" + valorProximo;
                else
                    window.location.href = "/Renderizar/"+ valorUser +"/" + valorPaginaPadraoLink + "/1";
            }, 10000);
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
                window.location.href = "/Renderizar/"+ valorUser +"/" + response + "/1";
            });
    }

    if ($.cookie('automatico') == '1') {
        ativarCheckbox(checkbox);
        setTimeout(function() {


            if ($.cookie('automatico') == '1')
                $("#loading").show();
            if (valorAtual < valorQuant && $.cookie('automatico') == '1')
                window.location.href = "/Renderizar/"+ valorUser +"/" + valorPaginaPadraoLink + "/" + valorProximo;
            else if ($.cookie('automatico') == '1') {

                if (valorStoryNome != "Padrao")
                    BuscarStory();
                else
                    window.location.href = "/Renderizar/"+ valorUser +"/0/1";
            }
        }, 10000);
    }
    else
        desativarCheckbox(checkbox);



    $(".carousel-control").click(function() { $("#loading").show(); });



    $("#NumeroPaginaAcesso2").change(function() {

        document.getElementById("acessoPaginaComInput2").href = "/Renderizar/"+ valorUser +"/" + valorPaginaPadraoLink + "/";
        document.getElementById("acessoPaginaComInput2").href += $(this).val();
    });

    $("#LinkPadrao").click(function() {        

        window.location.href = "/Renderizar/"+ valorUser +"/" + valorAtual + "/1";
    });

    setTimeout(function() {
        if (valorStoryNome != "Padrao")
            window.location.href = "/Renderizar/"+ valorUser +"/" + valorPaginaPadraoLink + "/" + valorAtual;
        else
            window.location.href = "/Renderizar/"+ valorUser +"/0/" + valorAtual;

    }, 600000);

});
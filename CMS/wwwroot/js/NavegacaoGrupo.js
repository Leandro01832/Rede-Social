$(document).ready(function() {

    var indexSubStory = $("#indexsubstory").val();
    var indexGrupo = $("#indexgrupo").val();

    var compartilhante = $("#compartilhante").val();
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
        window.location.href = "/Grupo/" + valorPaginaPadraoLink + "/" + indexSubStory + "/" + indexGrupo + "/" + valorAnterior + "/" + compartilhante;
    });

    $("#avancar").click(function() {
        redirecionar(valorProximo);
        window.location.href = "/Grupo/" + valorPaginaPadraoLink + "/" + indexSubStory + "/" + indexGrupo + "/" + valorProximo + "/" + compartilhante;
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
                    window.location.href = "/Grupo/" + valorPaginaPadraoLink + "/" + indexSubStory + "/" + indexGrupo + "/" + valorProximo + "/" + compartilhante;
                }
                else
                    window.location.href = "/Grupo/" + valorPaginaPadraoLink + "/" + indexSubStory + "/" + indexGrupo  + "/1" + "/" + compartilhante;
            }, tempo);
        }
        else
            $.cookie('automatico', '0');
    });

    function BuscarStory() {
        $.ajax({
            type: 'POST',
            url: '/AjaxGet/GetGrupo',
            dataType: 'json',
            data: { Indice: valorPaginaPadraoLink, IndiceSubStory : indexSubStory, IndiceGrupo : indexGrupo }
        })
            .done(function(response) {
                $.cookie('automatico', '1');

                if(response[0] != 0)
                window.location.href = "/Grupo/" + response[0]  + "/" + response[1] + "/" + response[2]  + "/1" + "/" + compartilhante;
                else
                window.location.href = "/SubStory/" + valorPaginaPadraoLink + "/" + 1 + "/1" + "/" + compartilhante;
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
            if (valorAtual < valorQuant && $.cookie('automatico') == '1'){
                redirecionar(valorProximo);
                window.location.href = "/Grupo/" + valorPaginaPadraoLink  + "/" + indexSubStory +  "/" + indexGrupo  + "/" + valorProximo + "/" + compartilhante;
            }
            else if ($.cookie('automatico') == '1')             
             BuscarStory();          
            
        }, tempo);
    }
    else
        desativarCheckbox(checkbox);

    $(".carousel-control").click(function() { $("#loading").show(); });    

    setTimeout(function () { refreshData(); }, 300000);

    $(".agrupamento").click(function () {

        $(".group").css("display", "block");
        $(".container1").css("display", "none");
        $(".DivPagina").css("display", "none");
    
    });

});
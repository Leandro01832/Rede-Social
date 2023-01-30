$(document).ready(function() {

    var indexSubStory = $("#indexsubstory").val();
    var indexGrupo = $("#indexgrupo").val();
    var indexSubGrupo = $("#indexsubgrupo").val();
    var indexSubSubGrupo = $("#indexsubsubgrupo").val();

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
        window.location.href = "/SubSubGrupo/" + valorPaginaPadraoLink + "/" + indexSubStory + "/" + indexGrupo + "/" +
         indexSubGrupo + "/" + indexSubSubGrupo + "/" + valorAnterior + "/" + auto + "/" + compartilhante;
    });

    $("#avancar").click(function() {
        redirecionar(valorProximo);
        window.location.href = "/SubSubGrupo/" + valorPaginaPadraoLink + "/" + indexSubStory + "/" + indexGrupo + "/" +
         indexSubGrupo + "/" + indexSubSubGrupo + "/" + valorProximo + "/" + auto + "/" + compartilhante;
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
                    window.location.href = "/SubSubGrupo/" + valorPaginaPadraoLink + "/" + indexSubStory + "/" + indexGrupo +
                     "/" + indexSubGrupo + "/" + indexSubSubGrupo + "/" + valorProximo + "/" + auto + "/" + compartilhante;
                }
                else
                    window.location.href = "/SubSubGrupo/" + valorPaginaPadraoLink + "/" + indexSubStory + "/" + indexGrupo +
                     "/" + indexSubGrupo + "/" + indexSubSubGrupo + "/1" + "/" + auto + "/" + compartilhante;
            }, tempo);
        }
        else
        window.location.href = "/SubSubGrupo/" + valorPaginaPadraoLink + "/" + indexSubStory + "/" + indexGrupo +
        "/" + indexSubGrupo + "/" + indexSubSubGrupo + "/" + valorAtual + "/" + 0 + "/" + compartilhante;
    });

    function BuscarStory() {
        $.ajax({
            type: 'POST',
            url: '/AjaxGet/GetSubSubGrupo',
            dataType: 'json',
            data: { Indice: valorPaginaPadraoLink, IndiceSubStory : indexSubStory, IndiceGrupo : indexGrupo, IndiceSubGrupo : indexSubGrupo, IndiceSubSubGrupo : indexSubSubGrupo }
        })
            .done(function(response) {
                $.cookie('automatico', '1');

                if(response[0] != 0)
                window.location.href = "/SubSubGrupo/" + response[0]  + "/" + response[1] + "/" + response[2] + "/" + response[3] + "/" + response[4] + "/1" + "/" + auto + "/" + compartilhante;
                else
                window.location.href = "/SubGrupo/" + valorPaginaPadraoLink + "/" + 1 + "/" + 1 + "/" + 1 + "/1" + "/" + auto + "/" + compartilhante;
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

    if (auto == 1) {
        ativarCheckbox(checkbox);
        setTimeout(function() {

            if (auto == 1)
                $("#loading").show();
            if (valorAtual < valorQuant && auto == 1){
                redirecionar(valorProximo);
                window.location.href = "/SubSubGrupo/" + valorPaginaPadraoLink  + "/" + indexSubStory +  "/" + indexGrupo  +
                 "/" + indexSubGrupo + "/" + indexSubSubGrupo + "/" + valorProximo + "/" + auto + "/" + compartilhante;
            }
            else if (auto == 1)             
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
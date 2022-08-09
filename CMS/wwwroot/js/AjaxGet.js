var items = $(".imagem");
var numero = $("#IdentificaPagina").val();
var imgs_ = [['']];

var selects = $("select");

var elementoSelect = "";
for (var i = 0; i < selects.length; i++) {

    var ele_selecionado = selects[i].className;
    if (ele_selecionado.includes("Texto"))
        buscar("Texto");

    if (ele_selecionado.includes("Carrossel"))
        buscar("Carrossel");

    if (ele_selecionado.includes("Imagem"))
        buscar("Imagem");

    if (ele_selecionado.includes("Form"))
        buscar("Form");

    if (ele_selecionado.includes("linkBody"))
        buscar("linkBody");

    if (ele_selecionado.includes("linkMenu"))
        buscar("linkBody");

    if (ele_selecionado.includes("Video"))
        buscar("Video");

    if (ele_selecionado.includes("Table"))
        buscar("Table");

    if (ele_selecionado.includes("Produto"))
        buscar("Produto");

    if (ele_selecionado.includes("Campo"))
        buscar("Campo");

    if (ele_selecionado.includes("Elementos"))
        buscar("Elementos");  
}

function buscar(elemento) {
    $.ajax({
        type: 'POST',
        url: '/AjaxGet/Elementos',
        dataType: 'json',
        data: { Pagina: numero, Tipo: elemento },
        success: function (data) {

            $("." + elemento).empty();

            if ($("#selecionado" + elemento).val() === "") {
                $("." + elemento).append('<option value="">Escolher ' + elemento + '...</option>');
            }


            $.each(data, function (i) {
                

                if ($("#selecionado" + elemento).val() !== "" &&
                    parseInt($("#selecionado" + elemento).val()) === data[i]) {
                    $("." + elemento).append('<option value="'
                        + data[i].id + '" ' + '" selected =' + "selected" + '> ' + data[i].nome +
                        ' - Chave: ' + data[i].id
                        + '</option>');
                }
                else {
                    $("." + elemento).append('<option value="' + data[i].id + '" > ' + data[i].nome +
                        ' - Chave: ' + data[i].id 
                        + '</option>');
                }
            });
        },
        error: function (ex) {
            alert('Falha ao buscar elementos.' + ex);
        }
    });
}

items.change(function () {
    var x = items[0];
    var y = x.selectedOptions[0].className;
    y = y.replace("~", "../..");

    var visu = document.getElementsByClassName("VisualizarImagem");

    for (var i = 0; i < visu.length; i++) {
        document.getElementsByClassName("VisualizarImagem")[i].innerHTML
            = "<br /> <img src='" + y
            + "' style='max-width: 100%;' /> <br />";
    }

});



$("#PaginaId").val(numero);

$(".pastas").empty();
$(".pastas").append('<option value="">Escolher pasta para as imagens</option>');


$.ajax({
    type: 'POST',
    url: '/AjaxGet/GetPastas',
    dataType: 'json',
    data: { Pagina: $("#IdentificaSite").val() }
})
    .done(function (response) {

        $.each(response, function (i, response) {
            $(".pastas").append('<option  value="' +
                response.id + '">' + response.nome + ' - Chave: ' + response.id +'</option>');
        });

    });




$(".backgroundGradiente").click(function () {

    $.ajax({
        type: 'POST',
        url: '/AjaxGet/GetCores',
        dataType: 'json',
        data: { Background: $(this).val() },
        success: function (data) {
            $(".CoresBackground").empty();
            $.each(data, function (i, data) {                
                $(".CoresBackground").append('<option value="'
                    + data.id + '">'
                    + data.corBackground + ' - Chave: '+ data.id +'</option>');
            });
        },
        error: function (ex) {
            alert('Falha ao buscar cores.' + ex);
        }
    });
    return false;
});


$.ajax({
    type: 'POST',
    contentType: 'application/json',
    url: '/AjaxGet/GetStories2',
    data: { User : $("#IdentificacaoUser").val() },
     headers: headers
    }).done(function (data) {

            $("#StoryId").empty();
            $.each(data, function (i, data) {

                $("#StoryId").append('<option value="'
                    + data.id + '">'
                    + data.capituloComNome + ' - Chave: ' + data.id + '</option>');
            });
    });



$.ajax({
    type: 'POST',
    url: '/AjaxGet/GetPaginas',
    dataType: 'json',
    data: { Pagina: numero },
    success: function (data) {
        $(".pagina").empty();

        if ($("#selecionadoPagina").val() === "") {
            $(".pagina").append('<option value="">[Selecione  uma pagina..]</option>');
        }

        
        $.each(data, function (i, data) {

            if ($("#selecionadoPagina").val() !== "" &&
                parseInt($("#selecionadoPagina").val()) === data[i]) {
                $(".pagina").append('<option value="'
                    + data.id + '" ' + '" selected =' + "selected" + '>'
                    + data.titulo + ' - Chave: ' + data.id + '</option>');
            }
            else {
                $(".pagina").append('<option value="'
                    + data.id + '" ' +  ' >'
                    + data.titulo + ' - Chave: ' + data.id + '</option>');
            }

            
        });
    },
    error: function (ex) {
        alert('Falha ao buscar paginas.' + ex);
    }
});


$(".site").change(function () {

    $.ajax({
        type: 'POST',
        url: '/AjaxGet/GetPaginasDoSite',
        dataType: 'json',
        data: { Pedido: $(this).val() },
        success: function (data) {
            $(".pagina").empty();
            $(".pagina").append('<option value="">[Selecione  uma pagina..]</option>');
            $.each(data, function (i, data) {

                $(".pagina").append('<option value="'
                    + data.id + '">'
                    + data.titulo + ' - Chave: ' + data.id + '</option>');
            });
        },
        error: function (ex) {
            alert('Falha ao buscar paginas.' + ex);
        }
    });
    return false;
});


$(".pagina").change(function () {   

    $.ajax({
        type: 'POST',
        url: '/AjaxGet/GetDivs',
        dataType: 'json',
        data: { PaginaId: $(this).val() },
        success: function (data) {
            $(".div").empty();
            $(".div").append('<option value="">[Selecione  um bloco..]</option>');
            $.each(data, function (i, data) {                
                
                $(".div").append('<option value="'
                    + data.id + '">'
                    + data.nome + ' - Chave: ' + data.id + '</option>');
            });
        },
        error: function (ex) {
            alert('Falha ao buscar blocos.' + ex);
        }
    });
    return false;
});


$("select").change(function () {          

    if($(this).id == "StoryId")
    {
         $.ajax({
        type: 'POST',
        contentType: 'application/json',
        url: '/AjaxGet/GetSubStories',
        data: { StoryId : $(this).val() },
         headers: headers
        }).done(function (data) {

                $("#SubStoryId").empty();
                $("#SubStoryId").append('<option value="0">Sub-Story(Opcional)</option>');
                $.each(data, function (i, data) {

                    $("#SubStoryId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }

    if($(this).id == "SubStoryId")
    {
         $.ajax({
        type: 'POST',
        contentType: 'application/json',
        url: '/AjaxGet/GetGrupos',
        data: { SubStoryId : $(this).val() },
         headers: headers
        }).done(function (data) {

                $("#GrupoId").empty();
                $("#GrupoId").append('<option value="0">Grupo(Opcional)</option>');
                $.each(data, function (i, data) {

                    $("#GrupoId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }

    if($(this).id == "GrupoId")
    {
         $.ajax({
        type: 'POST',
        contentType: 'application/json',
        url: '/AjaxGet/GetSubGrupos',
        data: { GrupoId : $(this).val() },
         headers: headers
        }).done(function (data) {

                $("#SubGrupoId").empty();
                $("#SubGrupoId").append('<option value="0">Sub-Grupo(Opcional)</option>');
                $.each(data, function (i, data) {

                    $("#SubGrupoId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }

     if($(this).id == "SubGrupoId")
    {
         $.ajax({
        type: 'POST',
        contentType: 'application/json',
        url: '/AjaxGet/GetSubSubGrupos',
        data: { SubGrupoId : $(this).val() },
         headers: headers
        }).done(function (data) {

                $("#SubSubGrupoId").empty();
                $("#SubSubGrupoId").append('<option value="0">Sub-Sub-Grupo(Opcional)</option>');
                $.each(data, function (i, data) {

                    $("#SubSubGrupoId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }


});


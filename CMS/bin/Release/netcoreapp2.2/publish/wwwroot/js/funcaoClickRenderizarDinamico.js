// $(".GaleriaBackground").click(function () {
//     var numero = $("#IdentificaPagina").val();
//     $("#conteudomodal").load("/Ferramenta/ListaBackground/" + numero);
// });

$("#GaleriaBlocoFixo").click(function () {
    $("#FormTexto, #estrutura, #Permissao, #Galeria, #GaleriaBlocos").fadeOut("slow");
    $("#GaleriaBlocos").fadeIn("slow");
    $("#GaleriaBlocos").load("/Div/ListaFixo/");
});

$("#GaleriaBloco").click(function () {    
    $("#FormTexto, #estrutura, #Permissao, #Galeria, #GaleriaBlocos").fadeOut("slow");
    $("#GaleriaBlocos").fadeIn("slow");
    $("#GaleriaBlocos").load("/Div/Lista/");

});

$("#GaleriaConteiners").click(function () {    
    $("#FormTexto, #estrutura, #Permissao, #Galeria, #GaleriaBlocos").fadeOut("slow");
    $("#GaleriaBlocos").fadeIn("slow");
    $("#GaleriaBlocos").load("/Container/Index/");

});

$(".GaleriaLayout").click(function () {
    var numero = $("#IdentificaPagina").val();    
    $("#conteudomodal").load("/Pagina/GaleriaLayout/" + numero);
});

function ElementoGaleria(Elemento) {

    $("#FormTexto, #estrutura, #Permissao, #Galeria, #GaleriaBlocos").fadeOut("slow");
    $("#Galeria").fadeIn("slow");
    $("#Galeria").load("/Elemento/Lista/" + Elemento.id + "-" + numero);
}

$(".imagemBackPagina").click(function () {
    var id = $("#corpo")[0].data("value");
    $("#conteudomodal").load("/Elemento/EditDiv/" + id);
});

$("#CreatePath").click(function () {
    $("#conteudomodal").load("/Ferramenta/CreatePasta");
});

$("#EditarCores").click(function () {  
    var numero = $("#IdentificaPagina").val();
    $("#conteudomodal").load("/Ferramenta/ListaCores/" + numero);
});

   

$("#BlocoCriarCor").click(function () {
    var numero = $("#IdentificaPagina").val();
    $("#conteudomodal").load("/Ferramenta/CreateCor/" + numero);
});

$("#BlocoCriarCorContainer").click(function () {
    var numero = $("#IdentificaPagina").val();
    $("#conteudomodal").load("/Ferramenta/CreateCorContainer/" + numero);
});

$("#BlocoCriarCorElemento").click(function () {
    var numero = $("#IdentificaPagina").val();
    $("#conteudomodal").load("/Ferramenta/CreateCorElemento/" + numero);
});


$(".Salvar").click(function () {
    var valor = $(this).data("value").replace(/[^0-9]/g, '');
    $("#conteudomodal").load("/Pagina/Salvar/" + valor);
});


$("#EditToolsLink").click(function () {
    var id = $(this).data("value");
    $("#conteudomodal").load("/Elemento/Edit/" + id);
});

$("#EditToolsForm").click(function () {

    var id = $(this).data("value");

    $("#conteudomodal").load("/Elemento/Edit/" + id);
});

$("#EditToolsTable").click(function () {
    var id = $(this).data("value");
    $("#conteudomodal").load("/Elemento/Edit/" + id);
});

$("#EditToolsImagem").click(function () {
    var id = $(this).data("value");
    $("#conteudomodal").load("/Elemento/Edit/" + id);
});

$("#EditToolsVideo").click(function () {
    var id = $(this).data("value");
    $("#conteudomodal").load("/Elemento/Edit/" + id);
});

$("#EscolherMusica").click(function () {
    $("#conteudoMusica").load("/Elemento/Create/musica");
});

$("#btnConfig").click(function () {
    $("#FormTexto, #estrutura, #Permissao").fadeOut("slow");
    $("#estrutura").fadeIn("slow");
});

$("#btnPermissao").click(function () {
    $("#FormTexto, #estrutura, #Permissao").fadeOut("slow");
    $("#Permissao").fadeIn("slow");
    $("#Permissao").load("/Admin/EditPermissao?id=" + numero);

});

$("#modo").click(function () {
    if ($("#modo").is(':checked')) {
        $(".content").css("width", "380px");
        $(".content").css("margin", "auto");
    }
    else {
        $(".content").css("width", "66%");
    }

});

$(".Configuracao").click(function () {

    $("#conteudomodal").load("/Pagina/EditarPagina/" + numero);
    });

$("#Atualizar").click(function () {
    $(".content").load("/Pagina/GetView/" + numero);
});

// $("#SalvarBlocos").click(function () {

//     if (condicaoBloco) {
//         condicaoBloco = false;
//         AlterarPosicaoBloco();

//     }
// });

// $("#SalvarElementos").click(function () {

//     if (condicaoElemento) {
//         condicaoElemento = false;
//         AlterarPosicaoElemento();

//     }
// });

// $("#AlterarPosicao").click(function () {
//     location.reload();
// });

$("#Ocultar").click(function () {

    $("#Chat").css("display", "none");
    $(".content").removeClass('col-md-8').addClass('col-md-12');

});

$(".Ferramenta").click(function () {    
    
    $(".content").removeClass('col-md-12').addClass('col-md-8');
    $("#Chat").css("display", "block");
    $("#FormTexto").load("/Pagina/EmBranco/");
    $("#FormTexto, #estrutura, #Permissao, #Galeria, #GaleriaBlocos").fadeOut("slow");
    $("#estrutura").fadeIn("slow");
    
});



$("#BlocoCriarTexto").click(function () {
    var numero = $("#IdentificaPagina").val();
    $("#conteudomodal").load("/Elemento/Create/Texto/" + numero);
});

$("#BlocoCriarVideo").click(function () {
    var numero = $("#IdentificaPagina").val();
    $("#conteudoVideo").load("/Elemento/Create/Video/" + numero);
});

$("#BlocoCriarLink").click(function () {
    var numero = $("#IdentificaPagina").val();
    $("#conteudomodal").load("/Elemento/Create/LinkBody/" + numero);
});

$("#BlocoCriarImagem").click(function () {
    var numero = $("#IdentificaPagina").val();
    $("#conteudoImagem").load("/Elemento/Create/Imagem/" + numero);
});

$("#BlocoCriarCarouselImg").click(function () {
    var numero = $("#IdentificaPagina").val();
    $("#conteudomodal").load("/Elemento/Create/CarouselImg/" + numero);
});

$("#BlocoCriarCarouselPagina").click(function () {
    var numero = $("#IdentificaPagina").val();
    $("#conteudomodal").load("/Elemento/Create/CarouselPagina/" + numero);
});

$("#BlocoCriarDropdown").click(function () {
    var numero = $("#IdentificaPagina").val();
    $("#conteudomodal").load("/Elemento/Create/Dropdown/" + numero);
});

$("#BlocoCriarFormulario").click(function () {
    var numero = $("#IdentificaPagina").val();
    $("#conteudomodal").load("/Elemento/Create/Formulario/" + numero);
});

$("#BlocoCriarCampo").click(function () {
    var numero = $("#IdentificaPagina").val();
    $("#conteudomodal").load("/Elemento/Create/Campo/" + numero);
});

$("#BlocoCriarPaginaComLayout").click(function () {
    var numero = $("#IdentificaPagina").val();
    $("#conteudomodal").load("/Pagina/CreatePaginaComLayout/" + numero);
});

$("#CriaElemento").click(function () {
    $("#conteudomodal").load("/Elemento/RenderizarElemento");
});
if(! $("body")[0].baseURI.includes('/Editar/')){

        $.ajax({
            type: 'POST',
            dataType: 'json',
            url: '/AjaxGet/GetStories2',
            data: {},
            success: function (data) {
                $("#StoryId").empty();
                $.each(data, function (i, data) {
        
                    $("#StoryId").append('<option value="'
                        + data.id + '">'
                        + data.capituloComNome + ' - Chave: ' + data.id + '</option>');
                });
            },
            error: function (ex) {
                alert('Falha ao buscar blocos.' + ex);
            }     
            });
            
}

else{

    $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetSubStories',
        data: { StoryId : $("#StoryId").val() }
         
        }).done(function (data) {

            $("#SubStoryId").empty();
            $("#SubStoryId").append('<option value="0">Sub-Story(Opcional)</option>');
            $("#GrupoId").empty();
            $("#GrupoId").append('<option value="0">Grupo(Opcional)</option>');
            $("#SubGrupoId").empty();
            $("#SubGrupoId").append('<option value="0">Grupo(Opcional)</option>');
            $("#SubSubGrupoId").empty();
            $("#SubSubGrupoId").append('<option value="0">Sub-Sub-Grupo(Opcional)</option>');
            $("#CamadaSeisId").empty();
            $("#CamadaSeisId").append('<option value="0">Camada nº 6(Opcional)</option>');
            $("#CamadaSeteId").empty();
            $("#CamadaSeteId").append('<option value="0">Camada nº 7(Opcional)</option>');
            $("#CamadaOitoId").empty();
            $("#CamadaOitoId").append('<option value="0">Camada nº 8(Opcional)</option>');
            $("#CamadaNoveId").empty();
            $("#CamadaNoveId").append('<option value="0">Camada nº 9(Opcional)</option>');
            $("#CamadaDezId").empty();
            $("#CamadaDezId").append('<option value="0">Camada nº 10(Opcional)</option>');
                $.each(data, function (i, data) {

                    $("#SubStoryId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    

}



$("select").change(function () {          

    if($(this)[0].id == "StoryId" && ! $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') &&
    $(this)[0].id == "StoryId" && ! $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
        
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetSubStories',
        data: { StoryId : $(this).val() }
         
        }).done(function (data) {

                $("#SubStoryId").empty();
                $.each(data, function (i, data) {

                    $("#SubStoryId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }

    if($(this)[0].id == "SubStoryId" && ! $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') &&
    $(this)[0].id == "SubStoryId" && ! $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetGrupos',
        data: { SubStoryId : $(this).val() }
         
        }).done(function (data) {

                $("#GrupoId").empty();
                $.each(data, function (i, data) {

                    $("#GrupoId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }

    if($(this)[0].id == "GrupoId" && ! $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') &&
     $(this)[0].id == "GrupoId" && ! $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetSubGrupos',
        data: { GrupoId : $(this).val() }
         
        }).done(function (data) {

                $("#SubGrupoId").empty();
                $.each(data, function (i, data) {

                    $("#SubGrupoId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }

     if($(this)[0].id == "SubGrupoId" && ! $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') &&
      $(this)[0].id == "SubGrupoId" && ! $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetSubSubGrupos',
        data: { SubGrupoId : $(this).val() }
         
        }).done(function (data) {

                $("#SubSubGrupoId").empty();
                $.each(data, function (i, data) {

                    $("#SubSubGrupoId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }
     
    if($(this)[0].id == "SubSubGrupoId" && ! $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') &&
      $(this)[0].id == "SubSubGrupoId" && ! $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetCamadaSeis',
        data: { SubSubGrupoId : $(this).val() }
         
        }).done(function (data) {

                $("#CamadaSeisId").empty();
                $.each(data, function (i, data) {

                    $("#CamadaSeisId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }
   
    if($(this)[0].id == "CamadaSeisId" && ! $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') &&
      $(this)[0].id == "CamadaSeisId" && ! $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetCamadaSete',
        data: { CamadaSeisId : $(this).val() }
         
        }).done(function (data) {

                $("#CamadaSeteId").empty();
                $.each(data, function (i, data) {

                    $("#CamadaSeteId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }

    if($(this)[0].id == "CamadaSeteId" && ! $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') &&
      $(this)[0].id == "CamadaSeteId" && ! $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetCamadaOito',
        data: { CamadaSeteId : $(this).val() }
         
        }).done(function (data) {

                $("#CamadaOitoId").empty();
                $.each(data, function (i, data) {

                    $("#CamadaOitoId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }
   
    if($(this)[0].id == "CamadaOitoId" && ! $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') &&
      $(this)[0].id == "CamadaOitoId" && ! $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetCamadaNove',
        data: { CamadaOitoId : $(this).val() }
         
        }).done(function (data) {

                $("#CamadaNoveId").empty();
                $.each(data, function (i, data) {

                    $("#CamadaNoveId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }
    
    if($(this)[0].id == "CamadaNoveId" && ! $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') &&
      $(this)[0].id == "CamadaNoveId" && ! $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetCamadaDez',
        data: { CamadaNoveId : $(this).val() }
         
        }).done(function (data) {

                $("#CamadaDezId").empty();
                $.each(data, function (i, data) {

                    $("#CamadaDezId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }


 /* /////////////////////////////////////   outra URL ///////////////////////////////////////////////////////////// */

    

    if($(this)[0].id == "StoryId" && $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') ||
    $(this)[0].id == "StoryId" && $("#StoryId")[0].baseURI.includes('/Home/CreatePagina') ||
       $(this)[0].id == "StoryId" && $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
        

         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetSubStories',
        data: { StoryId : $(this).val() }
         
        }).done(function (data) {

                $("#SubStoryId").empty();
                $("#SubStoryId").append('<option value="0">Sub-Story(Opcional)</option>');
                $("#GrupoId").empty();
                $("#GrupoId").append('<option value="0">Grupo(Opcional)</option>');
                $("#SubGrupoId").empty();
                $("#SubGrupoId").append('<option value="0">Grupo(Opcional)</option>');
                $("#SubSubGrupoId").empty();
                $("#SubSubGrupoId").append('<option value="0">Sub-Sub-Grupo(Opcional)</option>');
                $("#CamadaSeisId").empty();
                $("#CamadaSeisId").append('<option value="0">Camada nº 6(Opcional)</option>');
                $("#CamadaSeteId").empty();
                $("#CamadaSeteId").append('<option value="0">Camada nº 7(Opcional)</option>');
                $("#CamadaOitoId").empty();
                $("#CamadaOitoId").append('<option value="0">Camada nº 8(Opcional)</option>');
                $("#CamadaNoveId").empty();
                $("#CamadaNoveId").append('<option value="0">Camada nº 9(Opcional)</option>');
                $("#CamadaDezId").empty();
                $("#CamadaDezId").append('<option value="0">Camada nº 10(Opcional)</option>');
                $.each(data, function (i, data) {

                    $("#SubStoryId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }

    if($(this)[0].id == "SubStoryId" && $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') ||
    $(this)[0].id == "SubStoryId" && $("#StoryId")[0].baseURI.includes('/Home/CreatePagina') ||
       $(this)[0].id == "SubStoryId" && $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetGrupos',
        data: { SubStoryId : $(this).val() }
         
        }).done(function (data) {

                $("#GrupoId").empty();
                $("#GrupoId").append('<option value="0">Grupo(Opcional)</option>');
                $("#SubGrupoId").empty();
                $("#SubGrupoId").append('<option value="0">Grupo(Opcional)</option>');
                $("#SubSubGrupoId").empty();
                $("#SubSubGrupoId").append('<option value="0">Sub-Sub-Grupo(Opcional)</option>');
                $("#CamadaSeisId").empty();
                $("#CamadaSeisId").append('<option value="0">Camada nº 6(Opcional)</option>');
                $("#CamadaSeteId").empty();
                $("#CamadaSeteId").append('<option value="0">Camada nº 7(Opcional)</option>');
                $("#CamadaOitoId").empty();
                $("#CamadaOitoId").append('<option value="0">Camada nº 8(Opcional)</option>');
                $("#CamadaNoveId").empty();
                $("#CamadaNoveId").append('<option value="0">Camada nº 9(Opcional)</option>');
                $("#CamadaDezId").empty();
                $("#CamadaDezId").append('<option value="0">Camada nº 10(Opcional)</option>');
                $.each(data, function (i, data) {

                    $("#GrupoId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }

    if($(this)[0].id == "GrupoId" && $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') ||
    $(this)[0].id == "GrupoId" && $("#StoryId")[0].baseURI.includes('/Home/CreatePagina') ||
       $(this)[0].id == "GrupoId" && $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetSubGrupos',
        data: { GrupoId : $(this).val() }
         
        }).done(function (data) {

                $("#SubGrupoId").empty();
                $("#SubGrupoId").append('<option value="0">Sub-Grupo(Opcional)</option>');
                $("#SubSubGrupoId").empty();
                $("#SubSubGrupoId").append('<option value="0">Sub-Sub-Grupo(Opcional)</option>');
                $("#CamadaSeisId").empty();
                $("#CamadaSeisId").append('<option value="0">Camada nº 6(Opcional)</option>');
                $("#CamadaSeteId").empty();
                $("#CamadaSeteId").append('<option value="0">Camada nº 7(Opcional)</option>');
                $("#CamadaOitoId").empty();
                $("#CamadaOitoId").append('<option value="0">Camada nº 8(Opcional)</option>');
                $("#CamadaNoveId").empty();
                $("#CamadaNoveId").append('<option value="0">Camada nº 9(Opcional)</option>');
                $("#CamadaDezId").empty();
                $("#CamadaDezId").append('<option value="0">Camada nº 10(Opcional)</option>');
                $.each(data, function (i, data) {

                    $("#SubGrupoId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }

     if($(this)[0].id == "SubGrupoId" && $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') ||
     $(this)[0].id == "SubGrupoId" && $("#StoryId")[0].baseURI.includes('/Home/CreatePagina') ||
        $(this)[0].id == "SubGrupoId" && $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetSubSubGrupos',
        data: { SubGrupoId : $(this).val() }
         
        }).done(function (data) {

                $("#SubSubGrupoId").empty();
                $("#SubSubGrupoId").append('<option value="0">Sub-Sub-Grupo(Opcional)</option>');
                $("#CamadaSeisId").empty();
                $("#CamadaSeisId").append('<option value="0">Camada nº 6(Opcional)</option>');
                $("#CamadaSeteId").empty();
                $("#CamadaSeteId").append('<option value="0">Camada nº 7(Opcional)</option>');
                $("#CamadaOitoId").empty();
                $("#CamadaOitoId").append('<option value="0">Camada nº 8(Opcional)</option>');
                $("#CamadaNoveId").empty();
                $("#CamadaNoveId").append('<option value="0">Camada nº 9(Opcional)</option>');
                $("#CamadaDezId").empty();
                $("#CamadaDezId").append('<option value="0">Camada nº 10(Opcional)</option>');
                $.each(data, function (i, data) {

                    $("#SubSubGrupoId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }
    
    if($(this)[0].id == "SubSubGrupoId" && $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') ||
     $(this)[0].id == "SubSubGrupoId" && $("#StoryId")[0].baseURI.includes('/Home/CreatePagina') ||
        $(this)[0].id == "SubSubGrupoId" && $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetCamadaSeis',
        data: { SubSubGrupoId : $(this).val() }
         
        }).done(function (data) {

                $("#CamadaSeisId").empty();
                $("#CamadaSeisId").append('<option value="0">Camada nº 6(Opcional)</option>');
                $("#CamadaSeteId").empty();
                $("#CamadaSeteId").append('<option value="0">Camada nº 7(Opcional)</option>');
                $("#CamadaOitoId").empty();
                $("#CamadaOitoId").append('<option value="0">Camada nº 8(Opcional)</option>');
                $("#CamadaNoveId").empty();
                $("#CamadaNoveId").append('<option value="0">Camada nº 9(Opcional)</option>');
                $("#CamadaDezId").empty();
                $("#CamadaDezId").append('<option value="0">Camada nº 10(Opcional)</option>');
                $.each(data, function (i, data) {

                    $("#CamadaSeisId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }
    
    if($(this)[0].id == "CamadaSeisId" && $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') ||
     $(this)[0].id == "CamadaSeisId" && $("#StoryId")[0].baseURI.includes('/Home/CreatePagina') ||
        $(this)[0].id == "CamadaSeisId" && $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetCamadaSete',
        data: { CamadaSeisId : $(this).val() }
         
        }).done(function (data) {

                $("#CamadaSeteId").empty();
                $("#CamadaSeteId").append('<option value="0">Camada nº 7(Opcional)</option>');
                $("#CamadaOitoId").empty();
                $("#CamadaOitoId").append('<option value="0">Camada nº 8(Opcional)</option>');
                $("#CamadaNoveId").empty();
                $("#CamadaNoveId").append('<option value="0">Camada nº 9(Opcional)</option>');
                $("#CamadaDezId").empty();
                $("#CamadaDezId").append('<option value="0">Camada nº 10(Opcional)</option>');
                $.each(data, function (i, data) {

                    $("#CamadaSeteId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }
   
    if($(this)[0].id == "CamadaSeteId" && $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') ||
     $(this)[0].id == "CamadaSeteId" && $("#StoryId")[0].baseURI.includes('/Home/CreatePagina') ||
        $(this)[0].id == "CamadaSeteId" && $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetCamadaOito',
        data: { CamadaSeteId : $(this).val() }
         
        }).done(function (data) {
            
                $("#CamadaOitoId").empty();
                $("#CamadaOitoId").append('<option value="0">Camada nº 8(Opcional)</option>');
                $("#CamadaNoveId").empty();
                $("#CamadaNoveId").append('<option value="0">Camada nº 9(Opcional)</option>');
                $("#CamadaDezId").empty();
                $("#CamadaDezId").append('<option value="0">Camada nº 10(Opcional)</option>');
                $.each(data, function (i, data) {

                    $("#CamadaOitoId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }
   
    if($(this)[0].id == "CamadaOitoId" && $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') ||
     $(this)[0].id == "CamadaOitoId" && $("#StoryId")[0].baseURI.includes('/Home/CreatePagina') ||
        $(this)[0].id == "CamadaOitoId" && $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetCamadaNove',
        data: { CamadaOitoId : $(this).val() }
         
        }).done(function (data) {

                $("#CamadaNoveId").empty();
                $("#CamadaNoveId").append('<option value="0">Camada nº 9(Opcional)</option>');
                $("#CamadaDezId").empty();
                $("#CamadaDezId").append('<option value="0">Camada nº 10(Opcional)</option>');
                $.each(data, function (i, data) {

                    $("#CamadaNoveId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }
    
    if($(this)[0].id == "CamadaNoveId" && $("#StoryId")[0].baseURI.includes('/Pedido/CreatePagina') ||
     $(this)[0].id == "CamadaNoveId" && $("#StoryId")[0].baseURI.includes('/Home/CreatePagina') ||
        $(this)[0].id == "CamadaNoveId" && $("#StoryId")[0].baseURI.includes('/Editar/'))
    {
         $.ajax({
        type: 'POST',
        dataType: 'json',
        url: '/AjaxGet/GetCamadaDez',
        data: { CamadaNoveId : $(this).val() }
         
        }).done(function (data) {
                $("#CamadaDezId").empty();
                $("#CamadaDezId").append('<option value="0">Camada nº 10(Opcional)</option>');
                $.each(data, function (i, data) {

                    $("#CamadaDezId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }


});





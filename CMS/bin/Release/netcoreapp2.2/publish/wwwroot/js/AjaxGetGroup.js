if(! $("body")[0].baseURI.includes('/Editar/')){

        $.ajax({
            type: 'POST',
            dataType: 'json',
            url: '/AjaxGet/GetStories2',
            data: { User : $("#IdentificacaoUser").val() },
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
                $.each(data, function (i, data) {

                    $("#SubSubGrupoId").append('<option value="'
                        + data.id + '">'
                        + data.nome + ' - Chave: ' + data.id + '</option>');
                });
        });
    return false;
    }


});





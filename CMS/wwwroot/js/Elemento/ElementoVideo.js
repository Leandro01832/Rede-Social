﻿

class ElementoVideo {

    Create() {
        let data = this.getData();
        this.postBack(data);
    }

    Update() {
        let data = this.getData();
        this.editBack(data);
    }

    getElementos() {

        return {
            Id: itemId,
            Quantidade: novaQuantidade
        };
    }

    getData() {

        var numero = $("#IdentificaPagina").val();

        return {
            Id: $("#Id").val(),
            Pagina_: numero,
            Nome: $("#Nome").val(),
            tipo: $("#TipoCampo").val(),
            Ordem: $("#Ordem").val(),
            TableId: $("#TableId").val(),
            Placeholder: $("#Placeholder").val(),
            TipoCampo: $("#TipoCampo").val(),
            ArquivoVideo: $("#ArquivoVideo").val()

         };
    }

    postElemento(data) {

        let token = $('[name=__RequestVerificationToken]').val();

        let headers = {};
        headers['RequestVerificationToken'] = token;

        $.ajax({
            url: '/Elemento/_Video',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
            headers: headers
        }).done(function (response) {

            var numero = $("#IdentificaPagina").val();
            $(".content").load("/Pagina/getview", { id: numero });
            alert("Elemento criado com sucesso!!! " + response);
        });
    }

    editElemento(data) {

        let token = $('[name=__RequestVerificationToken]').val();

        let headers = {};
        headers['RequestVerificationToken'] = token;

        $.ajax({
            url: '/Elemento/_Video',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
            headers: headers
        }).done(function (response) {

            var numero = $("#IdentificaPagina").val();
            $(".content").load("/Pagina/getview", { id: numero });
        });
    }
}

var ScriptElemento = new ElementoVideo();








class cor {

    Create() {
        let data = this.getData();
        this.postCor(data);
    }

    Update() {
        let data = this.getData();
        this.editCor(data);
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
            CorBackground: $("#CorBackground").val(),
            Position: $("#Position").val(),
            Transparencia: $("#Transparencia").val(),
            BackgroundDivId: $("#BackgroundDivId").val(),
            BackgroundContainerId: $("#BackgroundContainerId").val(),
            BackgroundElementoId: $("#BackgroundElementoId").val(),
            Grau: $("#Grau").val()
        };
    }

    postCor(data) {

        let token = $('[name=__RequestVerificationToken]').val();

        let headers = {};
        headers['RequestVerificationToken'] = token;

        $.ajax({
            url: '/Ferramenta/CreateCor',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
            headers: headers
        }).done(function (response) {

            var numero = $("#IdentificaPagina").val();
            $(".content").load("/Pagina/getview", { id: numero });
            alert("Cor criada com sucesso!!! " + response);
        });
    }

    editCor(data) {

        let token = $('[name=__RequestVerificationToken]').val();

        let headers = {};
        headers['RequestVerificationToken'] = token;

        $.ajax({
            url: '/Ferramenta/EditCor',
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

var ScriptCor = new cor();






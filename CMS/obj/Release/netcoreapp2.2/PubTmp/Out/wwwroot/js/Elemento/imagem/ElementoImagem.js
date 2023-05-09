

class ElementoImagem {

    Create() {
        let data = this.getData();
        this.postElemento(data);
    }

    Update() {
        let data = this.getData();
        this.editElemento(data);
    }

    getElementos() {

        return {
            Id: itemId,
            Quantidade: novaQuantidade
        };
    }

    getData() {

        var numero = $("#IdentificaPagina").val();

        var data = $("form#formulario").serializeArray();

        var formdata = {};
        $(data).each(function (index, obj) {
            formdata[obj.name] = obj.value;
        });

        formdata["Pagina_"] = numero;
        return formdata;
    }

    postElemento(data) {

        let token = $('[name=__RequestVerificationToken]').val();

        let headers = {};
        headers['RequestVerificationToken'] = token;

        $.ajax({
            url: '/Elemento/_Imagem',
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
            url: '/Elemento/_Imagem',
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

var ScriptElemento = new ElementoImagem();






class Container {
    Create() {
        let data = this.getData();
        this.postDiv(data);
    }

    Update() {
        let data = this.getData();
        this.editDiv(data);
        
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

    postDiv(data) {

        data["Id"] = 0;
        let token = $('[name=__RequestVerificationToken]').val();

        let headers = {};
        headers['RequestVerificationToken'] = token;

        $.ajax({
            url: '/Container/Create',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
            headers: headers
        }).done(function (response) {

            var numero = $("#IdentificaPagina").val();
            $(".content").load("/Pagina/getview", { id: numero });

            if(response == "")
            alert("cadastro não realizado");
            else
            alert("Container criado com sucesso!!! " + response);
            
        });
    }

    editDiv(data) {

        let token = $('[name=__RequestVerificationToken]').val();

        let headers = {};
        headers['RequestVerificationToken'] = token;

        $.ajax({
            url: '/Container/Editar',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
            headers: headers
        }).done(function (response) {

            var numero = $("#IdentificaPagina").val();
            $(".content").load("/Pagina/getview", { id: numero });

            if(response != "")
            alert(response);

        });
    }
}

var div = new Container();



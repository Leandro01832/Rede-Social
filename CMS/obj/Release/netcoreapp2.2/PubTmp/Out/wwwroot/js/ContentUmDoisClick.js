$(document).ready(function () {

    var numero = $("#IdentificaPagina").val();  
    
    el.click(function () {

        z = event.target;
        y = event.target;
        x = event.target.className;        

        if (timer) clearTimeout(timer);
        timer = setTimeout(function () {
            condicao = 1;
        },
            300);
    });

    el.dblclick(function () {
        z = event.target;
        y = event.target;
        x = event.target.className;

        clearTimeout(timer);
        condicao = 2;

    });

    el.mouseover(function () {

        z = event.target;
        y = event.target;
        x = event.target.className;

        if (x !== "" && condicao === 4) {
            y = z;
            
                       

            while (y !== null && x !== "content col-md-8") {

                if (y.className === "Elemento") {
                    var valor = y.id.replace("elemento", "").replace("Pagina" + numero, "");                   
                    $("#ElementoId").load("/Pagina/IdentificacaoElemento?elemento=" + valor);
                    break;
                }


                if (y.tagName === "DIV") {
                    var arr = x.split(" ");

                    for (var i = 0; i <= arr.length; i++) {
                        if (arr[i] === "ClassDiv") {                          
                            $("#Bloco").load("/Pagina/IdentificacaoBloco?div=" + valor);
                            $("#QuantidadeElementos").load("/Pagina/QuantidadeBloco?div=" + valor);
                        }
                    }
                    
                    break;
                }

                y = y.parentElement;
            }
        }
    });

    el.mouseout(function () {

        z = event.target;
        y = event.target;
        x = event.target.className;


        if (y.className === "content col-md-8" ||
            y.className === "bloco") {
            condicao = 4;
            
        }

    });

    setInterval(verifica, 1000);

    function EditModalBorda(idElemento) {
        
        $("#conteudomodal").load("/Elemento/Edit/" + idElemento);
        condicao = 0;
    }

    function verifica() {

        if (condicao !== 0) {

            if (condicao === 1) {                

                if (y.tagName === "DIV" && x.includes(substring)) {
                    var id = $("#" + y.id).data("value");
                    condicao = 0;
                    $("#conteudomodal").load("/Div/Edit/" + id);
                }
                else if (y.tagName === "DIV" && x.includes(substring2)) {
                    var id = $("#" + y.id).data("value");
                    condicao = 0;
                    $("#conteudomodal").load("/Container/Edit/" + id);    
                }
                else if (y.tagName === "DIV" && x.includes(substring3)) {
                    var id = $("#" + y.id).data("value");
                    condicao = 0;
                    $("#conteudomodal").load("/Container/Edit/" + id);    
                }
                else if (y.tagName === "DIV" && x.includes(substring4)) {
                    var id = $("#" + y.id).data("value");
                    condicao = 0;
                    $("#conteudomodal").load("/Elemento/Edit/" + id);    
                }                             

                if (x === ""
                    || x !== ""
                    || x === "Elemento"
                    || x === "carousel-inner"
                    || x === "img-responsive"
                    || x === "carousel-item ativo"
                    || x === "img-responsive minhaimg") {
                    
                    y = z;

                    while (y.className !== "content col-md-8") {

                        if (y.className === "content col-md-8") {
                            condicao = 0;
                            break;
                        }

                        if (y.className === "Elemento") {

                            let id = $("#" + y.id).data("value");
                            EditModalBorda(id);
                            condicao = 0;
                            break;
                        }   
                        y = y.parentElement;
                    }

                }

            }

            if (condicao === 2) {                
                                  
                    
                condicao = 0;
            }
        }
    }
});
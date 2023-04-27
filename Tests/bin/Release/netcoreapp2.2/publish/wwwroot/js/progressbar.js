var ss = 0;
var tempo = parseInt($("#Tempo").val());
var porcentagem = 0;
const progresso = document.querySelector(".progressbar div")

setInterval(function() {           
    if(duracaoVideo != 0)
    {
        tempo = duracaoVideo * 1000;
    }              
    }, 1000);



if (parseInt( $("#auto").val()) == 1) 
{

    setInterval(function() {           

     ss += 1000;
     porcentagem = parseInt((ss / tempo) * 100); 
     progresso.setAttribute("style", "width: " +porcentagem+ "%");               
     }, 1000);     

}
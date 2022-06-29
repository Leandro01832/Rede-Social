
var checkbox = document.querySelector("#automatico");
function ativarCheckbox(el) {
    el.checked = true;
}
function desativarCheckbox(el) {
    el.checked = false;
}

var chat = new signalR.HubConnectionBuilder().withUrl("/streamingHub").build();

$('#message').click(function () {

    desativarCheckbox(checkbox);
    $.cookie('automatico', '0');

    if ($('#displayname').val() === '')
    {
        $('#displayname').val(prompt('Digite seu nome:', ''));
    }
    

});

chat.on("ReceiveMessage", (user, message) => {
    const recuperaMensagem = user + ": " + message;
    const li = document.createElement("li");
    li.textContent = recuperaMensagem;
    document.getElementById("discussion").appendChild(li);
});

chat.start().catch(err => console.error(err.toString()));

$("#sendmessage").click(function () {

    const user = $('#displayname').val();
    const message = $('#message').val();

    
        chat.invoke("SendMessage", user, message).catch(err => console.error(err.toString()));
        $('#message').val('').focus();
    

    return false;

});






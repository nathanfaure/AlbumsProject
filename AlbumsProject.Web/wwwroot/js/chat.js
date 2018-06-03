function htmlEncode(value) {
    var encodedValue = $('<div />').text(value).html();
    return encodedValue;
}

var chat = $.connection.chatHub;
$.connection.hub.start().done(function () {
    $('#sendmessage').click(function () {
        var message = {
            Content: $('#message').val(),
            RecipientName: $("#choose").val() === "User" ? $("#user  option:selected").text() : $("#chatGroup  option:selected").text()
        };

        if ($("#choose").val() === "User") {
            if (message.RecipientName === "All")
                chat.server.sendMessageAll(message);
            else
                chat.server.sendMessageToUser(message);
        } else {
            chat.server.sendMessageToGroup(message);
        }
        $('#message').val('').focus();
    });
});

chat.client.showMessage = function (message) {
    var li = $("<li>");
    li.html(htmlEncode(message.Author) + " : " + htmlEncode(message.Content));
    $("#discussion").append(li);
}

function setChoise() {
    if ($("#choose").val() === "User") {
        $("#user").prop('disabled', false);
        $("#chatGroup").prop('disabled', true);
    } else {
        $("#user").prop('disabled', true);
        $("#chatGroup").prop('disabled', false);
    }
}

$("#choose").change(setChoise);

$(document).ready(function () {
    $('#message').focus();
    setChoise();
});



$().ready(function () {
    $.get("/api/greetings", function (response, status) {
        $("#greeting").text(response.greetingMessage);
    });

    $("#btnGetGreeting").click(function () {
        var name = $("#inpName").val();
        var model = { Name: name };
        var request = JSON.stringify(model);
        callHttp(request);
    });
});

function callHttp(request) {
    $.ajax({
        headers: { 'Accept': 'application/json', 'Content-Type': 'application/json' },
        cache: false,
        dataType: 'json',
        type: 'POST',
        async: false,
        url: "/api/greetings",
        data: request,
        success: function (response) {
            populateResponse(response);
        },
        error: function () {
            populateResponse(null);
        }
    });
}

function populateResponse(response) {
    if (response === null) {
        $("#greeting").text("Error calling service")
    }
    else {
        $("#greeting").text(response.greetingMessage);
    }
}
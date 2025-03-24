$(document).ready(function () {
    $("form").submit(function (event) {
        event.preventDefault();

        var form = $(this);
        var url = form.attr("action");

        $.ajax({
            type: form.attr("method"),
            url: url,
            data: form.serialize(),
            success: function (response) {
                if (response.success) {
                    alert(response.message);
                    window.location.href = "/Home/Index";
                } else {
                    alert(response.message);
                }
            },
            error: function () {
                alert("Erro ao processar a requisição!");
            }
        });
    });
});
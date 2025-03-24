$(document).ready(function () {
    function validarTipoPessoa() {
        var cnpj = $("#Cnpj").val().trim();

        if (cnpj !== "-") {
            $(".pf").hide();
            $(".pj").show();
        } else {
            $(".pj").hide();
            $(".pf").show();
        }
    }

    validarTipoPessoa();
});
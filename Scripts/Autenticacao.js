$(document).ready(function () {

    $("#status").hide();

    


    $("#botao-entrar").click(function () {
        //alert("teste de botao...");
        $.ajax({
            url: "/Autenticacao/AutenticarUsuario",
            type: "POST",
            data: { Login: $("#txtLogin").val(), Senha: $("#txtSenha").val() },
            dataType: "json",
            async: true,
            beforeSend: function () {

                $("#status").html("Autenticando Usuário...");
                $("#status").show();
            },
            success: function (dados) {

                if (dados.OK) {
                    $('#status').html(dados.Mensagem);
                    setTimeout(function () { window.location.href = "/home" }, 2000);
                    $('#status').show();
                }
                else {
                    $("#status").html(dados.Mensagem);
                    $("#status").show();
                }
            },
            erro: function (dados) {
                $("#status").html(dados.Mensagem);
                $("#status").show();

            }
        });
    });

    $("#botao-sair").click(function () {
        //alert("teste de botao...");
        $.ajax({
            url: "/Autenticacao/DesautenticarUsuario",
            type: "POST",
            dataType: "json",
            async: true,
            success: function (dados) {
                if (dados.OK)
                    window.location.href = "/home";
                $('#status').show();
            }
        });
    });

    $.ajax({
        url: "/Autenticacao/VerificarAutenticacao",
        type: "POST",
        dataType: "json",
        async: true,
        success: function (dados) {
            if (dados.OK)
                $('#botao-sair').show();
            else
                $('#botao-sair').hide();
        }
    });

});
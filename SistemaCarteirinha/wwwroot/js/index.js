var listaClientes = [];

$(document).ready(function () {
    var url = "/Api/BuscarClientes";

    $("#tabelaClientes").DataTable({
        "pageLength": 10,
        "ajax": {
            "url": url,
            "type": "GET",
            "datatype": "json",
            "dataSrc": function (json) {
                listaClientes = json.data;
                return json.data;
            }
        },
        "columns": [
            { "data": "cpf", "title": "CPF" },
            { "data": "nome", "title": "Nome" },
            { "data": "rg", "title": "RG" },
            { "data": "cnpj", "title": "CNPJ" },
            { "data": "razaoSocial", "title": "Razão Social" },
            { "data": "nomeFantasia", "title": "Nome Fantasia" },
            {
                "data": "id", "title": "Ações",
                "render": function (data, type, full) {
                    return `
                        <a class="btn btn-link btn-sm fa fa-info" data-toggle="tooltip" title="Detalhes" href="#" onclick="BuscaDetalhes(${full.id})"></a>
                        <a class="btn btn-link btn-sm fa fa-trash-alt" data-toggle="tooltip" title="Excluir" href="#" onclick="DeletarRegistro(${full.id})"></a>
                    `;
                }
            }
        ],
        "oLanguage": {
            "sProcessing": "A processar...",
            "sLengthMenu": "Mostrar _MENU_ registros",
            "sZeroRecords": "Não foram encontrados resultados",
            "sInfo": "Mostrando de _START_ até _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostrando de 0 até 0 de 0 registros",
            "sInfoFiltered": "(filtrado de _MAX_ registros no total)",
            "sSearch": "Procurar:",
            "oPaginate": {
                "sFirst": "Primeiro",
                "sPrevious": "Anterior",
                "sNext": "Seguinte",
                "sLast": "Último"
            }
        }
    });
});

function BuscaDetalhes(id) {
    var data = listaClientes.find(cliente => cliente.id == id);

    if (data) {
        $('.modal-body').load('/Home/Detalhes', function () {
            $("#id").val(data.id);
            $("#Cpf").val(data.cpf);
            $("#Nome").val(data.nome);
            $("#Rg").val(data.rg);
            $("#Cnpj").val(data.cnpj);
            $("#RazaoSocial").val(data.razaoSocial);
            $("#NomeFantasia").val(data.nomeFantasia);
            $("#Sexo").val(data.sexo);
            $("#DtNascimento").val(data.dtNascimento);
            $("#Endereco").val(data.endereco);
            $("#Telefone").val(data.telefone);
            $("#Email").val(data.email);

            $('#ModalDetalhes').modal('show');
        });
    } else {
        alert("Erro ao carregar os detalhes do cliente!");
    }
}

function DeletarRegistro(id) {
    if (confirm("Tem certeza que deseja excluir este registro?")) {
        $.ajax({
            url: "/Api/Deletar",
            type: "POST",
            data: { id: id },
            success: function () {
                $('#tabelaClientes').DataTable().ajax.reload();
            },
            error: function () {
                alert("Erro ao excluir o registro.");
            }
        });
    }
}

function fecharModal() {
    window.location.href = "/Home/Index";
}

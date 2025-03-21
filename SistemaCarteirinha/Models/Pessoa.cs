using System.Text.Json.Serialization;

namespace SistemaCarteirinha.Models;

public class Pessoa
{
    public string? Cpf { get; set; }
    public string? Nome { get; set; }
    public string? Sexo { get; set; }
    public DateTime? DtNascimento { get; set; }
    public string? Rg { get; set; }
    public string? Endereco { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    public string? Cnpj { get; set; }
    public string? RazaoSocial { get; set; }
    public string? NomeFantasia { get; set; }
}

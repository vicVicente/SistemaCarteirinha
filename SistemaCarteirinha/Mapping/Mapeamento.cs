using SistemaCarteirinha.Models;
using MySql.Data.MySqlClient;

namespace SistemaCarteirinha.Mapping;

public class Mapeamento
{
    public Pessoa MapPessoa(MySqlDataReader reader)
    {
        return new Pessoa
        {
            Id = reader.GetInt64("ID_CLIENTE"),
            Cpf = reader.IsDBNull(reader.GetOrdinal("CPF")) ? "-" : reader.GetString("CPF"),
            Nome = reader.IsDBNull(reader.GetOrdinal("NOME")) ? "-" : reader.GetString("NOME"),
            Sexo = reader.IsDBNull(reader.GetOrdinal("SEXO")) ? "-" : reader.GetString("SEXO"),
            DtNascimento = reader.IsDBNull(reader.GetOrdinal("DT_NASCIMENTO")) ? (DateTime?)null : reader.GetDateTime("DT_NASCIMENTO"),
            Rg = reader.IsDBNull(reader.GetOrdinal("RG")) ? "-" : reader.GetString("RG"),
            Cnpj = reader.IsDBNull(reader.GetOrdinal("CNPJ")) ? "-" : reader.GetString("CNPJ"),
            RazaoSocial = reader.IsDBNull(reader.GetOrdinal("RAZAO_SOCIAL")) ? "-" : reader.GetString("RAZAO_SOCIAL"),
            NomeFantasia = reader.IsDBNull(reader.GetOrdinal("NOME_FANTASIA")) ? "-" : reader.GetString("NOME_FANTASIA"),
            Endereco = reader.IsDBNull(reader.GetOrdinal("ENDERECO")) ? "-" : reader.GetString("ENDERECO"),
            Telefone = reader.IsDBNull(reader.GetOrdinal("TELEFONE")) ? "-" : reader.GetString("TELEFONE"),
            Email = reader.IsDBNull(reader.GetOrdinal("EMAIL")) ? "-" : reader.GetString("EMAIL")
        };
    }

}

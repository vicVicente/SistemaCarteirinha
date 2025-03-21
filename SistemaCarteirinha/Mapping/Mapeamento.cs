using MySql.Data.MySqlClient;
using SistemaCarteirinha.Models;

namespace SistemaCarteirinha.Mapping;

public class Mapeamento
{
    public Pessoa MapPessoa(MySqlDataReader reader)
    {
        return new Pessoa
        {
            Cpf = reader.IsDBNull(reader.GetOrdinal("CPF")) ? null : reader.GetString("CPF"),
            Nome = reader.IsDBNull(reader.GetOrdinal("NOME")) ? null : reader.GetString("NOME"),
            Sexo = reader.IsDBNull(reader.GetOrdinal("SEXO")) ? null : reader.GetString("SEXO"),
            DtNascimento = reader.IsDBNull(reader.GetOrdinal("DT_NASCIMENTO")) ? (DateTime?)null : reader.GetDateTime("DT_NASCIMENTO"),
            Rg = reader.IsDBNull(reader.GetOrdinal("RG")) ? null : reader.GetString("RG"),
            Cnpj = reader.IsDBNull(reader.GetOrdinal("CNPJ")) ? null : reader.GetString("CNPJ"),
            RazaoSocial = reader.IsDBNull(reader.GetOrdinal("RAZAO_SOCIAL")) ? null : reader.GetString("RAZAO_SOCIAL"),
            NomeFantasia = reader.IsDBNull(reader.GetOrdinal("NOME_FANTASIA")) ? null : reader.GetString("NOME_FANTASIA"),
            Endereco = reader.IsDBNull(reader.GetOrdinal("ENDERECO")) ? null : reader.GetString("ENDERECO"),
            Telefone = reader.IsDBNull(reader.GetOrdinal("TELEFONE")) ? null : reader.GetString("TELEFONE"),
            Email = reader.IsDBNull(reader.GetOrdinal("EMAIL")) ? null : reader.GetString("EMAIL")
        };
    }

}

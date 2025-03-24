using MySql.Data.MySqlClient;
using SistemaCarteirinha.Mapping;
using SistemaCarteirinha.Models;

namespace SistemaCarteirinha.Data;

public class DataDAO
{
    protected readonly string _connectionString = Environment.GetEnvironmentVariable("ConnectionString");

    public void Insert(Pessoa pessoa)
    {
        using MySqlConnection conn = new(_connectionString);
        {
            conn.Open();

            string sql = @"INSERT INTO PESSOA (CPF, NOME, SEXO, DT_NASCIMENTO, RG, CNPJ, RAZAO_SOCIAL, NOME_FANTASIA, ENDERECO, TELEFONE, EMAIL) 
                            VALUES (@Cpf, @Nome, @Sexo, @DtNascimento, @Rg, @Cnpj, @RazaoSocial, @NomeFantasia,  @Endereco, @Telefone, @Email)";

            using MySqlCommand cmd = new(sql, conn);
            {
                cmd.Parameters.AddWithValue("@Cpf", pessoa.Cpf);
                cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@Sexo", pessoa.Sexo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DtNascimento", pessoa.DtNascimento ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Rg", pessoa.Rg ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cnpj", pessoa.Cnpj);
                cmd.Parameters.AddWithValue("@RazaoSocial", pessoa.RazaoSocial);
                cmd.Parameters.AddWithValue("@NomeFantasia", pessoa.NomeFantasia ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Endereco", pessoa.Endereco ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefone", pessoa.Telefone ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", pessoa.Email ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }
    }

    public List<Pessoa> GetAll()
    {
        List<Pessoa> listaPessoa = [];

        using (MySqlConnection conn = new(_connectionString))
        {
            conn.Open();

            Mapeamento map = new();

            string sql = "SELECT * FROM PESSOA";
            using MySqlCommand cmd = new(sql, conn);
            using MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pessoa pessoa = map.MapPessoa(reader);
                listaPessoa.Add(pessoa);
            }
        }
        return listaPessoa;
    }

    public void Delete(long id)
    {
        using MySqlConnection conn = new(_connectionString);
        {
            conn.Open();

            string sql = @"DELETE FROM PESSOA WHERE ID_CLIENTE = @id;";

            using MySqlCommand cmd = new(sql, conn);
            {
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }

    public bool ExisteCpfOuCnpj(string? cpf, string? cnpj)
    {
        using MySqlConnection conn = new(_connectionString);
        {
            conn.Open();

            string sql = @"SELECT COUNT(*) FROM PESSOA WHERE CPF = @Cpf OR CNPJ = @Cnpj";
            using MySqlCommand cmd = new(sql, conn);
            {
                cmd.Parameters.AddWithValue("@Cpf", cpf ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Cnpj", cnpj ?? (object)DBNull.Value);

                long count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }


}

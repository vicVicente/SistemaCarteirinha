using SistemaCarteirinha.Data;
using SistemaCarteirinha.Models;

namespace SistemaCarteirinha.Service;

public class PessoaJuridicaService
{
    private readonly DataDAO _pessoaDAO = new();

    public void InsertPJ(PessoaJuridica pj)
    {
        _pessoaDAO.InsertPJ(pj);
    }
}

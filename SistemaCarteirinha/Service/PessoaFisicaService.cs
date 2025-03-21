using SistemaCarteirinha.Data;
using SistemaCarteirinha.Models;

namespace SistemaCarteirinha.Service;

public class PessoaFisicaService
{
    private readonly DataDAO _pessoaDAO = new();

    public void InsertPF(PessoaFisica pf)
    {
        _pessoaDAO.InsertPF(pf);
    }
}

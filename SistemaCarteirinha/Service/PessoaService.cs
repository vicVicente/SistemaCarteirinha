using SistemaCarteirinha.Data;
using SistemaCarteirinha.Models;

namespace SistemaCarteirinha.Service;

public class PessoaService
{
    private readonly DataDAO _pessoaDAO = new();

    public void Insert(Pessoa pf)
    {
        _pessoaDAO.Insert(pf);
    }

    public List<Pessoa> GetAll()
    {
        return _pessoaDAO.GetAll();
    }
}

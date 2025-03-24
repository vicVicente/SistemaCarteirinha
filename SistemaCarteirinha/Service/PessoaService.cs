using SistemaCarteirinha.Models;
using SistemaCarteirinha.Data;

namespace SistemaCarteirinha.Service;

public class PessoaService
{
    private readonly DataDAO _pessoaDAO = new();

    public void Insert(Pessoa pf)
    {

        if (_pessoaDAO.ExisteCpfOuCnpj(pf.Cpf, pf.Cnpj))
        {
            throw new Exception("CPF ou CNPJ já cadastrado no sistema.");
        }

        _pessoaDAO.Insert(pf);
    }

    public List<Pessoa> GetAll()
    {
        return _pessoaDAO.GetAll();
    }

    public void Delete(long id)
    {
        _pessoaDAO.Delete(id);
    }
}

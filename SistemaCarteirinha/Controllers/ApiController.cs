using SistemaCarteirinha.Service;
using SistemaCarteirinha.Models;
using Microsoft.AspNetCore.Mvc;

namespace SistemaCarteirinha.Controllers;

public class ApiController : Controller
{
    private readonly PessoaService _pessoaService = new();

    public JsonResult BuscarClientes()
    {
        try
        {
            List<Pessoa> listPessoa = _pessoaService.GetAll();

            return Json(new { data = listPessoa });
        }
        catch (Exception ex)
        {
            return Json(new { error = ex.Message });
        }
    }

    [HttpPost]
    public JsonResult Cadastro(Pessoa Pessoa)
    {
        try
        {
            _pessoaService.Insert(Pessoa);
            return Json(new { success = true, message = "Cadastro realizado com sucesso!" });
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = "Erro ao cadastrar: " + ex.Message });
        }
    }


    [HttpPost]
    public ActionResult Deletar(long id)
    {
        _pessoaService.Delete(id);

        return RedirectToAction("Index", "Home");
    }

}
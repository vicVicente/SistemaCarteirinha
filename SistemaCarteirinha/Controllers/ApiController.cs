using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using SistemaCarteirinha.Models;
using SistemaCarteirinha.Service;

namespace SistemaCarteirinha.Controllers;

public class ApiController : Controller
{
    private readonly PessoaService _pessoaService = new();

    public JsonResult BuscarClientes()
    {
        try
        {
            List<Pessoa> listPessoa = _pessoaService.GetAll();

            Console.WriteLine(JsonSerializer.Serialize(listPessoa));

            return Json(new { listPessoa });
        }
        catch (Exception ex)
        {
            return Json(new { error = ex.Message });
        }
    }



    [HttpPost]
    public ActionResult Cadastro(Pessoa Pf)
    {
        _pessoaService.Insert(Pf);

        return RedirectToAction("Index", "Home");
    }
}
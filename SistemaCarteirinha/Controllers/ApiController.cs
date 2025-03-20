using System.Web.Mvc;


namespace SistemaCarteirinha.Controllers;

public class ApiController : Controller
{
    [HttpGet]
    public ActionResult BuscarClientes()
    {

        return null; // RedirectToAction("Index", "Home");
    }

    [HttpPost]
    public ActionResult CadastroPF()
    {

        return null; // RedirectToAction("Index", "Home");
    }

    [HttpPost]
    public ActionResult CadastroPJ()
    {

        return null; // RedirectToAction("Index", "Home");
    }
}

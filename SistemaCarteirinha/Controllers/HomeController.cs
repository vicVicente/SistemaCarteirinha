using Microsoft.AspNetCore.Mvc;
using SistemaCarteirinha.Models;
using System.Diagnostics;

namespace SistemaCarteirinha.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CadastroPF()
        {
            return View();
        }
        public IActionResult CadastroPJ()
        {
            return View();
        }
        
        public IActionResult Detalhes()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

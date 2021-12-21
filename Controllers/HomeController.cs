using CRUD_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CRUD_MVC.Data;

namespace CRUD_MVC.Controllers
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


        public IActionResult Promo()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Destino()
        {
            return View();
        }

        [HttpPost]
        [Route("SolicitarViagem")]
        public IActionResult SolicitarViagem(Cliente cliente)
        {
            var dbContext = new Contexto();
            dbContext.Add(cliente);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
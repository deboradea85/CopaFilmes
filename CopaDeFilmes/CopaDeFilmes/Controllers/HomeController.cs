
using System.Diagnostics;
using CopaDeFilmes.Models;
using CopaDeFilmesBusiness;
using Microsoft.AspNetCore.Mvc;


namespace CopaFilmes.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View(new FilmeBusiness().ListarFilmes());
        }
        [HttpPost]
        public IActionResult ResultadoCampeonato(string[] filmes)
        {

            return View(new FilmeBusiness().DefinirVencedor(filmes));


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

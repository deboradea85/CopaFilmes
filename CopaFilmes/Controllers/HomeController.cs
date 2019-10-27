using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CopaFilmes.Models;
using Business;

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

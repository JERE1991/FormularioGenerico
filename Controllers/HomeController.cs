using FormularioGenerico1._5.Models;
using FormularioGenerico1._5.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FormularioGenerico1._5.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositorioGenerico repositorioGenerico;

        public HomeController(IRepositorioGenerico repositorioGenerico)
        {
            this.repositorioGenerico = repositorioGenerico;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FormularioGenerico()
        {

            return View();

        }
        [HttpPost]
        public IActionResult FormularioGenerico(FormularioGenerico formularioGenerico)
        {
            repositorioGenerico.FormulariadoGenerizado(formularioGenerico);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

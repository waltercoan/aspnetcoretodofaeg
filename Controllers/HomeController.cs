using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.qqcoisa = 10;
            ViewData["idade"] = 20;

            var meuTeste = new Teste()
            {
                Nome = "Zezinho"
            };
            //meuTeste.Nome = "Zezinho";

            return Redirect("http://www.univille.br");
            return BadRequest("Isso nao deveria acontecer");
            return View(meuTeste);
            //return Content("<h1> eu nao acredito</h1>");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

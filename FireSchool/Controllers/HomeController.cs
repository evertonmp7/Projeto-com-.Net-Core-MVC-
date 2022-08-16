using FireSchool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FireSchool.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            Home home = new Home();

            home.Nome = "Everton";
            home.Email = "everton@gmail.com.br";
            

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cadastro() 
        {
            return View();
        }

        public IActionResult Editar()
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

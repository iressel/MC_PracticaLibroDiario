using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticaLibroDiarioTemplate.Models;
using PracticaLibroDiarioTemplate.Models.Contexts;

namespace PracticaLibroDiarioTemplate.Controllers
{
    public class HomeController : Controller
    {
        LibroDiarioContext db;
        public HomeController(LibroDiarioContext context)
        {

        }
        public IActionResult Index()
        {
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

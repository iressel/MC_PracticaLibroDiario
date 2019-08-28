using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PracticaLibroDiarioTemplate.Controllers
{
    public class LibroDiarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
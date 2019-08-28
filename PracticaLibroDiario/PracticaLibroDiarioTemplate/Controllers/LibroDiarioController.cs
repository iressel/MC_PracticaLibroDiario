using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public IActionResult Get(LibroDiarioCCC request)
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }
    }

    public class LibroDiarioCCC
    {
        [Required]
        public string Folio { get; set; }
        public DateTime Date { get; set; }
    }
}
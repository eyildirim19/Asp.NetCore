using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _9_LayoutPages.Controllers
{
    public class HakkimdaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ogr1"] = "Önder";
            ViewData["ogr2"] = "Semiha";

            return View(); 
        }
    }
}

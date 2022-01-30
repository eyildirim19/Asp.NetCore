using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1Giris.Controllers
{
    public class HomeController : Controller
    {
        // Action metot

        public IActionResult Index()
        {
            return View();
        }

        public List<string> Ogrenciler()
        {
            var l = new List<string>() { "Bahar", "Evren", "Büşra", "Suna", "Semiha", "Serhat", "Önder" };
            return l;
        }
    }
}
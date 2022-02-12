using _10_LayoutPages2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_LayoutPages2.Controllers
{
    public class ProfilController : Controller
    {
        public IActionResult Index()
        {
            ViewData["loginUserName"] = "eyildirim";
            return View();
        }

        public IActionResult UpdateProfil()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateProfil(ProfilViewModel model)
        {
            if (ModelState.IsValid)
            {
                // güncelleme
                ViewData["mesaj"] = "Profiliniz başarıyla güncellendi.";
            }

            return View();
        }
    }
}
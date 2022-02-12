using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _10_LayoutPages2.Models;

namespace _10_LayoutPages2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hakkimda()
        {
            return View();
        }

        public IActionResult Iletisim()
        {
            return View();
        }

        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // ModelState.IsValid =>modelin validation (doğrulama) yapıldısya true döner
            if (ModelState.IsValid)
            {
                // login komutları....
                ViewData["mesaj"] = "Başarılı bir şekilde login oldunuz...";
            }

            return View();
        }
    }
}
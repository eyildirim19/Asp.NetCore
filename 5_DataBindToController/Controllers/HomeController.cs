using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5_DataBindToController.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Parametre isimleri ile formdan gelecek input nameleri eşleşmelidir...
        [HttpPost]
        public IActionResult Index(string UserName, string Password)
        {
            return View();
        }

        [HttpPost]
        public IActionResult KayitOl(string UserName, string Email, string Password)
        {

            return View("Index"); // index view'ını render et..
        }

        // FormCollection => Request yapılan formdan veri almak için kullanılan sınıftır.. 
       [HttpPost]
        public IActionResult SifremiUnuttum(IFormCollection form)
        {
            string str = form["email"];
            return View("Index");
        }

        [HttpPost]
        public IActionResult EmailAbone()
        {
            string str = Request.Form["email"];
            string name = Request.Form["Name"];

            return View("Index");
        }


    }
}

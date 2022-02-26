using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12_StateManagement.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                HttpContext.Session.SetString("username", username); // username sessionı oluşur
                return RedirectToAction("Index", "Account");
            }
            else
            {
                ViewData["LoginError"] = "Hatalı kullancı adı veya şifre. Lütfen tekrar deneyiniz";
            }
            return View();
        }
    }
}

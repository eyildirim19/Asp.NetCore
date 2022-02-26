using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12_StateManagement.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            // username sessionı yoksa...
            if (HttpContext.Session.GetString("username") == null)
            {
                return RedirectToAction("Index", "Login"); // Login controllerın Index actionına yönlendir...
            }

            string UserName = HttpContext.Session.GetString("username");
            //return View(UserName); string gönderilen parametreyi view name olarak algılar
            // modele string bind edildiğinde view name olarak algıladığı için view namei belirtiyoruz..
            return View("Index", UserName);
        }

        public IActionResult LogOff()
        {
            HttpContext.Session.Remove("username"); // sessionı sil...
            return RedirectToAction("Index", "Home"); // anasayfa dön....
        }
    }
}

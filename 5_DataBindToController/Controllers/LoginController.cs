using _5_DataBindToController.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5_DataBindToController.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Login model)
        {
            // ModelState.IsValid  => doğrulama yapılmış mı????... (Bu örnekteki doğrulama zorunlu alanlar girilmişmidir???)
            if (ModelState.IsValid)
            {
                string s = model.UserName;
                // kayıt işlemini bitir.....
            }
            //else
            //{
            //    ModelState.AddModelError("UserName", "Kullanıcı Adı boş geçilemez");
            //    ModelState.AddModelError("Password", "Şifre alanı boş geçilemez");
            //}
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4_Models.Models;

namespace _4_Models.Controllers
{
    public class HomeController : Controller
    {

        // Serverdan sayfa veya action çağırdığıdan bu get işlemidir..

        // sayfadan action'a birşey gönderdiğinde bu post işlemidir.. (gizli veri gönderimi)

        [HttpGet] // sadece get edilebilir...
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] // sadece post edilebilir...
        public IActionResult Index(User model)
        {
            string gelenUserName = model.UserName;
            string password = model.Password;

            return View();
        }
    }
}

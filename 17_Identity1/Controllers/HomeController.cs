using _17_Identity1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _17_Identity1.Controllers
{
    public class HomeController : Controller
    {
        //IdentityDbContext => hazır identity tablolarını almak için kullanılılır...
        // IdentityDbContext Microsoft.AspNetCore.IdentityEntityFrameworkCore kütüphanesini indirmek gerekir...

        // Identity yapısında mevcut tablodaki alanlar yeterli değilse bu tabloları kendinize göre özelleştirebilirsiniz.. Bunun için MyDbContext sııfımıza göz atalım....

        MyDbContexts db;


        public IActionResult Index()
        {

            return View();
        }
    }
}

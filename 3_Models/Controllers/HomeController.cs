using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3_Models.Models;

namespace _3_Models.Controllers
{
    public class HomeController : Controller
    {
        CategoryRepository repository;
        public HomeController()
        {
            repository = new CategoryRepository();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KatList()
        {
            var list = repository.GetCategories();
            return Json(list); // listeyi serilize ederek dön...
        }

        public IActionResult Kategoriler()
        {
            var list = repository.GetCategories(); // kategorileri list nesnesine ata...
            return View(list);// view'a modeli gönder...
        }
    }
}
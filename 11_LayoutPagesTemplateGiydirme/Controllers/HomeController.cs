using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Controllers
{
    using Models;
    using Models.Repository;
    public class HomeController : Controller
    {
        CategoryRepository repository;
        public HomeController()
        {
            repository = new CategoryRepository();
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.PageTitle = "Anasayfa";
            model.Categories = repository.List();

            return View(model);
        }
    }
}

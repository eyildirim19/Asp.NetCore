using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Controllers
{
    using Models;
    using Models.Repository;
    using Models.Entities;
    public class HomeController : Controller
    {
        CategoryRepository repository;
        // dbContext instance startup dosyasındaki addDbContext metodu ile buraya, buradan da Repository'e gider...
        public HomeController(ProjectDbContext dbContext)
        {
            repository = new CategoryRepository(dbContext);
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

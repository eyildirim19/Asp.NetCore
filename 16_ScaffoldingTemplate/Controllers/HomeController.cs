using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _16_ScaffoldingTemplate.Controllers
{
    using Models;
    public class HomeController : Controller
    {
        CmsProjectDbContext _dbContext;
        public HomeController(CmsProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel();
            vm.Categories = _dbContext.Categories.ToList();
            vm.Listings = _dbContext.Listings.ToList();

            return View(vm);
        }

        public IActionResult Temp()
        {
            return View();
        }

        // Bind Attribute Action'da parametteden önce, sınıfta atrribute olarak  set edilir...
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Temp([Bind(include:"Name,Title")]MyModel model)
        {
           return View();
        }


        public IActionResult SearchIlan(string text)
        {
            //t-sql deki like  c.Title.Contains(text)
            List<Listing> result = _dbContext.Listings.Where(c => c.Title.Contains(text)).ToList();
            return PartialView("_SearchIlanResult", result);
        }

        [HttpPost]
        public IActionResult SepeteAt(int ListId)
        {
            // Sepete Ekleme komutlarımız..

            //int result = sayi / 0; // hata mesajını görmek isterseniz açınız...

            // action'a dön viewın beklediği modeli bind etsin


            return Json(new
            {
                Code = 0, // başarılı,
                Message = "İşlem Başarılı. Ürün sepetenize eklenmiştir...."
            });
        }
    }
}

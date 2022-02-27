using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14_Ajax.Controllers
{
    using Microsoft.EntityFrameworkCore;
    using Models;
    using OrnekModels;

    public class HomeController : Controller
    {
        CmsProjectDbContext _dbContext;
        public HomeController(CmsProjectDbContext dbContext) // runtime'da instance ctrodan enjecte edilecek...
        {
            _dbContext = dbContext; // gelen instance _dbContext nesnemize set edilir.. daha sonra bu controller içeerisinde kullanılır
        }

        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();

            model.Categories = _dbContext.Categories.ToList();
            model.Listings = _dbContext.Listings.ToList();

            return View(model);
        }


        public IActionResult SearchIlan(string text)
        {
            //t-sql deki like  c.Title.Contains(text)
            List<Listing> result = _dbContext.Listings.Where(c => c.Title.Contains(text)).ToList();
            return PartialView("_SearchIlanResult", result);
        }

        int sayi = 100;
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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _16_ScaffoldingTemplate.Areas.SiteManage.Controllers
{
    using Models;
    [Area("SiteManage")]
    public class HomeController : Controller
    {
        CmsProjectDbContext _db;
        public HomeController(CmsProjectDbContext db)
        {
            _db = db;
        }
        // GET: HomeController
        public ActionResult Index()
        {
            return View(_db.Categories.ToList());
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category model)
        {
            try
            {
                // aynı isimdeki kategoriyi getir...
                var kat = _db.Categories.FirstOrDefault(c => c.Name.ToUpper() == model.Name.ToUpper());

                if (kat==null) // kategori yoksa
                {
                    _db.Categories.Add(model); // kategoriyee ekle
                    _db.SaveChanges(); // veritabanına yansıt...
                                       
                    return RedirectToAction(nameof(Index)); // index'e yönlendir...
                }
                else
                {
                    ModelState.AddModelError("Error", $"{model.Name} isminde kategori eklenmiş...Lütfen kategori adını değiştiriniz...");

                    return View(model);
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            var cat=  _db.Categories.FirstOrDefault(c => c.Id == id);
            return View(cat);
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var cat = _db.Categories.FirstOrDefault(c => c.Id == id);
                _db.Categories.Remove(cat); // Categoriyi sil
                _db.SaveChanges(); // değişikliği yansıt..

                return RedirectToAction(nameof(Index)); // index'e yönlendir..
            }
            catch
            {
                return View();
            }
        }
    }
}

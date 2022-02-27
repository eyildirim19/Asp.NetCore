using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14_Ajax.Controllers
{
    public class JsonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetOgrencis()
        {
            List<string> ogrenciler = new List<string>();
            ogrenciler.Add("Furkan");
            ogrenciler.Add("Suna");
            ogrenciler.Add("Bahar");
            ogrenciler.Add("Semiha");

            return Json(ogrenciler); // JsonResult
        }

        public IActionResult GetOgrenciObject()
        {
            List<Ogrenci> ogrencis = new List<Ogrenci>();
            ogrencis.Add(new Ogrenci { Adi = "Ekrem", SoyAdi = "Yıldırım", OgrenimUcreti = 499.99m, IsDurumu = true });
            ogrencis.Add(new Ogrenci { Adi = "Önder", SoyAdi = "Coşkun", OgrenimUcreti = 1499.99m, IsDurumu = true });

            return Json(ogrencis);
        }
    }

    public class Ogrenci
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public decimal OgrenimUcreti { get; set; }
        public bool IsDurumu { get; set; }
    }
}

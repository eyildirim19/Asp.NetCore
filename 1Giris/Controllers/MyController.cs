using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1Giris.Controllers
{
    public class MyController : Controller
    {
        // Controller eklendiğinde Index metodu default hazır gelecektir. Kullanıcıyı karşılayan metottur..

        // Controller içerisinde metotlar action metotlardır. Bu metotlar get veya post yöntemiyle tetiklenirle. Url'den çağrılabilen metotlar GET metotlardır...get metotlar herkese açık metotlardır. buraya yapılan requestlerde url ve varsa parametreler tam görünür...

        // ActionResult : IActionResult
        // ViewResult   : ActionResult,IActionResult
        // JsonResult   : ActionResult,IActionResult

        // ActionResult => asp.net core mvc'de bir dönüş tipidir. Bu dönüş tipi bütün dönüş tiplerinin base'dir. Geriye içerik, sayfa, json gibi tipler dönülür...
        public ActionResult Index()
        {
            return View();
        }

        // ViewResult geriye sayfa dönmek için kullanır. Yapılan requestin sonund kullanıcnın syfa görmesi gerekiyorsa bu dönüş tipi kullanılır....

        public ViewResult Hakkimda()
        {
            return View(); // View metodu ViewResult dönüş tipli bir metottur. geriye sayfa döner. Eğer geriye view dönülüyorsa ilgili path'de illi view'In olması gerekiyor.. Index ve Hakkimda actionları çağrıldığında viewlar olmadığı için hata verecektir...
        }

        // JsonResult geriye json datası dönmek için kullanılır. (Javascript Object Notationn) Json, xml gibi bir veri transfer dilidir. Standartları vardır. Xml diline göre daha kullanışlıldır. Javascript ile manipulasyonu kolaydır. Genelde yapılan ajax (ilerde işlenecek)requestlerinde bu dönüş tipini kullanırız.
        public JsonResult Demo()
        {
            List<string> ogrenciler = new List<string>() { "Furkan", "Serhat", "Bahar" };
            //IHayvan i = new Kus();
            //i.Ses();
            return Json(ogrenciler); // data serilize edilerek dönülür...
        }
        public ActionResult Ogrenci()
        {
            Ogrenci o = new Ogrenci();
            o.Adi = "EKrem";
            o.SoyAdi = "Yıldırım";
            return Json(o);
        }
    }

    public class Ogrenci
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
    }
    //public interface IHayvan
    //{
    //    string Ses();
    //}

    //public class Kus : IHayvan
    //{
    //    public string Ses()
    //    {
    //        return "Cik Cik";
    //    }

    //    public string Kanat()
    //    {
    //        return "deneme";
    //    }
    //}
    //public class Kedi : IHayvan
    //{
    //    public string Ses()
    //    {
    //        return "Miyav Miyav";
    //    }
    //    public string Irk()
    //    {
    //        return "Van";
    //    }
    //}
}

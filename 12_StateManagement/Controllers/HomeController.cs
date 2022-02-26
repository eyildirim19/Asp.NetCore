using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _12_StateManagement.Controllers
{
    public class HomeController : Controller
    {
        int counter = 0;
        public IActionResult Index()
        {
            return View(counter);
        }
        [HttpPost]
        public IActionResult Arttir()
        {
            // session'I kullanmak için Startup.cs dosyasına geçip middlevare kısmında aktif hale getiriyoruz..
           // sayac sessionuı varsa....
            if (HttpContext.Session.GetInt32("sayac") != null)
            {
                // sessiondaki sayac değerini al...counter'a ata...
                counter = (int)HttpContext.Session.GetInt32("sayac");
            } 
            counter++; // arttır
            HttpContext.Session.SetInt32("sayac", counter); // sayac isminde bir session oluştur ve değeri burada sakla...
            return View("Index", counter); // view'a model olarak dön...
        }
        [HttpGet]
        public IActionResult Deneme()
        {
            HttpContext.Session.SetInt32("sayac", 100);
            return View();
        }
    }
}

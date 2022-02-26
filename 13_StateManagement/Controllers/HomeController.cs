using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13_StateManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            string deger = "";
            if (Request.Cookies["siteden"] != null) // kuki varsa...
            {
                deger = Request.Cookies["siteden"]; // kuki'yi deger değişkenine ata...
            }

            return View();
        }

        // tarayıcıdan localhos:portnumber/Home/CerezeYaz
        public ActionResult CerezeYaz()
        {
            // Cookies => Kuki => serverdan kullanıcı (client) tarayacısını veri yazma yönetimidir...Cookiler tarayıcıda belirtilen süre kadar saklanır. sonra kendiliğinden imha edilir.. Cookie süresi  Expires ile belirlenir..

            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddMinutes(1); // bir dakika sakla...

            // tarayıcıya siteden ismi ile ekrem yıldırım değerini yaz....
            Response.Cookies.Append("siteden", "ekrem yıldırım", options);

            return RedirectToAction("Index"); // Homenin indexi....
        }
    }
}

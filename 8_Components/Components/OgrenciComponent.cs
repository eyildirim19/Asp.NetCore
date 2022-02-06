using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8_Components.Components
{
    // Bu sınıfın view render etmesini istiyoruz....
    //ViewComponent => Microsoft.AspNetCore.Mvc namespaesi içerisindedir...

    
    public class OgrenciViewComponent : ViewComponent
    {
        // Buradan view dönmek için Invoke isimli metot yazılır.
        public IViewComponentResult Invoke()
        {
            List<string> ogrenciler = new List<string>();
            ogrenciler.Add("Furkan");
            ogrenciler.Add("Önder");
            ogrenciler.Add("Ekrem");

            return View(ogrenciler); // geriye ilgili view'ı dön.... bu metot shared klasörü içerisinde Components klasörü içerisinde Ogrenci klasörü içeriisndeki default isimli viewı döner..
        }
    }
}
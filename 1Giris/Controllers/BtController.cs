using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1Giris.Controllers
{

    // Default varsayım İlgili Controller için Views altında ilgili klasör olmalıdır. Bu klasör içerisinde ilgili actionların döneceği sayfalar olmalıdır..
    public class BtController : Controller
    {

        // bir action'a view eklemek için, action metot üzerinde sağ tık yapıp view kısa yolunu kullanabiliriz...
        // asp.net core mvc veya asp.net mvc yapılarında fiziki sayfalar yoktur.. yani kullanıcı url bölümünden fiziki sayfa çağrıamaz..
        // Önce Controller içesindne ACTİON TETİKLENİR sonra action kullanıcıya özel uzantılı bir view döner. bu dönen view sadece kopya bir viewdır. 
        public IActionResult Index()
        {
            return View(); // Eğer meottoda viewname belirtmezseniz View metodu action isimli view arar..
        }

        public IActionResult Hakkimda()
        {
            return View("Me"); // Metota parametre olarak string gönderirseniz bunu view name olarak algılar. Burada geriye index viewını döneceğini söyledik.. 
        }

        public IActionResult Demo()
        {
            return View(); // İlgili view (demo.cshtml) önce Bt klasöründe aranır. Eğer o klasörde bulunamazsa Shared klasöründe aranır. Örneğimizde iligli view sharedda olduğu için oradan render edildi. Shared klasörü önemli ve sık kullanılacak bir klasördük. Ancak Viewların ilgili folderlarda olamsında fayda vardır. Shared içerisinde ortak kullanılan viewları oluştururuz.
        }


        public ActionResult Sayfam()
        {
            return View();
        }

        public ActionResult My()
        {
            return View();
        }
    }
}
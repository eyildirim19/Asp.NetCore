using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _9_LayoutPages.Component
{
    public class KategoriViewComponent : ViewComponent
    {
        string[] items = { "C#", "Sql Server", "Entity Framework", "Html-Css-Javascript", "AspNet Core" };

        public IViewComponentResult Invoke()
        {
            return View(items); // Model olarak diziyi view'a gönder....
        }
    }
}
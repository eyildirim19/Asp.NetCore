using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Components
{
    using Models;
    public class PopularCategoryViewComponent : ViewComponent
    {
        CategoryRepository repository;
        public PopularCategoryViewComponent()
        {
            repository = new CategoryRepository();
        }

        public IViewComponentResult Invoke()
        {
            var list = repository.List();
            return View(list); // Default view'ına modeli gönder...
        }
    }
}

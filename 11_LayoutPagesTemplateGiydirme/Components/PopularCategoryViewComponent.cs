using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Components
{
    using Models;
    using Models.Repository;
    using Models.Entities;
    public class PopularCategoryViewComponent : ViewComponent
    {
        CategoryRepository repository;
        public PopularCategoryViewComponent(ProjectDbContext dbContext)
        {
            repository = new CategoryRepository(dbContext);
        }

        public IViewComponentResult Invoke()
        {
            var list = repository.List();
            return View(list); // Default view'ına modeli gönder...
        }
    }
}

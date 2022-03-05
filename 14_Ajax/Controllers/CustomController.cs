using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14_Ajax.Controllers
{
    using _14_Ajax.Models;
    using OrnekModels;
    public class CustomController : Controller
    {
        CmsProjectDbContext _dbContext;
        public CustomController(CmsProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IndexViewModel vm = new IndexViewModel();
            vm.Categories = _dbContext.Categories.ToList();
            vm.Listings = _dbContext.Listings.ToList();

            return View(vm);
        }
    }
}

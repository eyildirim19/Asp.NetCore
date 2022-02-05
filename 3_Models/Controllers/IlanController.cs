using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3_Models.Models;

namespace _3_Models.Controllers
{
    public class IlanController : Controller
    {
        ProductRepository productRepository;
        CategoryRepository categoryRepository;
        public IlanController()
        {
            productRepository = new ProductRepository();
            categoryRepository = new CategoryRepository();
        }

        public IActionResult Index()
        {
            var catList = categoryRepository.GetCategories();
            var prodList = productRepository.GetProducts();

            IlanIndexViewModel model = new IlanIndexViewModel();
            model.categories = catList;
            model.products = prodList;

            return View(model); // modeli view'a bind et...
        }
    }
}
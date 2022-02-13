using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Controllers
{
    using Models; // model namespacei al...
    public class CategoryController : Controller
    {
        CategoryRepository repository;
        public CategoryController()
        {
            repository = new CategoryRepository();
        }
        public IActionResult Index()
        {
            PageHeadingViewModel _pageHeading = new PageHeadingViewModel();
            _pageHeading.Text = "We have a wide range of business categories for you";
            _pageHeading.Title = "Categories with Simple Tabs";

            CategoryViewModel vm = new CategoryViewModel();
            vm.PageTitle = "Kategoriler";
            vm.PageHeading = _pageHeading;
            vm.Categories = repository.List();

            return View(vm);
        }
    }
}
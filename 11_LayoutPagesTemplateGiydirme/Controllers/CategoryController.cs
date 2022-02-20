using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Controllers
{
    using Models; // model namespacei al...
    using Models.Repository;
    using Models.Entities;
    public class CategoryController : Controller
    {
        CategoryRepository repository;
        public CategoryController(ProjectDbContext dbContext)
        {
            repository = new CategoryRepository(dbContext);
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
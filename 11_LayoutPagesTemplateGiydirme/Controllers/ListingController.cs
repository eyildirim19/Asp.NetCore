using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Controllers
{
    using Models; // model namespacei ekle...
    using Models.Repository;
    using Models.Entities;
    public class ListingController : Controller
    {
        IRepository<Listing> ListRepository;
        IRepository<Category> CatRepository;
        public ListingController(ProjectDbContext dbContext)
        {
            ListRepository = new ListingRepository(dbContext);
            CatRepository = new CategoryRepository(dbContext);
        }

        public IActionResult Index()
        {
            PageHeadingViewModel _pageHeading = new PageHeadingViewModel();
            _pageHeading.Title = "Check Out Our Listings";
            _pageHeading.Text = "Item listings of Different Categories";

            ListingViewModel model = new ListingViewModel();
            model.PageTitle = "Liste";
            model.PageHeading = _pageHeading;
            model.Listings = ListRepository.List();
            model.Category = CatRepository.List();
           
            return View(model);
        }
    }
}

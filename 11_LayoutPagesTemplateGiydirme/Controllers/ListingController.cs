using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Controllers
{
    using Models; // model namespacei ekle...
    public class ListingController : Controller
    {
        public IActionResult Index()
        {

            PageHeadingViewModel _pageHeading = new PageHeadingViewModel();
            _pageHeading.Title = "Check Out Our Listings";
            _pageHeading.Text = "Item listings of Different Categories";

            ListingViewModel model = new ListingViewModel();
            model.PageTitle = "Liste";
            model.PageHeading = _pageHeading;

            return View(model);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using _11_LayoutPagesTemplateGiydirme.Models;

namespace _11_LayoutPagesTemplateGiydirme.Controllers
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Models;
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            PageHeadingViewModel _pageHeading = new PageHeadingViewModel();
            _pageHeading.Title = "Keep in touch with us";
            _pageHeading.Text = "Feel free to send us a message about your business needs";

            ContactViewModel model = new ContactViewModel();
            model.PageTitle = "İletişim";
            model.PageHeading = _pageHeading;

            return View(model); // view'a modeli bind et...
        }

        [HttpPost]
        public IActionResult Index(ContactViewModel model)
        {



            if (ModelState.IsValid)
            {
                ViewData["mesaj"] = $"Mesajınız tarafımıza ulaştı. En kısa zamanda {model.Email}  adresine dönüş yapacağız";
            }

            return View();
        }
    }
}

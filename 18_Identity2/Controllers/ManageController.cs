using _18_Identity2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _18_Identity2.Controllers
{
    [Authorize(Roles = "Admin")] // Bu controllerdaki actinlar sadece adminler girebilir...
    public class ManageController : Controller
    {
        RoleManager<AppRole> _roleManager; // rolleri yönetmek için
        SignInManager<AppUser> _signInManager; // oturumu yönetmek için
        UserManager<AppUser> _userManager; // kullanıcı yönetimek (kayıt vs.) için

        public ManageController(RoleManager<AppRole> roleManager,
            SignInManager<AppUser> signInManager,
            UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }


        public ActionResult RoleEkle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RoleEkle(string roleName, string aciklama)
        {
            AppRole role = new AppRole();
            role.Name = roleName;
            role.RoleAciklama = aciklama;

            if (await _roleManager.RoleExistsAsync(roleName))
            {
                await _roleManager.CreateAsync(role); // role ekle...
                ViewData["SuccessMessage"] = "Role daha önce eklenmiş";
            }
            else
            {
                ViewData["ErrorMessage"] = "Role daha önce eklenmiş";
            }

            return View();
        }


        public ActionResult UserEkle()
        {
            List<AppRole> roller = _roleManager.Roles.ToList(); // rolleri ata
            // veya
            List<string> roles = _roleManager.Roles.Select(c => c.Name).ToList(); // roleNameleria ata..

            ViewData["roller"] = roles;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserEkle(string UserName, string Password, string FirstName, string LastName, string Email, List<string> roles)
        {
            AppUser user = new AppUser();
            user.Adi = FirstName;
            user.SoyAdi = LastName;
            user.UserName = UserName;
            user.Email = Email;

            var reuslt = await _userManager.CreateAsync(user, Password);

            if (reuslt.Succeeded)
            {
                foreach (var role in roles)
                {
                    await _userManager.AddToRoleAsync(user, role);
                }
                ViewData["SuccessMessage"] = "Kullanıcı ekleme işlemi başarılı";
            }
            else
            {
                ViewData["ErrorMessage"] = "Kullanıcı ekleme başarısız";
            }
            return View();
        }

        [AllowAnonymous] // bU Attribute anonim olarak herkesi kabul eder. Authorize yapılmaz...
        public IActionResult Demo()
        {
            return View();
        }


        public IActionResult Ozel()
        {
            return View();
        }
    }
}

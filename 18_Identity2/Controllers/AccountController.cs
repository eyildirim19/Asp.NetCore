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
    public class AccountController : Controller
    {
        RoleManager<AppRole> _roleManager; // rolleri yönetmek için
        SignInManager<AppUser> _signInManager; // oturumu yönetmek için
        UserManager<AppUser> _userManager; // kullanıcı yönetimek (kayıt vs.) için
        public AccountController(RoleManager<AppRole> roleManager,
            SignInManager<AppUser> signManager,
            UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _signInManager = signManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {

            return View();
        }

        [Authorize(Roles = "SiteUser")]
        public IActionResult Profile()
        {

            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();//oturumu kapat..
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(username, password, false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home"); // Kullanıcıyı yönlendir...
            }

            ViewData["LoginError"] = "Lütfen bilgilerinizi kontrol ediniz";
            return View("Index"); //index view'ını dön...
        }

        [HttpPost]
        public async Task<IActionResult> Register(string username, string email, string password)
        {
            AppUser user = new AppUser();
            user.UserName = username;
            user.Email = email;

            // async metotlar await ifadfesi ile çağrılır.. async metot tetiklemek için metodununuz async ifadesi ile işaretlenmesi gerekir.. aynı zaman task ifadesiile belirtilmesi gereli
            IdentityResult result = await _userManager.CreateAsync(user, password);

            string mesaj;
            bool isSucccess;
            if (result.Succeeded) // işlem başarılı...
            {
                mesaj = "Tebirkler. Başarılı bir şekilde kayıt oldunuz. Şimdi oturum açabilirsiniz";
                isSucccess = true;

                // SiteUser rolü yoksa
                if (!await _roleManager.RoleExistsAsync("SiteUser"))
                {
                    AppRole role = new AppRole();
                    role.Name = "SiteUser";
                    await _roleManager.CreateAsync(role); // role oluştur
                }

                await _userManager.AddToRoleAsync(user, "SiteUser"); // kullanıcıya role ekle...

            }
            else// işlem başarısız...
            {
                mesaj = "Üzgünüm. Bir hata oluştu. Lütfen bilgilerinizi kontrol ediniz!";
                isSucccess = false;
            }

            // new idesi ile anonim (tipsiz) tip oluşturalım...
            return Json(new
            {
                Message = mesaj,
                IsSuccess = isSucccess
            });
        }
    }
}

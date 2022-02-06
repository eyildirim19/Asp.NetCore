using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _6_ModelValidation.Models
{
    public class User
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="UserName alanı zorunludur")]
        public string UserName { get; set; }


        [Display(Name = "Şifre")]
        [Required(ErrorMessage ="Password alanı zorunludur")]
        [StringLength(10,ErrorMessage ="Şifre alanı max 10 karakter olmalıdır")]
        public string Password { get; set; }

      
        [Display(Name = "Şifre Tekrar")]
        [Required(ErrorMessage ="Passowrd Tekrar alanı zorunludur")]
        [Compare("Password",ErrorMessage = "Şifreler eşleşmiyor")]
        public string Password2 { get; set; }

        [Display(Name = "Mail Adresi")]
        [Required(ErrorMessage ="Email Alanı zorunludur")]
        [EmailAddress(ErrorMessage ="Hatalı email adresi")]
        public string Email { get; set; }
    }
}
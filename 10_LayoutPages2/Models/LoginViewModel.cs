using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _10_LayoutPages2.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Email alanı zorunludur")]
        [EmailAddress(ErrorMessage ="Hatalı Email Formatı")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Şifre alanı zorunludur")]
        [StringLength(10,MinimumLength =6,ErrorMessage ="Şifre 6 - 10 karakter arasında olmalıdır")]
        public string Password { get; set; }
    }
}
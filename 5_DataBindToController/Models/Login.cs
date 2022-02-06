using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _5_DataBindToController.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Kullanıcı Adı alanı zorunludur")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Şife alanı zorunludur")]
        public string Password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Models
{
    public class ContactViewModel : BaseViewModel
    {

        [Required(ErrorMessage = "Ad alanı zorunludur")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Email alanı zorunludur")]
        [EmailAddress(ErrorMessage = "Hatalı Email Adresi")]
        public string Email { get; set; }

        public List<string> Options { get; set; }

        [Required(ErrorMessage = "Mesaj alanı zorunludur")]
        [StringLength(300, ErrorMessage = "Max. 300 karakter yazılabilir")]
        public string Message { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _17_Identity1.Models
{
    // IdentityUser'in propertylerini MyUser'a devrediyoruz.. Sonra MyUser sınıfını IdentityUser sınıfı gibi kullanıyoruz...
    public class MyUser : IdentityUser<int>
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string Cinsiyet { get; set; }

        [NotMapped]
        public override string NormalizedEmail { get => base.NormalizedEmail; set => base.NormalizedEmail = value; }
    }

    
}

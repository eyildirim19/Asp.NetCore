using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _18_Identity2.Models
{
    public class AppUser : IdentityUser<int>
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string Cinsiyet { get; set; }
        public string Avatar { get; set; }
    }
}

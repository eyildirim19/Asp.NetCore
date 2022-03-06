using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _18_Identity2.Models
{
    public class AppRole : IdentityRole<int>
    {
        public string RoleAciklama { get; set; }
    }
}

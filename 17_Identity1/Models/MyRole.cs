using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _17_Identity1.Models
{
    public class MyRole : IdentityRole<int>
    {
        public string RoleAciklama { get; set; }
    }
}

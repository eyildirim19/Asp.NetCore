using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _18_Identity2.Models
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }


    // örnek => derived sınıftan base sınıfa ctor'da parametre göndermeye örnek....
    public class MyBase
    {
        public MyBase(string str) // str parametresi alan ctor..
        {

        }
    }
    public class MyClass : MyBase
    {
        public MyClass(string param) : base(param)
        {
        }
    }
}

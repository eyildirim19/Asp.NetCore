using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _17_Identity1.Models
{
    // 
    public class MyDbContexts : IdentityDbContext<MyUser,MyRole,int>
    {
        public MyDbContexts(DbContextOptions<MyDbContexts> options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
    }
}

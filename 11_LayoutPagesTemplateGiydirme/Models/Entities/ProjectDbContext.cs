using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Models.Entities
{
    public class ProjectDbContext : DbContext
    {
        // DbCCOntext sınıfına connectionstring Startup dosyasından inject edilir..
        public ProjectDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Listing>().Property(c => c.Price).HasPrecision(6, 2);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Listing> Listing { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Models.Repository
{
    using Models.Entities;
    public class ListingRepository : IRepository<Listing>
    {
        ProjectDbContext dbContext;
        public ListingRepository(ProjectDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Listing> List()
        {
            return dbContext.Listing.ToList();
        }
    }
}

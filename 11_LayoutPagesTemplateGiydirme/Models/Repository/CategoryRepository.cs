using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Models.Repository
{
    using Models.Entities;
    public class CategoryRepository : IRepository<Category>
    {
        ProjectDbContext dbContext;
        public CategoryRepository(ProjectDbContext dbContext)
        {
            //this o anki instance'i ifade eder. Veya bu class gibi düşünebilirsiniz..
            this.dbContext = dbContext;
        }
        public List<Category> List()
        {
            // Kategorinin bir kaynaktan (db) geldiğini düşünelim..
            var katList = dbContext.Categories.ToList();
            return katList;
        }
    }
}
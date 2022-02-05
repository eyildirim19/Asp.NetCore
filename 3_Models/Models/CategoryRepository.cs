using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_Models.Models
{
    public class CategoryRepository
    {
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category { ID = 1, Name = "Elektronik", Description = "Elektrikler..." });
            categories.Add(new Category { ID = 2, Name = "Mobilya", Description = "Mobilyalar" });
            categories.Add(new Category { ID = 3, Name = "Yiyecek & İçecek", Description = "Yiyin için" });

            return categories;
        }
    }
}
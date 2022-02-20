using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Models.Entities
{
    public class Category
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string IconPath { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string LargeImage { get; set; }

        public List<Listing> Listings { get; set; } // navigation property
    }
}
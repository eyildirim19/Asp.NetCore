using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Models.Entities
{
    public class Listing
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public DateTime CreDate { get; set; }


        public string ImagePath { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}

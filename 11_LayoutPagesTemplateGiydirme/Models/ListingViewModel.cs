using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Models
{
    using Models.Entities;
    public class ListingViewModel : BaseViewModel
    {
        public List<Listing> Listings { get; set; } // listingleri viewa bind etmek için...

        public List<Category> Category { get; set; } // categoryleri view'a bind etmek için...
    }
}
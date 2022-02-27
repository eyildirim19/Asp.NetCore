using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14_Ajax.Models
{
    using OrnekModels; // entity namespace
    public class IndexViewModel
    {
        public List<Category> Categories { get; set; }

        public List<Listing> Listings { get; set; }
    }
}
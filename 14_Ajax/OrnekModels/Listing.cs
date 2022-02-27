﻿using System;
using System.Collections.Generic;

#nullable disable

namespace _14_Ajax.OrnekModels
{
    public partial class Listing
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime CreDate { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}

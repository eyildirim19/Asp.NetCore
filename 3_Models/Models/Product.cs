using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_Models.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public short  Stok { get; set; }

        public decimal Price { get; set; }
    }
}

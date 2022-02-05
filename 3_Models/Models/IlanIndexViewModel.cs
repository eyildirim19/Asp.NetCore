using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_Models.Models
{
    // View'da birden fazla farklı model olduğu için View'a özel yeni bir model tanımlıyoruz...
    public class IlanIndexViewModel
    {
        public List<Category> categories { get; set; }
        public List<Product> products { get; set; }
    }
}
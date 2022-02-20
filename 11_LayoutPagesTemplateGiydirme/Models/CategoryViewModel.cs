using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Models
{
    using Models.Entities;
    public class CategoryViewModel : BaseViewModel
    {
        public List<Category> Categories { get; set; }
    }
}
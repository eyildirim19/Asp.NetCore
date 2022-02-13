using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Models
{
    // Sadece miras versin...Instance alınıp kullanılmasın...
    public abstract class BaseViewModel
    {
        public string PageTitle { get; set; }
        public PageHeadingViewModel PageHeading { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace _16_ScaffoldingTemplate.Models
{
    public partial class Category
    {
        public Category()
        {
            Listings = new HashSet<Listing>();
        }

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 20, ErrorMessage = "Max. 20 karakter eklenebilir")]
        public string Name { get; set; }

        [ScaffoldColumn(false)] // scaffolding template kullanıldındağı bu kolon kullanılmasın..
        public string IconPath { get; set; }


        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(maximumLength: 60, ErrorMessage = "Max. 20 karakter eklenebilir")]
        public string Title { get; set; }


        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string Description { get; set; }


        [ScaffoldColumn(false)] // scaffolding template kullanıldındağı bu kolon kullanılmasın..
        public string LargeImage { get; set; }

        public virtual ICollection<Listing> Listings { get; set; }
    }
}

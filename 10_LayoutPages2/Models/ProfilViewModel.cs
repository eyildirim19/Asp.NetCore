using System.ComponentModel.DataAnnotations;

namespace _10_LayoutPages2.Models
{
    public class ProfilViewModel
    {
        [Required(ErrorMessage ="*")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "*")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        public string Name { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace portfolio005.Models
{
    public class Testimonial
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter your Review")]
        public string Review { get; set; }
        [Required(ErrorMessage = "Enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter your Description")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "Enter your Image")]
        public string Image { get; set; }
    }
}

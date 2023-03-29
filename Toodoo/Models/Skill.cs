using System.ComponentModel.DataAnnotations;

namespace portfolio005.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter your Skillpercentage")]
        public string Percentage { get; set; }
    }
}

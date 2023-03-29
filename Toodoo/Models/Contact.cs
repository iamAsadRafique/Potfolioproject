using System.ComponentModel.DataAnnotations;

namespace portfolio005.Models
{
    //this is the contact model file.
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter your Name")]
        public string Name { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Enter your Name")]
        public string Email { get; set; }
        public string? Message{ get; set; }
        [Required(ErrorMessage = "Enter your Subject")]
        public string Subject { get; set; }
    }
}

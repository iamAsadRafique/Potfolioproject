using System.ComponentModel.DataAnnotations;

namespace portfolio005.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter your little bit Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please Enter your DoB")]
        public string DoB { get; set; }
        [Required(ErrorMessage = "Please Enter your Age")]
        public int Age{ get; set; }
        public string? Website { get; set; }
        [Required(ErrorMessage = "Please Enter your Degree Name")]
        public string Degree { get; set; }
        [Required(ErrorMessage = "Please Enter your phone number")]
        public string phone{ get; set; }
        [EmailAddress]
        [Required(ErrorMessage ="please enter Email")]
        public string Email { get; set; }
        public string city { get; set; }
        [Required(ErrorMessage = "Please Enter your CityName")]
        public string? freelance { get; set; }
        [Required(ErrorMessage = "Please Enter your file")]

        public string Image { get; set; }
        public string? UserName { get; set; }
        [DataType(DataType.Password)]
        public string? PassWord  { get; set; }

    }
}

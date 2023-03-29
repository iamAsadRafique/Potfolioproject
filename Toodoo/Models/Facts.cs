using System.ComponentModel.DataAnnotations;

namespace portfolio005.Models
{
    public class Facts
    {
        [Key]
        public int Id{ get; set; }
        [MaxLength(400)]
        [Required(ErrorMessage ="Please Enter little bit Description should be under 400 character")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Enter your ClientName")]
        public int HappyClients { get; set;}
        [Required(ErrorMessage = "Enter yours  projectName")]
        public int Project { get; set; }
        [Required(ErrorMessage = "Enter your Hourse of Support")]
        public int HourOfSupport { get; set; }
        [Required(ErrorMessage = "Enter your Awards")]
        public int Awards { get; set; }
    }
}

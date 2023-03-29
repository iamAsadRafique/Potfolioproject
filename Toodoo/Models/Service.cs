using System.ComponentModel.DataAnnotations;

namespace portfolio005.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter your ServiceName")]
        public string ServiceName { get; set; }
        [Required(ErrorMessage = "Enter your serviceDescription")]
        public string ServiceDescription { get; set; }
        [Required(ErrorMessage = "Enter your colourcode")]
        public string ColorCode { get; set; }
    }
}

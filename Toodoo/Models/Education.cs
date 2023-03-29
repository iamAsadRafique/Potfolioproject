using System.ComponentModel.DataAnnotations;

namespace portfolio005.Models
{
    public class Education
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter your Degree NAME")]
        public string Degree{ get; set; }

        [Required(ErrorMessage = "Please Enter your StartYear")]
        public int Startyear { get; set; }

        [Required(ErrorMessage = "Please Enter your End year")]
        public int Endyear { get; set; }
        [Required(ErrorMessage = "Please Enter your INSTITUTE NAME")]
        public string Institute { get; set; }
        [MaxLength(400, ErrorMessage="Please Too long it should be under 400 words" )]
        public string Description { get; set; }
    }
}

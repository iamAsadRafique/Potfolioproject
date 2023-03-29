using System.ComponentModel.DataAnnotations;

namespace portfolio005.ViewModel
{
    public class AboutVM
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DoB { get; set; }
        public int Age { get; set; }
        public string Website { get; set; }
        public string Degree { get; set; }
        public string phone { get; set; }
        public string Email { get; set; }
        public string city { get; set; }
        public string freelance { get; set; }
        public IFormFile Image { get; set; }
    }
}


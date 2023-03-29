using System.ComponentModel.DataAnnotations;

namespace portfolio005.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Please Enter Username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter PassWord")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

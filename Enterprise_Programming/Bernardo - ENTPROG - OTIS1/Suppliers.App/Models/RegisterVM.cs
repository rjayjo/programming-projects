using System.ComponentModel.DataAnnotations;

namespace Suppliers.App.Models
{
    public class RegisterVM
    {
        public RegisterVM()
        {
            UserName = "";
            Email = "";
            Password = "";
            ConfirmPassword = "";
        }
        
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match!")]
        public string ConfirmPassword { get; set; }
    }
}

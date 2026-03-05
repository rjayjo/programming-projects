using System.ComponentModel.DataAnnotations;

namespace Suppliers.App.Models
{
    public class SignInVM
    {
        public SignInVM()
        {
            UserName ="";
            Password ="";
            ReturnUrl = "";

        }
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public string ReturnUrl { get; set; }

    }
}

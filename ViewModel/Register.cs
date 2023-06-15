using System.ComponentModel.DataAnnotations;

namespace Asp_Identity.ViewModel
{
    public class Register
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage ="Did not match Password")]
        public string ConfirmPassword { get; set; }
    }
}

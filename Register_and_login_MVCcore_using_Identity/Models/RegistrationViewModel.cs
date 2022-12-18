using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Register_and_login_MVCcore_using_Identity.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [StringLength(15, MinimumLength = 3)]
        //[StringLength(15, ErrorMessage = "Name length can't be more than 15.")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Mobile no not valid")]
        public string Mobile { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        [NotMapped] // Does not effect with your database
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Register_and_login_MVCcore_using_Identity.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 6)]
        public string Password { get; set; }
    }
}

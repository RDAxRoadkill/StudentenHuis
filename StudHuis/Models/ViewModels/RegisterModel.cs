using System.ComponentModel.DataAnnotations;

namespace StudHuis.Models.ViewModels
{
    public class RegisterModel
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }

        public string ReturnUrl { get; set; } = "/";
    }
}
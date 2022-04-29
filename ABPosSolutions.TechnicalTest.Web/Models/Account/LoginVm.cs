using System.ComponentModel.DataAnnotations;

namespace ABPosSolutions.TechnicalTest.Web.Models.Account
{
    public class LoginVm
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} is required")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Password")]
        [StringLength(50, ErrorMessage = "{0} must be at least {2} characters long", MinimumLength = 5)]
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}

using System.ComponentModel.DataAnnotations;

namespace ABPosSolutions.TechnicalTest.Web.Models.Account
{
    public class RegisterVm
    {
        [Display(Name ="Name")]
        [Required(ErrorMessage ="{0} is required")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "LastName")]
        [Required(ErrorMessage = "{0} is required")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} is required")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Password")]
        [StringLength(50,ErrorMessage = "{0} must be at least {2} characters long", MinimumLength = 5)]
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Password")]
        [Compare("Password", ErrorMessage = "Password and Confirmation do not match")]
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}

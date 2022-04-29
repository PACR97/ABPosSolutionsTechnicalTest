using System.ComponentModel.DataAnnotations;

namespace ABPosSolutions.TechnicalTest.Web.Models
{
    public class CreateBuildingDto
    {
        public string? Id { get; set; }
        [Required(ErrorMessage ="{0} is required")]
        [Display(Name ="Name")]
        public string? BuildingName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }
    }
}

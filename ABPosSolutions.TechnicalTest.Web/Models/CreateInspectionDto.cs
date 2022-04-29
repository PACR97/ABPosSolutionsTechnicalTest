using System.ComponentModel.DataAnnotations;

namespace ABPosSolutions.TechnicalTest.Web.Models
{
    public class CreateInspectionDto
    {
        [Required(ErrorMessage ="{0} is required")]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "InspectionType")]
        public string? InspectionTypeId { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "Status")]
        public string? StatusId { get; set; }
        public DateTimeOffset Date { get; set; } = DateTimeOffset.Now;
    }
}

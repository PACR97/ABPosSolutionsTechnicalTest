using ABPosSolutions.TechnicalTest.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ABPosSolutions.TechnicalTest.Web.Models
{
    public class CreateInspectionVm
    {
        public CreateInspectionDto Input { get; set; } = new CreateInspectionDto();
        public List<Status> Statuses { get; set; } = new List<Status>();
        public List<InspectionType> InspectionTypes { get; set; } = new List<InspectionType>();

        public SelectList SatusSelectList() => new(Statuses, "Id", "StatusName");

        public SelectList InspectionTypesSelectList() => new(InspectionTypes, "Id", "TypeName");
    }
}

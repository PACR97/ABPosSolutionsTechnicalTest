using ABPosSolutions.TechnicalTest.Application.Common;
using ABPosSolutions.TechnicalTest.Domain;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Commands.CreateInspection
{
    public class CreateInspectionCommand : CommandBase<Inspection>
    {
        public string? Description { get; set; }

        public string? InspectionTypeId { get; set; }
        public string? StatusId { get; set; }
        public string? UserId { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}

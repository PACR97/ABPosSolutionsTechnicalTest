using ABPosSolutions.TechnicalTest.Domain.Common;

namespace ABPosSolutions.TechnicalTest.Domain
{
    public class Inspection : BaseDomainModel
    {
        public string? Description { get; set; }

        public string? InspectionTypeId { get; set; }
        public InspectionType? InspectionType { get; set; }

        public string? StatusId { get; set; }
        public Status? Status { get; set; }

        public string? UserId { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}

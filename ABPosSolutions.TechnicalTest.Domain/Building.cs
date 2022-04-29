using ABPosSolutions.TechnicalTest.Domain.Common;

namespace ABPosSolutions.TechnicalTest.Domain
{
    public class Building : BaseDomainModel
    {
        public string? BuildingName { get; set; }
        public string? Address { get; set; }
        public List<InspectionType>? InspectionTypes { get; set; }
    }
}

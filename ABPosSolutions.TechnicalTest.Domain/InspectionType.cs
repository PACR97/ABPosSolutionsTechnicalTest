using ABPosSolutions.TechnicalTest.Domain.Common;

namespace ABPosSolutions.TechnicalTest.Domain
{
    public class InspectionType : BaseDomainModel
    {
        public string? TypeName { get; set; }

        public string? BuildingId { get; set; }
        public Building? Building { get; set; }

        public List<Inspection>? Inspections { get; set; }
    }
}

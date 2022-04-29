using ABPosSolutions.TechnicalTest.Domain.Common;

namespace ABPosSolutions.TechnicalTest.Domain
{
    public class Status : BaseDomainModel
    {
        public string? StatusName { get; set; }

        public List<Inspection>? Inspections { get; set; }
    }
}

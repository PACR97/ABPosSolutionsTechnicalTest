using ABPosSolutions.TechnicalTest.Application.Common;
using ABPosSolutions.TechnicalTest.Common.Outputs;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetTotalInspections
{
    public class GetTotalInspectionsQuery : QueryBase<TotalInspectionsResponse>
    {
        public string SatusId { get; set; } = string.Empty;
    }
}

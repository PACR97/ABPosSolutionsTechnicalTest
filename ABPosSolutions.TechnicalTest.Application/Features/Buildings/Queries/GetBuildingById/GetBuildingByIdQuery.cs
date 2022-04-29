using ABPosSolutions.TechnicalTest.Application.Common;
using ABPosSolutions.TechnicalTest.Domain;

namespace ABPosSolutions.TechnicalTest.Application.Features.Buildings.Queries.GetBuildingById
{
    public class GetBuildingByIdQuery : QueryBase<Building>
    {
        public string Id { get; set; } = string.Empty;
    }
}

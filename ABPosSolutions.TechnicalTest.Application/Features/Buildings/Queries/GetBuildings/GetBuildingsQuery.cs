using ABPosSolutions.TechnicalTest.Application.Common;
using ABPosSolutions.TechnicalTest.Domain;

namespace ABPosSolutions.TechnicalTest.Application.Features.Buildings.Queries.GetBuildings
{
    public class GetBuildingsQuery : QueryBase<List<Building>>
    {
        public string? BuildingName { get; set; }
        public string? Address { get; set; }
    }
}

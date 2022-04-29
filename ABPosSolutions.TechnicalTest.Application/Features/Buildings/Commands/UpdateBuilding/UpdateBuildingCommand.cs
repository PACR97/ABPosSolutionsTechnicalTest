using ABPosSolutions.TechnicalTest.Application.Common;
using ABPosSolutions.TechnicalTest.Domain;

namespace ABPosSolutions.TechnicalTest.Application.Features.Buildings.Commands.UpdateBuilding
{
    public class UpdateBuildingCommand : CommandBase<Building>
    {
        public string BuildingId { get; set; } = String.Empty;
        public string? BuildingName { get; set; }
        public string? Address { get; set; }
    }
}

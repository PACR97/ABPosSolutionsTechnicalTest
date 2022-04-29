using ABPosSolutions.TechnicalTest.Application.Common;

namespace ABPosSolutions.TechnicalTest.Application.Features.Buildings.Commands.RemoveBuilding
{
    public class RemoveBuildingCommand : CommandBase
    {
        public string BuildingId { get; set; } = string.Empty;
    }
}

using ABPosSolutions.TechnicalTest.Application.Common;
using ABPosSolutions.TechnicalTest.Domain;

namespace ABPosSolutions.TechnicalTest.Application.Features.Buildings.Commands.CreateBuilding
{
    public class CreateBuildingCommand : CommandBase<Building>
    {
        public string? BuildingName { get; set; }
        public string? Address { get; set; }
    }
}

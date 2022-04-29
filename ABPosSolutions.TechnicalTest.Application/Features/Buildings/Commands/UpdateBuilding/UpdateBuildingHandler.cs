using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Domain;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ABPosSolutions.TechnicalTest.Application.Features.Buildings.Commands.UpdateBuilding
{
    public class UpdateBuildingHandler : BuildingBaseHandler, IRequestHandler<UpdateBuildingCommand, Building>
    {
        public UpdateBuildingHandler(IBuildingRepo repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Building> Handle(UpdateBuildingCommand request, CancellationToken cancellationToken)
        {
            Building building = await GetBuildingAsync(request.BuildingId);
            mapper.Map(request, building);
            Building buildingUpdate = repo.UpdateAsync(building);
            await repo.SaveChangesAsync();
            return buildingUpdate;
        }
    }
}

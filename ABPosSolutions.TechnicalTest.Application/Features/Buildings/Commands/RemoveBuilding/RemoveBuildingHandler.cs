using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Domain;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ABPosSolutions.TechnicalTest.Application.Features.Buildings.Commands.RemoveBuilding
{
    public class RemoveBuildingHandler : BuildingBaseHandler, IRequestHandler<RemoveBuildingCommand>
    {
        public RemoveBuildingHandler(IBuildingRepo repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Unit> Handle(RemoveBuildingCommand request, CancellationToken cancellationToken)
        {
            Building building = await GetBuildingAsync(request.BuildingId);
            repo.DeleteAsync(building);
            await repo.SaveChangesAsync();
            return new Unit();
        }
    }
}

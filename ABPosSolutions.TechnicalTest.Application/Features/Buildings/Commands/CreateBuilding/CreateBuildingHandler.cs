using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Domain;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ABPosSolutions.TechnicalTest.Application.Features.Buildings.Commands.CreateBuilding
{
    public class CreateBuildingHandler : BuildingBaseHandler, IRequestHandler<CreateBuildingCommand, Building>
    {
        public CreateBuildingHandler(IBuildingRepo repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Building> Handle(CreateBuildingCommand request, CancellationToken cancellationToken)
        {
            var building = mapper.Map<Building>(request);
            building = await repo.AddAsync(building);
            await repo.SaveChangesAsync();
            return building;
        }
    }
}

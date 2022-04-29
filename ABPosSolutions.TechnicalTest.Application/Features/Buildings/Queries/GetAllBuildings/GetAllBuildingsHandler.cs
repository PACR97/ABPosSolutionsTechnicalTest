using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Domain;
using MediatR;

namespace ABPosSolutions.TechnicalTest.Application.Features.Buildings.Queries.GetAllBuildings
{
    public class GetAllBuildingsHandler : IRequestHandler<GetAllBuildingsQuery, List<Building>>
    {
        private readonly IBuildingRepo repo;

        public GetAllBuildingsHandler(IBuildingRepo repo)
        {
            this.repo = repo;
        }

        public async Task<List<Building>> Handle(GetAllBuildingsQuery request, CancellationToken cancellationToken)
        {
            return await repo.GetAllAsync();
        }
    }
}

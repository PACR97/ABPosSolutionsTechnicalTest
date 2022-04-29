using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Application.Exceptions;
using ABPosSolutions.TechnicalTest.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPosSolutions.TechnicalTest.Application.Features.Buildings.Queries.GetBuildingById
{
    public class GetBuildingByIdHandler : IRequestHandler<GetBuildingByIdQuery, Building>
    {
        private readonly IBuildingRepo repo;

        public GetBuildingByIdHandler(IBuildingRepo repo)
        {
            this.repo = repo;
        }

        public async Task<Building> Handle(GetBuildingByIdQuery request, CancellationToken cancellationToken)
        {
            Building? building = await repo.GetByIdAsync(request.Id);
            if (building == null)
            {
                throw new NotFoundException(nameof(building), request.Id);
            }
            return building;
        }
    }
}

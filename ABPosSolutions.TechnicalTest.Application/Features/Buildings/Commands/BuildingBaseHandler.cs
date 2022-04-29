using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Application.Exceptions;
using ABPosSolutions.TechnicalTest.Domain;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ABPosSolutions.TechnicalTest.Application.Features.Buildings.Commands
{
    public class BuildingBaseHandler
    {
        protected readonly IBuildingRepo repo;
        protected readonly IMapper mapper;

        public BuildingBaseHandler(IBuildingRepo repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        protected async Task<Building> GetBuildingAsync(string id)
        {
            Building? building = await repo.GetByIdAsync(id);
            if (building == null)
                throw new NotFoundException(nameof(building), id);
            return building;
        }
    }
}

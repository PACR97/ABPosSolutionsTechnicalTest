using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Application.Exceptions;
using ABPosSolutions.TechnicalTest.Domain;
using AutoMapper;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections
{
    public class BaseInspectionHandler
    {
        protected readonly IInspectionRepo repo;
        protected readonly IMapper mapper;

        public BaseInspectionHandler(IInspectionRepo repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        protected async Task<Inspection> GetInspectionAsync(string id)
        {
            Inspection? inspection = await repo.GetByIdAsync(id);
            if (inspection == null)
                throw new NotFoundException(nameof(inspection), id);
            return inspection;
        }
    }
}

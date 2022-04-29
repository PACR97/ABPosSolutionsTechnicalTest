using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Domain;
using AutoMapper;
using MediatR;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Commands.CreateInspection
{
    public class CreateInspectionHandler : BaseInspectionHandler, IRequestHandler<CreateInspectionCommand, Inspection>
    {
        public CreateInspectionHandler(IInspectionRepo repo, IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task<Inspection> Handle(CreateInspectionCommand request, CancellationToken cancellationToken)
        {
            Inspection inspection = mapper.Map<Inspection>(request);
            inspection = await repo.AddAsync(inspection);
            await repo.SaveChangesAsync();
            return inspection;
        }
    }
}

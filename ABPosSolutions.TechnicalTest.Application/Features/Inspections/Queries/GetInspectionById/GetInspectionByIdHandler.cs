using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Application.Exceptions;
using ABPosSolutions.TechnicalTest.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetInspectionById
{
    public class GetInspectionByIdHandler : IRequestHandler<GetInspectionByIdQuery, Inspection>
    {
        private readonly IInspectionRepo repo;

        public GetInspectionByIdHandler(IInspectionRepo repo)
        {
            this.repo = repo;
        }

        public async Task<Inspection> Handle(GetInspectionByIdQuery request, CancellationToken cancellationToken)
        {
            Inspection? inspection = await repo.GetByIdAsync(request.Id);
            if (inspection == null) throw new NotFoundException(nameof(inspection), request.Id);

            return inspection;
        }
    }
}

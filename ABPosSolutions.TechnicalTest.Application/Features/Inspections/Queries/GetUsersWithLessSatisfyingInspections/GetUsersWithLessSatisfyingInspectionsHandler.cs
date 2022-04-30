using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Common.Outputs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetUsersWithLessSatisfyingInspections
{
    public class GetUsersWithLessSatisfyingInspectionsHandler : IRequestHandler<GetUsersWithLessSatisfyingInspectionsQuery, List<UsersWithInspectionsCountOutputDto>>
    {
        private readonly IInspectionRepo repo;

        public GetUsersWithLessSatisfyingInspectionsHandler(IInspectionRepo repo)
        {
            this.repo = repo;
        }

        public async Task<List<UsersWithInspectionsCountOutputDto>> Handle(GetUsersWithLessSatisfyingInspectionsQuery request, CancellationToken cancellationToken)
        {
            return await repo.GetUsersWithLessSatisfyingInspections(request.StatusId);
        }
    }
}

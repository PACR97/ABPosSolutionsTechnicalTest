using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Common.Outputs;
using MediatR;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetUsersWithMoreSatisfyingInspections
{
    public class GetUsersWithMoreSatisfyingInspectionsHandler : IRequestHandler<GetUsersWithMoreSatisfyingInspectionsQuery, List<UsersWithInspectionsCountOutputDto>>
    {
        private readonly IInspectionRepo repo;

        public GetUsersWithMoreSatisfyingInspectionsHandler(IInspectionRepo repo)
        {
            this.repo = repo;
        }

        public async Task<List<UsersWithInspectionsCountOutputDto>> Handle(GetUsersWithMoreSatisfyingInspectionsQuery request, CancellationToken cancellationToken)
        {
            return await repo.GetUsersWithMoreSatisfyingInspections(request.StatusId);
        }
    }
}

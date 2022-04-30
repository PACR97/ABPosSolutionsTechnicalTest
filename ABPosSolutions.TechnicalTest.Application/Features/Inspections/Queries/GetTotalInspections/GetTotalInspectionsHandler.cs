using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Common.Outputs;
using MediatR;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetTotalInspections
{
    public class GetTotalInspectionsHandler : IRequestHandler<GetTotalInspectionsQuery, TotalInspectionsResponse>
    {
        private readonly IInspectionRepo repo;

        public GetTotalInspectionsHandler(IInspectionRepo repo)
        {
            this.repo = repo;
        }

        public async Task<TotalInspectionsResponse> Handle(GetTotalInspectionsQuery request, CancellationToken cancellationToken)
        {
            int totalInspections = await repo.TotalInspections(request.SatusId);
            return new TotalInspectionsResponse
            {
                TotalInspections = totalInspections,
            };
        }
    }
}

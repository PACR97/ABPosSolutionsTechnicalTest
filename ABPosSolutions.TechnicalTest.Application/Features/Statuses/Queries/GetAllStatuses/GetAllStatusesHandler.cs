using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Domain;
using MediatR;

namespace ABPosSolutions.TechnicalTest.Application.Features.Statuses.Queries.GetAllStatuses
{
    public class GetAllStatusesHandler : IRequestHandler<GetAllStatusesQuery, List<Status>>
    {
        private readonly IStatusRepo repo;

        public GetAllStatusesHandler(IStatusRepo repo)
        {
            this.repo = repo;
        }

        public async Task<List<Status>> Handle(GetAllStatusesQuery request, CancellationToken cancellationToken)
        {
            return await repo.GetAllAsync();
        }
    }
}

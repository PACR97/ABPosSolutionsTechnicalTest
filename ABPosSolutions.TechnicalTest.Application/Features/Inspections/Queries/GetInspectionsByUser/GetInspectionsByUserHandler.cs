using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Domain;
using MediatR;
using System;
using System.Linq.Expressions;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetInspectionsByUser
{
    public class GetInspectionsByUserHandler : IRequestHandler<GetInspectionsByUserQuery, List<Inspection>>
    {
        private readonly IInspectionRepo repo;

        public GetInspectionsByUserHandler(IInspectionRepo repo)
        {
            this.repo = repo;
        }

        public async Task<List<Inspection>> Handle(GetInspectionsByUserQuery request, CancellationToken cancellationToken)
        {
            List<Expression<Func<Inspection, object>>> listIncludes = new List<Expression<Func<Inspection, object>>>();
            listIncludes.Add(x => x.InspectionType!);
            listIncludes.Add(x => x.Status!);
            listIncludes.Add(x => x.InspectionType!.Building!);
            var c = await repo.GetAsync(x => x.UserId == request.UserId, null, listIncludes);
            return c;
        }
    }
}

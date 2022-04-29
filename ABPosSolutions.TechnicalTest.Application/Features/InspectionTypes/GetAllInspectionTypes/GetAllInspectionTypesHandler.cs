using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ABPosSolutions.TechnicalTest.Application.Features.InspectionTypes.GetAllInspectionTypes
{
    public class GetAllInspectionTypesHandler : IRequestHandler<GetAllInspectionTypesQuery, List<InspectionType>>
    {
        private readonly IInspectionTypeRepo repo;

        public GetAllInspectionTypesHandler(IInspectionTypeRepo repo)
        {
            this.repo = repo;
        }

        public async Task<List<InspectionType>> Handle(GetAllInspectionTypesQuery request, CancellationToken cancellationToken)
        {
            List<Expression<Func<InspectionType, object>>> list = new();
            list.Add(x => x.Inspections!);
            list.Add(x => x.Building!);
            return await repo.GetAsync(null, null, list);
        }
    }
}

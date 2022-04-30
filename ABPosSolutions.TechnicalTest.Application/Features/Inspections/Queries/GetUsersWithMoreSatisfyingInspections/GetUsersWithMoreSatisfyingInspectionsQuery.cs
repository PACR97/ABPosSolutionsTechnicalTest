using ABPosSolutions.TechnicalTest.Application.Common;
using ABPosSolutions.TechnicalTest.Common.Outputs;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetUsersWithMoreSatisfyingInspections
{
    public class GetUsersWithMoreSatisfyingInspectionsQuery : QueryBase<List<UsersWithInspectionsCountOutputDto>>
    {
        public string StatusId { get; set; } = string.Empty;
    }
}

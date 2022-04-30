using ABPosSolutions.TechnicalTest.Application.Common;
using ABPosSolutions.TechnicalTest.Common.Outputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetUsersWithLessSatisfyingInspections
{
    public class GetUsersWithLessSatisfyingInspectionsQuery : QueryBase<List<UsersWithInspectionsCountOutputDto>>
    {
        public string StatusId { get; set; } = string.Empty;
    }
}

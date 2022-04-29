using ABPosSolutions.TechnicalTest.Application.Common;
using ABPosSolutions.TechnicalTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetInspectionsByUser
{
    public class GetInspectionsByUserQuery : QueryBase<List<Inspection>>
    {
        public string UserId { get; set; } = string.Empty;
    }
}

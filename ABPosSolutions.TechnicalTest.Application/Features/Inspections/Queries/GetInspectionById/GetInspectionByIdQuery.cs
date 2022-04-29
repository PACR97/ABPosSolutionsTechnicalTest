using ABPosSolutions.TechnicalTest.Application.Common;
using ABPosSolutions.TechnicalTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPosSolutions.TechnicalTest.Application.Features.Inspections.Queries.GetInspectionById
{
    public class GetInspectionByIdQuery : QueryBase<Inspection>
    {
        public string Id { get; set; } = string.Empty;
    }
}

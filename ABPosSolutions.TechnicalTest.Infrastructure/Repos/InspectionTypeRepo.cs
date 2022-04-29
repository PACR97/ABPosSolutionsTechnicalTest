using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Domain;
using ABPosSolutions.TechnicalTest.Infrastructure.Persistence;

namespace ABPosSolutions.TechnicalTest.Infrastructure.Repos
{
    public class InspectionTypeRepo : BaseRepo<string, InspectionType>, IInspectionTypeRepo
    {
        public InspectionTypeRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}

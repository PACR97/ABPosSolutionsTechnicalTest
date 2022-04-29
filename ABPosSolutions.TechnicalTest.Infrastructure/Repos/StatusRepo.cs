using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Domain;
using ABPosSolutions.TechnicalTest.Infrastructure.Persistence;

namespace ABPosSolutions.TechnicalTest.Infrastructure.Repos
{
    public class StatusRepo : BaseRepo<string, Status>, IStatusRepo
    {
        public StatusRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}

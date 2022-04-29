using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Domain;
using ABPosSolutions.TechnicalTest.Infrastructure.Persistence;

namespace ABPosSolutions.TechnicalTest.Infrastructure.Repos
{
    public class BuildingRepo : BaseRepo<string, Building>, IBuildingRepo
    {
        public BuildingRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}

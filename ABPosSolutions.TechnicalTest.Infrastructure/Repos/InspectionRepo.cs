using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Common.Outputs;
using ABPosSolutions.TechnicalTest.Domain;
using ABPosSolutions.TechnicalTest.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ABPosSolutions.TechnicalTest.Infrastructure.Repos
{
    public class InspectionRepo : BaseRepo<string, Inspection>, IInspectionRepo
    {
        public InspectionRepo(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<UsersWithInspectionsCountOutputDto>> GetUsersWithLessSatisfyingInspections(string statusId)
        {
            List<UsersWithInspectionsCountOutputDto> inspections = await context.Inspections!.GroupBy(x => x.UserId, (userId, inspections) => new UsersWithInspectionsCountOutputDto
            {
                UserId = userId,
                QuantityInspections = inspections.Where(x => x.StatusId == statusId).Count(),
            }).ToListAsync();

            return inspections.OrderBy(x => x.QuantityInspections).Take(3).ToList();
        }

        public async Task<List<UsersWithInspectionsCountOutputDto>> GetUsersWithMoreSatisfyingInspections(string statusId)
        {
            List<UsersWithInspectionsCountOutputDto> inspections = await context.Inspections!.GroupBy(x => x.UserId, (userId, inspections) => new UsersWithInspectionsCountOutputDto
            {
                UserId = userId,
                QuantityInspections = inspections.Where(x => x.StatusId == statusId).Count(),
            }).ToListAsync();

            return inspections.OrderByDescending(x => x.QuantityInspections).Take(3).ToList();
        }

        public Task<int> TotalInspections(string statusId)
        {
            return context.Inspections.CountAsync(x => x.StatusId == statusId);
        }
    }
}

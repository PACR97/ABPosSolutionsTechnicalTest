using ABPosSolutions.TechnicalTest.Common.Outputs;
using ABPosSolutions.TechnicalTest.Domain;

namespace ABPosSolutions.TechnicalTest.Application.Contracts.Persistence
{
    public interface IInspectionRepo : IBaseRepo<string, Inspection>
    {
        Task<int> TotalInspections(string statusId);
        Task<List<UsersWithInspectionsCountOutputDto>> GetUsersWithMoreSatisfyingInspections(string statusId);
        Task<List<UsersWithInspectionsCountOutputDto>> GetUsersWithLessSatisfyingInspections(string statusId);
    }
}

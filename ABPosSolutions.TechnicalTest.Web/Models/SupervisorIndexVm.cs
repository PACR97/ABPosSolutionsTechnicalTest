using ABPosSolutions.TechnicalTest.Common.Outputs;

namespace ABPosSolutions.TechnicalTest.Web.Models
{
    public class SupervisorIndexVm
    {
        public TotalInspectionsResponse TotalSatisfactory { get; set; } = new TotalInspectionsResponse();
        public TotalInspectionsResponse TotalUnsatisfactory { get; set; } = new TotalInspectionsResponse();
        public List<UsersWithInspectionsCountOutputDto> UsersWithLessSatisfyingInspections { get; set; } = new List<UsersWithInspectionsCountOutputDto>();
        public List<UsersWithInspectionsCountOutputDto> UsersWithMoreSatisfyingInspections { get; set; } = new List<UsersWithInspectionsCountOutputDto>();
    }
}

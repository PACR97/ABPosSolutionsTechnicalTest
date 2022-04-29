namespace ABPosSolutions.TechnicalTest.Application.Contracts
{
    public interface ICurrentUserService
    {
        CurrentUser User { get; }
        bool IsInRole(string roleName);
    }

    public record CurrentUser(string Id, string UserName, bool IsAuthenticatedUser);
}

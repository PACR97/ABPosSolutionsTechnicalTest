using ABPosSolutions.TechnicalTest.Application.Contracts;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace ABPosSolutions.TechnicalTest.Infrastructure.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor? _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor? httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            if (_httpContextAccessor is null || _httpContextAccessor.HttpContext is null)
            {
                User = new CurrentUser(Guid.Empty.ToString(), String.Empty, false);
                return;
            }

            // El Http Request existe pero es un usuario no autenticado
            var httpContext = _httpContextAccessor.HttpContext;
            if (!httpContext!.User!.Identity!.IsAuthenticated)
            {
                User = new CurrentUser(Guid.Empty.ToString(), String.Empty, false);
                return ;
            }
            var id = _httpContextAccessor!.HttpContext!.User!.FindFirst(ClaimTypes.NameIdentifier)!.Value;

            var userName = _httpContextAccessor!.HttpContext!.User!.Identity!.Name ?? "Unknown";

            User = new CurrentUser(id, userName, true);
        }

        public CurrentUser User { get; }

        public bool IsInRole(string roleName) =>
        _httpContextAccessor!.HttpContext!.User.IsInRole(roleName);
    }
}

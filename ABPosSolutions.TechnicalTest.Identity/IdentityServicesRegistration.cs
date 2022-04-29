using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ABPosSolutions.TechnicalTest.Identity
{
    public static class IdentityServicesRegistration
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationIdentityDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("Identity")));

            services.AddIdentity<IdentityUser, IdentityRole>(opt =>
             {
                 opt.SignIn.RequireConfirmedAccount = false;
             }).AddEntityFrameworkStores<ApplicationIdentityDbContext>();

            services.ConfigureApplicationCookie(opt =>
            {
                opt.Cookie.HttpOnly = true;
                opt.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                opt.LoginPath = "/Identity/Account/Login";
                opt.LogoutPath = "/Identity/Account/Logout";
                opt.AccessDeniedPath = "/Identity/Account/AccessDenied";
                opt.SlidingExpiration = true;
            });
            return services;
        }
    }
}

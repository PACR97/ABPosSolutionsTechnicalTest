using ABPosSolutions.TechnicalTest.Application.Contracts;
using ABPosSolutions.TechnicalTest.Application.Contracts.Persistence;
using ABPosSolutions.TechnicalTest.Infrastructure.Persistence;
using ABPosSolutions.TechnicalTest.Infrastructure.Repos;
using ABPosSolutions.TechnicalTest.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ABPosSolutions.TechnicalTest.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("ApplicationConnection")));
            services.AddScoped<IBuildingRepo, BuildingRepo>();
            services.AddScoped<IInspectionRepo,InspectionRepo>();
            services.AddScoped<IInspectionTypeRepo,InspectionTypeRepo>();
            services.AddScoped<IStatusRepo, StatusRepo>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            return services;
        }
    }
}

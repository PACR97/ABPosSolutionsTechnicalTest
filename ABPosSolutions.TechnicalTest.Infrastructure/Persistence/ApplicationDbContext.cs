using ABPosSolutions.TechnicalTest.Application.Contracts;
using ABPosSolutions.TechnicalTest.Domain;
using ABPosSolutions.TechnicalTest.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace ABPosSolutions.TechnicalTest.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        private readonly CurrentUser _currentUser;
        public ApplicationDbContext(DbContextOptions options, ICurrentUserService currentUserService) : base(options)
        {
            _currentUser = currentUserService.User;
        }

        public DbSet<Inspection>? Inspections { get; set; }
        public DbSet<Building>? Buildings { get; set; }
        public DbSet<InspectionType>? InspectionTypes { get; set; }
        public DbSet<Status>? Statuses { get; set; }


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainModel>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUser.Id;
                        entry.Entity.CreatedDate = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUser.Id;
                        entry.Entity.LastModifiedDate = DateTime.UtcNow;
                        break;
                    default:
                        break;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            b.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}

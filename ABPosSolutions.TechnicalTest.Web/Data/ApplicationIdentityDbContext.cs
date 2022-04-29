using ABPosSolutions.TechnicalTest.Web.Data.Seed;
using ABPosSolutions.TechnicalTest.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ABPosSolutions.TechnicalTest.Web.Data
{
    public class ApplicationIdentityDbContext : IdentityDbContext
    {
        public ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser>? ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new SeedRoles());
            builder.ApplyConfiguration(new SeedUsers());
            builder.ApplyConfiguration(new SeedUserRole());
        }
    }
}
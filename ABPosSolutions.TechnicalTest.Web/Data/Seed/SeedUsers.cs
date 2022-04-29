using ABPosSolutions.TechnicalTest.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPosSolutions.TechnicalTest.Web.Data.Seed
{
    public class SeedUsers : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "5895cd79-0c1d-43f1-b2d6-fb2509c5c1a0",
                    Email = "inspector@localhost.com",
                    NormalizedEmail = "inspector@localhost.com",
                    Name = "Inspector",
                    LastName = "Inspector",
                    UserName = "inspector@localhost.com",
                    NormalizedUserName = "inspector@localhost.com",
                    PasswordHash = hasher.HashPassword(null, "Inspector123$"),
                    EmailConfirmed = false,
                },
                new ApplicationUser
                {
                    Id = "d9d25759-2db6-4a02-80a4-dde2a685a196",
                    Email = "supervisor@localhost.com",
                    NormalizedEmail = "supervisor@localhost.com",
                    Name = "Supervisor",
                    LastName = "Supervisor",
                    UserName = "supervisor@localhost.com",
                    NormalizedUserName = "supervisor@localhost.com",
                    PasswordHash = hasher.HashPassword(null, "Supervisor123$"),
                    EmailConfirmed = false,
                },
                new ApplicationUser
                {
                    Id = "669c8f71-36b0-4342-bf34-e828a143e672",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "admin@localhost.com",
                    Name = "Administrator",
                    LastName = "Administrator",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "admin@localhost.com",
                    PasswordHash = hasher.HashPassword(null, "Admin123$"),
                    EmailConfirmed = false,
                }
            );
        }
    }
}

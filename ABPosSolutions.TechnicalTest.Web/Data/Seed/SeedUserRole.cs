using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPosSolutions.TechnicalTest.Web.Data.Seed
{
    public class SeedUserRole : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "71c1036c-3617-480a-9e6f-fec4d5ad7a89",
                    UserId = "5895cd79-0c1d-43f1-b2d6-fb2509c5c1a0"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "854fbbba-f694-43a5-a73e-96b956e74ce0",
                    UserId = "d9d25759-2db6-4a02-80a4-dde2a685a196"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "107b9d7e-7d8d-466f-bc51-db8f9c52706b",
                    UserId = "669c8f71-36b0-4342-bf34-e828a143e672"
                }
            );
        }
    }
}

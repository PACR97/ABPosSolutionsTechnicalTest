using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPosSolutions.TechnicalTest.Web.Data.Seed
{
    public class SeedRoles : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "71c1036c-3617-480a-9e6f-fec4d5ad7a89",
                    Name = "Inspector",
                    NormalizedName = "INSPECTOR"
                },
                new IdentityRole
                {
                    Id = "854fbbba-f694-43a5-a73e-96b956e74ce0",
                    Name = "Supervisor",
                    NormalizedName="SUPERVISOR"
                },
                 new IdentityRole
                 {
                     Id = "107b9d7e-7d8d-466f-bc51-db8f9c52706b",
                     Name = "Admin",
                     NormalizedName = "Admin"
                 }
            );
        }
    }
}

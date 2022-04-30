using ABPosSolutions.TechnicalTest.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPosSolutions.TechnicalTest.Infrastructure.SeedData
{
    public class SeedStatusData : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasData(
                new Status
                {
                    Id = "030CD480-A2CD-4986-B186-7281D3CE2153",
                    StatusName = "Unsatisfactory",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "d9d25759-2db6-4a02-80a4-dde2a685a196"
                },
                new Status
                {
                    Id = "9A5851E2-A057-4477-9A0F-038928B17F83",
                    StatusName = "Satisfactory",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "d9d25759-2db6-4a02-80a4-dde2a685a196"
                }
            );
        }
    }
}

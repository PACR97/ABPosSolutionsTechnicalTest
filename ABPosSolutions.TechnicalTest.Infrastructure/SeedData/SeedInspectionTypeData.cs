using ABPosSolutions.TechnicalTest.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPosSolutions.TechnicalTest.Infrastructure.SeedData
{
    public class SeedInspectionTypeData : IEntityTypeConfiguration<InspectionType>
    {
        public void Configure(EntityTypeBuilder<InspectionType> builder)
        {
            builder.HasData(
                new InspectionType
                {
                    Id = "24C2BF02-EECF-4C23-8459-43B4F0A96019",
                    TypeName = "Technical Inspection",
                    BuildingId = "3bcf902f-399e-4a52-af6d-5a30dc702fc0",
                    CreatedBy = "d9d25759-2db6-4a02-80a4-dde2a685a196",
                    CreatedDate = DateTime.UtcNow
                },
                new InspectionType
                {
                    Id = "63F6CB37-A46F-450C-A5B7-63497088E594",
                    TypeName = "Formal Inspection",
                    BuildingId = "54f97371-d8a2-4201-b076-95d5f0bcc136",
                    CreatedBy = "d9d25759-2db6-4a02-80a4-dde2a685a196",
                    CreatedDate = DateTime.UtcNow
                }
            );
        }
    }
}

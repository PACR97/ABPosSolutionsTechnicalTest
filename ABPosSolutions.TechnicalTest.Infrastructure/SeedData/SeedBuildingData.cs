using ABPosSolutions.TechnicalTest.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPosSolutions.TechnicalTest.Infrastructure.SeedData
{
    public class SeedBuildingData : IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> builder)
        {
            builder.HasData(
                new Building
                {
                    Id = "3bcf902f-399e-4a52-af6d-5a30dc702fc0",
                    BuildingName = "Building 2",
                    Address = "Building 2",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "d9d25759-2db6-4a02-80a4-dde2a685a196",
                },
                new Building
                {
                    Id = "54f97371-d8a2-4201-b076-95d5f0bcc136",
                    BuildingName = "Building 1",
                    Address = "Building 1",
                    CreatedDate = DateTime.UtcNow,
                    CreatedBy = "d9d25759-2db6-4a02-80a4-dde2a685a196",
                }
            );
        }
    }
}

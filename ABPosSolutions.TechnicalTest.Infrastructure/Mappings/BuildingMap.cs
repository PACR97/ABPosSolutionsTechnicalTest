using ABPosSolutions.TechnicalTest.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPosSolutions.TechnicalTest.Infrastructure.Mappings
{
    public class BuildingMap : IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).IsRequired().HasMaxLength(50);
            b.Property(x => x.BuildingName).IsRequired().HasMaxLength(100);
            b.Property(x => x.Address).IsRequired().HasMaxLength(200);
            b.HasMany(x => x.InspectionTypes).WithOne(x => x.Building).HasForeignKey(x => x.BuildingId);
        }
    }
}

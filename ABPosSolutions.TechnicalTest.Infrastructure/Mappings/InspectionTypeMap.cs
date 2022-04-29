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
    public class InspectionTypeMap : IEntityTypeConfiguration<InspectionType>
    {
        public void Configure(EntityTypeBuilder<InspectionType> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).IsRequired().HasMaxLength(50);
            b.Property(x => x.TypeName).IsRequired().HasMaxLength(100);
            b.Property(x => x.BuildingId).IsRequired().HasMaxLength(50);

            b.HasOne(x => x.Building).WithMany(x => x.InspectionTypes).HasForeignKey(x => x.BuildingId);
        }
    }
}

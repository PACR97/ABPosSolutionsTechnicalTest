using ABPosSolutions.TechnicalTest.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPosSolutions.TechnicalTest.Infrastructure.Mappings
{
    public class InspectionMap : IEntityTypeConfiguration<Inspection>
    {
        public void Configure(EntityTypeBuilder<Inspection> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).IsRequired().HasMaxLength(50);
            b.Property(x => x.UserId).IsRequired().HasMaxLength(50);
            b.Property(x => x.Description).IsRequired();

            b.HasOne(x => x.InspectionType).WithMany(x => x.Inspections).HasForeignKey(x => x.InspectionTypeId);
            b.HasOne(x => x.Status).WithMany(x => x.Inspections).HasForeignKey(x => x.StatusId);
        }
    }
}

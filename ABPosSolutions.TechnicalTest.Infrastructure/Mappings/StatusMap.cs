using ABPosSolutions.TechnicalTest.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABPosSolutions.TechnicalTest.Infrastructure.Mappings
{
    public class StatusMap : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> b)
        {
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).IsRequired().HasMaxLength(50);
            b.Property(x => x.StatusName).IsRequired().HasMaxLength(50);
            b.HasMany(x => x.Inspections).WithOne(x => x.Status).HasForeignKey(x => x.StatusId);
        }
    }
}

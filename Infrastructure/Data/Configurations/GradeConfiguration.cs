using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder) 
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Id).ValueGeneratedNever();
            builder.Property(g => g.Name).IsRequired().HasMaxLength(100);

        }
    }
}

using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Id).ValueGeneratedNever();
            builder.Property(g => g.Name).IsRequired().HasMaxLength(100);
            builder.Property(g => g.MonthlyPrice).HasColumnType("decimal(18,2)");

            builder.HasOne(g => g.Grade)
                   .WithMany()
                   .HasForeignKey(g => g.GradeId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class GroupTransferHistoryConfiguration : IEntityTypeConfiguration<GroupTransferHistory>
    {
        public void Configure(EntityTypeBuilder<GroupTransferHistory> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Id).ValueGeneratedNever();
            builder.Property(g => g.Reason).HasMaxLength(500);

            builder.HasOne(g => g.Student)
                   .WithMany()
                   .HasForeignKey(g => g.StudentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(g => g.FromGroup)
                   .WithMany()
                   .HasForeignKey(g => g.FromGroupId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(g => g.ToGroup)
                   .WithMany()
                   .HasForeignKey(g => g.ToGroupId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

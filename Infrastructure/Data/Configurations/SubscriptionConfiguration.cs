using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace Infrastructure.Data.Configurations
{
    public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedNever();
            builder.Property(s => s.MonthlyFee).HasColumnType("decimal(18,2)");

            builder.HasOne(s => s.Student)
                   .WithMany()
                   .HasForeignKey(s => s.StudentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.Group)
                   .WithMany()
                   .HasForeignKey(s => s.GroupId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

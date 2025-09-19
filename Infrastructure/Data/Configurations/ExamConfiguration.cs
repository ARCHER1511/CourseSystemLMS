using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Data.Configurations
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.Description).HasMaxLength(500);

            builder.HasOne(e => e.Grade)
                   .WithMany()
                   .HasForeignKey(e => e.GradeId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Group)
                   .WithMany()
                   .HasForeignKey(e => e.GroupId)
                   .OnDelete(DeleteBehavior.Restrict);


        }
    }
}

using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedNever();
            builder.Property(s => s.PublicCode).IsRequired().HasMaxLength(50);
            builder.Property(s => s.FullName).IsRequired().HasMaxLength(200);
            builder.Property(s => s.PersonalPhoneNumber).HasMaxLength(20);
            builder.Property(s => s.ParentPhoneNumber).HasMaxLength(20);

            builder.HasOne(s => s.CurrentGrade)
                   .WithMany()
                   .HasForeignKey(s => s.CurrentGradeId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.CurrentGroup)
                   .WithMany(g => g.Students)
                   .HasForeignKey(s => s.CurrentGroupId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace Infrastructure.Data.Configurations
{
    public class StudentExamScoreConfiguration : IEntityTypeConfiguration<StudentExamScore>
    {
        public void Configure(EntityTypeBuilder<StudentExamScore> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedNever();
            builder.Property(s => s.Score).HasColumnType("decimal(5,2)");

            builder.HasOne(s => s.Exam)
                   .WithMany()
                   .HasForeignKey(s => s.ExamId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.Student)
                   .WithMany()
                   .HasForeignKey(s => s.StudentId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

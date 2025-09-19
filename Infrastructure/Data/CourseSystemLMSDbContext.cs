using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class CourseSystemLMSDbContext : DbContext
    {
        public CourseSystemLMSDbContext(DbContextOptions<CourseSystemLMSDbContext> options)
            : base(options) { }
        // Define DbSets for your entities here DbSets
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupTransferHistory> GroupTransferHistories { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentExamScore> StudentExamScores { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CourseSystemLMSDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}

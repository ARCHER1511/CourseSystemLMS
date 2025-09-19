using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class CourseSystemLMSContextFactory : IDesignTimeDbContextFactory<CourseSystemLMSDbContext>
    {
        public CourseSystemLMSDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CourseSystemLMSDbContext>();

            // Use your actual connection string here
            optionsBuilder.UseSqlServer(
                "Server=.;Database=CourseSystemLMS;Trusted_Connection=True;TrustServerCertificate=True");

            return new CourseSystemLMSDbContext(optionsBuilder.Options);
        }
    }
}

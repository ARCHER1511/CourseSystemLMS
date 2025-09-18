using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
public class CourseSystemLMSDbContext : DbContext
{
public CourseSystemLMSDbContext(DbContextOptions<CourseSystemLMSDbContext> options) : base(options)
    {

    }
    // Define DbSets for your entities here DbSets
    }
    }

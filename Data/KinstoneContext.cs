
using Microsoft.EntityFrameworkCore;
using Kinston_eUniversity.Models;

namespace Kinston_eUniversity.Data
{
    public class KinstoneContext : DbContext
    {
        public KinstoneContext(DbContextOptions<KinstoneContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}

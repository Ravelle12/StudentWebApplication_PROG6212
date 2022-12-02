using Microsoft.EntityFrameworkCore;

namespace StudentWebApplication.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {}

        public DbSet<Student> Students { get; set; }
        public DbSet<ModuleSelect> ModuleSelect { get; set; }
    }
}

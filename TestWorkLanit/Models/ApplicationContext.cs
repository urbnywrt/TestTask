using Microsoft.EntityFrameworkCore;

namespace TestWorkLanit.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
             Database.EnsureCreated();
        }
    }
}

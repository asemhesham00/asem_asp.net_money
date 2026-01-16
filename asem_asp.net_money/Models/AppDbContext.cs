using Microsoft.EntityFrameworkCore;

namespace asem_asp.net_money.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson>Lessons { get; set; }
    }
}

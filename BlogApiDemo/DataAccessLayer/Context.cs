using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-O9C0BMP\\ALI; database = CoreBlogApiDB ; integrated security = true ;");
        }

        public DbSet<Employee> Employees1 { get; set; }
    }
}


using Demo.Dal.Configs;
using Microsoft.EntityFrameworkCore;

namespace Demo.Dal
{
    public class DemoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Demo05;User Id=sa;Password=713;");
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new BlogConfig());
            base.OnModelCreating(modelBuilder); 
        }

        public DbSet<StudentModel> Students { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}

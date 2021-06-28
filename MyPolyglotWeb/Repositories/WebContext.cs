using Microsoft.EntityFrameworkCore;
using PolyglotWeb.Models.DomainModels;

namespace PolyglotWeb.Repositories
{
    public class WebContext : DbContext
    {
        public DbSet<Lesson> Lesson { get; set; }

        public WebContext(DbContextOptions dbContext) : base(dbContext) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
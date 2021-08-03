using Microsoft.EntityFrameworkCore;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.DomainModels.DomainWords;

namespace MyPolyglotWeb.Repositories
{
    public class WebContext : DbContext
    {
        public DbSet<LessonDB> Lesson { get; set; }
        public DbSet<ExerciseDB> Exercise { get; set; }
        public DbSet<WordDB> Word { get; set; }

        public WebContext(DbContextOptions dbContext) : base(dbContext) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LessonDB>()
                .HasMany(x => x.Exercises)
                .WithOne(x => x.Lesson)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ExerciseDB>()
                .HasMany(x => x.EngPhrase)
                .WithOne(x => x.Exercise);

            base.OnModelCreating(modelBuilder);
        }
    }
}
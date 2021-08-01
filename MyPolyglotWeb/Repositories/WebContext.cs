using Microsoft.EntityFrameworkCore;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.DomainModels.Words;

namespace MyPolyglotWeb.Repositories
{
    public class WebContext : DbContext
    {
        public DbSet<LessonDbModel> Lesson { get; set; }
        public DbSet<ExerciseDbModel> Exercise { get; set; }
        public DbSet<WordDbModel> Word { get; set; }

        public WebContext(DbContextOptions dbContext) : base(dbContext) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LessonDbModel>()
                .HasMany(x => x.Exercises)
                .WithOne(x => x.Lesson)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ExerciseDbModel>()
                .HasMany(x => x.EngPhrase)
                .WithOne(x => x.Exercise);

            base.OnModelCreating(modelBuilder);
        }
    }
}
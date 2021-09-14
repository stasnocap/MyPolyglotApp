using Microsoft.EntityFrameworkCore;
using MyPolyglotWeb.Models.DomainModels;

namespace MyPolyglotWeb.Models
{
    public class WebContext : DbContext
    {
        public DbSet<LessonDB> Lesson { get; set; }
        public DbSet<ExerciseDB> Exercise { get; set; }
        public DbSet<UnrecognizedWordDB> UnrecognizedWord { get; set; }
        public DbSet<UserDB> User { get; set; }

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
                .HasMany(x => x.UnrecognizedWords)
                .WithOne(x => x.Exercise)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Tutorial.Configurations;
using Tutorial.Models;

namespace Tutorial
{
    public class LearnightDbContext(DbContextOptions<LearnightDbContext> options) : DbContext(options)
    {
        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<LessonEntity> Lessons { get; set; }
        public DbSet<AuthorEntity> Authors { get; set; }
        public DbSet<StudentEntity> Students { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new LessonConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}

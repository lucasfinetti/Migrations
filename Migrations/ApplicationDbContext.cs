using System.IO;
using Migrations.Models;
using Migrations.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Migrations.Models.ModelsManyToMany;

namespace Migrations
{
    public class ApplicationDbContext : DbContext
    {
        public IConfiguration _configuration;

        public ApplicationDbContext()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        public DbSet<MovieActor> MovieActor { get; set; }
        public DbSet<MovieCategory> MovieCategory { get; set; }
        public DbSet<MovieDirector> MovieDirector { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ActorMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new DirectorMap());
            modelBuilder.ApplyConfiguration(new LanguageMap());
            modelBuilder.ApplyConfiguration(new RatingMap());
            modelBuilder.ApplyConfiguration(new ReviewerMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}

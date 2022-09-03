using LocationCollector.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Security.Claims;

namespace LocationCollector.Core
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Person> People { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(b => b.Latitude)
            .HasPrecision(18, 14);

            modelBuilder.Entity<Person>()
                .Property(b => b.Longitude)
            .HasPrecision(18, 14);

        }
    }
}

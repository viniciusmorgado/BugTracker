using DonattoTech.BugTracker.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DonattoTech.BugTracker.Infrastructure.Data
{
    public class BugDbContext : DbContext
    {
        public DbSet<Bug> Bugs { get; set; }

        // Apply the configurations of the Config directory. 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = BugData; Integrated Security = SSPI");
            }
        }
    }
}

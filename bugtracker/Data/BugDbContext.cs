using bugtracker.Data.Temp;
using bugtracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace bugtracker.Data
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

        // For production only.

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = BugData; Integrated Security = SSPI");
        //    }
        // }

        // For developer enviroment only

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
		        TempString stringData = new TempString();
		        stringData.getString(optionsBuilder);
            }
        }
    }
}

using DonattoTech.BugTracker.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonattoTech.BugTracker.Infrastructure.Data.Config
{
    public class BugConfiguration : IEntityTypeConfiguration<Bug>
    {
        public void Configure(EntityTypeBuilder<Bug> builder)
        {
            builder.Property(prop => prop.Id).IsRequired();
            builder.Property(prop => prop.Type).IsRequired();
            builder.Property(prop => prop.Title).IsRequired();
            builder.Property(prop => prop.Product).IsRequired();
            builder.Property(prop => prop.Version).IsRequired();
            builder.Property(prop => prop.Description).IsRequired();
            builder.Property(prop => prop.Status).IsRequired().HasDefaultValue("Em Análise");
        }
    }
}

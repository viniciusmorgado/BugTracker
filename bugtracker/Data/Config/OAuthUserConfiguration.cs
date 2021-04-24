using bugtracker.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bugtracker.Data.Config
{
    public class OAuthUserConfiguration : IEntityTypeConfiguration<bugtrackerUser>
    {
        public void Configure(EntityTypeBuilder<bugtrackerUser> builder)
        {
            builder.Property(prop => prop.Email).IsRequired();
            builder.Property(prop => prop.Password).IsRequired();

        }
    }
}

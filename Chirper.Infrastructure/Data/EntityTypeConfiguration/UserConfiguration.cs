using Chirper.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirper.Infrastructure.Data.EntityTypeConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(o => o.Username).HasMaxLength(100).IsRequired();
            builder.Property(o => o.Email).IsRequired();
            builder.Property(o => o.Password).IsRequired();

        }
    }
}

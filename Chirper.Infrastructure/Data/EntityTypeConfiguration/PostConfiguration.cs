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
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
             builder.HasOne(x => x.User)
             .WithMany(x => x.Posts)
             .HasForeignKey(x => x.UserId)
             .OnDelete(DeleteBehavior.Cascade);
            builder.Property(o => o.Text).HasMaxLength(1000).IsRequired();
            builder.Property(o => o.Title).HasMaxLength(30).IsRequired();
        }
    }
}

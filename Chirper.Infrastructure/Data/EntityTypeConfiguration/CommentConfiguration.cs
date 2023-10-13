using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chirper.Core.Entities;

namespace Chirper.Infrastructure.Data.EntityTypeConfiguration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasOne(x => x.Post)
             .WithMany(x => x.Comments)
             .HasForeignKey(x => x.PostId)
             .OnDelete(DeleteBehavior.Cascade);
            builder.Property(o => o.Text).HasMaxLength(100);
        }
    }
}

using Chirper.Application.Repositories;
using Chirper.Core.Entities;
using Chirper.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirper.Infrastructure.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    { 
        public CommentRepository(ChirperContext context) : base(context)
        {
        }
    }
}

using Chirper.Core.Entities;
using System;
using Chirper.Application.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chirper.Infrastructure.Data;
using System.Threading;
using Microsoft.EntityFrameworkCore;

namespace Chirper.Infrastructure.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(ChirperContext context) : base(context)
        {
        }
    }
}

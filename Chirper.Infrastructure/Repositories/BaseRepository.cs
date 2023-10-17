using Chirper.Core.Common;
using Chirper.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chirper.Application.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace Chirper.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        internal readonly ChirperContext dataContext;

        public BaseRepository(ChirperContext context)
        {
            dataContext = context;
        }

        public void Create(T entity)
        {
            dataContext.Add(entity);
        }

        public void Update(T entity)
        {
            dataContext.Update(entity);
        }
        public void Delete(T entity)
        {
            dataContext.Set<T>().Remove(entity);
        }

        public Task<T> Get(int id, CancellationToken cancellationToken)
        {
            return dataContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public Task<List<T>> GetAll(CancellationToken cancellationToken)
        {
            return dataContext.Set<T>().ToListAsync(cancellationToken);
        }
    }
}

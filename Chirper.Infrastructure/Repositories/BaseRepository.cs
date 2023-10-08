using Chirper.Core.Common;
using Chirper.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chirper.Application.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Chirper.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DataContext _dataContext;

        public BaseRepository(DataContext context)
        {
            _dataContext = context;
        }

        public void Create(T entity)
        {
            _dataContext.Add(entity);
        }

        public void Update(T entity)
        {
            _dataContext.Update(entity);
        }

        public void Delete(T entity)
        {
            _dataContext.Update(entity);
        }

        public Task<T> Get(int id)
        {
            return _dataContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<T>> GetAll()
        {
            return _dataContext.Set<T>().ToListAsync();
        }
    }
}

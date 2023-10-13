﻿using Chirper.Core.Common;
using Chirper.Infrastructure.Data;
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
            dataContext.Update(entity);
        }

        public Task<T> Get(int id)
        {
            return dataContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<T>> GetAll()
        {
            return dataContext.Set<T>().ToListAsync();
        }
    }
}

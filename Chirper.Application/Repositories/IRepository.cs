using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chirper.Core.Common;
using System.Threading.Tasks;

namespace Chirper.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> Get(int id, CancellationToken cancellationToken);
        Task<List<T>> GetAll(CancellationToken cancellationToken);
    }
}

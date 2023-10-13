using Chirper.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirper.Application.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> repository<TEntity>() where TEntity : BaseEntity;

        Task Save(CancellationToken cancellationToken);
    }
}

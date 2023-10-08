using Chirper.Application.Repositories;
using Chirper.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chirper.Application.Repositories;
namespace Chirper.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }
        public Task Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}

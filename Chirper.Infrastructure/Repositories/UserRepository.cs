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
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ChirperContext context) : base(context)
        {
        }


        Task<User> IUserRepository.GetByEmail(string email)
        {
            return dataContext.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        Task<User> IUserRepository.GetByUsername(string username)
        {
            return dataContext.Users.FirstOrDefaultAsync(x => x.Username == username);
        }
    }
}

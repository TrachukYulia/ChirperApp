﻿using Chirper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirper.Application.Repositories
{
    public interface IUserRepository:IRepository<User>
    {
        Task<User> GetByEmail(string email);
        Task<User> GetByUsername(string username);
    }
}

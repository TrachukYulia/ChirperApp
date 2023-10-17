using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Text;
using System.Threading.Tasks;
using Chirper.Application.DTO;
using Chirper.Core.Entities;

namespace Chirper.Application.Profiles
{
    public class GetAllUserProfile: Profile
    {
        public GetAllUserProfile()
        {
            CreateMap<User, GetAllUserResponse>();
        }
    }
}

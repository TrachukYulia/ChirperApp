using AutoMapper;
using Chirper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chirper.Application.DTO;
namespace Chirper.Application.Profiles
{
    public class CreateUserMapper : Profile
    {
        public CreateUserMapper()
        {
            CreateMap<UserCreateRequest, User>().ReverseMap();
        }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirper.Application.DTO
{
    public record UserCreateRequest(string Username, string Password, string Email): IRequest<UserCreateResponse>;

}

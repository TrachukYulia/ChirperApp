using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirper.Application.DTO
{
    public record GetAllUserResponse
    {
        public int Id { get; set; }
        public string? Username { get; set; }
    }
}

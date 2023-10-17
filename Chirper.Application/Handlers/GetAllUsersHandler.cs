using AutoMapper;
using Chirper.Application.DTO;
using Chirper.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirper.Application.Handlers
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUserRequest, List<GetAllUserResponse>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetAllUsersHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllUserResponse>> Handle(GetAllUserRequest request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllUserResponse>>(users);
        }
    }
}

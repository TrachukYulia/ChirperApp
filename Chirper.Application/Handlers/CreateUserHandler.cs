using Chirper.Application.DTO;
using MediatR;
using Chirper.Core.Entities;
using AutoMapper;
using Chirper.Application.Repositories;
using Chirper.Application.Exception;

namespace Chirper.Application.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateUserHandler(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);
            var users = await _userRepository.GetAll(cancellationToken);
            if(users.ElementAt(Int32.Parse(user.Id)) != null )
            {
                throw new BadRequestException("This username already exists.");
            }
            _userRepository.Create(user);
            await _unitOfWork.Save(cancellationToken);
            return _mapper.Map<CreateUserResponse>(user);
        }

    }
}


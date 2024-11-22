using CSharpFunctionalExtensions;
using Microsoft.Extensions.Logging;
using StudentFileManagement.Domain;
using StudentFileManagment.Application.Database;
using StudentFileManagment.Application.EducationDirections;
using StudentFileManagment.Application.Subjects.Create;
using StudentFileManagment.Application.Subjects;
using StudentFileManagment.Domain.Shared;
using System.Numerics;

namespace StudentFileManagment.Application.Users.Create
{
    public class CreateUserHandler
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<CreateUserHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public CreateUserHandler(
            IUserRepository userRepository,
            IUnitOfWork unitOfWork,
            ILogger<CreateUserHandler> logger)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Result<Guid, Error>> Handle(CreateUserCommand command, CancellationToken cancellationToken = default)
        {
            var UserExists = await _userRepository.GetByChatId(command.chatId, cancellationToken);
            if (UserExists.IsSuccess)
            {
                return Error.Failure("user.already.exists", $"user already exists for chatId {command.chatId}");
            }

            var user = new User()
            {
                Id = Guid.NewGuid(),
                ChatId = command.chatId,
                IsAdmin = command.IsAdmin,
                IsModerator = command.IsModerator,
                Name = command.Name,
                Nickname = command.Nickname
            };

            await _userRepository.Add(user, cancellationToken);
            await _unitOfWork.SaveChanges(cancellationToken);
            _logger.LogInformation("created user {name} with id {id}",
                command.Name,
                user.Id);

            return user.Id;
        }
    }
}

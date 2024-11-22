using CSharpFunctionalExtensions;
using Microsoft.Extensions.Logging;
using StudentFileManagement.Domain;
using StudentFileManagment.Application.Database;
using StudentFileManagment.Application.Lectures.Create;
using StudentFileManagment.Application.Subjects;
using StudentFileManagment.Application.Users;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.Lectures.AddLectureData
{
    public class AddLectureDataHandler
    {
        private readonly ILectureRepositiry _lectureRepository;
        private readonly IUserRepository _userRepository;
        private readonly ILogger<AddLectureDataHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public AddLectureDataHandler(
            ILectureRepositiry lectureRepository,
            IUserRepository userRepository,
            IUnitOfWork unitOfWork,
            ILogger<AddLectureDataHandler> logger)
        {
            _lectureRepository = lectureRepository;
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Result<Guid, Error>> Handle(AddLectureDataCommand command, CancellationToken cancellationToken = default)
        {
            var userResult = await _userRepository.GetById(command.UserId);
            if (userResult.IsFailure)
            {
                return Errors.General.NotFound(command.UserId);
            }

            var lectureResult = await _lectureRepository.GetById(command.LectureId);
            if (lectureResult.IsFailure)
            {
                return Errors.General.NotFound(command.LectureId);
            }

            var lectureData = new LectureData()
            {
                Id = new Guid(),
                Comment = command.Comment,
                User = userResult.Value,
            };

            lectureResult.Value.Files!.ToList().Add(lectureData);
            await _unitOfWork.SaveChanges(cancellationToken);
            _logger.LogInformation("created lectureData with id {Id}", lectureData.Id);

            return lectureData.Id;
        }
    }
}

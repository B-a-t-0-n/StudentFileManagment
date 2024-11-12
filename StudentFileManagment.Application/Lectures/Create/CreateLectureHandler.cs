using StudentFileManagment.Application.Database;
using StudentFileManagement.Domain;
using Microsoft.Extensions.Logging;
using CSharpFunctionalExtensions;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.Lectures.Create
{
    public class CreateLectureHandler
    {
        private readonly ILectureRepositiry _lectureRepository;
        private readonly ILogger<CreateLectureHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public CreateLectureHandler(
            ILectureRepositiry lectureRepository,
            IUnitOfWork unitOfWork,
            ILogger<CreateLectureHandler> logger)
        {
            _lectureRepository = lectureRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Result<Guid, Error>> Handle(CreateLectureCommand command, CancellationToken cancellationToken = default)
        {
            var subject = new Subject();
            ////////////////////

            var lectureExists = await _lectureRepository.GetByDate(command.Date, cancellationToken);
            if (lectureExists.IsSuccess)
            {
                return Error.Failure("lecture.already.exists", $"lecture already exists for date {command.Date}");
            }

            var lecture = new Lecture() 
            {
                Id = new Guid(),
                Date = command.Date,
                Subject = subject,
            };

            await _lectureRepository.Add(lecture, cancellationToken);
            await _unitOfWork.SaveChanges(cancellationToken);
            _logger.LogInformation("created lecture {date} with id {volunteerId}",
                command.Date,
                lecture.Id);

            return lecture.Id;
        }
    }
}

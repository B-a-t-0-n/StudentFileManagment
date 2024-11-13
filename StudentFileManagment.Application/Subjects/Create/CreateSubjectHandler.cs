using CSharpFunctionalExtensions;
using Microsoft.Extensions.Logging;
using StudentFileManagement.Domain;
using StudentFileManagment.Application.Database;
using StudentFileManagment.Application.EducationDirections.Creaate;
using StudentFileManagment.Application.EducationDirections;
using StudentFileManagment.Application.Institutions;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.Subjects.Create
{
    public class CreateSubjectHandler
    {
        private readonly IEducationDirectionRepository _eucationDirectionRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly ILogger<CreateSubjectHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public CreateSubjectHandler(
            IEducationDirectionRepository eucationDirectionRepository,
            ISubjectRepository subjectRepository,
            IUnitOfWork unitOfWork,
            ILogger<CreateSubjectHandler> logger)
        {
            _eucationDirectionRepository = eucationDirectionRepository;
            _subjectRepository = subjectRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Result<Guid, Error>> Handle(CreateSubjectCommand command, CancellationToken cancellationToken = default)
        {
            var semesterExist = await _eucationDirectionRepository.GetBySemesterId(command.SemesterId);
            if (semesterExist.IsFailure)
            {
                return Errors.General.NotFound(command.SemesterId);
            }

            var subjectExists = await _eucationDirectionRepository.GetByName(command.Name, cancellationToken);
            if (subjectExists.IsSuccess)
            {
                return Error.Failure("subject.already.exists", $"subject already exists for name {command.Name}");
            }

            var subject = new Subject()
            {
                Id = new Guid(),
                Name = command.Name,
                SemesterId = command.SemesterId,
            };

            await _subjectRepository.Add(subject, cancellationToken);
            await _unitOfWork.SaveChanges(cancellationToken);
            _logger.LogInformation("created subject {name} with id {id}",
                command.Name,
                subject.Id);

            return subject.Id;
        }
    }
}

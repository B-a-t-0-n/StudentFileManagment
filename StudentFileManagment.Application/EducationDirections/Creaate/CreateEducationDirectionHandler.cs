using CSharpFunctionalExtensions;
using Microsoft.Extensions.Logging;
using StudentFileManagement.Domain;
using StudentFileManagment.Application.Database;
using StudentFileManagment.Application.Educations.Create;
using StudentFileManagment.Application.Educations;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.EducationDirections.Creaate
{
    public class CreateEducationDirectionHandler
    {
        private readonly IEducationDirectionRepository _eucationDirectionRepository;
        private readonly ILogger<CreateEducationDirectionHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public CreateEducationDirectionHandler(
            IEducationDirectionRepository eucationDirectionRepository,
            IUnitOfWork unitOfWork,
            ILogger<CreateEducationDirectionHandler> logger)
        {
            _eucationDirectionRepository = eucationDirectionRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Result<Guid, Error>> Handle(CreateEducationDirectionCommand command, CancellationToken cancellationToken = default)
        {

            var eucationDirectionExists = await _eucationDirectionRepository.GetByName(command.Name, cancellationToken);
            if (eucationDirectionExists.IsSuccess)
            {
                return Error.Failure("EducationDirection.already.exists", $"EducationDirection already exists for name {command.Name}");
            }

            var educationDirection = new EducationDirection()
            {
                Id = new Guid(),
                Name = command.Name,
                InstitutionAndEducationId = command.InstitutionAndEducationId,
            };

            await _eucationDirectionRepository.Add(educationDirection, cancellationToken);
            await _unitOfWork.SaveChanges(cancellationToken);
            _logger.LogInformation("created eucationDirection {name} with id {id}",
                command.Name,
                educationDirection.Id);

            return educationDirection.Id;
        }
    }
}

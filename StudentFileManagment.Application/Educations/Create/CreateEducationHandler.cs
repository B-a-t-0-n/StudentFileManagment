using CSharpFunctionalExtensions;
using Microsoft.Extensions.Logging;
using StudentFileManagement.Domain;
using StudentFileManagment.Application.Database;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.Educations.Create
{
    public class CreateEducationHandler
    {
        private readonly IEducationRepository _educationRepository;
        private readonly ILogger<CreateEducationHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public CreateEducationHandler(
            IEducationRepository educationRepository,
            IUnitOfWork unitOfWork,
            ILogger<CreateEducationHandler> logger)
        {
            _educationRepository = educationRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Result<Guid, Error>> Handle(CreateEducationCommand command, CancellationToken cancellationToken = default)
        {
            
            var educationExists = await _educationRepository.GetByName(command.Name, cancellationToken);
            if (educationExists.IsSuccess)
            {
                return Error.Failure("education.already.exists", $"education already exists for id {command.Name}");
            }

            var education = new Education()
            {
                Id = new Guid(),
                Name = command.Name,
            };

            await _educationRepository.Add(education, cancellationToken);
            await _unitOfWork.SaveChanges(cancellationToken);
            _logger.LogInformation("created education {name} with id {id}",
                command.Name,
                education.Id);

            return education.Id;
        }
    }
}

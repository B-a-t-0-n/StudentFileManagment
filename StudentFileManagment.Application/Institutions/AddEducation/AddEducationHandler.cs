using CSharpFunctionalExtensions;
using Microsoft.Extensions.Logging;
using StudentFileManagement.Domain;
using StudentFileManagment.Application.Database;
using StudentFileManagment.Application.Educations;
using StudentFileManagment.Application.Institutions.Create;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.Institutions.AddEducation
{
    public class AddEducationHandler
    {
        private readonly IInstitutionRepository _institutionRepository;
        private readonly IEducationRepository _educationRepository;
        private readonly ILogger<AddEducationHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public AddEducationHandler(
            IInstitutionRepository institutionRepository,
            IEducationRepository educationRepository,
            IUnitOfWork unitOfWork,
            ILogger<AddEducationHandler> logger)
        {
            _institutionRepository = institutionRepository;
            _educationRepository = educationRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Result<Guid, Error>> Handle(AddEducationCommand command, CancellationToken cancellationToken = default)
        {
            var institutionExists = await _institutionRepository.GetById(command.InstitutionId, cancellationToken);
            if (institutionExists.IsFailure)
            {
                return Error.NotFound("institutionExists.not.found", $"institutionExists not found for id {command.InstitutionId}");
            }

            var educationExists = await _educationRepository.GetById(command.EduvationId, cancellationToken);
            if (educationExists.IsFailure)
            {
                return Error.Failure("education.already.exists", $"education already exists for id {command.EduvationId}");
            }

            var institutionAndEducation = new InstitutionAndEducation()
            {
                Id = new Guid(),
                EducationId = command.EduvationId,
                InstitutionId = command.InstitutionId,
            };

            institutionExists.Value.InstitutionAndEducation!.ToList().Add(institutionAndEducation);

            await _institutionRepository.Add(institutionExists.Value, cancellationToken);
            await _unitOfWork.SaveChanges(cancellationToken);
            _logger.LogInformation("created InstitutionAndEducation with id {id}",
                institutionAndEducation.Id);

            return institutionAndEducation.Id;
        }
    }
}

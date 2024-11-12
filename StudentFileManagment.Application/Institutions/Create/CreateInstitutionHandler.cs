using CSharpFunctionalExtensions;
using Microsoft.Extensions.Logging;
using StudentFileManagement.Domain;
using StudentFileManagment.Application.Database;
using StudentFileManagment.Application.Educations;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.Institutions.Create
{
    public class CreateInstitutionHandler
    {
        private readonly IInstitutionRepository _institutionRepository;
        private readonly ILogger<CreateInstitutionHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public CreateInstitutionHandler(
            IInstitutionRepository institutionRepository,
            IUnitOfWork unitOfWork,
            ILogger<CreateInstitutionHandler> logger)
        {
            _institutionRepository = institutionRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Result<Guid, Error>> Handle(CreateInstitutionCommand command, CancellationToken cancellationToken = default)
        {
            var institutionExists = await _institutionRepository.GetByName(command.Name, cancellationToken);
            if (institutionExists.IsSuccess)
            {
                return Error.Failure("institution.already.exists", $"institution already exists for id {command.Name}");
            }

            var institution = new Institution()
            {
                Id = new Guid(),
                Name = command.Name,
            };

            await _institutionRepository.Add(institution, cancellationToken);
            await _unitOfWork.SaveChanges(cancellationToken);
            _logger.LogInformation("created institution {name} with id {id}",
                command.Name,
                institution.Id);

            return institution.Id;
        }
    }
}

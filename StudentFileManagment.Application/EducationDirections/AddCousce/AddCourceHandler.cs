using CSharpFunctionalExtensions;
using Microsoft.Extensions.Logging;
using StudentFileManagment.Application.Database;
using StudentFileManagment.Domain;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.EducationDirections.AddCousce
{
    public class AddCourceHandler
    {
        private readonly IEducationDirectionRepository _eucationDirectionRepository;
        private readonly ILogger<AddCourceHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public AddCourceHandler(
            IEducationDirectionRepository eucationDirectionRepository,
            IUnitOfWork unitOfWork,
            ILogger<AddCourceHandler> logger)
        {
            _eucationDirectionRepository = eucationDirectionRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Result<Guid, Error>> Handle(AddCourceCommand command, CancellationToken cancellationToken = default)
        {
            var educationDirectionExists = await _eucationDirectionRepository.GetById(command.EducationDirectionId, cancellationToken);
            if (educationDirectionExists.IsFailure)
            {
                return Errors.General.NotFound(command.EducationDirectionId);
            }

            var cources = educationDirectionExists.Value.Cources;

            if (cources != null && cources.Any(c => c.Number == command.Number))
            {
                return Errors.General.ValueIsInvalid(command.Number.ToString());
            }

            var cource = new Cource()
            {
                Id = new Guid(),
                Number = command.Number
            };

           educationDirectionExists.Value.Cources!.ToList().Add(cource);

            await _unitOfWork.SaveChanges(cancellationToken);
            _logger.LogInformation("add cource {number} for education direction with id {id}",
                command.Number,
                command.EducationDirectionId);

            return cource.Id;
        }
    }
}

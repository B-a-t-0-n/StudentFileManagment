using CSharpFunctionalExtensions;
using Microsoft.Extensions.Logging;
using StudentFileManagement.Domain;
using StudentFileManagment.Application.Database;
using StudentFileManagment.Application.EducationDirections.AddCousce;
using StudentFileManagment.Application.EducationDirections.Creaate;
using StudentFileManagment.Application.Institutions;
using StudentFileManagment.Domain;
using StudentFileManagment.Domain.Shared;

namespace StudentFileManagment.Application.EducationDirections.AddSemester
{
    public class AddSemesterHandler
    {
        private readonly IEducationDirectionRepository _eucationDirectionRepository;
        private readonly ILogger<AddSemesterHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public AddSemesterHandler(
            IEducationDirectionRepository eucationDirectionRepository,
            IUnitOfWork unitOfWork,
            ILogger<AddSemesterHandler> logger)
        {
            _eucationDirectionRepository = eucationDirectionRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Result<Guid, Error>> Handle(AddSemesterCommand command, CancellationToken cancellationToken = default)
        {
            var courceExists = await _eucationDirectionRepository.GetByCourceId(command.CourceId, cancellationToken);
            if (courceExists.IsFailure)
            {
                return Errors.General.NotFound(command.CourceId);
            }

            var semesters = courceExists.Value.Semesters;

            if (semesters != null && semesters.Any(c => c.Number == command.Number))
            {
                return Errors.General.ValueIsInvalid(command.Number.ToString());
            }

            var semester = new Semester()
            {
                Id = new Guid(),
                Number = command.Number
            };

            courceExists.Value.Semesters!.ToList().Add(semester);

            await _unitOfWork.SaveChanges(cancellationToken);
            _logger.LogInformation("add semester {number} for cource with id {id}",
                command.Number,
                command.CourceId);

            return semester.Id;
        }
    }
}
